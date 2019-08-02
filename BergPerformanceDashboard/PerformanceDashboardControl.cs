using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Threading;

namespace BergPerformanceDashboard
{
    public partial class BergPerformanceDashboardControl : UserControl
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        public CpuPerformanceData CpuData { get; private set; }

        public DiskPerformanceData DiskData { get; private set; }

        public MemoryPerformanceData MemoryData { get; private set; }

        public ProcessPerformanceData ProcessData { get; private set; }

        public SystemPerformanceData SystemData { get; private set; }
        #endregion Properties..

        #region Delegates/Events
        public delegate void OnPerformanceDataUpdated();
        #endregion Delegates/Events

        #region Constructors..
        #region BergPerformanceDashboardControl
        public BergPerformanceDashboardControl()
        {
            InitializeComponent();

            InitializeControls();

            // Prevent the control from running in VS Designer
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                InitializeData();
            }
        }
        #endregion BergPerformanceDashboardControl
        #endregion Constructors..

        #region Methods..
        #region InitializeControls
        private void InitializeControls()
        {
            // chartLogicalProcessingUnits
            chartLogicalProcessingUnits.Series[0].Name = "Processor Time";

            chartLogicalProcessingUnits.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chartLogicalProcessingUnits.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartLogicalProcessingUnits.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartLogicalProcessingUnits.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chartLogicalProcessingUnits.ChartAreas[0].AxisY.Minimum = 0;
            chartLogicalProcessingUnits.ChartAreas[0].AxisY.Maximum = 100;
        }
        #endregion InitializeControls 

        #region InitializeData
        private void InitializeData()
        {
            CpuData = new CpuPerformanceData(1000);
            DiskData = new DiskPerformanceData(5000);
            MemoryData = new MemoryPerformanceData(5000);
            ProcessData = new ProcessPerformanceData(5000);
            SystemData = new SystemPerformanceData(5000);

            CpuData.PerformanceDataUpdated += OnCpuDataUpdated;
        }
        #endregion InitializeData

        public void OnCpuDataUpdated(object sender, EventArgs e)
        {
            Invoke(new OnPerformanceDataUpdated(() =>
            {
                lblCores.Text = CpuData.CoreCount;
                lblLogicalProcessors.Text = CpuData.LogicalProcessorsCount;
                lblTotalCPU.Text = CpuData.TotalCPU;
                lblTotalCpuUser.Text = CpuData.TotalUserCPU;

                chartLogicalProcessingUnits.Series[0].Points.Clear();
                for (int i = 0; i < CpuData.LogicalCores.Count; i++)
                {
                    chartLogicalProcessingUnits.Series[0].Points.AddXY(i, (Convert.ToDouble(CpuData.LogicalCores[i].PercentUserTime)));
                }
            }), null);
        }    
        #endregion Methods..
    }
}
