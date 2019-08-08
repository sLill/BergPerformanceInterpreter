using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BergPerformanceServices;

namespace BergUI
{
    public partial class BergPerformanceControl : UserControl
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        #region BergPerformanceData
        public BergPerformanceData PerformanceData { get; set; }
        #endregion BergPerformanceData
        #endregion Properties..

        #region Delegates/Events
        public delegate void OnPerformanceDataUpdated();
        #endregion Delegates/Events

        #region Constructors..
        #region BergPerformanceControl
        public BergPerformanceControl()
        {
            InitializeComponent();
            InitializeControls();

            // Prevent the control from running in VS Designer
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                InitializeData();
            }
        }
        #endregion BergPerformanceControl
        #endregion Constructors..

        #region Methods..
        #region InitializeControls
        protected virtual void InitializeControls()
        {

        }
        #endregion InitializeControls

        #region InitializeData
        protected virtual void InitializeData()
        {
            PerformanceData.PerformanceDataUpdated += OnDataUpdated;
        }
        #endregion InitializeData

        #region OnDataUpdated
        public virtual void OnDataUpdated(object sender, EventArgs e)
        {

        }
        #endregion OnDataUpdated
        #endregion Methods..
    }
}
