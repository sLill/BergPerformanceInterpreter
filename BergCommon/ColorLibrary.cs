using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BergCommon
{
    public static class ColorLibrary
    {
        #region Member Variables..
        private static int _Index = 0;
        #endregion Member Variables..

        #region Properties..
        public static Dictionary<string, Color> Colors = new Dictionary<string, Color>
        {
            { "Blue", Color.FromArgb(128,128,255) },
            { "Red", Color.Red },
            { "Orange", Color.Orange },
            { "Purple", Color.Purple },
            { "Green", Color.Green },
            { "Pink", Color.Pink },
            { "Yellow", Color.Yellow },
            { "Black", Color.Black },
            { "Brown", Color.Brown },
            { "Magenta", Color.Magenta },
            { "Gold", Color.Gold }
        };
        #endregion Properties..

        #region Constructors..
        #endregion Constructors..

        #region Methods..
        public static (string Key, Color Value) GetNextColor()
        {
            string Key = Colors.Keys.ToList()[_Index];
            Color Value = Colors[Key];

            _Index = _Index == Colors.Count - 1 ? 1 : _Index + 1;

            return (Key, Value);
        }
        #endregion Methods..
    }
}
