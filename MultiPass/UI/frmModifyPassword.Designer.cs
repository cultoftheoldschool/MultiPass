namespace MultiPass.UI
{
    partial class frmModifyPassword
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
            this.txtVerifyNewPassword = new System.Windows.Forms.TextBox();
            this.lblVerifyPassword = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSetPassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblSelectPassword = new System.Windows.Forms.Label();
            this.cbxPasswordList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtVerifyNewPassword
            // 
            this.txtVerifyNewPassword.Location = new System.Drawing.Point(101, 65);
            this.txtVerifyNewPassword.MaxLength = 30;
            this.txtVerifyNewPassword.Name = "txtVerifyNewPassword";
            this.txtVerifyNewPassword.PasswordChar = '*';
            this.txtVerifyNewPassword.Size = new System.Drawing.Size(236, 20);
            this.txtVerifyNewPassword.TabIndex = 3;
            // 
            // lblVerifyPassword
            // 
            this.lblVerifyPassword.AutoSize = true;
            this.lblVerifyPassword.Location = new System.Drawing.Point(10, 69);
            this.lblVerifyPassword.Name = "lblVerifyPassword";
            this.lblVerifyPassword.Size = new System.Drawing.Size(85, 13);
            this.lblVerifyPassword.TabIndex = 18;
            this.lblVerifyPassword.Text = "Verify Password:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSetPassword
            // 
            this.btnSetPassword.Location = new System.Drawing.Point(31, 102);
            this.btnSetPassword.Name = "btnSetPassword";
            this.btnSetPassword.Size = new System.Drawing.Size(120, 23);
            this.btnSetPassword.TabIndex = 4;
            this.btnSetPassword.Text = "Set Password";
            this.btnSetPassword.UseVisualStyleBackColor = true;
            this.btnSetPassword.Click += new System.EventHandler(this.btnSetPassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(101, 39);
            this.txtNewPassword.MaxLength = 30;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(236, 20);
            this.txtNewPassword.TabIndex = 2;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(10, 42);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblSelectPassword
            // 
            this.lblSelectPassword.AutoSize = true;
            this.lblSelectPassword.Location = new System.Drawing.Point(10, 15);
            this.lblSelectPassword.Name = "lblSelectPassword";
            this.lblSelectPassword.Size = new System.Drawing.Size(89, 13);
            this.lblSelectPassword.TabIndex = 20;
            this.lblSelectPassword.Text = "Select Password:";
            // 
            // cbxPasswordList
            // 
            this.cbxPasswordList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPasswordList.FormattingEnabled = true;
            this.cbxPasswordList.Location = new System.Drawing.Point(101, 12);
            this.cbxPasswordList.Name = "cbxPasswordList";
            this.cbxPasswordList.Size = new System.Drawing.Size(237, 21);
            this.cbxPasswordList.TabIndex = 1;
            // 
            // frmModifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 134);
            this.ControlBox = false;
            this.Controls.Add(this.cbxPasswordList);
            this.Controls.Add(this.lblSelectPassword);
            this.Controls.Add(this.txtVerifyNewPassword);
            this.Controls.Add(this.lblVerifyPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSetPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmModifyPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Password";
            this.Load += new System.EventHandler(this.frmModifyPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVerifyNewPassword;
        private System.Windows.Forms.Label lblVerifyPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSetPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblSelectPassword;
        private System.Windows.Forms.ComboBox cbxPasswordList;
    }
}