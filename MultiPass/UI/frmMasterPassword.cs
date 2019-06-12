using System;
using System.Windows.Forms;

namespace MultiPass.UI
{
    public partial class frmMasterPassword : Form
    {
        #region Private Fields

        // Captions
        private const string CAP_VALIDATION = "Validation Error";

        // Messages
        private const string MSG_PASSWORDBLANK = "Password cannot be blank.";

        #endregion

        #region Public Properties

        public string Password { get; private set; }

        #endregion

        #region Constructors

        public frmMasterPassword()
        {
            InitializeComponent();

            // Initialize password
            this.Password = null;
        }

        #endregion

        #region Event Handlers

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel and close window
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check form and notify user of any issues
            if (!ValidateForm()) return;

            // Store password
            this.Password = txtMasterPassword.Text;

            // Master password entered, set OK and close form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtMasterPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if user pressed return
            if(e.KeyChar==(char)13)
            {
                // Return pressed, click submit
                btnSubmit_Click(this, new EventArgs());
            }
        }

        #endregion

        #region Private Methods

        private bool ValidateForm()
        {
            // Ensure master password is not blank
            if (txtMasterPassword.Text.Length == 0)
            {
                MessageBox.Show(MSG_PASSWORDBLANK, CAP_VALIDATION);
                return false;
            }

            // Form is valid
            return true;
        }

        #endregion
    }
}
