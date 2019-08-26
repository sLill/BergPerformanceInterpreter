using System.Collections.Generic;
using System.Drawing;

namespace BergCommon
{
    public static class ColorLibrary
    {
        #region Member Variables..
        private static int _Index = 0;
        private static List<Color> Colors = new List<Color>
        {
            Color.FromArgb(128,128,255), // Blue
            Color.Red,
            Color.Orange,
            Color.Purple,
            Color.Green,
            Color.Pink,
            Color.Yellow,
            Color.Black,
            Color.Brown,
            Color.Magenta,
            Color.Gold
        };
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #endregion Constructors..

        #region Methods..
        public static Color GetNextColor()
        {
            Color NextColor = Colors[_Index];
            _Index = _Index == Colors.Count - 1 ? 1 : _Index + 1;
            return NextColor;
        }
        #endregion Methods..
    }
}
