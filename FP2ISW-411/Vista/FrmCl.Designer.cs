namespace FP2ISW_411.Vista
{
    partial class FrmCl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCl));
            this.PlnMain = new System.Windows.Forms.Panel();
            this.PlnHead = new System.Windows.Forms.Panel();
            this.LblUser = new System.Windows.Forms.Label();
            this.PBMini = new System.Windows.Forms.PictureBox();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PBHome = new System.Windows.Forms.PictureBox();
            this.PlnMenu = new System.Windows.Forms.Panel();
            this.BtnMV = new System.Windows.Forms.Button();
            this.BtnRes = new System.Windows.Forms.Button();
            this.PlnHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHome)).BeginInit();
            this.PlnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlnMain
            // 
            this.PlnMain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(73)))), ((int)(((byte)(44)))));
            this.PlnMain.Location = new System.Drawing.Point(183, 30);
            this.PlnMain.Name = "PlnMain";
            this.PlnMain.Size = new System.Drawing.Size(907, 546);
            this.PlnMain.TabIndex = 2;
            // 
            // PlnHead
            // 
            this.PlnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.PlnHead.Controls.Add(this.LblUser);
            this.PlnHead.Controls.Add(this.PBMini);
            this.PlnHead.Controls.Add(this.PBClose);
            this.PlnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlnHead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlnHead.Location = new System.Drawing.Point(183, 0);
            this.PlnHead.Name = "PlnHead";
            this.PlnHead.Size = new System.Drawing.Size(907, 30);
            this.PlnHead.TabIndex = 3;
            this.PlnHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlnHead_MouseDown_1);
            this.PlnHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlnHead_MouseMove_1);
            this.PlnHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlnHead_MouseUp_1);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LblUser.Location = new System.Drawing.Point(3, 3);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(134, 20);
            this.LblUser.TabIndex = 3;
            this.LblUser.Text = "Bienvenidx Cliente,";
            this.LblUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblUser_MouseDown);
            this.LblUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblUser_MouseMove);
            this.LblUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblUser_MouseUp);
            // 
            // PBMini
            // 
            this.PBMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBMini.Image = ((System.Drawing.Image)(resources.GetObject("PBMini.Image")));
            this.PBMini.Location = new System.Drawing.Point(849, 3);
            this.PBMini.Name = "PBMini";
            this.PBMini.Size = new System.Drawing.Size(24, 24);
            this.PBMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMini.TabIndex = 2;
            this.PBMini.TabStop = false;
            this.PBMini.Click += new System.EventHandler(this.PBMini_Click_1);
            // 
            // PBClose
            // 
            this.PBClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(879, 3);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(24, 24);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 1;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.PBClose_Click_1);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ForeColor = System.Drawing.Color.DimGray;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 530);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(183, 46);
            this.BtnLogOut.TabIndex = 1;
            this.BtnLogOut.Text = "Cerrar Sesión";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
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
            this.button1.Size = new System.Drawing.Size(183, 30);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PBHome
            // 
            this.PBHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBHome.Image = ((System.Drawing.Image)(resources.GetObject("PBHome.Image")));
            this.PBHome.Location = new System.Drawing.Point(0, 30);
            this.PBHome.Name = "PBHome";
            this.PBHome.Size = new System.Drawing.Size(183, 53);
            this.PBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBHome.TabIndex = 4;
            this.PBHome.TabStop = false;
            // 
            // PlnMenu
            // 
            this.PlnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(71)))), ((int)(((byte)(48)))));
            this.PlnMenu.Controls.Add(this.BtnMV);
            this.PlnMenu.Controls.Add(this.BtnRes);
            this.PlnMenu.Controls.Add(this.PBHome);
            this.PlnMenu.Controls.Add(this.button1);
            this.PlnMenu.Controls.Add(this.BtnLogOut);
            this.PlnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlnMenu.Location = new System.Drawing.Point(0, 0);
            this.PlnMenu.Name = "PlnMenu";
            this.PlnMenu.Size = new System.Drawing.Size(183, 576);
            this.PlnMenu.TabIndex = 1;
            this.PlnMenu.Click += new System.EventHandler(this.PlnMenu_Click);
            // 
            // BtnMV
            // 
            this.BtnMV.BackColor = System.Drawing.Color.Transparent;
            this.BtnMV.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMV.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMV.ForeColor = System.Drawing.Color.DimGray;
            this.BtnMV.Location = new System.Drawing.Point(0, 131);
            this.BtnMV.Name = "BtnMV";
            this.BtnMV.Size = new System.Drawing.Size(183, 47);
            this.BtnMV.TabIndex = 6;
            this.BtnMV.Text = "Mi Viaje";
            this.BtnMV.UseVisualStyleBackColor = false;
            this.BtnMV.Click += new System.EventHandler(this.BtnMV_Click);
            // 
            // BtnRes
            // 
            this.BtnRes.BackColor = System.Drawing.Color.Transparent;
            this.BtnRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes.ForeColor = System.Drawing.Color.DimGray;
            this.BtnRes.Location = new System.Drawing.Point(0, 83);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(183, 48);
            this.BtnRes.TabIndex = 5;
            this.BtnRes.Text = "Reservaciones";
            this.BtnRes.UseVisualStyleBackColor = false;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // FrmCl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 576);
            this.Controls.Add(this.PlnHead);
            this.Controls.Add(this.PlnMain);
            this.Controls.Add(this.PlnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrin";
            this.Load += new System.EventHandler(this.FrmPrin_Load);
            this.PlnHead.ResumeLayout(false);
            this.PlnHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHome)).EndInit();
            this.PlnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PlnMain;
        private System.Windows.Forms.Panel PlnHead;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.PictureBox PBMini;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PBHome;
        private System.Windows.Forms.Panel PlnMenu;
        private System.Windows.Forms.Button BtnMV;
        private System.Windows.Forms.Button BtnRes;
    }
}