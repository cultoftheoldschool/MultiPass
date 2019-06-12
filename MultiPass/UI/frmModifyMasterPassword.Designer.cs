namespace MultiPass.UI
{
    partial class frmModifyMasterPassword
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
            this.lblOldMasterPassword = new System.Windows.Forms.Label();
            this.lblNewMasterPassword = new System.Windows.Forms.Label();
            this.txtOldMasterPassword = new System.Windows.Forms.TextBox();
            this.txtNewMasterPassword = new System.Windows.Forms.TextBox();
            this.btnSetMasterPassword = new System.Windows.Forms.Button();
            this.lblPasswordInfo3 = new System.Windows.Forms.Label();
            this.lblPasswordInfo2 = new System.Windows.Forms.Label();
            this.lblPasswordInfo1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblVerifyMasterPassword = new System.Windows.Forms.Label();
            this.txtVerifyNewMasterPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOldMasterPassword
            // 
            this.lblOldMasterPassword.AutoSize = true;
            this.lblOldMasterPassword.Location = new System.Drawing.Point(11, 128);
            this.lblOldMasterPassword.Name = "lblOldMasterPassword";
            this.lblOldMasterPassword.Size = new System.Drawing.Size(128, 13);
            this.lblOldMasterPassword.TabIndex = 0;
            this.lblOldMasterPassword.Text = "Current Master Password:";
            // 
            // lblNewMasterPassword
            // 
            this.lblNewMasterPassword.AutoSize = true;
            this.lblNewMasterPassword.Location = new System.Drawing.Point(11, 154);
            this.lblNewMasterPassword.Name = "lblNewMasterPassword";
            this.lblNewMasterPassword.Size = new System.Drawing.Size(116, 13);
            this.lblNewMasterPassword.TabIndex = 1;
            this.lblNewMasterPassword.Text = "New Master Password:";
            // 
            // txtOldMasterPassword
            // 
            this.txtOldMasterPassword.Location = new System.Drawing.Point(140, 125);
            this.txtOldMasterPassword.MaxLength = 30;
            this.txtOldMasterPassword.Name = "txtOldMasterPassword";
            this.txtOldMasterPassword.PasswordChar = '*';
            this.txtOldMasterPassword.Size = new System.Drawing.Size(217, 20);
            this.txtOldMasterPassword.TabIndex = 1;
            // 
            // txtNewMasterPassword
            // 
            this.txtNewMasterPassword.Location = new System.Drawing.Point(140, 151);
            this.txtNewMasterPassword.MaxLength = 30;
            this.txtNewMasterPassword.Name = "txtNewMasterPassword";
            this.txtNewMasterPassword.PasswordChar = '*';
            this.txtNewMasterPassword.Size = new System.Drawing.Size(217, 20);
            this.txtNewMasterPassword.TabIndex = 2;
            // 
            // btnSetMasterPassword
            // 
            this.btnSetMasterPassword.Location = new System.Drawing.Point(44, 214);
            this.btnSetMasterPassword.Name = "btnSetMasterPassword";
            this.btnSetMasterPassword.Size = new System.Drawing.Size(120, 23);
            this.btnSetMasterPassword.TabIndex = 4;
            this.btnSetMasterPassword.Text = "Set Master Password";
            this.btnSetMasterPassword.UseVisualStyleBackColor = true;
            this.btnSetMasterPassword.Click += new System.EventHandler(this.btnSetMasterPassword_Click);
            // 
            // lblPasswordInfo3
            // 
            this.lblPasswordInfo3.AutoSize = true;
            this.lblPasswordInfo3.Location = new System.Drawing.Point(10, 73);
            this.lblPasswordInfo3.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblPasswordInfo3.Name = "lblPasswordInfo3";
            this.lblPasswordInfo3.Size = new System.Drawing.Size(349, 39);
            this.lblPasswordInfo3.TabIndex = 8;
            this.lblPasswordInfo3.Text = "If you forget the master password, you will lose access to all of your passwords," +
    " so make sure you set the master password to something you will never forget.";
            // 
            // lblPasswordInfo2
            // 
            this.lblPasswordInfo2.AutoSize = true;
            this.lblPasswordInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordInfo2.Location = new System.Drawing.Point(10, 46);
            this.lblPasswordInfo2.Name = "lblPasswordInfo2";
            this.lblPasswordInfo2.Size = new System.Drawing.Size(268, 13);
            this.lblPasswordInfo2.TabIndex = 7;
            this.lblPasswordInfo2.Text = "BE SURE TO REMEMBER THIS PASSWORD!";
            // 
            // lblPasswordInfo1
            // 
            this.lblPasswordInfo1.AutoSize = true;
            this.lblPasswordInfo1.Location = new System.Drawing.Point(10, 9);
            this.lblPasswordInfo1.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblPasswordInfo1.Name = "lblPasswordInfo1";
            this.lblPasswordInfo1.Size = new System.Drawing.Size(331, 26);
            this.lblPasswordInfo1.TabIndex = 6;
            this.lblPasswordInfo1.Text = "You are about to change the Master Password used to retrieve all of your password" +
    "s in the store.";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblVerifyMasterPassword
            // 
            this.lblVerifyMasterPassword.AutoSize = true;
            this.lblVerifyMasterPassword.Location = new System.Drawing.Point(11, 180);
            this.lblVerifyMasterPassword.Name = "lblVerifyMasterPassword";
            this.lblVerifyMasterPassword.Size = new System.Drawing.Size(120, 13);
            this.lblVerifyMasterPassword.TabIndex = 10;
            this.lblVerifyMasterPassword.Text = "Verify Master Password:";
            // 
            // txtVerifyNewMasterPassword
            // 
            this.txtVerifyNewMasterPassword.Location = new System.Drawing.Point(140, 177);
            this.txtVerifyNewMasterPassword.MaxLength = 30;
            this.txtVerifyNewMasterPassword.Name = "txtVerifyNewMasterPassword";
            this.txtVerifyNewMasterPassword.PasswordChar = '*';
            this.txtVerifyNewMasterPassword.Size = new System.Drawing.Size(217, 20);
            this.txtVerifyNewMasterPassword.TabIndex = 3;
            // 
            // frmModifyMasterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 251);
            this.ControlBox = false;
            this.Controls.Add(this.txtVerifyNewMasterPassword);
            this.Controls.Add(this.lblVerifyMasterPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPasswordInfo3);
            this.Controls.Add(this.lblPasswordInfo2);
            this.Controls.Add(this.lblPasswordInfo1);
            this.Controls.Add(this.btnSetMasterPassword);
            this.Controls.Add(this.txtNewMasterPassword);
            this.Controls.Add(this.txtOldMasterPassword);
            this.Controls.Add(this.lblNewMasterPassword);
            this.Controls.Add(this.lblOldMasterPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmModifyMasterPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Master Password";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldMasterPassword;
        private System.Windows.Forms.Label lblNewMasterPassword;
        private System.Windows.Forms.TextBox txtOldMasterPassword;
        private System.Windows.Forms.TextBox txtNewMasterPassword;
        private System.Windows.Forms.Button btnSetMasterPassword;
        private System.Windows.Forms.Label lblPasswordInfo3;
        private System.Windows.Forms.Label lblPasswordInfo2;
        private System.Windows.Forms.Label lblPasswordInfo1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblVerifyMasterPassword;
        private System.Windows.Forms.TextBox txtVerifyNewMasterPassword;
    }
}