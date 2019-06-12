namespace MultiPass.UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreateMasterPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifyMasterPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miPasswords = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeletePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxPasswordList = new System.Windows.Forms.ComboBox();
            this.btnClearClipboard = new System.Windows.Forms.Button();
            this.lblSelectPassword = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miPasswords});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(354, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreateMasterPassword,
            this.miModifyMasterPassword,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miCreateMasterPassword
            // 
            this.miCreateMasterPassword.Name = "miCreateMasterPassword";
            this.miCreateMasterPassword.Size = new System.Drawing.Size(204, 22);
            this.miCreateMasterPassword.Text = "Create Master Password";
            this.miCreateMasterPassword.Click += new System.EventHandler(this.miCreateMasterPassword_Click);
            // 
            // miModifyMasterPassword
            // 
            this.miModifyMasterPassword.Name = "miModifyMasterPassword";
            this.miModifyMasterPassword.Size = new System.Drawing.Size(204, 22);
            this.miModifyMasterPassword.Text = "Modify Master Password";
            this.miModifyMasterPassword.Click += new System.EventHandler(this.miModifyMasterPassword_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(204, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miPasswords
            // 
            this.miPasswords.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddPassword,
            this.miModifyPassword,
            this.miDeletePassword});
            this.miPasswords.Name = "miPasswords";
            this.miPasswords.Size = new System.Drawing.Size(74, 20);
            this.miPasswords.Text = "Passwords";
            // 
            // miAddPassword
            // 
            this.miAddPassword.Name = "miAddPassword";
            this.miAddPassword.Size = new System.Drawing.Size(165, 22);
            this.miAddPassword.Text = "Add Password";
            this.miAddPassword.Click += new System.EventHandler(this.miAddPassword_Click);
            // 
            // miModifyPassword
            // 
            this.miModifyPassword.Name = "miModifyPassword";
            this.miModifyPassword.Size = new System.Drawing.Size(165, 22);
            this.miModifyPassword.Text = "Modify Password";
            this.miModifyPassword.Click += new System.EventHandler(this.miModifyPassword_Click);
            // 
            // miDeletePassword
            // 
            this.miDeletePassword.Name = "miDeletePassword";
            this.miDeletePassword.Size = new System.Drawing.Size(165, 22);
            this.miDeletePassword.Text = "Delete Password";
            this.miDeletePassword.Click += new System.EventHandler(this.miDeletePassword_Click);
            // 
            // cbxPasswordList
            // 
            this.cbxPasswordList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPasswordList.FormattingEnabled = true;
            this.cbxPasswordList.Location = new System.Drawing.Point(106, 27);
            this.cbxPasswordList.MaxDropDownItems = 20;
            this.cbxPasswordList.Name = "cbxPasswordList";
            this.cbxPasswordList.Size = new System.Drawing.Size(237, 21);
            this.cbxPasswordList.Sorted = true;
            this.cbxPasswordList.TabIndex = 1;
            this.cbxPasswordList.Tag = "";
            this.cbxPasswordList.SelectedValueChanged += new System.EventHandler(this.cbxPasswords_SelectedValueChanged);
            // 
            // btnClearClipboard
            // 
            this.btnClearClipboard.Location = new System.Drawing.Point(13, 66);
            this.btnClearClipboard.Name = "btnClearClipboard";
            this.btnClearClipboard.Size = new System.Drawing.Size(329, 23);
            this.btnClearClipboard.TabIndex = 2;
            this.btnClearClipboard.Text = "Clear Clipboard";
            this.btnClearClipboard.UseVisualStyleBackColor = true;
            this.btnClearClipboard.Click += new System.EventHandler(this.btnClearClipboard_Click);
            // 
            // lblSelectPassword
            // 
            this.lblSelectPassword.AutoSize = true;
            this.lblSelectPassword.Location = new System.Drawing.Point(11, 30);
            this.lblSelectPassword.Name = "lblSelectPassword";
            this.lblSelectPassword.Size = new System.Drawing.Size(89, 13);
            this.lblSelectPassword.TabIndex = 5;
            this.lblSelectPassword.Text = "Select Password:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 93);
            this.Controls.Add(this.lblSelectPassword);
            this.Controls.Add(this.btnClearClipboard);
            this.Controls.Add(this.cbxPasswordList);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiPass";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miCreateMasterPassword;
        private System.Windows.Forms.ToolStripMenuItem miModifyMasterPassword;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miPasswords;
        private System.Windows.Forms.ToolStripMenuItem miAddPassword;
        private System.Windows.Forms.ToolStripMenuItem miModifyPassword;
        private System.Windows.Forms.ToolStripMenuItem miDeletePassword;
        private System.Windows.Forms.ComboBox cbxPasswordList;
        private System.Windows.Forms.Button btnClearClipboard;
        private System.Windows.Forms.Label lblSelectPassword;
    }
}

