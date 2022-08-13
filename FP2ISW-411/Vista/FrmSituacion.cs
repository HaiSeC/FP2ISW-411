using FP2ISW_411.Datos;
using FP2ISW_411.Modelos;
using FP2ISW_411.Procesos;
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
    public partial class FrmSituacion : Form
    {
        int id;
        Situaciones ss = new Situaciones();
        procesos ps = new procesos();
        Counsultas cc = new Counsultas();
        public FrmSituacion(int userid)
        {
            id = userid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ss.EmplID = id;
            ss.UsoBar = Convert.ToInt32(checkBox1.Checked);
            ss.UsoCF = Convert.ToInt32(checkBox2.Checked);
            if (checkBox3.Checked)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Ingrese detalles de la situacion", "Atencion");

                } else
                {
                    ss.Desc = textBox1.Text;
                }
            }

            ps.insert_situacion(ss, ps.getResidHab(id));

        }

 
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                button1.Enabled = true;
            } else
            {
                button1.Enabled = false;
            }
        }
    }
}
