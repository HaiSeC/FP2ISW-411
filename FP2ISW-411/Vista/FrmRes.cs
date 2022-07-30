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

namespace FP2ISW_411.Vista
{
    public partial class FrmRes : Form
    {
        procesos P = new procesos();
        public FrmRes()
        {
            InitializeComponent();
            CantA.Value = 1;
            CantA.Minimum = 1;
            DPE.MinDate = DateTime.Now.AddDays(1);
            UpdateTH();
            UpdatePrice();
        }

        public void UpdateTH()
        {
            List<string> tipos = P.tipos_habi();
            if (tipos == null)
            {
                MessageBox.Show("Error al ingresar a la base de datos");
            }
            else
            {
                foreach (string tipo in tipos)
                {
                    CBoxTH.Items.Add(tipo);
                }
                CBoxTH.SelectedItem = tipos[0];
            }
            
        }
       public void UpdatePrice()
        {
            TimeSpan rest_tiempo = DPS.Value.Subtract(DPE.Value);
            int CantN = Convert.ToInt32(rest_tiempo.TotalDays);
            double Tarifa =Convert.ToDouble(P.tarifa_hab(CBoxTH.Text));
            double t1 = Tarifa * CantN;
            double CostXN = (Tarifa * 0.15)* Convert.ToInt32(this.CantN.Value);
            double CostXA = (Tarifa * 0.30) * Convert.ToInt32(CantA.Value);
            double TTotal = t1 + CostXA + CostXN;
            LblP.Text = "Precio: $" + TTotal;
        }

        private void CBoxTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void CantA_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void DPE_ValueChanged(object sender, EventArgs e)
        {
            DPS.MinDate = DPE.Value.AddDays(1);
            UpdatePrice();
        }

        private void DPS_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            if (CantA.Value <= 0)
            {
                MessageBox.Show("Digite la cantidad de personas", "Atención",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            else
            {
                if (DPE.Value >= DPS.Value)
                {
                    MessageBox.Show("La fecha de entrada y salida no coinciden,\nverifiquelas por favor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CantN_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }
    }
}
