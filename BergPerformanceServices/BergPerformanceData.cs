using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BergPerformanceServices
{
    public class BergPerformanceData
    {
        #region Member Variables..
        protected object _UpdateLock = new object();
        private int _UpdateInterval = -1;
        private Timer _UpdateTimer;
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Delegates/Events
        public event EventHandler DataUpdated;
        #endregion Delegates/Events

        #region Constructors..
        #region BergPerformanceData
        public BergPerformanceData(int updateInterval)
        {
            _UpdateInterval = updateInterval;

            Initialize();
        }
        #endregion BergPerformanceData
        #endregion Constructors..

        #region Methods..
        #region GetPerfValueFromRaw
        /// <summary>
        /// PERF_100NSEC_TIMER_INV algorithm.
        /// </summary>
        /// <param name="dataPointTwo"></param>
        /// <param name="dataPointOne"></param>
        /// <param name="dateTwo"></param>
        /// <param name="dateOne"></param>
        /// <returns></returns>
        public static int GetPerfValueFromRaw(long dataPointTwo, long dataPointOne, UInt64 dateTwo, UInt64 dateOne)
        {
            int Result = 0;

            try
            {
                double DataDifference = (dataPointTwo - dataPointOne);
                double TimeDifference = (dateTwo - dateOne);
                double UsageRaw = (1 - (DataDifference / TimeDifference)) * 100;

                Result = (UsageRaw >= 0.5) ? Convert.ToInt32(Math.Ceiling(UsageRaw)) : 0;
            }
            catch { }

            // Return
            return Result;
        }
        #endregion GetPerfValueFromRaw

        #region Initialize
        protected virtual void Initialize()
        {
            _UpdateTimer = new Timer(GetPerformanceUpdate, new AutoResetEvent(true), 0 , _UpdateInterval);
        }
        #endregion Initialize

        #region GetPerformanceUpdate
        protected virtual void GetPerformanceUpdate(object state)
        {
            DataUpdated?.Invoke(this, EventArgs.Empty);
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
