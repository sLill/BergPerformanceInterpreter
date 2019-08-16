using System;

namespace BergCommon
{
    [Serializable]
    public class PerformanceWatch
    {
        #region Member Variables..
        #endregion Member Variables..
        #region Properties..
        public bool Active { get; set; }

        public string Name { get; set; }

        public Guid UniqueId { get; private set; }
        #endregion Properties..

        #region Constructors..
        #region PerformanceWatch
        public PerformanceWatch()
        {
            UniqueId = Guid.NewGuid();
        }
        #endregion PerformanceWatch
        #endregion Constructors..

        #region Methods..
        #endregion Methods..
    }
}
