using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FP2ISW_411.Modelos;
using FP2ISW_411.Procesos;

namespace FP2ISW_411.Vista
{
    public partial class FrmCRUDH : Form
    {
        procesos H = new procesos();
        public FrmCRUDH()
        {
            InitializeComponent();
        }

        private void BtnE_Click(object sender, EventArgs e)
        {

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCH.Text = "";
            TxtID.Text = "";
            TxtLoc.Text = "";
            TxtName.Text = "";
        }
        
        private void BtnS_Click(object sender, EventArgs e)
        {
            try
            {
                Hoteles H1 = H.GetH(Convert.ToInt64(TxtID.Text));
                if (H == null)
                {
                    MessageBox.Show("El Hotel " + TxtID.Text + " no esta registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TxtCH.Text = H1.CantidadHab.ToString();
                    TxtLoc.Text = H1.Localidad;
                    TxtName.Text = H1.Nombre;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
