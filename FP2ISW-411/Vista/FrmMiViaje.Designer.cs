namespace FP2ISW_411.Vista
{
    partial class FrmMiViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMiViaje));
            this.PlnMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PlnMain
            // 
            this.PlnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(73)))), ((int)(((byte)(44)))));
            this.PlnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlnMain.Location = new System.Drawing.Point(0, 0);
            this.PlnMain.Name = "PlnMain";
            this.PlnMain.Size = new System.Drawing.Size(1090, 576);
            this.PlnMain.TabIndex = 3;
            // 
            // FrmMiViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 576);
            this.Controls.Add(this.PlnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMiViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMiViaje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlnMain;
    }
}