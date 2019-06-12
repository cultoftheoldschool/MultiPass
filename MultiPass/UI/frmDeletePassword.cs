using MultiPass.Logic;
using System;
using System.Windows.Forms;

namespace MultiPass.UI
{
    public partial class frmDeletePassword : Form
    {
        #region Private Fields

        // Captions
        private const string CAP_AUTHENTICATION = "Authentication Error";
        private const string CAP_ERROR = "Error";
        private const string CAP_SUCCESS = "MultiPass";
        private const string CAP_VALIDATION = "Validation Error";
        private const string CAP_VERIFY = "Delete Password";

        // Messages
        private const string MSG_INVALIDPASSWORD = "Invalid password.";
        private const string MSG_DELETESUCCESS = "Password deleted.";
        private const string MSG_SELECTPASSWORD = "Please select a password.";
        private const string MSG_VERIFYDELETE = "This will permanently delete the selected password.  Are you sure?";

        #endregion

        #region Constructors

        public frmDeletePassword()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check form and notify user of any issues
            if (!ValidateForm()) return;

            // Prompt user for master password
            string masterPassword = GetMasterPassword();

            // Delete password from vault
            if (DeletePassword(cbxPasswordList.Text, masterPassword))
            {
                // Password deleted, set OK and close form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmDeletePassword_Load(object sender, EventArgs e)
        {
            // Populate dropdown list with password names from vault
            PopulatePasswordList();
        }

        #endregion

        #region Private Methods

        private bool DeletePassword(string name, string masterPassword)
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

                // Delete password from vault
                vault.DeletePassword(name);
            }
            catch(Exception ex)
            {
                // Error loading vault
                MessageBox.Show(ex.Message, CAP_ERROR);
                return false;
            }
            
            // Success
            MessageBox.Show(MSG_DELETESUCCESS, CAP_SUCCESS);
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
            // Ensure password is selected
            if (cbxPasswordList.Text == "")
            {
                MessageBox.Show(MSG_SELECTPASSWORD, CAP_VALIDATION);
                return false;
            }

            // Verify user intent to permanently delete password
            DialogResult result = MessageBox.Show(MSG_VERIFYDELETE, CAP_VERIFY, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            // Return user choice
            return (result == DialogResult.Yes);
        }

        #endregion
    }
}
