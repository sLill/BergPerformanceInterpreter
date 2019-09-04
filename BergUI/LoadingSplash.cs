using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Drawing2D;

namespace BergUI
{
    public partial class LoadingSplash : UserControl
    {
        #region Constructors..
        public LoadingSplash()
        {
            InitializeComponent();
        }
        #endregion Constructors..

        #region Methods..
        private void LoadingSplash_Resize(object sender, EventArgs e)
        {
            // Re-center controls
            progressIndicator.Left = (this.ClientSize.Width - progressIndicator.Width) / 2;
            progressIndicator.Top = (this.ClientSize.Height - progressIndicator.Height) / 2;

            lblStatus.Left = (this.ClientSize.Width - lblStatus.Width) / 2;
            lblStatus.Top = (this.ClientSize.Height - lblStatus.Height) / 2;
        }
        #endregion Methods..
    }
}
