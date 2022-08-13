using FP2ISW_411.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP2ISW_411.Vista
{
    public partial class FrmAdmPS : Form
    {
        usuario usuario = null;
        bool drag = false;
        int mX = 0;
        int mY = 0;
        string puesto = "";

        public FrmAdmPS(usuario U)
        {                      
            InitializeComponent();           
            this.usuario = U;
            int r = 0;
            int g = 0;
            int b = 0;
            ChildForms(new FrmInicio(r, g, b));
            PlnMenu.Width = 50;
        }


        private void PBClose_Click(object sender, EventArgs e)
        {
            string messag = "Esta Seguro de Cerrar Sesión?";
            string titl = "Atención";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult resul = MessageBox.Show(messag, titl, button, MessageBoxIcon.Warning);
            if (resul == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void PBMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void BtnCRUDs_Click(object sender, EventArgs e)
        {          
            if (PlnCRUDs.Visible == false)
            {
                PlnCRUDs.Visible = true;
                BtnCRUDs.Text = "Administrar Puestos";
                BtnSit.Text = "Situaciones";
                BtnPay.Text = "Cobros";
                BtnRes.Text = "Reservaciones";
                BtnCheck.Text = "Check In/Out";
                BtnLogOut.Text = "Cerrar Sesión";
                PlnMenu.Width = 210;
            }
            else if (PlnCRUDs.Visible == true)
            {
                PlnCRUDs.Visible = false;
            }
        }

        private void PBHome_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmInicio());
        }

        public void rol()
        {
            if (usuario.Puesto == 1)
            {
                puesto = "GERENTE";
            }
            else if (usuario.Puesto == 2)
            {
                puesto = "SECRETARIO";
            }
            else if (usuario.Puesto == 3)
            {
                puesto = "CONTADOR";
            }
            else if (usuario.Puesto == 4)
            {
                puesto = "RECEPCIONISTA";
            }
            else if (usuario.Puesto == 5)
            {
                puesto = "BOTONES";
            }
            else if (usuario.Puesto == 6)
            {
                puesto = "CAMARERO";
            }
            else if (usuario.Puesto == 7)
            {
                puesto = "JEFE LIMPIEZA";
            }
            else if (usuario.Puesto == 8)
            {
                puesto = "JEFE BOTTONES";
            }
        }
        
        private void FrmAdmPuestos_Load(object sender, EventArgs e)
        {
            rol();
            Buttons();
            LblUser.Text = LblUser.Text + " " + puesto + " " + usuario.nombre + " " + usuario.Apellido1;
        }
        public void Buttons()
        {
            if (puesto == "RECEPCIONISTA")
            {
                BtnCRUDs.Visible = false;
                BtnSit.Visible = false;

                button1.Visible = true;
            }
            if (puesto == "JEFE LIMPIEZA")
            {
                BtnCRUDs.Visible = false;
                BtnPay.Visible = false;
                BtnRes.Visible = false;
                BtnCheck.Visible = false;
                button1.Visible = true;
            }
            if (puesto == "CAMARERO")
            {
                BtnCRUDs.Visible = false;
                BtnPay.Visible = false;
                BtnRes.Visible = false;
                BtnCheck.Visible = false;
                button1.Visible = false;
            }
        }
        private void BtnHead_Click(object sender, EventArgs e)
        {
            if (PlnCRUDs.Visible == true)
            {
                PlnCRUDs.Visible = false;
            }
            if (BtnCRUDs.Text == "")
            {
                BtnCRUDs.Text = "CRUDS";
                BtnSit.Text = "Situaciones";
                BtnPay.Text = "Cobros";
                BtnRes.Text = "Reservaciones";
                BtnCheck.Text = "Check In/Out";
                BtnLogOut.Text = "Cerrar Sesión";
                button1.Text = "Administrar Puestos";
            }
            else if (BtnCRUDs.Text != "" || PlnCRUDs.Visible == true)
            {
                BtnCRUDs.Text = "";
                BtnSit.Text = "";
                BtnPay.Text = "";
                BtnRes.Text = "";
                BtnCheck.Text = "";
                BtnLogOut.Text = "";
                button1.Text = "";
            }
            if (PlnMenu.Width == 50)
            {
                PlnMenu.Width = 210;
            } else
            {
                PlnMenu.Width = 50;
            }          
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmReg());
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

        private void BtnCRUDH_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmCRUDH());
        }

        private void FrmTarifas_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmTarifa());
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            ChildForms(new FrmRes(this.usuario, r, g, b));
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmCobro(this.usuario));
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmCheck(this.usuario));
        }

        private void BtnSit_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmSituacion((int)this.usuario.Cedula));
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

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForms(new FrmCRUDPuestos(this.usuario));
        }
    }
}
