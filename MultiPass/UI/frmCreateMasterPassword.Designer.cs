namespace MultiPass.UI
{
    partial class frmCreateMasterPassword
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
            this.lblPasswordInfo1 = new System.Windows.Forms.Label();
            this.btnSetMasterPassword = new System.Windows.Forms.Button();
            this.lblMasterPassword = new System.Windows.Forms.Label();
            this.txtMasterPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordInfo2 = new System.Windows.Forms.Label();
            this.lblPasswordInfo3 = new System.Windows.Forms.Label();
            this.lblPasswordInfo4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMasterPasswordVerify = new System.Windows.Forms.Label();
            this.txtMasterPasswordVerify = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPasswordInfo1
            // 
            this.lblPasswordInfo1.AutoSize = true;
            this.lblPasswordInfo1.Location = new System.Drawing.Point(7, 9);
            this.lblPasswordInfo1.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblPasswordInfo1.Name = "lblPasswordInfo1";
            this.lblPasswordInfo1.Size = new System.Drawing.Size(347, 13);
            this.lblPasswordInfo1.TabIndex = 0;
            this.lblPasswordInfo1.Text = "The master password will be used to retrieve all of your other passwords.";
            // 
            // btnSetMasterPassword
            // 
            this.btnSetMasterPassword.Location = new System.Drawing.Point(40, 225);
            this.btnSetMasterPassword.Name = "btnSetMasterPassword";
            this.btnSetMasterPassword.Size = new System.Drawing.Size(120, 23);
            this.btnSetMasterPassword.TabIndex = 3;
            this.btnSetMasterPassword.Text = "Set Master Password";
            this.btnSetMasterPassword.UseVisualStyleBackColor = true;
            this.btnSetMasterPassword.Click += new System.EventHandler(this.btnSetMasterPassword_Click);
            // 
            // lblMasterPassword
            // 
            this.lblMasterPassword.AutoSize = true;
            this.lblMasterPassword.Location = new System.Drawing.Point(15, 161);
            this.lblMasterPassword.Name = "lblMasterPassword";
            this.lblMasterPassword.Size = new System.Drawing.Size(91, 13);
            this.lblMasterPassword.TabIndex = 2;
            this.lblMasterPassword.Text = "Master Password:";
            // 
            // txtMasterPassword
            // 
            this.txtMasterPassword.Location = new System.Drawing.Point(133, 158);
            this.txtMasterPassword.MaxLength = 30;
            this.txtMasterPassword.Name = "txtMasterPassword";
            this.txtMasterPassword.PasswordChar = '*';
            this.txtMasterPassword.Size = new System.Drawing.Size(217, 20);
            this.txtMasterPassword.TabIndex = 1;
            // 
            // lblPasswordInfo2
            // 
            this.lblPasswordInfo2.AutoSize = true;
            this.lblPasswordInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordInfo2.Location = new System.Drawing.Point(7, 32);
            this.lblPasswordInfo2.Name = "lblPasswordInfo2";
            this.lblPasswordInfo2.Size = new System.Drawing.Size(268, 13);
            this.lblPasswordInfo2.TabIndex = 4;
            this.lblPasswordInfo2.Text = "BE SURE TO REMEMBER THIS PASSWORD!";
            // 
            // lblPasswordInfo3
            // 
            this.lblPasswordInfo3.AutoSize = true;
            this.lblPasswordInfo3.Location = new System.Drawing.Point(7, 55);
            this.lblPasswordInfo3.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblPasswordInfo3.Name = "lblPasswordInfo3";
            this.lblPasswordInfo3.Size = new System.Drawing.Size(349, 39);
            this.lblPasswordInfo3.TabIndex = 5;
            this.lblPasswordInfo3.Text = "If you forget the master password, you will lose access to all of your passwords," +
    " so make sure you set the master password to something you will never forget.";
            // 
            // lblPasswordInfo4
            // 
            this.lblPasswordInfo4.AutoSize = true;
            this.lblPasswordInfo4.Location = new System.Drawing.Point(7, 105);
            this.lblPasswordInfo4.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblPasswordInfo4.Name = "lblPasswordInfo4";
            this.lblPasswordInfo4.Size = new System.Drawing.Size(350, 26);
            this.lblPasswordInfo4.TabIndex = 6;
            this.lblPasswordInfo4.Text = "After setting the master password, you can change it at any time through the File" +
    " menu.";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMasterPasswordVerify
            // 
            this.lblMasterPasswordVerify.AutoSize = true;
            this.lblMasterPasswordVerify.Location = new System.Drawing.Point(15, 185);
            this.lblMasterPasswordVerify.Name = "lblMasterPasswordVerify";
            this.lblMasterPasswordVerify.Size = new System.Drawing.Size(120, 13);
            this.lblMasterPasswordVerify.TabIndex = 8;
            this.lblMasterPasswordVerify.Text = "Verify Master Password:";
            // 
            // txtMasterPasswordVerify
            // 
            this.txtMasterPasswordVerify.Location = new System.Drawing.Point(133, 182);
            this.txtMasterPasswordVerify.MaxLength = 30;
            this.txtMasterPasswordVerify.Name = "txtMasterPasswordVerify";
            this.txtMasterPasswordVerify.PasswordChar = '*';
            this.txtMasterPasswordVerify.Size = new System.Drawing.Size(217, 20);
            this.txtMasterPasswordVerify.TabIndex = 2;
            // 
            // frmCreateMasterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
            this.Controls.Add(this.txtMasterPasswordVerify);
            this.Controls.Add(this.lblMasterPasswordVerify);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPasswordInfo4);
            this.Controls.Add(this.lblPasswordInfo3);
            this.Controls.Add(this.lblPasswordInfo2);
            this.Controls.Add(this.txtMasterPassword);
            this.Controls.Add(this.lblMasterPassword);
            this.Controls.Add(this.btnSetMasterPassword);
            this.Controls.Add(this.lblPasswordInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCreateMasterPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Master Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordInfo1;
        private System.Windows.Forms.Button btnSetMasterPassword;
        private System.Windows.Forms.Label lblMasterPassword;
        private System.Windows.Forms.TextBox txtMasterPassword;
        private System.Windows.Forms.Label lblPasswordInfo2;
        private System.Windows.Forms.Label lblPasswordInfo3;
        private System.Windows.Forms.Label lblPasswordInfo4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMasterPasswordVerify;
        private System.Windows.Forms.TextBox txtMasterPasswordVerify;
    }
}