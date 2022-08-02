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
            ChkBxAc.Enabled = false;
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            int act = 0;
            if (ChkBxAc.Checked)
            {
                act = 1;
            }
            else
            {
                act = 0;
            }
            Hoteles H1 = new Hoteles(int.Parse(TxtID.Text), TxtName.Text, TxtLoc.Text, int.Parse(TxtCH.Text), act);
            if (H.modi_hot(H1))
            {
                MessageBox.Show("Se ha modificado la información exitosamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtID.Text = "";
                ChkBxAc.Enabled = false;
                Clear();
            }
            else
            {
                MessageBox.Show("Verifique la información.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            try
            {
                Hoteles H1 = new Hoteles(Convert.ToInt64(TxtID.Text), TxtName.Text, TxtLoc.Text, int.Parse(TxtCH.Text), 1);
                if (H.insert_hotel(H1))
                {
                    MessageBox.Show("Se ha registrado exitosamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema, por favor vuelva a intentarlo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                TxtID.Text = "";
                Clear();
            }
            catch
            {
                MessageBox.Show("No se pudo realizar el registro.\nPor favor verifique la información", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }
        public void Clear()
        {
            TxtCH.Text = "";
            TxtID.Text = "";
            TxtLoc.Text = "";
            TxtName.Text = "";
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
            ChkBxAc.Enabled = false;
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
                    if (H1.Activo == 1)
                    {
                        ChkBxAc.Checked = true;
                        ChkBxAc.Enabled = true;
                    }
                    else
                    {
                        ChkBxAc.Checked = false;
                        ChkBxAc.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
