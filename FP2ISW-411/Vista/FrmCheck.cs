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
    public partial class FrmCheck : Form
    {
        usuario usuario = null;
        static Situaciones st = null;
        procesos P = new procesos();
        int sit = 0;
        public FrmCheck()
        {
            InitializeComponent();
        }
        public FrmCheck(usuario U)
        {
            InitializeComponent();
            this.usuario = U;
            text_ced.Text = U.Cedula.ToString();                       
        }
        public void llenar_combo(List<int> ids)
        {
            comboBox_ids.Items.Clear();
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
                MessageBox.Show("Se ha realizado el ChecK" + estado + " correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha Ocurrido un Error", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }
        public void buscar()
        {
            dataGridView1.DataSource = default;
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
                    comboBox_ids.Items.Clear();
                    MessageBox.Show("El usuario no tiene reservaciones pendientes a hacer check" + tipoC + ".", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
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
                MessageBox.Show("Verifique la Cédula", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RB_in_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_in.Checked == true)
            {
                if (text_ced.Text != "")
                {
                    buscar();
                }
                else if (RBout.Checked == false)
                {
                    dataGridView1.DataSource = default;
                    MessageBox.Show("Digite una Cédula", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        if (RBout.Checked == true)
            {
                if (text_ced.Text != "")
                {
                    buscar();
                }
                else if (RB_in.Checked == false)
                {
                    dataGridView1.DataSource = default;
                    MessageBox.Show("Digite una Cédula", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }
    }
}
