using MultiPass.Logic;
using System;
using System.Windows.Forms;

namespace MultiPass.UI
{
    public partial class frmAddPassword : Form
    {
        #region Private Fields

        // Captions
        private const string CAP_AUTHENTICATION = "Authentication Error";
        private const string CAP_ERROR = "Error";
        private const string CAP_SUCCESS = "MultiPass";
        private const string CAP_VALIDATION = "Validation Error";

        // Messages
        private const string MSG_ADDSUCCESS = "Password added.";
        private const string MSG_NAMEBLANK = "Name cannot be blank.";
        private const string MSG_PASSWORDBLANK = "Password cannot be blank.";
        private const string MSG_INVALIDPASSWORD = "Invalid password.";
        private const string MSG_UNMATCHINGPASSWORDS = "Passwords must match.";

        #endregion

        #region Constructors

        public frmAddPassword()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void btnAddPassword_Click(object sender, EventArgs e)
        {
            // Check form and notify user of any issues
            if (!ValidateForm()) return;
            
            // Prompt user for master password
            string masterPassword = GetMasterPassword();

            // Add password to vault
            if(AddPassword(txtName.Text, txtPassword.Text, masterPassword))
            {
                // Password added, set OK and close form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel and close window
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Private Methods

        private bool AddPassword(string name, string password, string masterPassword)
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

                // Add password to vault
                vault.AddPassword(name, password, masterPassword);
            }
            catch(Exception ex)
            {
                // Error loading vault
                MessageBox.Show(ex.Message, CAP_ERROR);
                return false;
            }

            // Success
            MessageBox.Show(MSG_ADDSUCCESS, CAP_SUCCESS);
            return true;
        }

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

        private bool ValidateForm()
        {
            // Ensure fields are not blank and passwords are the same
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show(MSG_NAMEBLANK, CAP_VALIDATION);
                return false;
            }
            else if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show(MSG_PASSWORDBLANK, CAP_VALIDATION);
                return false;
            }
            else if (txtPassword.Text != txtPasswordVerify.Text)
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