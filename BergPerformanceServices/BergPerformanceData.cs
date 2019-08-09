﻿using System;
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
        #region Initialize
        protected virtual void Initialize()
        {
            _UpdateTimer = new Timer(GetPerformanceUpdate, new AutoResetEvent(true), 0 , _UpdateInterval);
        }
        #endregion Initialize

        #region GetPerformanceUpdate
        protected virtual void GetPerformanceUpdate(object state)
        {
            //foreach (var property in systemItem.Properties)
            //{
            //    Console.WriteLine($"{property.Name} - {property.Value}");
            //}
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }
        #endregion GetPerformanceUpdate

        #region GetPerfValueFromRaw
        /// <summary>
        /// PERF_100NSEC_TIMER_INV algorithm.
        /// </summary>
        /// <param name="dataPointNew"></param>
        /// <param name="dataPointOld"></param>
        /// <param name="dataPointTimeStampNew"></param>
        /// <param name="dataPointTimeStampOld"></param>
        /// <returns></returns>
        public static string GetPerfValueFromRaw(long dataPointOld, long dataPointNew, UInt64 dataPointTimeStampOld, UInt64 dataPointTimeStampNew)
        {
            string Result = string.Empty;

            try
            {
                double DataDifference = (dataPointNew - dataPointOld);
                double TimeDifference = (dataPointTimeStampNew - dataPointTimeStampOld);
                double UsageRaw = (1 - (DataDifference / TimeDifference)) * 100;

                Result = (UsageRaw >= 0.5) ? Convert.ToInt32(Math.Ceiling(UsageRaw)).ToString() : "0";
            }
            catch { }

            return Result;
        }
        #endregion GetPerfValueFromRaw

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
