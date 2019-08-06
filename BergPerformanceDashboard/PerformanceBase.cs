using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BergPerformanceDashboard
{
    public class PerformanceBase
    {
        #region Member Variables..
        protected object _UpdateLock = new object();
        private int _UpdateInterval = -1;
        private Timer _UpdateTimer;
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Delegates/Events
        public event EventHandler PerformanceDataUpdated;
        #endregion Delegates/Events

        #region Constructors..
        #region PerformanceBase
        public PerformanceBase(int updateInterval)
        {
            _UpdateInterval = updateInterval;

            Initialize();
        }
        #endregion PerformanceBase
        #endregion Constructors..

        #region Methods..
        #region Initialize
        protected virtual void Initialize()
        {
            _UpdateTimer = new Timer(GetPerformanceUpdate, new AutoResetEvent(true), 0 , _UpdateInterval);
        }
        #endregion Initialize

        #region GetPerformanceUpdate
        protected virtual void GetPerformanceUpdate(object state)
        {
            PerformanceDataUpdated?.Invoke(this, EventArgs.Empty);
        }
        #endregion GetPerformanceUpdate

        #region GetPropertyValue
        protected string GetPropertyValue(ManagementBaseObject systemItem, string fieldName)
        {
            string Result = string.Empty;

            try
            {
                Result = systemItem.GetPropertyValue(fieldName).ToString();
                //Result = systemItem[fieldName].ToString();
            }
            catch { }

            return Result;
        }
        #endregion GetPropertyValue
        #endregion Methods..
    }
}
