using BergCommon;
using BergPerformanceServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BergUI
{
    public partial class CpuPerformanceControl : BergPerformanceControl
    {
        #region Member Variables..
        private bool _RefreshStatics = true;
        private BergCpuMonitor _BergCpuMonitor { get; set; }
        private CpuViewMode _CpuViewMode = CpuViewMode.Total;
        #endregion Member Variables..

        #region Properties..
        #region ChartAreas
        public ChartAreaCollection ChartAreas
        {
            get { return chartCpu.ChartBase.ChartAreas; }
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

        #region Series
        public SeriesCollection Series
        {
            get { return chartCpu.ChartBase.Series; }
        }
        #endregion Series

        #region ScopeItems
        [Browsable(false)]
        public BindingList<Scope> ScopeItems = new BindingList<Scope>();
        #endregion ScopeItems

        #region TotalCpu
        [Browsable(false)]
        public string TotalCpu
        {
            get { return lblTotalCpu.Text; }
            set { lblTotalCpu.Text = $"{value}%"; }
        }
        #endregion TotalCpu

        #region LogicalThreads
        [Browsable(false)]
        public string LogicalThreads { get; private set; }
        #endregion LogicalThreads

        #region UseLocalDataSource
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description(@"""True"" uses the current system this control is running on as the datasource. ""False"" uses a remote application or executable running the BergDataServices dll as the datasource"), Category("DataSource")]
        public bool UseLocalDataSource { get; set; }
        #endregion UseLocalDataSource

        #region CurrentThreads
        [Browsable(false)]
        public string CurrentThreads
        {
            get { return lblThreads.Text; }
            set { lblThreads.Text = value; }
        }
        #endregion CurrentThreads

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
            Total,
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

                ShowLoadingSplash(this.groupBoxCPU, true);

                _BergCpuMonitor = new BergCpuMonitor(UpdateInterval, true, UseLocalDataSource);
                _BergCpuMonitor.DataUpdated += OnPerformanceDataUpdated;
            }
        }
        #endregion CpuPerformanceControl
        #endregion Constructors..

        #region Methods..
        #region Events..
        #region CmbScope_SelectedValueChanged
        private void CmbScope_SelectedValueChanged(object sender, EventArgs e)
        {
            _RefreshStatics = true;
            UpdateChartViewMode();
        }
        #endregion CmbScope_SelectedValueChanged

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
        private ChartArea AddChartArea_LogicalProcessor(string name, ScopeType scopeType)
        {
            ChartArea ChartArea = new ChartArea(name);
            ChartArea.Tag = new List<object>()
            {
                CpuViewMode.LogicalProcessors,
                scopeType
            };

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
        private ChartArea AddChartArea_OverallCpu(string name, ScopeType scopeType)
        {
            ChartArea ChartArea = new ChartArea(name);
            ChartArea.Tag = new List<object>()
            {
                CpuViewMode.Total,
                scopeType
            };

            bool ShowLogicalProcessors = _CpuViewMode == CpuViewMode.Total;
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
            //ChartArea.AxisY.Title = "%";
            //ChartArea.AxisY.TitleFont = new Font(FontFamily.GenericSansSerif, 6);

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
        private Series AddSeries_OverallCpu(string name, Color color)
        {
            Series Series = new Series(name);
            Series.ChartType = SeriesChartType.Line;
            Series.MarkerStyle = MarkerStyle.Circle;
            Series.Color = color;
            Series.BorderWidth = 2;

            return Series;
        }
        #endregion AddSeries_OverallCpu

        #region UpdateGrid
        private void UpdateGrid(CpuPerformanceData cpuPerformanceData)
        {
            if (GridState == GridState.WAITING)
            {
                UpdateChartViewMode();
                GridState = GridState.ALIVE;
            }
            else if (GridState == GridState.ALIVE)
            {
                foreach (ScopeType scopeType in Enum.GetValues(typeof(ScopeType)))
                {
                    // Overall : Points
                    Series OverallCpuSeries = this.Series[$"OverallCpuSeries_{scopeType}"];
                    OverallCpuSeries.Points.AddXY(cpuPerformanceData.ElapsedTime / 1000, cpuPerformanceData.CpuUtilization[scopeType]);

                    ChartArea OverallChartArea = this.ChartAreas[$"OverallCpuChartArea_{scopeType}"];
                    double XValueMin = OverallCpuSeries.Points.FindMinByValue("X").XValue;
                    double XValueMax = OverallCpuSeries.Points.FindMaxByValue("X").XValue;

                    bool IncreaseXMaximum = XValueMax >= OverallChartArea.AxisX.Maximum;
                    if (IncreaseXMaximum)
                    {
                        OverallChartArea.AxisX.Minimum = Math.Floor(XValueMin / 30) * 30;
                        OverallChartArea.AxisX.Maximum = Math.Ceiling(XValueMax / 30) * 30;
                    }

                    // Logical Cores : Points
                    foreach (var logicalCore in cpuPerformanceData.LogicalCores)
                    {
                        string SeriesName = $"LogicalProcessorSeries_{scopeType}_{logicalCore.CoreId}";
                        this.Series[SeriesName].Points.AddXY(cpuPerformanceData.ElapsedTime / 1000, logicalCore.PercentCpuTotal);

                        if (IncreaseXMaximum)
                        {
                            string ChartAreaName = $"LogicalProcessorChartArea_{scopeType}_{logicalCore.CoreId}";
                            ChartArea LogicalProcessorChartArea = this.ChartAreas[ChartAreaName];

                            LogicalProcessorChartArea.AxisX.Minimum = Math.Floor(XValueMin / 30) * 30;
                            LogicalProcessorChartArea.AxisX.Maximum = Math.Ceiling(XValueMax / 30) * 30;
                        }
                    }

                    // Performance Watches
                    foreach (var PerformanceWatch in cpuPerformanceData.PerformanceWatchCollection)
                    {
                        string OverallWatchSeriesName = $"OverallCpuWatchSeries_{scopeType}_{PerformanceWatch.Value.UniqueId}";

                        var Series = this.Series.FindByName(OverallWatchSeriesName);
                        if (Series == null)
                        {
                            Color GridColor = ColorLibrary.GetNextColor();

                            // Overall : UI
                            Series OverallWatchSeries = AddSeries_OverallCpu(OverallWatchSeriesName, GridColor);
                            OverallWatchSeries.ChartArea = $"OverallCpuChartArea_{scopeType}";
                            chartCpu.ChartBase.Series.Add(OverallWatchSeries);

                            // Logical Cores : UI
                            foreach (var logicalCore in cpuPerformanceData.LogicalCores)
                            {
                                string LogicalProcessorWatchSeriesName = $"LogicalProcessorSeries_{scopeType}_{PerformanceWatch.Value.UniqueId}_{logicalCore.CoreId}";
                                Series LogicalProcessorWatchSeries = AddSeries_LogicalProcessor(LogicalProcessorWatchSeriesName, GridColor);
                                LogicalProcessorWatchSeries.ChartArea = $"LogicalProcessorChartArea_{scopeType}_{logicalCore.CoreId}";
                                chartCpu.ChartBase.Series.Add(LogicalProcessorWatchSeries);
                            }
                        }

                        if (PerformanceWatch.Value.Active)
                        {
                            // Overall : Points
                            this.Series[OverallWatchSeriesName].Points.AddXY(cpuPerformanceData.ElapsedTime / 1000, cpuPerformanceData.CpuUtilization[scopeType]);

                            // Logical Cores : Points
                            foreach (var logicalCore in cpuPerformanceData.LogicalCores)
                            {
                                string LogicalProcessorSeriesName = $"LogicalProcessorSeries_{scopeType}_{logicalCore.CoreId}";
                                Series LogicalProcessorSeries = this.Series[LogicalProcessorSeriesName];

                                string LogicalProcessorWatchSeriesName = $"LogicalProcessorSeries_{scopeType}_{PerformanceWatch.Value.UniqueId}_{logicalCore.CoreId}";
                                this.Series[LogicalProcessorWatchSeriesName].Points.AddXY(cpuPerformanceData.ElapsedTime / 1000, logicalCore.PercentCpuTotal);
                            }
                        }
                    }
                }
            }
        }
        #endregion UpdateGrid

        #region InitializeControls
        public void InitializeControls()
        {
            BindingSource BindingSource = new BindingSource() { DataSource = ScopeItems };
            cmbScope.DataSource = BindingSource;
            cmbScope.DisplayMember = "Name";
            cmbScope.ValueMember = "ScopeType";

            chartCpu.ContextMenuStrip = ctxChartCpu;

            InitializeGridLayout();
        }
        #endregion InitializeControls

        #region InitializeGridLayout
        private void InitializeGridLayout()
        {
            Color GridColor = ColorLibrary.GetNextColor();
            GridState = GridState.WAITING;

            foreach (ScopeType scopeType in Enum.GetValues(typeof(ScopeType)))
            {
                ToolStripMenuItem CpuViewModeMenuItem = chartCpu.ContextMenuStrip.Items["tsCpuViewMode"] as ToolStripMenuItem;
                CpuViewModeMenuItem.DropDownItems["tsOverallUtilization"].Tag = CpuViewMode.Total;
                CpuViewModeMenuItem.DropDownItems["tsLogicalProcessors"].Tag = CpuViewMode.LogicalProcessors;

                // Overall ChartArea
                string OverallCpuChartAreaName = $"OverallCpuChartArea_{scopeType}";
                ChartArea OverallCpuChartArea = AddChartArea_OverallCpu(OverallCpuChartAreaName, scopeType);
                chartCpu.ChartBase.ChartAreas.Add(OverallCpuChartArea);

                // Overall Series
                string OverallCpuSeriesName = $"OverallCpuSeries_{scopeType}";
                Series OverallCpuSeries = AddSeries_OverallCpu(OverallCpuSeriesName, GridColor);
                OverallCpuSeries.ChartArea = OverallCpuChartAreaName;
                chartCpu.ChartBase.Series.Add(OverallCpuSeries);

                for (int i = 0; i < Environment.ProcessorCount; i++)
                {
                    // LP ChartArea
                    string ChartAreaName = $"LogicalProcessorChartArea_{scopeType}_{i}";
                    ChartArea LogicalProcessorChartArea = AddChartArea_LogicalProcessor(ChartAreaName, scopeType);
                    chartCpu.ChartBase.ChartAreas.Add(LogicalProcessorChartArea);

                    // LP Series
                    string SeriesName = $"LogicalProcessorSeries_{scopeType}_{i}";
                    Series LogicalProcessorSeries = AddSeries_LogicalProcessor(SeriesName, GridColor);
                    LogicalProcessorSeries.ChartArea = ChartAreaName;
                    chartCpu.ChartBase.Series.Add(LogicalProcessorSeries);
                }
            }
        }
        #endregion InitializeGridLayout

        #region OnPerformanceDataUpdated
        public void OnPerformanceDataUpdated(object sender, EventArgs e)
        {
            CpuPerformanceData CpuPerformanceData = sender as CpuPerformanceData;
            Invoke(new OnDataUpdated(() =>
            {
                ShowLoadingSplash(this.groupBoxCPU, false);

                string SystemName = $"System - {CpuPerformanceData.SystemName}";
                if (!string.IsNullOrEmpty(SystemName) && !ScopeItems.Any(x => x.Name == SystemName))
                {
                    ScopeItems.Add(new Scope()
                    {
                        Name = SystemName,
                        ScopeType = ScopeType.System
                    });
                }

                string ProcessName = $"Process - {CpuPerformanceData.ParentProcessName}";
                if (!string.IsNullOrEmpty(ProcessName) && !ScopeItems.Any(x => x.Name == ProcessName))
                {
                    ScopeItems.Add(new Scope()
                    {
                        Name = ProcessName,
                        ScopeType = ScopeType.Process
                    });
                }

                if (_RefreshStatics)
                {
                    Cores = CpuPerformanceData.CoreCount.ToString();
                    CurrentClockSpeed = CpuPerformanceData.CurrentClockSpeed.ToString();
                    LogicalProcessors = CpuPerformanceData.LogicalProcessorsCount.ToString();
                    MaximumClockSpeed = CpuPerformanceData.MaxClockSpeed.ToString();
                    Name = CpuPerformanceData.Name;
                    LogicalThreads = CpuPerformanceData.ThreadCount.ToString();

                    ttlProcessor.KeyObjectToolTipText = $"Cores:               {Cores}{Environment.NewLine}" +
                                                        $"Logical Processors:  {LogicalProcessors}{Environment.NewLine}" +
                                                        $"Logical Threads:     {LogicalThreads}{Environment.NewLine}" +
                                                        $"{Environment.NewLine}" +
                                                        $"Maximum Clock Speed: {MaximumClockSpeed}{Environment.NewLine}" +
                                                        $"Current Clock Speed: {CurrentClockSpeed}";

                    _RefreshStatics = false;
                }

                ScopeType SelectedScope = (ScopeType)cmbScope.SelectedValue;
                TotalCpu = CpuPerformanceData.CpuUtilization[SelectedScope].ToString();
                CurrentThreads = CpuPerformanceData.Threads[SelectedScope].ToString();

                UpdateGrid(CpuPerformanceData);                
            }), null);
        }
        #endregion OnPerformanceDataUpdated

        #region UpdateChartViewMode
        public void UpdateChartViewMode()
        {
            foreach (var chartArea in chartCpu.ChartBase.ChartAreas)
            {
                // Determine visibility by the selected Scope and ViewMode
                List<object> ChartAreaTags = chartArea.Tag as List<object>;
                chartArea.Visible = ChartAreaTags.Contains(_CpuViewMode)
                    && ChartAreaTags.Contains(cmbScope.SelectedValue);
            }
        }
        #endregion UpdateChartViewMode
        #endregion Methods..
    }
}
