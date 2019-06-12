using MultiPass.Logic;
using System;
using System.Windows.Forms;

namespace MultiPass.UI
{
    public partial class frmModifyMasterPassword : Form
    {
        #region Private Fields

        // Captions
        private const string CAP_AUTHENTICATION = "Authentication Error";
        private const string CAP_ERROR = "Error";
        private const string CAP_SUCCESS = "MultiPass";
        private const string CAP_VALIDATION = "Validation Error";

        // Messages
        private const string MSG_INVALIDPASSWORD = "Invalid password.";
        private const string MSG_MODIFYSUCCESS = "Master password modified.";
        private const string MSG_NEWPASSWORDBLANK = "New password cannot be blank.";
        private const string MSG_OLDPASSWORDBLANK = "Old password cannot be blank.";
        private const string MSG_UNMATCHINGPASSWORDS = "Passwords must match.";

        #endregion

        #region Constructors

        public frmModifyMasterPassword()
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

        private void btnSetMasterPassword_Click(object sender, EventArgs e)
        {
            // Check form and notify user of any issues
            if (!ValidateForm()) return;

            // Modify master passwrod
            if (ModifyMasterPassword(txtOldMasterPassword.Text, txtNewMasterPassword.Text))
            {
                // Master password modified, set OK and close form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #endregion

        #region Private Methods

        private bool ModifyMasterPassword(string oldMasterPassword, string newMasterPassword)
        {
            try
            {
                // Load vault
                PasswordVault vault = new PasswordVault();

                // Authenticate master password
                if (!vault.VerifyMasterPassword(oldMasterPassword))
                {
                    // Invalid master password
                    MessageBox.Show(MSG_INVALIDPASSWORD, CAP_AUTHENTICATION);
                    return false;
                }

                // Modify master password
                vault.ModifyMasterPassword(oldMasterPassword, newMasterPassword);
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

        private bool ValidateForm()
        {
            // Ensure fields are not blank and passwords are the same
            if (txtOldMasterPassword.Text.Length == 0)
            {
                MessageBox.Show(MSG_OLDPASSWORDBLANK, CAP_VALIDATION);
                return false;
            }
            else if (txtNewMasterPassword.Text.Length == 0)
            {
                MessageBox.Show(MSG_NEWPASSWORDBLANK, CAP_VALIDATION);
                return false;
            }
            else if (txtNewMasterPassword.Text != txtVerifyNewMasterPassword.Text)
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
