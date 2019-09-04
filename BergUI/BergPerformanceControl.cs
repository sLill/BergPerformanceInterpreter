using System.Windows.Forms;

namespace BergUI
{
    public partial class BergPerformanceControl : UserControl
    {
        #region Member Variables..
        private LoadingSplash _LoadingSplash;
        #endregion Member Variables..

        #region Constructors..
        public BergPerformanceControl()
        {
            InitializeComponent();
        }
        #endregion Constructors..

        #region Methods..
        #region ShowLoadingSplash
        public void ShowLoadingSplash(Control containingControl, bool show)
        {
            if (show)
            {
                _LoadingSplash = new LoadingSplash() { Dock = DockStyle.Fill };
                containingControl.Controls.Add(_LoadingSplash);
                _LoadingSplash.BringToFront();
            }
            else
            {
                if (containingControl.Controls.Contains(_LoadingSplash))
                {
                    containingControl.Controls.Remove(_LoadingSplash);
                }
            }
        }
        #endregion ShowLoadingSplash
        #endregion Methods..
    }
}
