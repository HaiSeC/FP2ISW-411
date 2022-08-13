namespace FP2ISW_411.Vista
{
    partial class FrmCobro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_ced = new System.Windows.Forms.TextBox();
            this.LblCed = new System.Windows.Forms.Label();
            this.BtnS = new System.Windows.Forms.Button();
            this.comboBox_ids = new System.Windows.Forms.ComboBox();
            this.LblID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB100 = new System.Windows.Forms.RadioButton();
            this.RB_40 = new System.Windows.Forms.RadioButton();
            this.LblP = new System.Windows.Forms.Label();
            this.BtnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(317, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(526, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // text_ced
            // 
            this.text_ced.BackColor = System.Drawing.Color.Black;
            this.text_ced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_ced.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ced.ForeColor = System.Drawing.Color.DimGray;
            this.text_ced.Location = new System.Drawing.Point(79, 78);
            this.text_ced.Name = "text_ced";
            this.text_ced.Size = new System.Drawing.Size(199, 29);
            this.text_ced.TabIndex = 19;
            // 
            // LblCed
            // 
            this.LblCed.AutoSize = true;
            this.LblCed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCed.ForeColor = System.Drawing.Color.Gray;
            this.LblCed.Location = new System.Drawing.Point(12, 80);
            this.LblCed.Name = "LblCed";
            this.LblCed.Size = new System.Drawing.Size(61, 21);
            this.LblCed.TabIndex = 18;
            this.LblCed.Text = "Cédula:";
            // 
            // BtnS
            // 
            this.BtnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnS.ForeColor = System.Drawing.Color.Gray;
            this.BtnS.Location = new System.Drawing.Point(61, 290);
            this.BtnS.Name = "BtnS";
            this.BtnS.Size = new System.Drawing.Size(138, 38);
            this.BtnS.TabIndex = 20;
            this.BtnS.Text = "Buscar";
            this.BtnS.UseVisualStyleBackColor = true;
            this.BtnS.Click += new System.EventHandler(this.BtnS_Click);
            // 
            // comboBox_ids
            // 
            this.comboBox_ids.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_ids.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_ids.BackColor = System.Drawing.Color.Black;
            this.comboBox_ids.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_ids.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ids.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_ids.FormattingEnabled = true;
            this.comboBox_ids.Location = new System.Drawing.Point(527, 351);
            this.comboBox_ids.Name = "comboBox_ids";
            this.comboBox_ids.Size = new System.Drawing.Size(204, 29);
            this.comboBox_ids.TabIndex = 22;
            this.comboBox_ids.SelectedIndexChanged += new System.EventHandler(this.comboBox_ids_SelectedIndexChanged);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.Gray;
            this.LblID.Location = new System.Drawing.Point(405, 353);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(116, 21);
            this.LblID.TabIndex = 21;
            this.LblID.Text = "ID Reservación:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RB100);
            this.groupBox1.Controls.Add(this.RB_40);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(41, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 70);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Porcentaje a pagar";
            // 
            // RB100
            // 
            this.RB100.AutoSize = true;
            this.RB100.Location = new System.Drawing.Point(7, 43);
            this.RB100.Name = "RB100";
            this.RB100.Size = new System.Drawing.Size(58, 21);
            this.RB100.TabIndex = 1;
            this.RB100.Text = "100%";
            this.RB100.UseVisualStyleBackColor = true;
            // 
            // RB_40
            // 
            this.RB_40.AutoSize = true;
            this.RB_40.Checked = true;
            this.RB_40.Location = new System.Drawing.Point(7, 20);
            this.RB_40.Name = "RB_40";
            this.RB_40.Size = new System.Drawing.Size(51, 21);
            this.RB_40.TabIndex = 0;
            this.RB_40.TabStop = true;
            this.RB_40.Text = "40%";
            this.RB_40.UseVisualStyleBackColor = true;
            this.RB_40.CheckedChanged += new System.EventHandler(this.RB_40_CheckedChanged);
            // 
            // LblP
            // 
            this.LblP.AutoSize = true;
            this.LblP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP.ForeColor = System.Drawing.Color.Gray;
            this.LblP.Location = new System.Drawing.Point(57, 257);
            this.LblP.Name = "LblP";
            this.LblP.Size = new System.Drawing.Size(123, 21);
            this.LblP.TabIndex = 24;
            this.LblP.Text = "Total a pagar: $0";
            // 
            // BtnPay
            // 
            this.BtnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.ForeColor = System.Drawing.Color.Gray;
            this.BtnPay.Location = new System.Drawing.Point(61, 336);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(138, 38);
            this.BtnPay.TabIndex = 25;
            this.BtnPay.Text = "Pagar";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 546);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.LblP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_ids);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.BtnS);
            this.Controls.Add(this.text_ced);
            this.Controls.Add(this.LblCed);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCobro";
            this.Text = "FrmCobro";
            this.Load += new System.EventHandler(this.FrmCobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_ced;
        private System.Windows.Forms.Label LblCed;
        private System.Windows.Forms.Button BtnS;
        private System.Windows.Forms.ComboBox comboBox_ids;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB100;
        private System.Windows.Forms.RadioButton RB_40;
        private System.Windows.Forms.Label LblP;
        private System.Windows.Forms.Button BtnPay;
    }
}