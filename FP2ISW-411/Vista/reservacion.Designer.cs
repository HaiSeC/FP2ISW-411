namespace FP2ISW_411.Vista
{
    partial class reservacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cant_adult = new System.Windows.Forms.NumericUpDown();
            this.Fecha_E = new System.Windows.Forms.DateTimePicker();
            this.Fecha_s = new System.Windows.Forms.DateTimePicker();
            this.tipo_habi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.cant_niños = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cant_adult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_niños)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Adultos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Entrada:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de salida:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de habitación:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Cant_adult
            // 
            this.Cant_adult.Location = new System.Drawing.Point(347, 41);
            this.Cant_adult.Name = "Cant_adult";
            this.Cant_adult.ReadOnly = true;
            this.Cant_adult.Size = new System.Drawing.Size(51, 20);
            this.Cant_adult.TabIndex = 4;
            this.Cant_adult.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Fecha_E
            // 
            this.Fecha_E.Location = new System.Drawing.Point(329, 122);
            this.Fecha_E.Name = "Fecha_E";
            this.Fecha_E.Size = new System.Drawing.Size(200, 20);
            this.Fecha_E.TabIndex = 5;
            this.Fecha_E.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Fecha_s
            // 
            this.Fecha_s.Location = new System.Drawing.Point(315, 167);
            this.Fecha_s.Name = "Fecha_s";
            this.Fecha_s.Size = new System.Drawing.Size(200, 20);
            this.Fecha_s.TabIndex = 6;
            this.Fecha_s.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // tipo_habi
            // 
            this.tipo_habi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tipo_habi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipo_habi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_habi.FormattingEnabled = true;
            this.tipo_habi.Location = new System.Drawing.Point(335, 203);
            this.tipo_habi.Name = "tipo_habi";
            this.tipo_habi.Size = new System.Drawing.Size(186, 21);
            this.tipo_habi.TabIndex = 7;
            this.tipo_habi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(264, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Resevar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(260, 262);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(104, 24);
            this.lbl_precio.TabIndex = 9;
            this.lbl_precio.Text = "Precio: $0";
            this.lbl_precio.Click += new System.EventHandler(this.label5_Click);
            // 
            // cant_niños
            // 
            this.cant_niños.Location = new System.Drawing.Point(347, 80);
            this.cant_niños.Name = "cant_niños";
            this.cant_niños.ReadOnly = true;
            this.cant_niños.Size = new System.Drawing.Size(51, 20);
            this.cant_niños.TabIndex = 11;
            this.cant_niños.ValueChanged += new System.EventHandler(this.cant_niños_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad de niños:";
            // 
            // reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 384);
            this.Controls.Add(this.cant_niños);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tipo_habi);
            this.Controls.Add(this.Fecha_s);
            this.Controls.Add(this.Fecha_E);
            this.Controls.Add(this.Cant_adult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "reservacion";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Cant_adult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_niños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Cant_adult;
        private System.Windows.Forms.DateTimePicker Fecha_E;
        private System.Windows.Forms.DateTimePicker Fecha_s;
        private System.Windows.Forms.ComboBox tipo_habi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.NumericUpDown cant_niños;
        private System.Windows.Forms.Label label5;
    }
}