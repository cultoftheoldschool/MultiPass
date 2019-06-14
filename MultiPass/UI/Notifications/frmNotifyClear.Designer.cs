namespace MultiPass.UI.Notifications
{
    partial class frmNotifyClear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotifyClear));
            this.lblClipboardCleared = new System.Windows.Forms.Label();
            this.pbxBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClipboardCleared
            // 
            this.lblClipboardCleared.AutoSize = true;
            this.lblClipboardCleared.BackColor = System.Drawing.Color.Black;
            this.lblClipboardCleared.Font = new System.Drawing.Font("Px437 IBM ISO9", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(255)));
            this.lblClipboardCleared.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblClipboardCleared.Location = new System.Drawing.Point(8, 2);
            this.lblClipboardCleared.Name = "lblClipboardCleared";
            this.lblClipboardCleared.Size = new System.Drawing.Size(267, 27);
            this.lblClipboardCleared.TabIndex = 0;
            this.lblClipboardCleared.Text = "CLIPBOARD CLEARED";
            // 
            // pbxBanner
            // 
            this.pbxBanner.BackColor = System.Drawing.Color.Transparent;
            this.pbxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbxBanner.Image")));
            this.pbxBanner.Location = new System.Drawing.Point(0, 0);
            this.pbxBanner.Margin = new System.Windows.Forms.Padding(0);
            this.pbxBanner.Name = "pbxBanner";
            this.pbxBanner.Size = new System.Drawing.Size(275, 30);
            this.pbxBanner.TabIndex = 1;
            this.pbxBanner.TabStop = false;
            // 
            // frmNotifyClear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(275, 30);
            this.Controls.Add(this.pbxBanner);
            this.Controls.Add(this.lblClipboardCleared);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotifyClear";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Load += new System.EventHandler(this.frmNotifyClear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClipboardCleared;
        private System.Windows.Forms.PictureBox pbxBanner;
    }
}