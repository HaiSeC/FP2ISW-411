namespace FP2ISW_411.Vista
{
    partial class FrmCRUDH
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
            this.ChkBxAc = new System.Windows.Forms.CheckBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtLoc = new System.Windows.Forms.TextBox();
            this.TxtCH = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblLoc = new System.Windows.Forms.Label();
            this.LblCantHab = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnE = new System.Windows.Forms.Button();
            this.BtnS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChkBxAc
            // 
            this.ChkBxAc.AutoSize = true;
            this.ChkBxAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxAc.ForeColor = System.Drawing.Color.Gray;
            this.ChkBxAc.Location = new System.Drawing.Point(578, 269);
            this.ChkBxAc.Name = "ChkBxAc";
            this.ChkBxAc.Size = new System.Drawing.Size(96, 29);
            this.ChkBxAc.TabIndex = 38;
            this.ChkBxAc.Text = "Activo";
            this.ChkBxAc.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Gray;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnClear.Location = new System.Drawing.Point(253, 341);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(101, 36);
            this.BtnClear.TabIndex = 37;
            this.BtnClear.Text = "Limpiar";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtLoc
            // 
            this.TxtLoc.BackColor = System.Drawing.Color.Gray;
            this.TxtLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoc.Location = new System.Drawing.Point(293, 168);
            this.TxtLoc.Name = "TxtLoc";
            this.TxtLoc.Size = new System.Drawing.Size(266, 29);
            this.TxtLoc.TabIndex = 36;
            // 
            // TxtCH
            // 
            this.TxtCH.BackColor = System.Drawing.Color.Gray;
            this.TxtCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCH.Location = new System.Drawing.Point(293, 213);
            this.TxtCH.Name = "TxtCH";
            this.TxtCH.Size = new System.Drawing.Size(266, 29);
            this.TxtCH.TabIndex = 35;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.Gray;
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(293, 125);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(266, 29);
            this.TxtName.TabIndex = 34;
            // 
            // TxtID
            // 
            this.TxtID.BackColor = System.Drawing.Color.Gray;
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(293, 83);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(266, 29);
            this.TxtID.TabIndex = 33;
            // 
            // LblLoc
            // 
            this.LblLoc.AutoSize = true;
            this.LblLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoc.ForeColor = System.Drawing.Color.Gray;
            this.LblLoc.Location = new System.Drawing.Point(146, 176);
            this.LblLoc.Name = "LblLoc";
            this.LblLoc.Size = new System.Drawing.Size(79, 21);
            this.LblLoc.TabIndex = 32;
            this.LblLoc.Text = "Localidad:";
            // 
            // LblCantHab
            // 
            this.LblCantHab.AutoSize = true;
            this.LblCantHab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantHab.ForeColor = System.Drawing.Color.Gray;
            this.LblCantHab.Location = new System.Drawing.Point(146, 221);
            this.LblCantHab.Name = "LblCantHab";
            this.LblCantHab.Size = new System.Drawing.Size(141, 21);
            this.LblCantHab.TabIndex = 31;
            this.LblCantHab.Text = "Cant. Habitaciones:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.Gray;
            this.LblName.Location = new System.Drawing.Point(146, 133);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(71, 21);
            this.LblName.TabIndex = 30;
            this.LblName.Text = "Nombre:";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.Gray;
            this.LblID.Location = new System.Drawing.Point(146, 91);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(100, 21);
            this.LblID.TabIndex = 29;
            this.LblID.Text = "Identificador:";
            // 
            // BtnReg
            // 
            this.BtnReg.BackColor = System.Drawing.Color.Gray;
            this.BtnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnReg.Location = new System.Drawing.Point(360, 341);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(101, 36);
            this.BtnReg.TabIndex = 39;
            this.BtnReg.Text = "Registrar";
            this.BtnReg.UseVisualStyleBackColor = false;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnE
            // 
            this.BtnE.BackColor = System.Drawing.Color.Gray;
            this.BtnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnE.Location = new System.Drawing.Point(467, 341);
            this.BtnE.Name = "BtnE";
            this.BtnE.Size = new System.Drawing.Size(101, 36);
            this.BtnE.TabIndex = 40;
            this.BtnE.Text = "Modificar";
            this.BtnE.UseVisualStyleBackColor = false;
            this.BtnE.Click += new System.EventHandler(this.BtnE_Click);
            // 
            // BtnS
            // 
            this.BtnS.BackColor = System.Drawing.Color.Gray;
            this.BtnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnS.Location = new System.Drawing.Point(360, 299);
            this.BtnS.Name = "BtnS";
            this.BtnS.Size = new System.Drawing.Size(101, 36);
            this.BtnS.TabIndex = 41;
            this.BtnS.Text = "Buscar";
            this.BtnS.UseVisualStyleBackColor = false;
            this.BtnS.Click += new System.EventHandler(this.BtnS_Click);
            // 
            // FrmCRUDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(870, 468);
            this.Controls.Add(this.BtnS);
            this.Controls.Add(this.BtnE);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.ChkBxAc);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtLoc);
            this.Controls.Add(this.TxtCH);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblLoc);
            this.Controls.Add(this.LblCantHab);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblID);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCRUDH";
            this.Text = "FrmCRUDH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkBxAc;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtLoc;
        private System.Windows.Forms.TextBox TxtCH;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblLoc;
        private System.Windows.Forms.Label LblCantHab;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnE;
        private System.Windows.Forms.Button BtnS;
    }
}