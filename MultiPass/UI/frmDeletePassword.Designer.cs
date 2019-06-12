namespace MultiPass.UI
{
    partial class frmDeletePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeletePassword));
            this.lblDeleteNotice1 = new System.Windows.Forms.Label();
            this.lblSelectPassword = new System.Windows.Forms.Label();
            this.cbxPasswordList = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDeleteNotice2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeleteNotice1
            // 
            this.lblDeleteNotice1.AutoSize = true;
            this.lblDeleteNotice1.Location = new System.Drawing.Point(26, 9);
            this.lblDeleteNotice1.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblDeleteNotice1.Name = "lblDeleteNotice1";
            this.lblDeleteNotice1.Size = new System.Drawing.Size(349, 26);
            this.lblDeleteNotice1.TabIndex = 0;
            this.lblDeleteNotice1.Text = "You are about to permanently delete a password.  Once the password is deleted, it" +
    " can no longer be recovered.";
            // 
            // lblSelectPassword
            // 
            this.lblSelectPassword.AutoSize = true;
            this.lblSelectPassword.Location = new System.Drawing.Point(13, 104);
            this.lblSelectPassword.Name = "lblSelectPassword";
            this.lblSelectPassword.Size = new System.Drawing.Size(132, 13);
            this.lblSelectPassword.TabIndex = 1;
            this.lblSelectPassword.Text = "Select password to delete:";
            // 
            // cbxPasswordList
            // 
            this.cbxPasswordList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPasswordList.FormattingEnabled = true;
            this.cbxPasswordList.Location = new System.Drawing.Point(151, 101);
            this.cbxPasswordList.Name = "cbxPasswordList";
            this.cbxPasswordList.Size = new System.Drawing.Size(237, 21);
            this.cbxPasswordList.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(59, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Password";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDeleteNotice2
            // 
            this.lblDeleteNotice2.AutoSize = true;
            this.lblDeleteNotice2.Location = new System.Drawing.Point(26, 45);
            this.lblDeleteNotice2.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblDeleteNotice2.Name = "lblDeleteNotice2";
            this.lblDeleteNotice2.Size = new System.Drawing.Size(347, 39);
            this.lblDeleteNotice2.TabIndex = 5;
            this.lblDeleteNotice2.Text = resources.GetString("lblDeleteNotice2.Text");
            // 
            // frmDeletePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 176);
            this.ControlBox = false;
            this.Controls.Add(this.lblDeleteNotice2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbxPasswordList);
            this.Controls.Add(this.lblSelectPassword);
            this.Controls.Add(this.lblDeleteNotice1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDeletePassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Password";
            this.Load += new System.EventHandler(this.frmDeletePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteNotice1;
        private System.Windows.Forms.Label lblSelectPassword;
        private System.Windows.Forms.ComboBox cbxPasswordList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDeleteNotice2;
    }
}