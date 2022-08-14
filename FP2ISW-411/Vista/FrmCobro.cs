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
    public partial class FrmCobro : Form
    {
        usuario usuario = null;
        procesos P = new procesos();
        public FrmCobro()
        {
            InitializeComponent();
            BtnPay.Enabled = false;           
        }
        public FrmCobro(usuario U)
        {
            InitializeComponent();
            BtnPay.Enabled = false;
            this.usuario = U;
            text_ced.Text = U.Cedula.ToString();
        }

        private void FrmCobro_Load(object sender, EventArgs e)
        {
  
        }
        
        public void llenar_combo(List<int> ids)
        {
            comboBox_ids.Items.Clear();
            foreach (int id in ids)
            {
                comboBox_ids.Items.Add(id);
            }
            comboBox_ids.SelectedIndex = 0;
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = default;
            try
            {
                long ced = Convert.ToInt64(text_ced.Text);
                List<int> ids = P.ids_reservas(ced);
                if (ids.Count == 0)
                {
                    comboBox_ids.Items.Clear();
                    MessageBox.Show("El cliente no tiene reservaciones a pagar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    llenar_combo(ids);
                    DataTable informacion = P.informacion_reservacion(ced);
                    dataGridView1.DataSource = informacion.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique la Cédula", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void update_precio()
        {
            int estado = P.status(Convert.ToInt32(comboBox_ids.Text));
            if (RB_40.Checked)
            {
                LblP.Text = "Total a pagar: $" + (P.total_reserva(Convert.ToInt32(comboBox_ids.Text)) * 0.40);
            }
            else
            {
                if (RB100.Checked && estado == 2)
                {
                    LblP.Text = "Total a pagar: $" + (P.total_reserva(Convert.ToInt32(comboBox_ids.Text)) * 0.60);
                }
                else
                {
                    LblP.Text = "Total a pagar: $" + P.total_reserva(Convert.ToInt32(comboBox_ids.Text));
                }
            }
        }
        private void comboBox_ids_SelectedIndexChanged(object sender, EventArgs e)
        {
            int estado = P.status(Convert.ToInt32(comboBox_ids.Text));
            if (estado == 2)
            {
                RB_40.Enabled = false;
            }
            else
            {
                RB_40.Enabled = true;
            }
            BtnPay.Enabled = true;
            RB100.Checked = true;
            update_precio();
        }

        private void RB_40_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_40.Checked == true)
            {
                if (BtnPay.Enabled == false)
                {
                    MessageBox.Show("Busque una reserveación primero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    update_precio();
                }
            }
            if (RB100.Checked == true)
            {
                if (BtnPay.Enabled == false)
                {
                    MessageBox.Show("Busque una reserveación primero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    update_precio();
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int estado = 0;
            if (RB100.Checked)
            {
                estado = 3;
            }
            else
            {
                estado = 2;
            }
            if (P.modificar_status(estado, Convert.ToInt32(comboBox_ids.Text)))
            {
                MessageBox.Show("Se la realizado el Pago Exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = default;
        }
    }
}
