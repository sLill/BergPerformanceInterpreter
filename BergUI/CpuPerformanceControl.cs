using BergCommon;
using BergPerformanceServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BergUI
{
    public partial class CpuPerformanceControl : UserControl, IBergPerformanceControl
    {
        #region Member Variables..
        BergCpuMonitor _BergCpuMonitor { get; set; }
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
        [Browsable(false)]
        public string Cores
        {
            get { return lblCores.Text; }
            set { lblCores.Text = value; }
        }
        #endregion Cores

        #region GridState
        [Browsable(false)]
        public GridState GridState { get; private set; }
        #endregion GridState

        #region LogicalProcessors
        [Browsable(false)]
        public string LogicalProcessors
        {
            get { return lblLogicalProcessors.Text; }
            set { lblLogicalProcessors.Text = value; }
        }
        #endregion LogicalProcessors

        #region ParentProcess
        [Browsable(false)]
        public string ParentProcess
        {
            get { return ttlParentProcessName.Text; }
            set { ttlParentProcessName.Text = value; }
        }
        #endregion ParentProcess

        #region Series
        public SeriesCollection Series
        {
            get { return chartCpu.Series; }
        }
        #endregion Series

        #region TotalCpu
        [Browsable(false)]
        public string TotalCpu
        {
            get { return lblTotalCpu.Text; }
            set { lblTotalCpu.Text = value; }
        }
        #endregion TotalCpu

        #region TotalCpuUser
        [Browsable(false)]
        public string TotalCpuUser
        {
            get { return lblTotalCpuUser.Text; }
            set { lblTotalCpuUser.Text = value; }
        }
        #endregion TotalCpuUser

        #region Threads
        [Browsable(false)]
        public string Threads
        {
            get { return lblThreads.Text; }
            set { lblThreads.Text = value; }
        }
        #endregion Threads

        #region UseLocalDataSource
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description(@"""True"" uses the current system this control is running on as the datasource. ""False"" uses a remote application or executable running the BergDataServices dll as the datasource"), Category("DataSource")]
        public bool UseLocalDataSource { get; set; }
        #endregion UseLocalDataSource

        #region UpdateInterval
        [DefaultValue(1000)]
        [Description(@"Frequency at which performance data is refreshed. Default - 1000ms"), Category("DataSource")]
        public int UpdateInterval { get; set; }
        #endregion UpdateInterval
        #endregion Properties..

        #region Delegates/Events
        public delegate void OnDataUpdated();
        #endregion Delegates/Events

        #region Enums..
        private enum CpuViewMode
        {
            OverallUtilization,
            LogicalProcessors
        }
        #endregion Enums..

        #region Constructors..
        #region CpuPerformanceControl
        public CpuPerformanceControl()
             : base()
        {
            InitializeComponent();
            InitializeControls();

            // Prevent the control from running in VS Designer
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                UpdateInterval = 1000;
                UseLocalDataSource = false;

                _BergCpuMonitor = new BergCpuMonitor(UpdateInterval, true, UseLocalDataSource);
                _BergCpuMonitor.DataUpdated += OnPerformanceDataUpdated;
            }
        }
        #endregion CpuPerformanceControl
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

            _CpuViewMode = (CpuViewMode)e.ClickedItem.Tag;
            UpdateChartViewMode();
        }
        #endregion tsCpuViewMode_DropDownItemClicked
        #endregion Events..

        #region AddChartArea_LogicalProcessor
        private ChartArea AddChartArea_LogicalProcessor(string name)
        {
            ChartArea ChartArea = new ChartArea(name);
            ChartArea.Tag = CpuViewMode.LogicalProcessors;

            bool ShowLogicalProcessors = _CpuViewMode == CpuViewMode.LogicalProcessors;
            ChartArea.Visible = ShowLogicalProcessors && _BergCpuMonitor?.PerformanceData != null;

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
        #endregion AddChartArea_LogicalProcessor

        #region AddChartArea_OverallCpu
        private ChartArea AddChartArea_OverallCpu(string name)
        {
            ChartArea ChartArea = new ChartArea(name);
            ChartArea.Tag = CpuViewMode.OverallUtilization;

            bool ShowLogicalProcessors = _CpuViewMode == CpuViewMode.OverallUtilization;
            ChartArea.Visible = ShowLogicalProcessors && _BergCpuMonitor?.PerformanceData != null;

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
            ChartArea.AxisY.Title = "%";

            ChartArea.AxisX.MajorGrid.Enabled = false;
            ChartArea.AxisX.MajorTickMark.Enabled = false;
            ChartArea.AxisX.LabelStyle.Enabled = false;

            return ChartArea;
        }
        #endregion AddChartArea_OverallCpu

        #region AddSeries_LogicalProcessor
        private Series AddSeries_LogicalProcessor(string name, Color color)
        {
            Series Series = new Series(name);
            Series.ChartType = SeriesChartType.Line;
            Series.Color = color;

            return Series;
        }
        #endregion AddSeries_LogicalProcessor

        #region AddSeries_OverallCpu
        private Series AddSeries_OverallCpu(string name, Color color, params double[] yPoints)
        {
            Series Series = new Series(name);
            Series.ChartType = SeriesChartType.Line;
            Series.Color = color;
            Series.BorderWidth = 2;

            return Series;
        }
        #endregion AddSeries_OverallCpu

        #region CheckState
        private void CheckState(DataState dataState)
        {
            if (dataState == DataState.BEGIN)
            {
                UpdateChartViewMode();
            }
            else if (dataState == DataState.ALIVE)
            {
                if (GridState == GridState.WAITING)
                {
                    UpdateChartViewMode();
                    GridState = GridState.ALIVE;
                }
            }
        }
        #endregion CheckState

        #region InitializeControls
        public void InitializeControls()
        {
            InitializeGridLayout();
        }
        #endregion InitializeControls

        #region InitializeGridLayout
        private void InitializeGridLayout()
        {
            Color GridColor = ColorLibrary.GetNextColor();
            GridState = GridState.WAITING;

            ToolStripMenuItem CpuViewModeMenuItem = chartCpu.ContextMenuStrip.Items["tsCpuViewMode"] as ToolStripMenuItem;
            CpuViewModeMenuItem.DropDownItems["tsOverallUtilization"].Tag = CpuViewMode.OverallUtilization;
            CpuViewModeMenuItem.DropDownItems["tsLogicalProcessors"].Tag = CpuViewMode.LogicalProcessors;

            // Overall ChartArea
            string OverallCpuChartAreaName = $"OverallCpuChartArea";
            ChartArea OverallCpuChartArea = AddChartArea_OverallCpu(OverallCpuChartAreaName);
            chartCpu.ChartAreas.Add(OverallCpuChartArea);

            // Overall Series
            string OverallCpuSeriesName = $"OverallCpuSeries";
            Series OverallCpuSeries = AddSeries_OverallCpu(OverallCpuSeriesName, GridColor);
            OverallCpuSeries.ChartArea = OverallCpuChartAreaName;
            chartCpu.Series.Add(OverallCpuSeries);

            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                // LP ChartArea
                string ChartAreaName = $"LogicalProcessorChartArea_{i}";
                ChartArea LogicalProcessorChartArea = AddChartArea_LogicalProcessor(ChartAreaName);
                chartCpu.ChartAreas.Add(LogicalProcessorChartArea);

                // LP Series
                string SeriesName = $"LogicalProcessorSeries_{i}";
                Series LogicalProcessorSeries = AddSeries_LogicalProcessor(SeriesName, GridColor);
                LogicalProcessorSeries.ChartArea = ChartAreaName;
                chartCpu.Series.Add(LogicalProcessorSeries);
            }
        }
        #endregion InitializeGridLayout

        #region OnPerformanceDataUpdated
        public void OnPerformanceDataUpdated(object sender, EventArgs e)
        {
            CpuPerformanceData CpuPerformanceData = sender as CpuPerformanceData;
            Invoke(new OnDataUpdated(() =>
            {
                Cores = CpuPerformanceData.CoreCount;
                LogicalProcessors = CpuPerformanceData.LogicalProcessorsCount;
                ParentProcess = CpuPerformanceData.ParentProcessName;

                TotalCpu = CpuPerformanceData.TotalCPU;
                TotalCpuUser = CpuPerformanceData.TotalUserCPU;

                // Overall : Points
                Series OverallCpuSeries = this.Series["OverallCpuSeries"];
                OverallCpuSeries.Points.Add(new DataPoint(OverallCpuSeries.Points.Count, Convert.ToDouble(CpuPerformanceData.TotalCPU)));

                // Logical Cores : Points
                foreach (var logicalCore in CpuPerformanceData.LogicalCores)
                {
                    string SeriesName = $"LogicalProcessorSeries_{logicalCore.CoreId}";
                    this.Series[SeriesName].Points.Add(Convert.ToDouble(logicalCore.PercentProcessorTime));
                }

                // Performance Watches
                foreach (var PerformanceWatch in CpuPerformanceData.PerformanceWatchCollection)
                {
                    string OverallWatchSeriesName = $"OverallCpuSeries_{PerformanceWatch.Value.UniqueId}";

                    var Series = this.Series.FindByName(OverallWatchSeriesName);
                    if (Series == null)
                    {
                        Color GridColor = ColorLibrary.GetNextColor();

                        // Overall : UI
                        Series OverallWatchSeries = AddSeries_OverallCpu(OverallWatchSeriesName, GridColor);
                        OverallWatchSeries.ChartArea = "OverallCpuChartArea";
                        chartCpu.Series.Add(OverallWatchSeries);

                        // Logical Cores : UI
                        foreach (var logicalCore in CpuPerformanceData.LogicalCores)
                        {
                            string LogicalProcessorWatchSeriesName = $"LogicalProcessorSeries_{PerformanceWatch.Value.UniqueId}_{logicalCore.CoreId}";
                            Series LogicalProcessorWatchSeries = AddSeries_LogicalProcessor(LogicalProcessorWatchSeriesName, GridColor);
                            LogicalProcessorWatchSeries.ChartArea = $"LogicalProcessorChartArea_{ logicalCore.CoreId}";
                            chartCpu.Series.Add(LogicalProcessorWatchSeries);
                        }
                    }

                    if (PerformanceWatch.Value.Active)
                    {
                        // Overall : Points
                        this.Series[OverallWatchSeriesName].Points.Add(new DataPoint(OverallCpuSeries.Points[OverallCpuSeries.Points.Count - 1].XValue, new double[] { Convert.ToDouble(CpuPerformanceData.TotalCPU) }));

                        // Logical Cores : Points
                        foreach (var logicalCore in CpuPerformanceData.LogicalCores)
                        {
                            string LogicalProcessorSeriesName = $"LogicalProcessorSeries_{logicalCore.CoreId}";
                            Series LogicalProcessorSeries = this.Series[LogicalProcessorSeriesName];

                            string LogicalProcessorWatchSeriesName = $"LogicalProcessorSeries_{PerformanceWatch.Value.UniqueId}_{logicalCore.CoreId}";
                            this.Series[LogicalProcessorWatchSeriesName].Points.Add(new DataPoint(LogicalProcessorSeries.Points[LogicalProcessorSeries.Points.Count - 1].XValue, new double[] { Convert.ToDouble(logicalCore.PercentProcessorTime) }));
                        }
                    }
                }

                // Handle state changes
                CheckState(CpuPerformanceData.DataState);
            }), null);
        }
        #endregion OnPerformanceDataUpdated

        #region UpdateChartViewMode
        public void UpdateChartViewMode()
        {
            foreach (var chartArea in chartCpu.ChartAreas)
            {
                chartArea.Visible = _CpuViewMode == (CpuViewMode)chartArea.Tag;
            }
        }
        #endregion UpdateChartViewMode
        #endregion Methods..
    }
}
