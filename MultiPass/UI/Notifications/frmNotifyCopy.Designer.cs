namespace MultiPass.UI.Notifications
{
    partial class frmNotifyCopy
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
            this.pbxPasswordCopied = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPasswordCopied)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPasswordCopied
            // 
            this.pbxPasswordCopied.BackColor = System.Drawing.Color.Transparent;
            this.pbxPasswordCopied.Image = global::MultiPass.Properties.Resources.PasswordCopied;
            this.pbxPasswordCopied.Location = new System.Drawing.Point(0, 0);
            this.pbxPasswordCopied.Name = "pbxPasswordCopied";
            this.pbxPasswordCopied.Size = new System.Drawing.Size(275, 30);
            this.pbxPasswordCopied.TabIndex = 0;
            this.pbxPasswordCopied.TabStop = false;
            // 
            // frmNotifyCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(275, 30);
            this.Controls.Add(this.pbxPasswordCopied);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotifyCopy";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Load += new System.EventHandler(this.frmNotifyCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPasswordCopied)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPasswordCopied;
    }
}