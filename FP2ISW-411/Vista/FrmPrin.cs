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

namespace FP2ISW_411.Vista
{
    public partial class FrmPrin : Form
    {
        bool drag = false;
        int mX = 0;
        int mY = 0;
        usuario usuario = null;
        public FrmPrin()
        {
            InitializeComponent();
            //ChildForms(new FrmInicio());
        }

        public FrmPrin(usuario U)
        {
            InitializeComponent();
            LblUser.Text = LblUser.Text + " " + U.nombre+" "+U.Apellido1;
            int r = 0;
            int g = 0;
            int b = 0;
            ChildForms(new FrmInicio(r, g, b));
            this.usuario = U;
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ChildForms(object FrmChild)
        {
            if (this.PlnMain.Controls.Count > 0)                          
                this.PlnMain.Controls.RemoveAt(0);     
            Form fh = FrmChild as Form;        
            fh.TopLevel = false;          
            fh.Dock = DockStyle.Fill;     
            this.PlnMain.Controls.Add(fh);       
            this.PlnMain.Tag = fh;      
            fh.Show();
        }
        private void PBHome_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            ChildForms(new FrmInicio(r, g, b));
        }

        private void PlnHead_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void PlnHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Top = Cursor.Position.Y - mY;
                this.Left = Cursor.Position.X - mX;
            }
        }
        private void PlnHead_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mX = Cursor.Position.X - this.Left;
            mY = Cursor.Position.Y - this.Top;
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            ChildForms(new FrmRes(this.usuario, r, g, b));
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            string messag = "Esta Seguro de Cerrar Sesión?";
            string titl = "Atención";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult resul = MessageBox.Show(messag, titl, button, MessageBoxIcon.Warning);
            if (resul == DialogResult.Yes)
            {
                FrmLogIn FLI = new FrmLogIn();
                FLI.Visible = true;
                this.Dispose(false);
            }           
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmReg());
        }

        private void BtnCRUDH_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmCRUDH());
        }

        private void FrmTarifas_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmTarifa());
        }

        private void BtnCRUDs_Click(object sender, EventArgs e)
        {
            if(PlnCRUDs.Visible == false)
            {
                PlnCRUDs.Visible = true;
                BtnRes.Visible = false;
                BtnCheckIn.Visible = false;
                BtnPay.Visible = false;
            }
            else if (PlnCRUDs.Visible == true)
            {
                PlnCRUDs.Visible = false;
                BtnRes.Visible = true;
                BtnCheckIn.Visible = true;
                BtnPay.Visible = true;
            }
        }

        private void PlnMenu_Click(object sender, EventArgs e)
        {
            if (PlnCRUDs.Visible == true)
            {
                PlnCRUDs.Visible = false;
                BtnRes.Visible = true;
                BtnCheckIn.Visible = true;
                BtnPay.Visible = true;
            }
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmCheck(this.usuario));
        }

        private void LblUser_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mX = Cursor.Position.X - this.Left;
            mY = Cursor.Position.Y - this.Top;
        }

        private void LblUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Top = Cursor.Position.Y - mY;
                this.Left = Cursor.Position.X - mX;
            }
        }

        private void LblUser_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmCobro(this.usuario));
        }
    }
}
