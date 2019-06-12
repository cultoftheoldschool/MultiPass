using System;
using System.Windows.Forms;

namespace MultiPass.UI.Notifications
{
    public partial class frmNotifyClear : Form
    {
        #region Private Fields

        private const double _opacityReduction = 0.05;
        private Timer _timer;

        #endregion

        #region Constructors

        public frmNotifyClear()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void frmNotifyClear_Load(object sender, EventArgs e)
        {
            // Set initial opacity
            this.Opacity = 100;

            // Initialize timer
            _timer = new Timer();

            // Add fadeout event handler
            _timer.Tick += new EventHandler(FadeOut);

            // Start timer
            _timer.Start();
        }

        #endregion

        #region Private Methods

        private void FadeOut(object sender, EventArgs e)
        {
            // Check if fadeout is complete
            if (this.Opacity == 0)
            {
                // Stop fadeout and close window
                _timer.Stop();
                this.Close();
                this.Dispose();
            }
            else
            {
                // Continue fading out
                this.Opacity -= _opacityReduction;
            }
        }

        #endregion
    }
}