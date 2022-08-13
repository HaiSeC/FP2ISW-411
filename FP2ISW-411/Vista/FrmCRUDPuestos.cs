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
    public partial class FrmCRUDPuestos : Form
    {
        procesos P = new procesos();
        usuario User;
        List<string> puestos;
        List<string> hoteles;
        List<int> habs;
        List<usuario> usuarios;
        int code;
        int index = 0;
        public FrmCRUDPuestos(usuario Us)
        {
            User = Us;
            InitializeComponent();
            listView1.Visible = false;
            panel2.Visible = false;
            comboBox1.Enabled = false;
        }

        private void FrmCRUDPuestos_Load(object sender, EventArgs e)
        {
            usuarios = P.getEmpleados();
            puestos = P.tipo_puestos();
            if (puestos  == null)
            {
                MessageBox.Show("Error al Conectar con la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //CBoxTH.SelectedIndex = 0;
                foreach (string puesto in puestos)
                {
                    comboBox3.Items.Add(puesto);
                }
                comboBox3.SelectedIndex = 0;
                
            }
            if (User.Puesto == 1 || User.Puesto == 2)
            {
                listView1.Visible = true;
                if (usuarios == null)
                {
                    MessageBox.Show("Error al Conectar con la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (usuario empleado in usuarios)
                    {
                        //listView1.Items.ro
                        listView1.Items.Add(empleado.nombre);
                    }
                }
                hoteles = P.nombre_hoteles();
                if (hoteles == null)
                {
                    MessageBox.Show("Error al Conectar con la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (string hotel in hoteles)
                    {
                        comboBox1.Items.Add(hotel);
                    }
                    comboBox1.SelectedIndex = 0;
                    comboBox1.Enabled = true;
                    comboBox3.Enabled = true;
                }
            }
            else
            {
                code = P.getCode_H(User.Cedula);
                comboBox1.Items.Add(P.nombre_hotel(code));
                comboBox2.SelectedIndex = (User.Puesto - 1);
                fillh();
            }
        }

        private void fillh()
        {
            if (habs != null)
            {
                habs.Clear();
            }
            comboBox2.Items.Clear();
            if (User.Puesto == 1 || User.Puesto == 2)
            {
                int coded = P.getCode_HN(comboBox1.Text);
                habs = P.habs(coded);
            } else
            {
                habs = P.habs(code);
            }
            if (puestos == null)
            {
                MessageBox.Show("Error al Conectar con la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (int hab in habs)
                {
                    comboBox2.Items.Add(hab);
                }
                //comboBox2.SelectedIndex = 0;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod = P.codigo_puest(comboBox3.Text);
            if (cod == 6 || cod == 7)
            {
                panel2.Visible = true;
                fillh();
            } else
            {
                panel2.Visible = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0) index = listView1.SelectedIndices[0];
            textBox1.Text = usuarios[index].nombre;
            comboBox3.Text = P.nombre_puesto(usuarios[index].Puesto);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Verifique los datos", "Atencion");
            }
            else
            {
                if (P.CASS(usuarios[index].Cedula) && P.cambiar_puesto(P.codigo_puest(comboBox3.Text),usuarios[index].Cedula))
                {
                    if(P.cambiar_asignacion(usuarios[index].Cedula, P.getCode_HN(comboBox1.Text), Convert.ToInt32(comboBox2.Text)))
                    {
                        MessageBox.Show("Modificacion completada correctamente", "Completo");
                    }
                }
                else
                {
                    if(P.agregar_asignacion(usuarios[index].Cedula, P.getCode_HN(comboBox1.Text), Convert.ToInt32(comboBox2.Text)) && P.cambiar_puesto(P.codigo_puest(comboBox3.Text), usuarios[index].Cedula))
                    {
                        MessageBox.Show("Se ha asignado correctamente", "Completo");
                    }
                }
            }
        }
    }
}
