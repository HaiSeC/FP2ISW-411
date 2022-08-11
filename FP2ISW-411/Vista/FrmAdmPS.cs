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


        bool drag = false;
        int mX = 0;
        int mY = 0;
        public FrmAdmPS()
        {
            InitializeComponent();
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (PlnCRUDs.Visible == true)
            {
                PlnCRUDs.Visible = false;
            } else
            {
                PlnCRUDs.Visible = true;
            }
        }

        private void PBHome_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdmPuestos_Load(object sender, EventArgs e)
        {

        }
    }
}
