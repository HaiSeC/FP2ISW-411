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
using Microsoft.VisualBasic;

namespace FP2ISW_411.Vista
{
    public partial class FrmLogIn : Form
    {
        procesos P = new procesos();
        encriptar E = new encriptar();
        bool drag = false;
        int mX = 0;
        int mY = 0;
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            string messag = "Esta Seguro de Salir?";
            string titl = "Atención";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult resul = MessageBox.Show(messag, titl, button, MessageBoxIcon.Warning);
            if (resul == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void BtnLog_Click(object sender, EventArgs e)
        {
            Login();  
        }

        public void Login()
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(TxtUser.Text, "^[a-zA-Z ]*$"))
                {
                    MessageBox.Show("No se permiten espacios o letras en la identificación", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                usuario U = P.user(Convert.ToInt64(TxtUser.Text));
                if (U == null)
                {
                    MessageBox.Show("El usuario " + TxtUser.Text + " no esta registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUser.Text = "";
                    TxtPass.Text = "";
                }
                if (U.Password == E.Encriptar(TxtPass.Text))
                {
                    if (U.Puesto != 9) //&& U.Cliente == 0
                    {
                        FrmAdmPS FP = new FrmAdmPS(P.info_usu(U.Cedula));
                        FP.Visible = true;
                        this.Dispose(false);
                    }
                    else if (U.Puesto == 9)
                    {
                        FrmCl CL = new FrmCl(P.info_usu(U.Cedula));
                        CL.Visible = true;
                        this.Dispose(false);
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPass.Text = "";
                }
            }
            catch (Exception ex)
            {
                TxtUser.Text = "";
                TxtPass.Text = "";
            }
        }
        private void LblHead_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mX = Cursor.Position.X - this.Left;
            mY = Cursor.Position.Y - this.Top;
        }

        private void LblHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Top = Cursor.Position.Y - mY;
                this.Left = Cursor.Position.X - mX;
            }
        }

        private void LblHead_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void LBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string messag = "Esta Seguro de Crear una Cuenta?";
            string titl = "Atención";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult resul = MessageBox.Show(messag, titl, button, MessageBoxIcon.Warning);
            if (resul == DialogResult.Yes)
            {
                FrmAdmPS FP = new FrmAdmPS(null);
                FP.Visible = true;
                this.Dispose(false);
            }
        }
    }
}
