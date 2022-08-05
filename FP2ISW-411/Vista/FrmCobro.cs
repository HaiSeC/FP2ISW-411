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
    public partial class FrmCobro : Form
    {
        procesos P = new procesos();
        public FrmCobro()
        {
            InitializeComponent();
            button2.Enabled = false;
            
        }

        private void FrmCobro_Load(object sender, EventArgs e)
        {
  
        }
        public void llenar_combo(List<int> ids)
        {
            foreach (int id in ids)
            {
                comboBox_ids.Items.Add(id);
            }
            comboBox_ids.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long ced = Convert.ToInt64(text_ced.Text);
                List<int> ids = P.ids_reservas(ced);
                if (ids.Count == 0)
                {
                    MessageBox.Show("El usuario no tiene reservas pendientes a cancelar.");
                }
                else
                {
                    llenar_combo(ids);
                    DataTable informacion = P.informacion_reservacion(ced);
                    dataGridView1.DataSource = informacion.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique la cedula.");
            }
        }
        public void update_precio()
        {
            int estado = P.status(Convert.ToInt32(comboBox_ids.Text));
            if (RB_40.Checked)
            {
                LblP.Text = "Total a pagar: $" + (P.total_reserva(Convert.ToInt32(comboBox_ids.Text)) * 0.40);
            }
            else
            {
                if (RB100.Checked && estado == 2)
                {
                    LblP.Text = "Total a pagar: $" + (P.total_reserva(Convert.ToInt32(comboBox_ids.Text)) * 0.60);
                }
                else
                {
                    LblP.Text = "Total a pagar: $" + P.total_reserva(Convert.ToInt32(comboBox_ids.Text));
                }
            }
        }
        private void comboBox_ids_SelectedIndexChanged(object sender, EventArgs e)
        {
            int estado = P.status(Convert.ToInt32(comboBox_ids.Text));
            if (estado == 2)
            {
                RB_40.Enabled = false;
            }
            else
            {
                RB_40.Enabled = true;
            }
            button2.Enabled = true;
            RB100.Checked = true;
            update_precio();
        }

        private void RB_40_CheckedChanged(object sender, EventArgs e)
        {
            update_precio();
        }

        private void RB100_CheckedChanged(object sender, EventArgs e)
        {
            update_precio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int estado = 0;
            if (RB100.Checked)
            {
                estado = 3;
            }
            else
            {
                estado = 2;
            }
            if (P.modificar_status(estado, Convert.ToInt32(comboBox_ids.Text)))
            {
                MessageBox.Show("Se ha realizado el cobro correctamente");
                FrmCobro f = new FrmCobro();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
