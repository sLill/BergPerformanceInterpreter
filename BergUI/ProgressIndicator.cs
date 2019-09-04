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
    public partial class ProgressIndicator : UserControl
    { 
        #region Member Variables..
        private int _Value = 1;
        private int _Interval = 100;
        private Color _Color = Color.LightBlue;
        private bool _Stopped = false;
        private float _CircleSize = 0.5f;
        private int _CircleCount = 16;
        private int _VisibleCircleCount = 16;
        private RotationType _RotationType = RotationType.Clockwise;
        private float _Percentage;
        private bool _ShowPercentage;
        private bool _ShowText;
        private TextDisplayModes _TextDisplay = TextDisplayModes.None;
        #endregion Member Variables..

        #region Properties..

        #region CircleColor
        [DefaultValue(typeof(Color), "20, 20, 20")]
        [Description("Gets or sets the base color for the circles.")]
        [Category("Appearance")]
        public Color CircleColor
        {
            get { return _Color; }
            set
            {
                _Color = value;
                Invalidate();
            }
        }
        #endregion CircleColor

        #region CircleSize
        [DefaultValue(1.0F)]
        [Description("Gets or sets the scale for the circles raging from 0.1 to 1.0.")]
        [Category("Appearance")]
        public float CircleSize
        {
            get { return _CircleSize; }
            set
            {
                if (value <= 0.0F)
                {
                    _CircleSize = 0.1F;
                }
                else
                {
                    _CircleSize = value > 1.0F ? 1.0F : value;
                }

                Invalidate();
            }
        }
        #endregion CircleSize

        #region AnimationSpeed
        [DefaultValue(75)]
        [Description("Gets or sets the animation speed.")]
        [Category("Behavior")]
        public int AnimationSpeed
        {
            get { return (-_Interval + 400) / 4; }
            set
            {
                checked
                {
                    int Interval = 400 - (value * 4);

                    if (Interval < 10)
                    {
                        _Interval = 10;
                    }
                    else
                    {
                        _Interval = Interval > 400 ? 400 : Interval;
                    }

                    timerAnimation.Interval = _Interval;
                }
            }
        }
        #endregion AnimationSpeed

        #region NumberOfCircles
        [DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("Behavior")]
        public int NumberOfCircles
        {
            get { return _CircleCount; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer.");
                }

                _CircleCount = value;
                Invalidate();
            }
        }
        #endregion NumberOfCircles

        #region NumberOfVisibleCircles
        [DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("Behavior")]
        public int NumberOfVisibleCircles
        {
            get { return _VisibleCircleCount; }
            set
            {
                if (value <= 0 || value > _CircleCount)
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer and less than or equal to the number of circles.");

                _VisibleCircleCount = value;
                Invalidate();
            }
        }
        #endregion NumberOfVisibleCircles

        #region Rotation
        [DefaultValue(RotationType.Clockwise)]
        [Description("Gets or sets a value indicating if the rotation should be clockwise or counter-clockwise.")]
        [Category("Behavior")]
        public RotationType Rotation
        {
            get { return _RotationType; }
            set { _RotationType = value; }
        }
        #endregion Rotation

        #region Percentage
        [DefaultValue(0)]
        [Description("Gets or sets the percentage to show on the control.")]
        [Category("Appearance")]
        public float Percentage
        {
            get { return _Percentage; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("value", "Percentage must be a positive integer between 0 and 100.");

                _Percentage = value;
            }
        }
        #endregion Percentage

        #region ShowPercentage
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the percentage value should be shown.")]
        [Category("Behavior")]
        public bool ShowPercentage
        {
            get { return _ShowPercentage; }
            set
            {
                _ShowPercentage = value;

                _TextDisplay = _ShowPercentage
                                   ? _TextDisplay | TextDisplayModes.Percentage
                                   : _TextDisplay & ~TextDisplayModes.Percentage;
                Invalidate();
            }
        }
        #endregion ShowPercentage

        #region ShowText
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the control text should be shown.")]
        [Category("Behavior")]
        public bool ShowText
        {
            get { return _ShowText; }
            set
            {
                _ShowText = value;

                _TextDisplay = _ShowText
                                   ? _TextDisplay | TextDisplayModes.Text
                                   : _TextDisplay & ~TextDisplayModes.Text;
                Invalidate();
            }
        }
        #endregion ShowText

        #region TextDisplay
        [DefaultValue(TextDisplayModes.None)]
        [Description("Gets or sets the property that will be shown in the control.")]
        [Category("Appearance")]
        public TextDisplayModes TextDisplay
        {
            get { return _TextDisplay; }
            set
            {
                _TextDisplay = value;

                _ShowText = (_TextDisplay & TextDisplayModes.Text) == TextDisplayModes.Text;
                _ShowPercentage = (_TextDisplay & TextDisplayModes.Percentage) == TextDisplayModes.Percentage;
                Invalidate();
            }
        }
        #endregion TextDisplay
        #endregion Properties..

        #region Enums..
        public enum RotationType
        {
            Clockwise = 1,
            CounterClockwise = -1,
        }

        [Flags]
        public enum TextDisplayModes
        {
            /// <summary>
            /// No text will be shown by the control.
            /// </summary>
            None = 0,

            /// <summary>
            /// The control will show the value of the Percentage property.
            /// </summary>
            Percentage = 1,

            /// <summary>
            /// The control will show the value of the Text property.
            /// </summary>
            Text = 2,

            /// <summary>
            /// The control will show the values of the Text and Percentage properties.
            /// </summary>
            Both = Percentage | Text
        }
        #endregion Enums..

        #region Constructors..
        public ProgressIndicator()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            if (!DesignMode)
            {
                timerAnimation.Start();
            }
        }
        #endregion Constructors..

        #region Methods..
        #region Start
        public void Start()
        {
            timerAnimation.Interval = _Interval;
            _Stopped = false;
            timerAnimation.Start();
        }
        #endregion Start

        #region Stop
        public void Stop()
        {
            timerAnimation.Stop();
            _Value = 1;
            _Stopped = true;
            Invalidate();
        }
        #endregion Stop

        #region OnPaint
        protected override void OnPaint(PaintEventArgs e)
        {
            float Angle = 360.0F / _CircleCount;
            GraphicsState PrevState = e.Graphics.Save();

            e.Graphics.TranslateTransform(Width / 2.0F, Height / 2.0F);
            e.Graphics.RotateTransform(Angle * _Value * (int)_RotationType);
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            for (int i = 1; i <= _CircleCount; i++)
            {
                int AlphaValue = (255.0F * (i / (float)_VisibleCircleCount)) > 255.0 ? 0 : (int)(255.0F * (i / (float)_VisibleCircleCount));
                int Alpha = _Stopped ? (int)(255.0F * (1.0F / 8.0F)) : AlphaValue;

                Color DrawColor = Color.FromArgb(Alpha, _Color);

                using (SolidBrush brush = new SolidBrush(DrawColor))
                {
                    float SizeRate = 4.5F / _CircleSize;
                    float Size = Width / SizeRate;

                    float Diff = (Width / 4.5F) - Size;

                    float X = (Width / 9.0F) + Diff;
                    float Y = (Height / 9.0F) + Diff;
                    e.Graphics.FillEllipse(brush, X, Y, Size, Size);
                    e.Graphics.RotateTransform(Angle * (int)_RotationType);
                }
            }

            e.Graphics.Restore(PrevState);

            string Percent = GetDrawText();
            if (!string.IsNullOrEmpty(Percent))
            {
                SizeF TextSize = e.Graphics.MeasureString(Percent, Font);
                float TextX = (Width / 2.0F) - (TextSize.Width / 2.0F);
                float TextY = (Height / 2.0F) - (TextSize.Height / 2.0F);

                StringFormat Format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                RectangleF Rectangle = new RectangleF(TextX, TextY, TextSize.Width, TextSize.Height);
                using (SolidBrush textBrush = new SolidBrush(ForeColor))
                {
                    e.Graphics.DrawString(Percent, Font, textBrush, Rectangle, Format);
                }
            }

            base.OnPaint(e);
        }
        #endregion OnPaint

        #region OnResize
        protected override void OnResize(EventArgs e)
        {
            SetNewSize();
            base.OnResize(e);
        }
        #endregion OnResize

        #region OnSizeChanged
        protected override void OnSizeChanged(EventArgs e)
        {
            SetNewSize();
            base.OnSizeChanged(e);
        }
        #endregion OnSizeChanged

        #region GetDrawText
        private string GetDrawText()
        {
            string Percent = string.Format(CultureInfo.CurrentCulture, "{0:0.##} %", _Percentage);
            if (_ShowText && _ShowPercentage)
            {
                return string.Format("{0}{1}{2}", Percent, Environment.NewLine, Text);
            }

            if (_ShowText)
            {
                return Text;
            }

            if (_ShowPercentage)
            {
                return Percent;
            }

            return string.Empty;
        }
        #endregion GetDrawText

        #region SetNewSize
        private void SetNewSize()
        {
            int NewSize = Math.Max(Width, Height);
            Size = new Size(NewSize, NewSize);
        }
        #endregion SetNewSize

        #region IncreaseValue
        private void IncreaseValue()
        {
            if (_Value + 1 <= _CircleCount)
            {
                _Value++;
            }
            else
            {
                _Value = 1;
            }
        }
        #endregion IncreaseValue

        #region timerAnimation_Tick
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                IncreaseValue();
                Invalidate();
            }
        }
        #endregion timerAnimation_Tick
        #endregion Methods..
    }
}
