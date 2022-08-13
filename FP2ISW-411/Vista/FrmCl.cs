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
    public partial class FrmCl : Form
    {
        bool drag = false;
        int mX = 0;
        int mY = 0;
        usuario usuario = null;
        public FrmCl()
        {
            InitializeComponent();
            //ChildForms(new FrmInicio());
        }

        public FrmCl(usuario u)
        {
            this.usuario = u;
            InitializeComponent();
            LblUser.Text = LblUser.Text + " " + usuario.nombre + " " + usuario.Apellido1;
           //ChildForms(new FrmInicio());
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
            int r = 96;
            int g = 73;
            int b = 44;
            ChildForms(new FrmInicio(r,g,b));           
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {

            ChildForms(new FrmChRes(this.usuario.Cedula));
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

        private void BtnMV_Click(object sender, EventArgs e)
        {
            int r = 96;
            int g = 73;
            int b = 44;
            ChildForms(new FrmRes(this.usuario, r, g, b));
        }

        private void PlnMenu_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMV_Click_1(object sender, EventArgs e)
        {

        }

        private void PBClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMini_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PlnHead_MouseUp_1(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void PlnHead_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Top = Cursor.Position.Y - mY;
                this.Left = Cursor.Position.X - mX;
            }
        }

        private void PlnHead_MouseDown_1(object sender, MouseEventArgs e)
        {
            drag = true;
            mX = Cursor.Position.X - this.Left;
            mY = Cursor.Position.Y - this.Top;
        }

        private void LblUser_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void LblUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Top = Cursor.Position.Y - mY;
                this.Left = Cursor.Position.X - mX;
            }
        }

        private void LblUser_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mX = Cursor.Position.X - this.Left;
            mY = Cursor.Position.Y - this.Top;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (PlnMenu.Width == 50)
            {
                PlnMenu.Width = 210;
            }
            else
            {
                PlnMenu.Width = 50;
            }

            if (BtnRes.Text == "")
            {
                BtnRes.Text = "Reservaciones";
                BtnMV.Text = "Mi Viaje";
                BtnLogOut.Text = "Cerrar Sesión";
            }
            else
            {
                BtnRes.Text = "";
                BtnMV.Text = "";
                BtnLogOut.Text = "";
            }
        }
    }
}
