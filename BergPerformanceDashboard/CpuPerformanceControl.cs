using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BergPerformanceDashboard
{
    public partial class CpuPerformanceControl : UserControl
    {
        #region Enums..
        private enum CpuViewMode
        {
            OverallUtilization,
            LogicalProcessors
        }
        #endregion Enums..

        #region Member Variables..
        private CpuViewMode _CpuViewMode = CpuViewMode.OverallUtilization;
        #endregion Member Variables..

        #region Properties..
        #region ChartAreas
        public ChartAreaCollection ChartAreas
        {
            get { return chartCpu.ChartAreas; }
        }
        #endregion ChartAreas

        #region Cores
        public string Cores
        {
            get { return lblCores.Text; }
            set { lblCores.Text = value; }
        }
        #endregion Cores

        #region LogicalProcessors
        public string LogicalProcessors
        {
            get { return lblLogicalProcessors.Text; }
            set { lblLogicalProcessors.Text = value; }
        }
        #endregion LogicalProcessors

        #region Series
        public SeriesCollection Series
        {
            get { return chartCpu.Series; }
        }
        #endregion Series

        #region TotalCpu
        public string TotalCpu
        {
            get { return lblTotalCpu.Text; }
            set { lblTotalCpu.Text = value; }
        }
        #endregion TotalCpu

        #region TotalCpuUser
        public string TotalCpuUser
        {
            get { return lblTotalCpuUser.Text; }
            set { lblTotalCpuUser.Text = value; }
        }
        #endregion TotalCpuUser

        #region Threads
        public string Threads
        {
            get { return lblThreads.Text; }
            set { lblThreads.Text = value; }
        }
        #endregion Threads

        #endregion Properties..

        #region Constructors..
        public CpuPerformanceControl()
        {
            InitializeComponent();
            InitializeControls();
        }
        #endregion Constructors..

        #region Methods..
        #region Events..
        #region tsCpuViewMode_DropDownItemClicked
        private void tsCpuViewMode_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in tsCpuViewMode.DropDownItems)
            {
                item.Checked = item.Name == e.ClickedItem.Name;
            }

            foreach (var chartArea in chartCpu.ChartAreas)
            {
                chartArea.Visible = (CpuViewMode)e.ClickedItem.Tag == (CpuViewMode)chartArea.Tag;
            }
        }
        #endregion tsCpuViewMode_DropDownItemClicked
        #endregion Events..

        #region AddLogicalProcessorChartArea
        private ChartArea AddLogicalProcessorChartArea(string name)
        {
            ChartArea ChartArea = new ChartArea(name);
            ChartArea.Tag = CpuViewMode.LogicalProcessors;

            bool ShowLogicalProcessors = _CpuViewMode == CpuViewMode.LogicalProcessors;
            ChartArea.Visible = ShowLogicalProcessors;

            ChartArea.AxisX2.Enabled = AxisEnabled.True;
            ChartArea.AxisX2.MajorGrid.Enabled = false;
            ChartArea.AxisX2.MinorGrid.Enabled = false;
            ChartArea.AxisX2.MajorTickMark.Enabled = false;
            ChartArea.AxisX2.MinorTickMark.Enabled = false;
            ChartArea.AxisX2.LabelStyle.Enabled = false;

            ChartArea.AxisY2.Enabled = AxisEnabled.True;
            ChartArea.AxisY2.MajorGrid.Enabled = false;
            ChartArea.AxisY2.MinorGrid.Enabled = false;
            ChartArea.AxisY2.MajorTickMark.Enabled = false;
            ChartArea.AxisY2.MinorTickMark.Enabled = false;
            ChartArea.AxisY2.LabelStyle.Enabled = false;

            ChartArea.AxisY.MajorGrid.Enabled = false;
            ChartArea.AxisY.MajorTickMark.Enabled = false;
            ChartArea.AxisY.LabelStyle.Enabled = false;
            //ChartArea.AxisY.Title = "%";

            ChartArea.AxisX.MajorGrid.Enabled = false;
            ChartArea.AxisX.MajorTickMark.Enabled = false;
            ChartArea.AxisX.LabelStyle.Enabled = false;

            return ChartArea;
        }
        #endregion AddLogicalProcessorChartArea

        #region AddLogicalProcessorSeries
        private Series AddLogicalProcessorSeries(string name)
        {
            Series Series = new Series(name);
            Series.ChartType = SeriesChartType.Line;

            return Series;
        }
        #endregion AddLogicalProcessorSeries

        #region InitializeControls
        private void InitializeControls()
        {
            cbFilterUser.SelectedIndex = 0;

            InitializeGridLayout();
        }
        #endregion InitializeControls

        #region InitializeGridLayout
        private void InitializeGridLayout()
        {
            chartCpu.ChartAreas["OverallCpu"].Tag = CpuViewMode.OverallUtilization;

            ToolStripMenuItem CpuViewModeMenuItem = chartCpu.ContextMenuStrip.Items["tsCpuViewMode"] as ToolStripMenuItem;
            CpuViewModeMenuItem.DropDownItems ["tsOverallUtilization"].Tag = CpuViewMode.OverallUtilization;
            CpuViewModeMenuItem.DropDownItems["tsLogicalProcessors"].Tag = CpuViewMode.LogicalProcessors;

            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                // ChartArea
                string ChartAreaName = $"LogicalProcessorChartArea_{i}";
                ChartArea LogicalProcessorChartArea = AddLogicalProcessorChartArea(ChartAreaName);
                LogicalProcessorChartArea.Name = $"LogicalProcessorChartArea_{i}";
                chartCpu.ChartAreas.Add(LogicalProcessorChartArea);

                // Series
                string SeriesName = $"LogicalProcessorSeries_{i}";
                Series LogicalProcessorSeries = AddLogicalProcessorSeries(SeriesName);
                LogicalProcessorSeries.ChartArea = LogicalProcessorChartArea.Name;
                chartCpu.Series.Add(LogicalProcessorSeries);
            }
        }
        #endregion InitializeGridLayout

        #endregion Methods..
    }
}
