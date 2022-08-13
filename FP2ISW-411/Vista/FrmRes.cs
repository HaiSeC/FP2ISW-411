using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP2ISW_411.Procesos;
using System.Windows.Forms;
using FP2ISW_411.Modelos;

namespace FP2ISW_411.Vista
{
    public partial class FrmRes : Form
    {
        usuario usuario = null;
        procesos P = new procesos();
        List<int> disponibles;
        List<RadioButton> radioButtons = new List<RadioButton>();

        public FrmRes(usuario U, int r, int g, int b)
        {
            InitializeComponent();
            this.usuario = U;
            text_ced.Text = U.Cedula.ToString();
            CantA.Value = 1;
            CantA.Minimum = 1;
            DPE.MinDate = DateTime.Now.AddDays(1);
            UpdateTH();
            UpdatePrice();
            update_disponibles();
            text_ced.Enabled=des_ced();
            this.BackColor = Color.FromArgb(r, g, b);
        }
        public bool des_ced()
        {
            return this.usuario.Puesto != 2;           
        }

        public void update_disponibles()
        {
            comboBox_habitacion.Items.Clear();
            disponibles = P.habi_disponibles(DPE.Value, P.cod_Hotel(comboBox_hotel.Text), P.cod_T_habi(CBoxTH.Text));
            if(disponibles==null || disponibles.Count <= 0)
            {
                comboBox_habitacion.Text = "No hay habitaciones disponibles";
                BtnRes.Enabled = false;
            }
            else
            {
                int isd = 1;
                int isdY = 1;
                IEnumerable<int> enumerableThing = disponibles;
                foreach (int item in enumerableThing.Reverse())
                {
                    comboBox_habitacion.Items.Add(item);
                    RadioButton chb = new RadioButton();
                    chb.SetBounds(isd * 50, isdY * 50, 50, 30);
                    chb.Text = item.ToString();
                    
                    panel1.Controls.Add(chb);
                    if (isd == 5)
                    {
                        isdY++;
                        isd = 1;
                    }
                    else
                    {
                        isd++;
                    }
                    radioButtons.Add(chb);
                }
                comboBox_habitacion.SelectedIndex = 0;
                //BtnRes.Enabled = true;
            }
            
        }

        public int getHab()
        {
            string habID = "";

            foreach (var rbutton in radioButtons)
            {
                if (rbutton.Checked)
                {
                    habID = rbutton.Text;
                    return Convert.ToInt32(habID);
                }
            }

            return Convert.ToInt32(habID);
        }

        public void UpdateTH()
        {
            List<string> tipos = P.tipos_habi();
            List<string> hoteles = P.nombre_hoteles();
            if (tipos == null || hoteles == null)
            {
                MessageBox.Show("Error al Conectar con la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string tipo in tipos)
                {
                    CBoxTH.Items.Add(tipo);
                }
                CBoxTH.SelectedIndex=0;
                foreach (string hotel in hoteles)
                {
                    comboBox_hotel.Items.Add(hotel);
                }
                comboBox_hotel.SelectedIndex = 0;
            }
            
        }
       public void UpdatePrice()
        {
            TimeSpan rest_tiempo = DPS.Value.Subtract(DPE.Value);
            int CantN = Convert.ToInt32(rest_tiempo.TotalDays);
            double Tarifa =Convert.ToDouble(P.prec_tarifa(comboBox_hotel.Text,CBoxTH.Text));
            double t1 = Tarifa * CantN;
            double CostXN = (Tarifa * 0.15)* Convert.ToInt32(this.CantN.Value);
            double CostXA = (Tarifa * 0.30) * Convert.ToInt32(CantA.Value);
            double TTotal = t1 + CostXA + CostXN;
            LblP.Text = "Precio: $" + TTotal;
        }

        void resetBTmS()
        {
            foreach (var item in radioButtons)
            {
                if (panel1.Controls.Contains(item))
                {
                    panel1.Controls.Remove(item);
                }
            }
            radioButtons.Clear();
        }

        private void CBoxTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetBTmS();
            UpdatePrice();
            update_disponibles();
        }

        private void CantA_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void DPE_ValueChanged(object sender, EventArgs e)
        {
            DPS.MinDate = DPE.Value.AddDays(1);
            UpdatePrice();
            update_disponibles();
        }

        private void DPS_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            update_disponibles();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            bool checkedS = panel1.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
            if (CantA.Value <= 0)
            {
                MessageBox.Show("Digite la cantidad de personas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkedS ) {
                MessageBox.Show("Seleccione una habitacion", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DPE.Value >= DPS.Value)
                {
                    MessageBox.Show("La fecha de entrada y salida no coinciden,\nverifiquelas por favor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (des_ced())
                    {
                        try
                        {
                            long c = Convert.ToInt64(text_ced.Text);
                            if (P.info_usu(c) != null)
                            {
                                reservar(c);
                            }
                            else
                            {
                                MessageBox.Show("El Cliente no esta Registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Verifique la información!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        reservar(this.usuario.Cedula);
  
                    }
                }
            }
            resetBTmS();
            update_disponibles();
        }

        public void reservar(long ced)
        {
            if (P.reservar(ced, DPE.Value, DPS.Value, Convert.ToInt32(CantA.Value + CantN.Value), getHab()/*Convert.ToInt32(comboBox_habitacion.Text)*/, Convert.ToInt32(LblP.Text.Split('$')[1])))
            {
                MessageBox.Show("Se ha realizado la reserva exitosamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update_disponibles();
            }
            else
            {
                MessageBox.Show("Verifique la información", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CantN_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void comboBox_hotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetBTmS();
            update_disponibles();
            UpdatePrice();
            label4.Text = "HOTEL " + comboBox_hotel.Text.ToUpper();
        }

        private void comboBox_habitacion_SelectedValueChanged(object sender, EventArgs e)
        {
            BtnRes.Enabled = true;
        }
    }
}
