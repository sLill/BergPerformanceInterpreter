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

namespace BergUI
{
    public partial class BergChart : UserControl
    {
        #region Member Variables..
        private Point? _PrevMousePos = null;
        private ToolTip _ToolTip = new ToolTip();
        #endregion Member Variables..

        #region Properties..

        #region ChartBase
        public Chart ChartBase
        {
            get { return this.chartBase; }
            set { this.chartBase = value; }
        }
        #endregion ChartBase
        #endregion Properties..

        #region Constructors..
        #region BergChart
        public BergChart()
        {
            InitializeComponent();
        }
        #endregion BergChart
        #endregion Constructors..

        #region Methods..
        #region Events..
        #region ChartBase_MouseMove
        private void ChartBase_MouseMove(object sender, MouseEventArgs e)
        {
            Point MousePos = e.Location;
            if (_PrevMousePos != MousePos)
            {
                _ToolTip.RemoveAll();

                var HoveredObjects = ChartBase.HitTest(MousePos.X, MousePos.Y, false, ChartElementType.DataPoint);
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
                            _ToolTip.Show(ToolTipText, ChartBase, MousePos.X - 30, MousePos.Y - 30);
                        }
                    }
                }

                _PrevMousePos = MousePos;
            }
        }
        #endregion ChartBase_MouseMove

        #region ChartBase_MouseWheel
        private void ChartBase_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                Point MousePos = e.Location;

                var HoveredControls = chartBase.HitTest(MousePos.X, MousePos.Y, false, ChartElementType.PlottingArea);
                ChartArea ChartArea = (from control in HoveredControls
                                       where control.Object.GetType() == typeof(ChartArea)
                                       select (ChartArea)control.Object).FirstOrDefault();

                if (e.Delta < 0)
                {
                    // Up scroll
                    Series ChartAreaSeries = chartBase.Series.Where(x => x.ChartArea == ChartArea.Name).FirstOrDefault();
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
        #endregion ChartBase_MouseWheel

        #endregion Events..

        #endregion Methods..
    }
}
