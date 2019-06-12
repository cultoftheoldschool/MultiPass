using MultiPass.Logic;
using System;
using System.Windows.Forms;

namespace MultiPass.UI
{
    public partial class frmModifyPassword : Form
    {
        #region Private Fields

        // Captions
        private const string CAP_AUTHENTICATION = "Authentication Error";
        private const string CAP_ERROR = "Error";
        private const string CAP_SUCCESS = "MultiPass";
        private const string CAP_VALIDATION = "Validation Error";

        // Messages
        private const string MSG_PASSWORDBLANK = "Password cannot be blank.";
        private const string MSG_INVALIDPASSWORD = "Invalid password.";
        private const string MSG_MODIFYSUCCESS = "Password modified.";
        private const string MSG_SELECTPASSWORD = "Please select a password.";
        private const string MSG_UNMATCHINGPASSWORDS = "Passwords must match.";

        #endregion

        #region Constructors

        public frmModifyPassword()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel and close window
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            // Check form and notify user of any issues
            if (!ValidateForm()) return;

            // Prompt user for master password
            string masterPassword = GetMasterPassword();

            // Modify password from vault
            if (ModifyPassword(cbxPasswordList.Text, txtNewPassword.Text, masterPassword))
            {
                // Password added, set OK and close form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmModifyPassword_Load(object sender, EventArgs e)
        {
            // Populate dropdown list with password names from vault
            PopulatePasswordList();
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

        private bool ModifyPassword(string name, string password, string masterPassword)
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

                // Modify password
                vault.ModifyPassword(name, password, masterPassword);
            }
            catch(Exception ex)
            {
                // Error loading vault
                MessageBox.Show(ex.Message, CAP_ERROR);
                return false;
            }

            // Success
            MessageBox.Show(MSG_MODIFYSUCCESS, CAP_SUCCESS);
            return true;
        }

        private void PopulatePasswordList()
        {
            // Initialize password list
            cbxPasswordList.Items.Clear();

            try
            {
                // Load vault
                PasswordVault vault = new PasswordVault();

                // Get all password names from vault and add to dropdown list
                foreach (var name in vault.GetPasswordNames())
                {
                    cbxPasswordList.Items.Add(name);
                }
            }
            catch(Exception ex)
            {
                // Error loading vault
                MessageBox.Show(ex.Message, CAP_ERROR);
            }
        }

        private bool ValidateForm()
        {
            // Ensure password is selected, fields are not blank, and passwords are the same
            if (cbxPasswordList.Text == "")
            {
                MessageBox.Show(MSG_SELECTPASSWORD, CAP_VALIDATION);
                return false;
            }
            else if (txtNewPassword.Text.Length == 0)
            {
                MessageBox.Show(MSG_PASSWORDBLANK, CAP_VALIDATION);
                return false;
            }
            else if (txtNewPassword.Text != txtVerifyNewPassword.Text)
            {
                MessageBox.Show(MSG_UNMATCHINGPASSWORDS, CAP_VALIDATION);
                return false;
            }

            // Form is validated
            return true;
        }

        #endregion
    }
}
