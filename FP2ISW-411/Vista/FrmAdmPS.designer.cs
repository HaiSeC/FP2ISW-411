namespace FP2ISW_411.Vista
{
    partial class FrmAdmPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmPS));
            this.PlnMenu = new System.Windows.Forms.Panel();
            this.PlnCRUDs = new System.Windows.Forms.Panel();
            this.BtnReg = new System.Windows.Forms.Button();
            this.FrmTarifas = new System.Windows.Forms.Button();
            this.BtnCRUDH = new System.Windows.Forms.Button();
            this.BtnCRUDs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBHome = new System.Windows.Forms.PictureBox();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PlnHead = new System.Windows.Forms.Panel();
            this.LblUser = new System.Windows.Forms.Label();
            this.PBMini = new System.Windows.Forms.PictureBox();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnRes = new System.Windows.Forms.Button();
            this.PlnMenu.SuspendLayout();
            this.PlnCRUDs.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBHome)).BeginInit();
            this.PlnHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PlnMenu
            // 
            this.PlnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PlnMenu.Controls.Add(this.BtnRes);
            this.PlnMenu.Controls.Add(this.PlnCRUDs);
            this.PlnMenu.Controls.Add(this.BtnCRUDs);
            this.PlnMenu.Controls.Add(this.panel1);
            this.PlnMenu.Controls.Add(this.BtnLogOut);
            this.PlnMenu.Controls.Add(this.button1);
            this.PlnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlnMenu.Location = new System.Drawing.Point(0, 0);
            this.PlnMenu.Name = "PlnMenu";
            this.PlnMenu.Size = new System.Drawing.Size(210, 576);
            this.PlnMenu.TabIndex = 2;
            // 
            // PlnCRUDs
            // 
            this.PlnCRUDs.Controls.Add(this.BtnReg);
            this.PlnCRUDs.Controls.Add(this.FrmTarifas);
            this.PlnCRUDs.Controls.Add(this.BtnCRUDH);
            this.PlnCRUDs.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlnCRUDs.Location = new System.Drawing.Point(0, 150);
            this.PlnCRUDs.Name = "PlnCRUDs";
            this.PlnCRUDs.Size = new System.Drawing.Size(210, 96);
            this.PlnCRUDs.TabIndex = 16;
            this.PlnCRUDs.Visible = false;
            // 
            // BtnReg
            // 
            this.BtnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReg.FlatAppearance.BorderSize = 0;
            this.BtnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReg.ForeColor = System.Drawing.Color.DimGray;
            this.BtnReg.Location = new System.Drawing.Point(0, 64);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnReg.Size = new System.Drawing.Size(210, 32);
            this.BtnReg.TabIndex = 2;
            this.BtnReg.Text = "CRUD Usuarios";
            this.BtnReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReg.UseVisualStyleBackColor = false;
            // 
            // FrmTarifas
            // 
            this.FrmTarifas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FrmTarifas.Dock = System.Windows.Forms.DockStyle.Top;
            this.FrmTarifas.FlatAppearance.BorderSize = 0;
            this.FrmTarifas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrmTarifas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmTarifas.ForeColor = System.Drawing.Color.DimGray;
            this.FrmTarifas.Location = new System.Drawing.Point(0, 32);
            this.FrmTarifas.Name = "FrmTarifas";
            this.FrmTarifas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.FrmTarifas.Size = new System.Drawing.Size(210, 32);
            this.FrmTarifas.TabIndex = 4;
            this.FrmTarifas.Text = "CRUD Tarifas";
            this.FrmTarifas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmTarifas.UseVisualStyleBackColor = false;
            // 
            // BtnCRUDH
            // 
            this.BtnCRUDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnCRUDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCRUDH.FlatAppearance.BorderSize = 0;
            this.BtnCRUDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCRUDH.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCRUDH.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCRUDH.Location = new System.Drawing.Point(0, 0);
            this.BtnCRUDH.Name = "BtnCRUDH";
            this.BtnCRUDH.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnCRUDH.Size = new System.Drawing.Size(210, 32);
            this.BtnCRUDH.TabIndex = 3;
            this.BtnCRUDH.Text = "CRUD Hoteles";
            this.BtnCRUDH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCRUDH.UseVisualStyleBackColor = false;
            // 
            // BtnCRUDs
            // 
            this.BtnCRUDs.BackColor = System.Drawing.Color.DimGray;
            this.BtnCRUDs.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCRUDs.FlatAppearance.BorderSize = 0;
            this.BtnCRUDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCRUDs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCRUDs.Image = ((System.Drawing.Image)(resources.GetObject("BtnCRUDs.Image")));
            this.BtnCRUDs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCRUDs.Location = new System.Drawing.Point(0, 105);
            this.BtnCRUDs.Name = "BtnCRUDs";
            this.BtnCRUDs.Size = new System.Drawing.Size(210, 45);
            this.BtnCRUDs.TabIndex = 13;
            this.BtnCRUDs.UseVisualStyleBackColor = false;
            this.BtnCRUDs.Click += new System.EventHandler(this.BtnCRUDs_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PBHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 75);
            this.panel1.TabIndex = 12;
            // 
            // PBHome
            // 
            this.PBHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBHome.Image = ((System.Drawing.Image)(resources.GetObject("PBHome.Image")));
            this.PBHome.Location = new System.Drawing.Point(0, 0);
            this.PBHome.Name = "PBHome";
            this.PBHome.Size = new System.Drawing.Size(210, 74);
            this.PBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBHome.TabIndex = 0;
            this.PBHome.TabStop = false;
            this.PBHome.Click += new System.EventHandler(this.PBHome_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.DimGray;
            this.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogOut.Image")));
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 531);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(210, 45);
            this.BtnLogOut.TabIndex = 11;
            this.BtnLogOut.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlnHead
            // 
            this.PlnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlnHead.Controls.Add(this.LblUser);
            this.PlnHead.Controls.Add(this.PBMini);
            this.PlnHead.Controls.Add(this.PBClose);
            this.PlnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlnHead.Location = new System.Drawing.Point(210, 0);
            this.PlnHead.Name = "PlnHead";
            this.PlnHead.Size = new System.Drawing.Size(880, 30);
            this.PlnHead.TabIndex = 3;
            this.PlnHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlnHead_MouseDown);
            this.PlnHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlnHead_MouseMove);
            this.PlnHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlnHead_MouseUp);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.DimGray;
            this.LblUser.Location = new System.Drawing.Point(3, 3);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(104, 20);
            this.LblUser.TabIndex = 3;
            this.LblUser.Text = "Bienvenido(a),";
            // 
            // PBMini
            // 
            this.PBMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBMini.Image = ((System.Drawing.Image)(resources.GetObject("PBMini.Image")));
            this.PBMini.Location = new System.Drawing.Point(822, 3);
            this.PBMini.Name = "PBMini";
            this.PBMini.Size = new System.Drawing.Size(24, 24);
            this.PBMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMini.TabIndex = 2;
            this.PBMini.TabStop = false;
            this.PBMini.Click += new System.EventHandler(this.PBMini_Click);
            // 
            // PBClose
            // 
            this.PBClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(852, 3);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(24, 24);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 1;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.PBClose_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 546);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnRes
            // 
            this.BtnRes.BackColor = System.Drawing.Color.DimGray;
            this.BtnRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRes.FlatAppearance.BorderSize = 0;
            this.BtnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes.Image = ((System.Drawing.Image)(resources.GetObject("BtnRes.Image")));
            this.BtnRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRes.Location = new System.Drawing.Point(0, 246);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(210, 45);
            this.BtnRes.TabIndex = 17;
            this.BtnRes.UseVisualStyleBackColor = false;
            // 
            // FrmAdmPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1090, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PlnHead);
            this.Controls.Add(this.PlnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMiViaje";
            this.Load += new System.EventHandler(this.FrmAdmPuestos_Load);
            this.PlnMenu.ResumeLayout(false);
            this.PlnCRUDs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBHome)).EndInit();
            this.PlnHead.ResumeLayout(false);
            this.PlnHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlnMenu;
        private System.Windows.Forms.Panel PlnCRUDs;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button FrmTarifas;
        private System.Windows.Forms.Button BtnCRUDH;
        private System.Windows.Forms.Button BtnCRUDs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBHome;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PlnHead;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.PictureBox PBMini;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnRes;
    }
}