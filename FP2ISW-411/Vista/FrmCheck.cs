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
            if (sit == 1)
            {
                situaciones();
            }
            if (P.Modificar_checks(Convert.ToInt32(comboBox_ids.Text),estado, st))
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
                ChkBoxS.Visible = true;
                ChkBoxS.Enabled = true;
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
                ChkBoxS.Visible = false;
                ChkBoxS.Enabled = false;
            }
        }

        private void situaciones()
        {
            string input = "";
            ShowInputDialogBox(ref input, "Cual es la situacion presentada?", "Ingrese Datos", 300, 200);
        }
        private void ChkBoxS_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxS.Checked == true)
            {
                sit = 1;
            }
            else
            {
                sit = 0;
            }
        }

        private static DialogResult ShowInputDialogBox(ref string input, string prompt, string title, int width, int height)
        {
            Situaciones stz = new Situaciones();
            #region FormItself
            Size size = new Size(width, height);
            Form inputBox = new Form();
            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            inputBox.ClientSize = size;
            inputBox.BackColor = Color.Black;
            inputBox.Text = title;

            Label label = new Label();
            label.Text = prompt;
            label.Location = new Point(5, 5);
            label.Width = size.Width - 10;
            label.Font = new Font("Segoe UI", 8);
            label.ForeColor = Color.White;
            inputBox.Controls.Add(label);

            CheckBox ChkUB = new CheckBox();
            ChkUB.Text = "Se ha Utlizado el MiniBar?";
            ChkUB.Font = new Font("Segoe UI", 9);
            ChkUB.Size = new Size(200, 20);
            ChkUB.ForeColor = Color.DarkGray;
            ChkUB.Location = new Point(5, 60);
            inputBox.Controls.Add(ChkUB);

            CheckBox ChkCF = new CheckBox();
            ChkCF.Text = "Se ha Utlizado la Caja Fuerte?";
            ChkCF.Font = new Font("Segoe UI", 9);
            ChkCF.Size = new Size(200, 20);
            ChkCF.ForeColor = Color.DarkGray;
            ChkCF.Location = new Point(5, 80);
            inputBox.Controls.Add(ChkCF);

            TextBox textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Size = new Size(size.Width - 10, 10);
            textBox.Location = new Point(5, label.Location.Y + 20);
            textBox.Text = input;
            textBox.BackColor = Color.Gray;
            textBox.Font = new Font("Segoe UI", 10);
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(70, 26);
            okButton.Text = "&OK";
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.BackColor = Color.Gray;
            okButton.Font = new Font("Segoe UI", 8);
            okButton.Location = new Point(size.Width - 80 - 80, size.Height - 30);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(70, 24);
            cancelButton.Text = "&Cancel";
            cancelButton.BackColor = Color.Gray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 8);
            cancelButton.Location = new Point(size.Width - 80, size.Height - 29);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            #endregion
            if (result == DialogResult.OK)
            {
                input = textBox.Text;
                if (input == "")
                {
                    MessageBox.Show("Debe escribir datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ChkCF.Checked == true)
                    {
                        stz.UsoCF = 1;
                    }
                    if (ChkUB.Checked == true)
                    {
                        stz.UsoBar = 1;
                    }
                    stz.Desc = input;
                    MessageBox.Show(stz.GetAll, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st = stz;
                }
            }
            else
            {
                string messag = "Esta Seguro de Cancelar?";
                string titl = "Atención";
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult resul = MessageBox.Show(messag, titl, button, MessageBoxIcon.Warning);
                if (resul == DialogResult.No)
                {
                    ShowInputDialogBox(ref input, "Cual es la situación presentada?", "Ingrese los Datos Solicitados", 300, 100);
                }
            }
            return result;

        }

    }
}
