using BergCommon;
using BergPerformanceServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BergUI
{
    public partial class CpuPerformanceControl : UserControl, IBergPerformanceControl
    {
        #region Member Variables..
        private BergCpuMonitor _BergCpuMonitor { get; set; }
        private CpuViewMode _CpuViewMode = CpuViewMode.OverallUtilization;
        private Point? _PrevMousePos = null;
        private ToolTip _ToolTip = new ToolTip();
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
        public string Cores { get; private set; }
        #endregion Cores

        #region CurrentClockSpeed
        [Browsable(false)]
        public string CurrentClockSpeed { get; private set; }
        #endregion CurrentClockSpeed

        #region GridState
        [Browsable(false)]
        public GridState GridState { get; private set; }
        #endregion GridState

        #region LogicalProcessors
        [Browsable(false)]
        public string LogicalProcessors { get; private set; }
        #endregion LogicalProcessors

        #region MaximumClockSpeed
        [Browsable(false)]
        public string MaximumClockSpeed { get; private set; }
        #endregion MaximumClockSpeed

        #region Name
        [Browsable(false)]
        public new string Name
        {
            get { return ttlProcessor.Text; }
            set { ttlProcessor.Text = value; }
        }
        #endregion Name

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
        public string ThreadCount { get; private set; }
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
                UseLocalDataSource = true;

                _BergCpuMonitor = new BergCpuMonitor(UpdateInterval, true, UseLocalDataSource);
                _BergCpuMonitor.DataUpdated += OnPerformanceDataUpdated;
            }
        }
        #endregion CpuPerformanceControl
        #endregion Constructors..

        #region Methods..
        #region Events..
        #region ChartCpu_MouseMove
        private void ChartCpu_MouseMove(object sender, MouseEventArgs e)
        {
            Point MousePos = e.Location;
            if (_PrevMousePos != MousePos)
            {
                _ToolTip.RemoveAll();

                var HoveredObjects = chartCpu.HitTest(MousePos.X, MousePos.Y, false, ChartElementType.DataPoint);
                foreach (var hoveredObject in HoveredObjects)
                {
                    if (hoveredObject.ChartElementType != ChartElementType.Nothing)
                    {
                        DataPoint ObjectDataPoint = hoveredObject.Object as DataPoint;
                        var ObjectX = hoveredObject.ChartArea.AxisX.ValueToPixelPosition(ObjectDataPoint.XValue);
                        var ObjectY = hoveredObject.ChartArea.AxisY.ValueToPixelPosition(ObjectDataPoint.YValues[0]);

                        double DistanceToMouse = Math.Sqrt(Math.Pow(MousePos.X - ObjectX, 2) + Math.Pow(MousePos.Y - ObjectY, 2));
                        if (DistanceToMouse < 3)
                        {
                            string ToolTipText = $"{ObjectDataPoint.YValues[0]}% - {ObjectDataPoint.XValue} seconds";
                            _ToolTip.Show(ToolTipText, chartCpu, MousePos.X - 30, MousePos.Y - 30);
                        }
                    }
                }

                _PrevMousePos = MousePos;
            }
        }
        #endregion ChartCpu_MouseMove

        #region ChartCpu_MouseWheel
        private void ChartCpu_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                Point MousePos = e.Location;

                var HoveredControls = chartCpu.HitTest(MousePos.X, MousePos.Y, false, ChartElementType.PlottingArea);
                ChartArea ChartArea = (from control in HoveredControls
                                       where control.Object.GetType() == typeof(ChartArea)
                                       select (ChartArea)control.Object).FirstOrDefault();

                if (e.Delta < 0)
                {
                    // Up scroll
                    Series ChartAreaSeries = Series.Where(x => x.ChartArea == ChartArea.Name).FirstOrDefault();
                    double XValueMax = ChartAreaSeries.Points.FindMaxByValue("X").XValue;
                    ChartArea.AxisX.Maximum = Math.Ceiling(XValueMax / 30) * 30;
                    ChartArea.AxisX.Interval = 30;

                    ChartArea.AxisX.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0)
                {
                    // Down scroll
                    var XMin = ChartArea.AxisX.ScaleView.ViewMinimum;
                    var XMax = ChartArea.AxisX.ScaleView.ViewMaximum;

                    var XPositionBegin = (int)(ChartArea.AxisX.PixelPositionToValue(e.Location.X) - (XMax - XMin) / 4);
                    var XPositionEnd = (int)(ChartArea.AxisX.PixelPositionToValue(e.Location.X) + (XMax - XMin) / 4);

                    ChartArea.AxisX.Maximum = XPositionEnd;
                    ChartArea.AxisX.Interval = (XPositionEnd - XPositionBegin) / 4;
                    ChartArea.AxisX.ScaleView.Zoom(XPositionBegin, XPositionEnd);
                }
            }
            catch { }
        }
        #endregion ChartCpu_MouseWheel

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

            ChartArea.AxisY.MajorTickMark.Enabled = false;
            ChartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(50, 0, 0, 0);
            ChartArea.AxisY.Maximum = 100;
            ChartArea.AxisY.LabelStyle.Enabled = false;
            ChartArea.AxisY.Title = "%";

            ChartArea.AxisX.LabelStyle.Enabled = false;
            ChartArea.AxisX.MajorGrid.Enabled = false;
            ChartArea.AxisX.MajorTickMark.Enabled = false;
            ChartArea.AxisX.Minimum = 0;
            ChartArea.AxisX.Maximum = 30;
            ChartArea.AxisX.Interval = 30;

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

            ChartArea.AxisY.MajorTickMark.Enabled = false;
            ChartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(50, 0, 0, 0);
            ChartArea.AxisY.Maximum = 100;
            ChartArea.AxisY.Title = "%";

            ChartArea.AxisX.MajorGrid.Enabled = false;
            ChartArea.AxisX.MajorTickMark.Enabled = false;
            ChartArea.AxisX.Minimum = 0;
            ChartArea.AxisX.Maximum = 30;
            ChartArea.AxisX.Interval = 30;
            ChartArea.AxisX.ScaleView.Zoomable = true;
            //ChartArea.AxisX.Title = "Seconds";

            ChartArea.CursorX.AutoScroll = true;
            ChartArea.CursorX.IsUserSelectionEnabled = true;

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
            Series.MarkerStyle = MarkerStyle.Circle;
            Series.Color = color;
            Series.BorderWidth = 2;

            return Series;
        }
        #endregion AddSeries_OverallCpu

        #region ReconcileStates
        private void ReconcileStates(CpuPerformanceData cpuPerformanceData)
        {
            // Data state
            if (cpuPerformanceData.DataState == DataState.BEGIN)
            {
                // Static header data. Only set once
                Cores = cpuPerformanceData.CoreCount;
                CurrentClockSpeed = cpuPerformanceData.CurrentClockSpeed;
                LogicalProcessors = cpuPerformanceData.LogicalProcessorsCount;
                MaximumClockSpeed = cpuPerformanceData.MaxClockSpeed;
                Name = cpuPerformanceData.Name;
                ParentProcess = cpuPerformanceData.ParentProcessName;

                TotalCpu = cpuPerformanceData.TotalCPU;
                TotalCpuUser = cpuPerformanceData.TotalUserCPU;
                ThreadCount = cpuPerformanceData.ThreadCount;

                ttlProcessor.KeyObjectToolTipText = $"Cores:               {Cores}{Environment.NewLine}" +
                                                    $"Logical Processors:  {LogicalProcessors}{Environment.NewLine}" +
                                                    $"Logical Threads:     {ThreadCount}{Environment.NewLine}" +
                                                    $"{Environment.NewLine}" +
                                                    $"Maximum Clock Speed: {MaximumClockSpeed}{Environment.NewLine}" +
                                                    $"Current Clock Speed: {CurrentClockSpeed}";

                UpdateChartViewMode();
            }
            else if (cpuPerformanceData.DataState == DataState.ALIVE)
            {
                if (GridState == GridState.WAITING)
                {
                    UpdateChartViewMode();
                    GridState = GridState.ALIVE;
                }
            }
        }
        #endregion ReconcileStates

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
                // Handle state changes
                ReconcileStates(CpuPerformanceData);

                // Overall : Points
                Series OverallCpuSeries = this.Series["OverallCpuSeries"];
                OverallCpuSeries.Points.AddXY(CpuPerformanceData.ElapsedTime / 1000, Convert.ToDouble(CpuPerformanceData.TotalCPU));

                ChartArea OverallChartArea = this.ChartAreas["OverallCpuChartArea"];
                double XValueMin = OverallCpuSeries.Points.FindMinByValue("X").XValue;
                double XValueMax = OverallCpuSeries.Points.FindMaxByValue("X").XValue;

                bool IncreaseXMaximum = XValueMax > OverallChartArea.AxisX.Maximum;
                if (IncreaseXMaximum)
                {
                    OverallChartArea.AxisX.Minimum = Math.Floor(XValueMin / 30) * 30;
                    OverallChartArea.AxisX.Maximum = Math.Ceiling(XValueMax / 30) * 30; 
                }

                // Logical Cores : Points
                foreach (var logicalCore in CpuPerformanceData.LogicalCores)
                {
                    string SeriesName = $"LogicalProcessorSeries_{logicalCore.CoreId}";
                    this.Series[SeriesName].Points.AddXY(CpuPerformanceData.ElapsedTime / 1000, Convert.ToDouble(logicalCore.PercentProcessorTime));

                    if (IncreaseXMaximum)
                    {
                        string ChartAreaName = $"LogicalProcessorChartArea_{logicalCore.CoreId}";
                        ChartArea LogicalProcessorChartArea = this.ChartAreas[ChartAreaName];

                        LogicalProcessorChartArea.AxisX.Minimum = Math.Floor(XValueMin / 30) * 30;
                        LogicalProcessorChartArea.AxisX.Maximum = Math.Ceiling(XValueMax / 30) * 30;
                    }
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
                        this.Series[OverallWatchSeriesName].Points.AddXY(CpuPerformanceData.ElapsedTime / 1000, Convert.ToDouble(CpuPerformanceData.TotalCPU));

                        // Logical Cores : Points
                        foreach (var logicalCore in CpuPerformanceData.LogicalCores)
                        {
                            string LogicalProcessorSeriesName = $"LogicalProcessorSeries_{logicalCore.CoreId}";
                            Series LogicalProcessorSeries = this.Series[LogicalProcessorSeriesName];

                            string LogicalProcessorWatchSeriesName = $"LogicalProcessorSeries_{PerformanceWatch.Value.UniqueId}_{logicalCore.CoreId}";
                            this.Series[LogicalProcessorWatchSeriesName].Points.AddXY(CpuPerformanceData.ElapsedTime / 1000, Convert.ToDouble(logicalCore.PercentProcessorTime));
                        }
                    }
                }
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
