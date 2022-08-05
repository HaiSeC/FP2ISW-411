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

namespace FP2ISW_411.Vista
{
    public partial class FrmCheck : Form
    {
        procesos P = new procesos();
        public FrmCheck()
        {
            InitializeComponent();
            RB_in.Checked = true;
        }
        public void llenar_combo(List<int> ids)
        {
            foreach (int id in ids)
            {
                comboBox_ids.Items.Add(id);
            }
            comboBox_ids.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (RB_in.Checked)
            {
                estado = "in";
            }
            else
            {
                estado = "out";
            }
            if (P.Modificar_checks(Convert.ToInt32(comboBox_ids.Text),estado))
            {
                MessageBox.Show("Se ha realizado el ChecK"+estado+" correctamente");
                FrmCheck f = new FrmCheck();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }
        public void buscar()
        {
            try
            {
                long ced = Convert.ToInt64(text_ced.Text);
                string tipoC = "";
                if (RBout.Checked)
                {
                    tipoC = "out";
                }
                else
                {
                    tipoC = "in";
                }
                List<int> ids = P.ids_reservas_check(ced, tipoC);
                if (ids.Count == 0)
                {
                    MessageBox.Show("El usuario no tiene reservas pendientes a hacer check" + tipoC + ".");
                }
                else
                {
                    llenar_combo(ids);
                    DataTable informacion = P.informacion_reservacion_Check(tipoC, ced);
                    dataGridView1.DataSource = informacion.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique la cedula.");
            }
        }

        private void RB_in_CheckedChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void RBout_CheckedChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
