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
    public partial class FrmCrudHab : Form
    {

        inserciones ins = new inserciones(); 
        procesos P = new procesos();
        public FrmCrudHab()
        {
            InitializeComponent();
            UpdateTH();
        }

        private void FrmCrudHab_Load(object sender, EventArgs e)
        {

        }


        public void UpdateTH()
        {
            List<string> tipos = P.tipos_habi();
            List<string> hoteles = P.nombre_hoteles();
            if (tipos == null || hoteles == null)
            {
                MessageBox.Show("Error al Conectar con la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string tipo in tipos)
                {
                    comboBox2.Items.Add(tipo);
                }
                //CBoxTH.SelectedIndex = 0;
                foreach (string hotel in hoteles)
                {
                    comboBox1.Items.Add(hotel);
                }
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
            }

        }

        private void aut_Hab()
        {
            for (int i = 0; i < 100; i++)
            {
                Habitaciones hab = new Habitaciones(type_asig(), (int)P.cod_Hotel((string)comboBox1.SelectedItem));
                ins.registrar_habitaH(hab);
            }

        }


        private int type_asig()
        {
            int type = 0;
            Random rnd = new Random();
            int num = rnd.Next(1, 10);

            if (num >= 1 && num<=2)
            {
                type = 1;
            } else if (num > 2 && num<=5)
            {
                type = 2;
            } else if (num > 5 && num <= 10)
            {
                type = 3;
            }

            return type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aut_Hab();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Habitaciones hab = new Habitaciones((comboBox2.SelectedIndex + 1), P.cod_Hotel((string)comboBox1.SelectedItem));
            ins.registrar_habitaH(hab);
        }
    }
}
