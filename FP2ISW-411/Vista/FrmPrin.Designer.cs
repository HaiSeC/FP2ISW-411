namespace FP2ISW_411.Vista
{
    partial class FrmPrin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrin));
            this.PlnHead = new System.Windows.Forms.Panel();
            this.PBRes = new System.Windows.Forms.PictureBox();
            this.PBMini = new System.Windows.Forms.PictureBox();
            this.PBMax = new System.Windows.Forms.PictureBox();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.PlnMenu = new System.Windows.Forms.Panel();
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.PBHome = new System.Windows.Forms.PictureBox();
            this.BtnRes = new System.Windows.Forms.Button();
            this.PlnMain = new System.Windows.Forms.Panel();
            this.PlnHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            this.PlnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBHome)).BeginInit();
            this.SuspendLayout();
            // 
            // PlnHead
            // 
            this.PlnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PlnHead.Controls.Add(this.PBRes);
            this.PlnHead.Controls.Add(this.PBMini);
            this.PlnHead.Controls.Add(this.PBMax);
            this.PlnHead.Controls.Add(this.PBClose);
            this.PlnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlnHead.Location = new System.Drawing.Point(0, 0);
            this.PlnHead.Name = "PlnHead";
            this.PlnHead.Size = new System.Drawing.Size(1090, 30);
            this.PlnHead.TabIndex = 0;
            this.PlnHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlnHead_MouseDown);
            this.PlnHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlnHead_MouseMove);
            this.PlnHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlnHead_MouseUp);
            // 
            // PBRes
            // 
            this.PBRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBRes.Image = ((System.Drawing.Image)(resources.GetObject("PBRes.Image")));
            this.PBRes.Location = new System.Drawing.Point(1032, 3);
            this.PBRes.Name = "PBRes";
            this.PBRes.Size = new System.Drawing.Size(24, 24);
            this.PBRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBRes.TabIndex = 3;
            this.PBRes.TabStop = false;
            this.PBRes.Visible = false;
            this.PBRes.Click += new System.EventHandler(this.PBRes_Click);
            // 
            // PBMini
            // 
            this.PBMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBMini.Image = ((System.Drawing.Image)(resources.GetObject("PBMini.Image")));
            this.PBMini.Location = new System.Drawing.Point(1002, 3);
            this.PBMini.Name = "PBMini";
            this.PBMini.Size = new System.Drawing.Size(24, 24);
            this.PBMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMini.TabIndex = 2;
            this.PBMini.TabStop = false;
            this.PBMini.Click += new System.EventHandler(this.PBMini_Click);
            // 
            // PBMax
            // 
            this.PBMax.Image = ((System.Drawing.Image)(resources.GetObject("PBMax.Image")));
            this.PBMax.Location = new System.Drawing.Point(1032, 3);
            this.PBMax.Name = "PBMax";
            this.PBMax.Size = new System.Drawing.Size(24, 24);
            this.PBMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMax.TabIndex = 2;
            this.PBMax.TabStop = false;
            this.PBMax.Click += new System.EventHandler(this.PBMax_Click);
            // 
            // PBClose
            // 
            this.PBClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(1062, 3);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(24, 24);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 1;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.PBClose_Click);
            // 
            // PlnMenu
            // 
            this.PlnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PlnMenu.Controls.Add(this.BtnReg);
            this.PlnMenu.Controls.Add(this.BtnLogOut);
            this.PlnMenu.Controls.Add(this.PBHome);
            this.PlnMenu.Controls.Add(this.BtnRes);
            this.PlnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlnMenu.Location = new System.Drawing.Point(0, 30);
            this.PlnMenu.Name = "PlnMenu";
            this.PlnMenu.Size = new System.Drawing.Size(188, 546);
            this.PlnMenu.TabIndex = 1;
            // 
            // BtnReg
            // 
            this.BtnReg.BackColor = System.Drawing.Color.Gray;
            this.BtnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReg.Location = new System.Drawing.Point(0, 228);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(188, 23);
            this.BtnReg.TabIndex = 2;
            this.BtnReg.Text = "button1";
            this.BtnReg.UseVisualStyleBackColor = false;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Gray;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(0, 520);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(188, 23);
            this.BtnLogOut.TabIndex = 1;
            this.BtnLogOut.Text = "Cerrar Sesión";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // PBHome
            // 
            this.PBHome.Image = ((System.Drawing.Image)(resources.GetObject("PBHome.Image")));
            this.PBHome.Location = new System.Drawing.Point(0, 0);
            this.PBHome.Name = "PBHome";
            this.PBHome.Size = new System.Drawing.Size(188, 128);
            this.PBHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBHome.TabIndex = 0;
            this.PBHome.TabStop = false;
            this.PBHome.Click += new System.EventHandler(this.PBHome_Click);
            // 
            // BtnRes
            // 
            this.BtnRes.BackColor = System.Drawing.Color.Gray;
            this.BtnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRes.Location = new System.Drawing.Point(0, 158);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(188, 23);
            this.BtnRes.TabIndex = 0;
            this.BtnRes.Text = "BtnRes";
            this.BtnRes.UseVisualStyleBackColor = false;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // PlnMain
            // 
            this.PlnMain.BackColor = System.Drawing.Color.Black;
            this.PlnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlnMain.Location = new System.Drawing.Point(188, 30);
            this.PlnMain.Name = "PlnMain";
            this.PlnMain.Size = new System.Drawing.Size(902, 546);
            this.PlnMain.TabIndex = 2;
            // 
            // FrmPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 576);
            this.Controls.Add(this.PlnMain);
            this.Controls.Add(this.PlnMenu);
            this.Controls.Add(this.PlnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrin";
            this.PlnHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            this.PlnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlnHead;
        private System.Windows.Forms.PictureBox PBMini;
        private System.Windows.Forms.PictureBox PBMax;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.PictureBox PBRes;
        private System.Windows.Forms.Panel PlnMenu;
        private System.Windows.Forms.Panel PlnMain;
        private System.Windows.Forms.Button BtnRes;
        private System.Windows.Forms.PictureBox PBHome;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnReg;
    }
}