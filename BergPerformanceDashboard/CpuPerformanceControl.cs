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
        #region Member Variables..
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
        #region CbStyle_SelectedIndexChanged
        private void CbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ShowLogicalProcessors = cbStyle.SelectedIndex == 1;
            foreach (var chartArea in chartCpu.ChartAreas)
            {
                bool IsLogicalProcessorChart = chartArea.Name.Contains("LogicalProcessorChartArea");
                if (ShowLogicalProcessors)
                {
                    chartArea.Visible = IsLogicalProcessorChart;
                }
                else
                {
                    chartArea.Visible = !IsLogicalProcessorChart;
                }
            }
        }
        #endregion CbStyle_SelectedIndexChanged
        #endregion Events..

        #region GetNewChartArea
        private ChartArea GetNewChartArea(string name)
        {
            ChartArea ChartArea = new ChartArea(name);

            bool ShowLogicalProcessors = cbStyle.SelectedIndex == 1;
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
        #endregion GetNewChartArea

        #region GetNewSeries
        private Series GetNewSeries(string name)
        {
            Series Series = new Series(name);
            Series.ChartType = SeriesChartType.Line;

            return Series;
        }
        #endregion GetNewSeries

        #region InitializeControls
        private void InitializeControls()
        {
            cbStyle.SelectedIndex = 0;
            cbFilterUser.SelectedIndex = 0;

            InitializeGridLayout();
        }
        #endregion InitializeControls

        #region InitializeGridLayout
        private void InitializeGridLayout()
        {
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                // ChartArea
                string ChartAreaName = $"LogicalProcessorChartArea_{i}";
                ChartArea LogicalProcessorChartArea = GetNewChartArea(ChartAreaName);
                LogicalProcessorChartArea.Name = $"LogicalProcessorChartArea_{i}";
                chartCpu.ChartAreas.Add(LogicalProcessorChartArea);

                // Series
                string SeriesName = $"LogicalProcessorSeries_{i}";
                Series LogicalProcessorSeries = GetNewSeries(SeriesName);
                LogicalProcessorSeries.ChartArea = LogicalProcessorChartArea.Name;
                chartCpu.Series.Add(LogicalProcessorSeries);
            }
        }
        #endregion InitializeGridLayout
        #endregion Methods..
    }
}
