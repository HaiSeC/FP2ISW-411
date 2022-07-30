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
            ((System.ComponentModel.ISupportInitialize)(this.CantA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantN)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCantA
            // 
            this.LblCantA.AutoSize = true;
            this.LblCantA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantA.ForeColor = System.Drawing.Color.Gray;
            this.LblCantA.Location = new System.Drawing.Point(285, 113);
            this.LblCantA.Name = "LblCantA";
            this.LblCantA.Size = new System.Drawing.Size(169, 21);
            this.LblCantA.TabIndex = 0;
            this.LblCantA.Text = "Cantidad de Adultos:";
            // 
            // LblFE
            // 
            this.LblFE.AutoSize = true;
            this.LblFE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFE.ForeColor = System.Drawing.Color.Gray;
            this.LblFE.Location = new System.Drawing.Point(285, 198);
            this.LblFE.Name = "LblFE";
            this.LblFE.Size = new System.Drawing.Size(144, 21);
            this.LblFE.TabIndex = 1;
            this.LblFE.Text = "Fecha de Entrada:";
            // 
            // LblFS
            // 
            this.LblFS.AutoSize = true;
            this.LblFS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFS.ForeColor = System.Drawing.Color.Gray;
            this.LblFS.Location = new System.Drawing.Point(285, 242);
            this.LblFS.Name = "LblFS";
            this.LblFS.Size = new System.Drawing.Size(130, 21);
            this.LblFS.TabIndex = 2;
            this.LblFS.Text = "Fecha de salida:";
            // 
            // LblTH
            // 
            this.LblTH.AutoSize = true;
            this.LblTH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTH.ForeColor = System.Drawing.Color.Gray;
            this.LblTH.Location = new System.Drawing.Point(285, 284);
            this.LblTH.Name = "LblTH";
            this.LblTH.Size = new System.Drawing.Size(157, 21);
            this.LblTH.TabIndex = 3;
            this.LblTH.Text = "Tipo de habitación:";
            // 
            // CantA
            // 
            this.CantA.BackColor = System.Drawing.Color.Gray;
            this.CantA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantA.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantA.Location = new System.Drawing.Point(454, 113);
            this.CantA.Name = "CantA";
            this.CantA.ReadOnly = true;
            this.CantA.Size = new System.Drawing.Size(104, 22);
            this.CantA.TabIndex = 4;
            this.CantA.ValueChanged += new System.EventHandler(this.CantA_ValueChanged);
            // 
            // DPE
            // 
            this.DPE.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPE.Location = new System.Drawing.Point(454, 198);
            this.DPE.Name = "DPE";
            this.DPE.Size = new System.Drawing.Size(200, 22);
            this.DPE.TabIndex = 5;
            this.DPE.ValueChanged += new System.EventHandler(this.DPE_ValueChanged);
            // 
            // DPS
            // 
            this.DPS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPS.Location = new System.Drawing.Point(454, 242);
            this.DPS.Name = "DPS";
            this.DPS.Size = new System.Drawing.Size(200, 22);
            this.DPS.TabIndex = 6;
            this.DPS.ValueChanged += new System.EventHandler(this.DPS_ValueChanged);
            // 
            // CBoxTH
            // 
            this.CBoxTH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBoxTH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBoxTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTH.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxTH.FormattingEnabled = true;
            this.CBoxTH.Location = new System.Drawing.Point(454, 284);
            this.CBoxTH.Name = "CBoxTH";
            this.CBoxTH.Size = new System.Drawing.Size(200, 21);
            this.CBoxTH.TabIndex = 7;
            this.CBoxTH.SelectedIndexChanged += new System.EventHandler(this.CBoxTH_SelectedIndexChanged);
            // 
            // BtnRes
            // 
            this.BtnRes.BackColor = System.Drawing.Color.Silver;
            this.BtnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes.Location = new System.Drawing.Point(374, 381);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(148, 27);
            this.BtnRes.TabIndex = 8;
            this.BtnRes.Text = "Resevar";
            this.BtnRes.UseVisualStyleBackColor = false;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // LblP
            // 
            this.LblP.AutoSize = true;
            this.LblP.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP.ForeColor = System.Drawing.Color.Silver;
            this.LblP.Location = new System.Drawing.Point(390, 333);
            this.LblP.Name = "LblP";
            this.LblP.Size = new System.Drawing.Size(100, 25);
            this.LblP.TabIndex = 9;
            this.LblP.Text = "Precio: $0";
            // 
            // CantN
            // 
            this.CantN.BackColor = System.Drawing.Color.Gray;
            this.CantN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantN.Location = new System.Drawing.Point(454, 156);
            this.CantN.Name = "CantN";
            this.CantN.ReadOnly = true;
            this.CantN.Size = new System.Drawing.Size(104, 22);
            this.CantN.TabIndex = 11;
            this.CantN.ValueChanged += new System.EventHandler(this.CantN_ValueChanged);
            // 
            // LblCantN
            // 
            this.LblCantN.AutoSize = true;
            this.LblCantN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantN.ForeColor = System.Drawing.Color.Gray;
            this.LblCantN.Location = new System.Drawing.Point(285, 156);
            this.LblCantN.Name = "LblCantN";
            this.LblCantN.Size = new System.Drawing.Size(152, 21);
            this.LblCantN.TabIndex = 10;
            this.LblCantN.Text = "Cantidad de niños:";
            // 
            // FrmRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(902, 546);
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
    }
}