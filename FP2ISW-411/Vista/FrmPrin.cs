﻿using System;
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
    public partial class FrmPrin : Form
    {
        bool drag = false;
        int mX = 0;
        int mY = 0;
        public FrmPrin()
        {
            InitializeComponent();
            ChildForms(new FrmInicio());
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PBMax.Visible = false;
            PBRes.Visible = true;
        }

        private void PBMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PBRes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PBMax.Visible = true;
            PBRes.Visible = false;
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
            ChildForms(new FrmInicio());
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
            ChildForms(new FrmRes());
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
    }
}