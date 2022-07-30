using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP2ISW_411.Procesos;
using System.Windows.Forms;

namespace FP2ISW_411.Vista
{
    public partial class reservacion : Form
    {
        procesos P = new procesos();
        public reservacion()
        {
            InitializeComponent();
            Cant_adult.Value = 1;
            Cant_adult.Minimum = 1;
            Fecha_E.MinDate = DateTime.Now.AddDays(1);
            act_tipos_h();
            actualizar_precio();
        }

        public void act_tipos_h()
        {
            List<string> tipos = P.tipos_habi();
            if (tipos == null)
            {
                MessageBox.Show("Error al ingresar a la base de datos");
            }
            else
            {
                foreach (string tipo in tipos)
                {
                    tipo_habi.Items.Add(tipo);
                }
                tipo_habi.SelectedItem = tipos[0];
            }
            
        }
       public void actualizar_precio()
        {
            TimeSpan rest_tiempo = Fecha_s.Value.Subtract(Fecha_E.Value);
            int noches = Convert.ToInt32(rest_tiempo.TotalDays);
            double tarifa =Convert.ToDouble(P.tarifa_hab(tipo_habi.Text));
            double t1 = tarifa * noches;
            double costo_por_niño = (tarifa * 0.15)*Convert.ToInt32(cant_niños.Value);
            double costo_por_adulto = (tarifa * 0.30) * (Convert.ToInt32(Cant_adult.Value)-1);
            double tarifa_total = t1 + costo_por_adulto + costo_por_niño;
            lbl_precio.Text = "Precio: $" + tarifa_total;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizar_precio();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            actualizar_precio();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Fecha_s.MinDate = Fecha_E.Value.AddDays(1);
            actualizar_precio();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            actualizar_precio();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cant_adult.Value <= 0)
            {
                MessageBox.Show("Digite la cantidad de personas");
            }
            else
            {
                if (Fecha_E.Value >= Fecha_s.Value)
                {
                    MessageBox.Show("La fecha de entrada y salida no coinciden,\nverifiquelas por favor.");
                }
            }
        }

        private void cant_niños_ValueChanged(object sender, EventArgs e)
        {
            actualizar_precio();
        }
    }
}
