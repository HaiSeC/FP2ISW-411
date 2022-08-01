namespace FP2ISW_411.Vista
{
    partial class FrmTarifa
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
            this.comboBox_Hoteles = new System.Windows.Forms.ComboBox();
            this.comboBox_Thabitacion = new System.Windows.Forms.ComboBox();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.button_reg = new System.Windows.Forms.Button();
            this.button_Modi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(279, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(279, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(279, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de habitación:";
            // 
            // comboBox_Hoteles
            // 
            this.comboBox_Hoteles.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_Hoteles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Hoteles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Hoteles.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Hoteles.FormattingEnabled = true;
            this.comboBox_Hoteles.Location = new System.Drawing.Point(342, 123);
            this.comboBox_Hoteles.Name = "comboBox_Hoteles";
            this.comboBox_Hoteles.Size = new System.Drawing.Size(181, 28);
            this.comboBox_Hoteles.TabIndex = 3;
            // 
            // comboBox_Thabitacion
            // 
            this.comboBox_Thabitacion.BackColor = System.Drawing.Color.DimGray;
            this.comboBox_Thabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Thabitacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Thabitacion.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Thabitacion.FormattingEnabled = true;
            this.comboBox_Thabitacion.Location = new System.Drawing.Point(446, 233);
            this.comboBox_Thabitacion.Name = "comboBox_Thabitacion";
            this.comboBox_Thabitacion.Size = new System.Drawing.Size(181, 28);
            this.comboBox_Thabitacion.TabIndex = 4;
            // 
            // text_precio
            // 
            this.text_precio.BackColor = System.Drawing.Color.DimGray;
            this.text_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_precio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_precio.ForeColor = System.Drawing.Color.Black;
            this.text_precio.Location = new System.Drawing.Point(342, 183);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(173, 27);
            this.text_precio.TabIndex = 5;
            this.text_precio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_reg
            // 
            this.button_reg.BackColor = System.Drawing.Color.Gray;
            this.button_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reg.ForeColor = System.Drawing.Color.Black;
            this.button_reg.Location = new System.Drawing.Point(541, 304);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(86, 29);
            this.button_reg.TabIndex = 6;
            this.button_reg.Text = "Registrar";
            this.button_reg.UseVisualStyleBackColor = false;
            this.button_reg.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Modi
            // 
            this.button_Modi.BackColor = System.Drawing.Color.Gray;
            this.button_Modi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modi.ForeColor = System.Drawing.Color.Black;
            this.button_Modi.Location = new System.Drawing.Point(304, 304);
            this.button_Modi.Name = "button_Modi";
            this.button_Modi.Size = new System.Drawing.Size(86, 29);
            this.button_Modi.TabIndex = 7;
            this.button_Modi.Text = "Modificar";
            this.button_Modi.UseVisualStyleBackColor = false;
            this.button_Modi.Click += new System.EventHandler(this.button_Modi_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(429, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(886, 507);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_Modi);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.text_precio);
            this.Controls.Add(this.comboBox_Thabitacion);
            this.Controls.Add(this.comboBox_Hoteles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTarifa";
            this.Text = "FrmTarifa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Hoteles;
        private System.Windows.Forms.ComboBox comboBox_Thabitacion;
        private System.Windows.Forms.TextBox text_precio;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.Button button_Modi;
        private System.Windows.Forms.Button button3;
    }
}