using MultiPass.Logic;
using MultiPass.UI.Notifications;
using System;
using System.IO;
using System.Windows.Forms;

namespace MultiPass.UI
{
    public partial class frmMain : Form
    {
        #region Private Fields

        // Captions
        private const string CAP_AUTHENTICATION = "Authentication Error";
        private const string CAP_ERROR = "Error";
        private const string CAP_VALIDATION = "Validation Error";

        // Messages
        private const string MSG_INVALIDPASSWORD = "Invalid password.";
        private const string MSG_SELECTPASSWORD = "Please select a password.";

        #endregion

        #region Constructors

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void btnClearClipboard_Click(object sender, EventArgs e)
        {
            // Clear clipboard
            Clipboard.Clear();

            // Show clipboard cleared notification
            frmNotifyClear clearNotification = new frmNotifyClear();
            clearNotification.Show();
        }

        private void cbxPasswords_SelectedValueChanged(object sender, EventArgs e)
        {
            // Check form and notify user of any issues
            if (!ValidateForm()) return;

            // Prompt user for master password
            string masterPassword = GetMasterPassword();

            // Get password from vault and copy to clipboard
            if (GetPassword(cbxPasswordList.Text, masterPassword))
            {
                // Show password copied notification
                frmNotifyCopy copyNotification = new frmNotifyCopy();
                copyNotification.Show();

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Populate dropdown list with password names from vault
            PopulatePasswordList();
        }

        private void miAddPassword_Click(object sender, EventArgs e)
        {
            // Show add password form
            using (frmAddPassword addPassword = new frmAddPassword())
            {
                DialogResult result = addPassword.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Re-populate password list from vault
                    PopulatePasswordList();
                }
            }
        }

        private void miCreateMasterPassword_Click(object sender, EventArgs e)
        {
            // Show create master password form
            using (frmCreateMasterPassword createMasterPassword = new frmCreateMasterPassword())
            {
                DialogResult result = createMasterPassword.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Re-populate password list from vault
                    PopulatePasswordList();
                }
            }
        }

        private void miDeletePassword_Click(object sender, EventArgs e)
        {
            // Show delete password form
            using (frmDeletePassword deletePassword = new frmDeletePassword())
            {
                DialogResult result = deletePassword.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Re-populate password list from vault
                    PopulatePasswordList();
                }
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            // Exit
            Application.Exit();
        }

        private void miModifyMasterPassword_Click(object sender, EventArgs e)
        {
            // Show modify master password form
            using (frmModifyMasterPassword modifyMasterPassword = new frmModifyMasterPassword())
            {
                DialogResult result = modifyMasterPassword.ShowDialog();
                if(result == DialogResult.OK)
                {
                    // Re-populate password list from vault
                    PopulatePasswordList();
                }
            }
        }

        private void miModifyPassword_Click(object sender, EventArgs e)
        {
            // Show modify password form
            using (frmModifyPassword modifyPassword = new frmModifyPassword())
            {
                DialogResult result = modifyPassword.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Re-populate password list from vault
                    PopulatePasswordList();
                }
            }
        }

        #endregion

        #region Private Methods

        private string GetMasterPassword()
        {
            // Initialize master password
            string masterPassword = null;

            // Show master password entry form
            using (frmMasterPassword masterPasswordForm = new frmMasterPassword())
            {
                masterPasswordForm.ShowDialog();

                // If result is OK, user entered a master password, otherwise they cancelled
                if (masterPasswordForm.DialogResult == DialogResult.OK)
                {
                    // Get master password from form
                    masterPassword = masterPasswordForm.Password;
                }
            }

            // Return master password
            return masterPassword;
        }

        private bool GetPassword(string name, string masterPassword)
        {
            // Verify master password
            if (masterPassword == null) return false;

            try
            {
                // Load vault
                PasswordVault vault = new PasswordVault();

                // Authenticate master password
                if (!vault.VerifyMasterPassword(masterPassword))
                {
                    // Invalid master password
                    MessageBox.Show(MSG_INVALIDPASSWORD, CAP_AUTHENTICATION);
                    return false;
                }

                // Get password from vault
                string password = vault.GetPassword(name, masterPassword);

                // Copy password to clipboard
                Clipboard.SetText(password);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, CAP_ERROR);
                return false;
            }

            // Success
            return true;
        }

        private void PopulatePasswordList()
        {
            // Disable all relevant menu items
            miCreateMasterPassword.Enabled = false;
            miModifyMasterPassword.Enabled = false;
            miPasswords.Enabled = false;
            miAddPassword.Enabled = false;
            miModifyPassword.Enabled = false;
            miDeletePassword.Enabled = false;

            // Initialize password list
            cbxPasswordList.Items.Clear();

            try
            {
                // Load vault
                PasswordVault vault = new PasswordVault();

                // Allow master password modification and password creation
                miModifyMasterPassword.Enabled = true;
                miPasswords.Enabled = true;
                miAddPassword.Enabled = true;

                // Get all password names from vault and add to dropdown list
                foreach (var name in vault.GetPasswordNames())
                {
                    cbxPasswordList.Items.Add(name);
                }

                // Check if dropdown list contains passwords
                if (cbxPasswordList.Items.Count > 0)
                {
                    // Dropdown list contains passwords, allow password modification and deletion
                    miModifyPassword.Enabled = true;
                    miDeletePassword.Enabled = true;
                }
            }
            catch(Exception ex) when (ex.InnerException is FileNotFoundException)
            {
                // Enable initial master password creation
                miCreateMasterPassword.Enabled = true;
            }
            catch(Exception ex)
            {
                // Error loading vault
                MessageBox.Show(ex.Message, CAP_ERROR);
            }
        }

        private bool ValidateForm()
        {
            // Ensure password is selected
            if (cbxPasswordList.Text == "")
            {
                MessageBox.Show(MSG_SELECTPASSWORD, CAP_VALIDATION);
                return false;
            }

            // Form is valid
            return true;
        }

        #endregion
    }
}
