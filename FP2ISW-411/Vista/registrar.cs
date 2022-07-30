using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FP2ISW_411.Procesos;
using FP2ISW_411.Modelos;
namespace FP2ISW_411.Vista
{
    public partial class registrar : Form
    {
        procesos P = new procesos();
        public registrar()
        {
            InitializeComponent();
            llenar_combo();
            nacimiento.MaxDate = DateTime.Now-(DateTime.Now.AddYears(18)-DateTime.Now) ;
        }
        public void llenar_combo()
        {
            List<string> puestos = P.tipo_puestos();
            foreach (string i in puestos)
            {
                combo_puesto.Items.Add(i);
            }
            combo_puesto.SelectedIndex = 0;
        }

        public void registrarse()
        {
            try
            {
                int edad = Convert.ToInt32((DateTime.Now.Subtract(nacimiento.Value).TotalDays)/365);
                encriptar E = new encriptar();
                usuario usu = new usuario(Convert.ToInt64(cedula.Text),nombre.Text,apellidos.Text,E.Encriptar(contra.Text),edad,nacimiento.Value,direccion.Text,DateTime.Now,P.codigo_puest(combo_puesto.Text));
            }
            catch
            {
                MessageBox.Show("No se pudo realizar el registro.\nPor favor verifique la información");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void combo_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
