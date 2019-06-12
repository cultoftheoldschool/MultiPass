using MultiPass.Logic;
using System;
using System.Windows.Forms;

namespace MultiPass.UI
{
    public partial class frmCreateMasterPassword : Form
    {
        #region Private Fields
        
        // Captions
        private const string CAP_ERROR = "Error";
        private const string CAP_SUCCESS = "MultiPass";
        private const string CAP_VALIDATION = "Validation Error";
        
        // Messages
        private const string MSG_PASSWORDBLANK = "Password cannot be blank.";
        private const string MSG_CREATESUCCESS = "Master password created.";
        private const string MSG_UNMATCHINGPASSWORDS = "Passwords must match.";

        #endregion

        #region Constructors

        public frmCreateMasterPassword()
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

            // Create new master password
            if (CreateMasterPassword(txtMasterPassword.Text))
            {
                // Master password created, set OK and close form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #endregion

        #region Private Methods

        private bool CreateMasterPassword(string masterPassword)
        {
            try
            {
                // Create new vault, don't load from file
                PasswordVault vault = new PasswordVault(false);

                // Create master password
                vault.CreateMasterPassword(masterPassword);
            }
            catch(Exception ex)
            {
                // Error creating password
                MessageBox.Show(ex.Message, CAP_ERROR);
                return false;
            }
            
            // Success
            MessageBox.Show(MSG_CREATESUCCESS, CAP_SUCCESS);
            return true;
        }

        private bool ValidateForm()
        {
            // Ensure fields are not blank and passwords are the same
            if (txtMasterPassword.Text.Length == 0)
            {
                MessageBox.Show(MSG_PASSWORDBLANK, CAP_VALIDATION);
                return false;
            }
            else if (txtMasterPassword.Text != txtMasterPasswordVerify.Text)
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
