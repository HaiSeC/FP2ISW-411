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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_ced = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_ids = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_40 = new System.Windows.Forms.RadioButton();
            this.RB100 = new System.Windows.Forms.RadioButton();
            this.LblP = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // text_ced
            // 
            this.text_ced.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ced.Location = new System.Drawing.Point(85, 22);
            this.text_ced.Name = "text_ced";
            this.text_ced.Size = new System.Drawing.Size(199, 24);
            this.text_ced.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cédula:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_ids
            // 
            this.comboBox_ids.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_ids.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_ids.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ids.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ids.FormattingEnabled = true;
            this.comboBox_ids.Location = new System.Drawing.Point(414, 195);
            this.comboBox_ids.Name = "comboBox_ids";
            this.comboBox_ids.Size = new System.Drawing.Size(127, 21);
            this.comboBox_ids.TabIndex = 22;
            this.comboBox_ids.SelectedIndexChanged += new System.EventHandler(this.comboBox_ids_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(294, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Identificador:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB100);
            this.groupBox1.Controls.Add(this.RB_40);
            this.groupBox1.Location = new System.Drawing.Point(16, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 70);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Porcentaje a pagar";
            // 
            // RB_40
            // 
            this.RB_40.AutoSize = true;
            this.RB_40.Location = new System.Drawing.Point(7, 20);
            this.RB_40.Name = "RB_40";
            this.RB_40.Size = new System.Drawing.Size(45, 17);
            this.RB_40.TabIndex = 0;
            this.RB_40.TabStop = true;
            this.RB_40.Text = "40%";
            this.RB_40.UseVisualStyleBackColor = true;
            this.RB_40.CheckedChanged += new System.EventHandler(this.RB_40_CheckedChanged);
            // 
            // RB100
            // 
            this.RB100.AutoSize = true;
            this.RB100.Location = new System.Drawing.Point(7, 43);
            this.RB100.Name = "RB100";
            this.RB100.Size = new System.Drawing.Size(51, 17);
            this.RB100.TabIndex = 1;
            this.RB100.TabStop = true;
            this.RB100.Text = "100%";
            this.RB100.UseVisualStyleBackColor = true;
            this.RB100.CheckedChanged += new System.EventHandler(this.RB100_CheckedChanged);
            // 
            // LblP
            // 
            this.LblP.AutoSize = true;
            this.LblP.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP.ForeColor = System.Drawing.Color.Silver;
            this.LblP.Location = new System.Drawing.Point(18, 153);
            this.LblP.Name = "LblP";
            this.LblP.Size = new System.Drawing.Size(163, 25);
            this.LblP.TabIndex = 24;
            this.LblP.Text = "Total a pagar: $0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Pagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_ids);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_ced);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_ids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB100;
        private System.Windows.Forms.RadioButton RB_40;
        private System.Windows.Forms.Label LblP;
        private System.Windows.Forms.Button button2;
    }
}