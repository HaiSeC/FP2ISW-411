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
    public partial class FrmTarifa : Form
    {
        procesos P = new procesos();
        bool val_precio= false;
        public FrmTarifa()
        {
            InitializeComponent();
            llenar_combos();
            comboBox_Hoteles.SelectedIndex = 0;
            comboBox_Thabitacion.SelectedIndex = 0;
            vaina_de_botones();
        }
        public void vaina_de_botones()
        {
            button_reg.Enabled = val_precio;
            button_Modi.Enabled = val_precio;
        }
        public void llenar_combos()
        {
            foreach (string x in P.tipos_habi())
            {
                comboBox_Thabitacion.Items.Add(x);
            }
            foreach (string y in P.nombre_hoteles())
            {
                comboBox_Hoteles.Items.Add(y);
            }
        }
        public void registrar()
        {
            double pre = P.prec_tarifa(comboBox_Hoteles.Text, comboBox_Thabitacion.Text);
            if (pre == 0 || pre < 1)
            {
                try
                {
                    double x = Convert.ToDouble(text_precio.Text);
                    P.insert_tarifa(comboBox_Thabitacion.Text, comboBox_Hoteles.Text, x);
                    MessageBox.Show("Se ha insertado correctamente");
                }
                catch
                {
                    MessageBox.Show("Verifique la información");
                }
            }
            else
            {
                MessageBox.Show("Ya hay una tarifa asignada");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            registrar();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (text_precio.Text == "")
            {
                this.val_precio= false;
            }
            else
            {
                this.val_precio= true;
            }
            vaina_de_botones();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pre = P.prec_tarifa(comboBox_Hoteles.Text, comboBox_Thabitacion.Text);
            if (pre==0 || pre<1)
            {
                MessageBox.Show("No hay una tarifa asignada");
            }
            else
            {
                text_precio.Text = Convert.ToString(pre);
            }
        }

        private void button_Modi_Click(object sender, EventArgs e)
        {
            double pre = P.prec_tarifa(comboBox_Hoteles.Text, comboBox_Thabitacion.Text);
            if (pre == 0 || pre < 1)
            {
                MessageBox.Show("No hay una tarifa asignada,\nSe procederá a registrarla");
                registrar();
            }
            else
            {
                try
                {
                    double precio = Convert.ToInt64(text_precio.Text);
                    P.modi_tarifa(comboBox_Thabitacion.Text,comboBox_Hoteles.Text,precio);
                    MessageBox.Show("Se ha modificado correctamente");
                }
                catch
                {
                    MessageBox.Show("Verifique la información");
                }
            }
        }
    }
}
