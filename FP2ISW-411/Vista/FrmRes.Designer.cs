namespace FP2ISW_411.Vista
{
    partial class FrmRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRes));
            this.LblCantA = new System.Windows.Forms.Label();
            this.LblFE = new System.Windows.Forms.Label();
            this.LblFS = new System.Windows.Forms.Label();
            this.LblTH = new System.Windows.Forms.Label();
            this.CantA = new System.Windows.Forms.NumericUpDown();
            this.DPE = new System.Windows.Forms.DateTimePicker();
            this.DPS = new System.Windows.Forms.DateTimePicker();
            this.CBoxTH = new System.Windows.Forms.ComboBox();
            this.BtnRes = new System.Windows.Forms.Button();
            this.LblP = new System.Windows.Forms.Label();
            this.CantN = new System.Windows.Forms.NumericUpDown();
            this.LblCantN = new System.Windows.Forms.Label();
            this.comboBox_hotel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_habitacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_ced = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CantA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantN)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCantA
            // 
            this.LblCantA.AutoSize = true;
            this.LblCantA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantA.ForeColor = System.Drawing.Color.Gray;
            this.LblCantA.Location = new System.Drawing.Point(39, 99);
            this.LblCantA.Name = "LblCantA";
            this.LblCantA.Size = new System.Drawing.Size(153, 21);
            this.LblCantA.TabIndex = 0;
            this.LblCantA.Text = "Cantidad de Adultos:";
            // 
            // LblFE
            // 
            this.LblFE.AutoSize = true;
            this.LblFE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFE.ForeColor = System.Drawing.Color.Gray;
            this.LblFE.Location = new System.Drawing.Point(39, 184);
            this.LblFE.Name = "LblFE";
            this.LblFE.Size = new System.Drawing.Size(131, 21);
            this.LblFE.TabIndex = 1;
            this.LblFE.Text = "Fecha de Entrada:";
            // 
            // LblFS
            // 
            this.LblFS.AutoSize = true;
            this.LblFS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFS.ForeColor = System.Drawing.Color.Gray;
            this.LblFS.Location = new System.Drawing.Point(39, 228);
            this.LblFS.Name = "LblFS";
            this.LblFS.Size = new System.Drawing.Size(118, 21);
            this.LblFS.TabIndex = 2;
            this.LblFS.Text = "Fecha de salida:";
            // 
            // LblTH
            // 
            this.LblTH.AutoSize = true;
            this.LblTH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTH.ForeColor = System.Drawing.Color.Gray;
            this.LblTH.Location = new System.Drawing.Point(39, 336);
            this.LblTH.Name = "LblTH";
            this.LblTH.Size = new System.Drawing.Size(140, 21);
            this.LblTH.TabIndex = 3;
            this.LblTH.Text = "Tipo de habitación:";
            // 
            // CantA
            // 
            this.CantA.BackColor = System.Drawing.Color.Gray;
            this.CantA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantA.Location = new System.Drawing.Point(208, 99);
            this.CantA.Name = "CantA";
            this.CantA.ReadOnly = true;
            this.CantA.Size = new System.Drawing.Size(277, 29);
            this.CantA.TabIndex = 4;
            this.CantA.ValueChanged += new System.EventHandler(this.CantA_ValueChanged);
            // 
            // DPE
            // 
            this.DPE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPE.Location = new System.Drawing.Point(208, 184);
            this.DPE.Name = "DPE";
            this.DPE.Size = new System.Drawing.Size(277, 29);
            this.DPE.TabIndex = 5;
            this.DPE.ValueChanged += new System.EventHandler(this.DPE_ValueChanged);
            // 
            // DPS
            // 
            this.DPS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPS.Location = new System.Drawing.Point(208, 228);
            this.DPS.Name = "DPS";
            this.DPS.Size = new System.Drawing.Size(277, 29);
            this.DPS.TabIndex = 6;
            this.DPS.ValueChanged += new System.EventHandler(this.DPS_ValueChanged);
            // 
            // CBoxTH
            // 
            this.CBoxTH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBoxTH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBoxTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxTH.FormattingEnabled = true;
            this.CBoxTH.Location = new System.Drawing.Point(208, 328);
            this.CBoxTH.Name = "CBoxTH";
            this.CBoxTH.Size = new System.Drawing.Size(277, 29);
            this.CBoxTH.TabIndex = 7;
            this.CBoxTH.SelectedIndexChanged += new System.EventHandler(this.CBoxTH_SelectedIndexChanged);
            // 
            // BtnRes
            // 
            this.BtnRes.BackColor = System.Drawing.Color.Silver;
            this.BtnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes.Location = new System.Drawing.Point(208, 489);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(148, 39);
            this.BtnRes.TabIndex = 8;
            this.BtnRes.Text = "Resevar";
            this.BtnRes.UseVisualStyleBackColor = false;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // LblP
            // 
            this.LblP.AutoSize = true;
            this.LblP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP.ForeColor = System.Drawing.Color.Silver;
            this.LblP.Location = new System.Drawing.Point(224, 441);
            this.LblP.Name = "LblP";
            this.LblP.Size = new System.Drawing.Size(78, 21);
            this.LblP.TabIndex = 9;
            this.LblP.Text = "Precio: $0";
            // 
            // CantN
            // 
            this.CantN.BackColor = System.Drawing.Color.Gray;
            this.CantN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantN.Location = new System.Drawing.Point(208, 142);
            this.CantN.Name = "CantN";
            this.CantN.ReadOnly = true;
            this.CantN.Size = new System.Drawing.Size(277, 29);
            this.CantN.TabIndex = 11;
            this.CantN.ValueChanged += new System.EventHandler(this.CantN_ValueChanged);
            // 
            // LblCantN
            // 
            this.LblCantN.AutoSize = true;
            this.LblCantN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantN.ForeColor = System.Drawing.Color.Gray;
            this.LblCantN.Location = new System.Drawing.Point(39, 142);
            this.LblCantN.Name = "LblCantN";
            this.LblCantN.Size = new System.Drawing.Size(138, 21);
            this.LblCantN.TabIndex = 10;
            this.LblCantN.Text = "Cantidad de niños:";
            // 
            // comboBox_hotel
            // 
            this.comboBox_hotel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_hotel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hotel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_hotel.FormattingEnabled = true;
            this.comboBox_hotel.Location = new System.Drawing.Point(208, 270);
            this.comboBox_hotel.Name = "comboBox_hotel";
            this.comboBox_hotel.Size = new System.Drawing.Size(277, 29);
            this.comboBox_hotel.TabIndex = 13;
            this.comboBox_hotel.SelectedIndexChanged += new System.EventHandler(this.comboBox_hotel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(39, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hotel:";
            // 
            // comboBox_habitacion
            // 
            this.comboBox_habitacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_habitacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_habitacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_habitacion.FormattingEnabled = true;
            this.comboBox_habitacion.Location = new System.Drawing.Point(208, 383);
            this.comboBox_habitacion.Name = "comboBox_habitacion";
            this.comboBox_habitacion.Size = new System.Drawing.Size(277, 29);
            this.comboBox_habitacion.TabIndex = 15;
            this.comboBox_habitacion.Visible = false;
            this.comboBox_habitacion.SelectedValueChanged += new System.EventHandler(this.comboBox_habitacion_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(39, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Habitación:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(39, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cédula:";
            // 
            // text_ced
            // 
            this.text_ced.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ced.Location = new System.Drawing.Point(208, 50);
            this.text_ced.Name = "text_ced";
            this.text_ced.Size = new System.Drawing.Size(277, 29);
            this.text_ced.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(552, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 546);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 453);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(13, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "HOTEL";
            // 
            // FrmRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_ced);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_habitacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_hotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantN);
            this.Controls.Add(this.LblCantN);
            this.Controls.Add(this.LblP);
            this.Controls.Add(this.BtnRes);
            this.Controls.Add(this.CBoxTH);
            this.Controls.Add(this.DPS);
            this.Controls.Add(this.DPE);
            this.Controls.Add(this.CantA);
            this.Controls.Add(this.LblTH);
            this.Controls.Add(this.LblFS);
            this.Controls.Add(this.LblFE);
            this.Controls.Add(this.LblCantA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRes";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.CantA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCantA;
        private System.Windows.Forms.Label LblFE;
        private System.Windows.Forms.Label LblFS;
        private System.Windows.Forms.Label LblTH;
        private System.Windows.Forms.NumericUpDown CantA;
        private System.Windows.Forms.DateTimePicker DPE;
        private System.Windows.Forms.DateTimePicker DPS;
        private System.Windows.Forms.ComboBox CBoxTH;
        private System.Windows.Forms.Button BtnRes;
        private System.Windows.Forms.Label LblP;
        private System.Windows.Forms.NumericUpDown CantN;
        private System.Windows.Forms.Label LblCantN;
        private System.Windows.Forms.ComboBox comboBox_hotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_habitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_ced;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}