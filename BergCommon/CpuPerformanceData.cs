using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;

namespace BergCommon
{
    [Serializable]
    public class CpuPerformanceData : BergPerformanceData
    {
        #region Member Variables..
        //private long _RawCpuPrev = 0;
        //private long _RawUserCpuPrev = 0;
        //private UInt64 _RawTimeStampPrev = 0;
        #endregion Member Variables..

        #region Properties..
        public string CoreCount { get; private set; }
        
        public string CurrentClockSpeed { get; private set; }

        public string L2CacheSize { get; private set; }

        public string L3CacheSize { get; private set; }

        public List<LogicalCore> LogicalCores { get; private set; }

        public string LoadPercentage { get; private set; }

        public string LogicalProcessorsCount { get; private set; }

        public string MaxClockSpeed { get; private set; }

        public string Name { get; private set; }

        public string ParentProcessName { get; private set; }

        public string Status { get; private set; }

        public string ThreadCount { get; private set; }

        public string TotalCPU { get; private set; }

        public string TotalUserCPU { get; private set; }
        #endregion Properties..

        #region Structs
        #region LogicalCore
        [Serializable]
        public struct LogicalCore
        {
            public string CoreId;
            public string PercentProcessorTime;
            public string PercentUserTime;
        }
        #endregion LogicalCore
        #endregion Structs

        #region Constructors..
        #region CpuPerformanceData
        public CpuPerformanceData()
            : base() { }
        #endregion CpuPerformanceData
        #endregion Constructors..

        #region Methods..
        #region Initialize
        public override void Initialize()
        {
            base.Initialize();

            ManagementObjectSearcher ManagementObjectSearcher = new ManagementObjectSearcher();

            // CPU Information
            string CpuInformationQuery = "SELECT * FROM Win32_Processor";
            ManagementObjectSearcher.Query = new ObjectQuery(CpuInformationQuery);

            foreach (var systemItem in ManagementObjectSearcher.Get())
            {
                L2CacheSize = systemItem["L2CacheSize"].ToString();
                L3CacheSize = systemItem["L3CacheSize"].ToString();
                CurrentClockSpeed = systemItem["CurrentClockSpeed"].ToString();
                MaxClockSpeed = systemItem["MaxClockSpeed"].ToString();
                ThreadCount = GetPropertyValue(systemItem, "ThreadCount");
                CoreCount = systemItem["NumberOfCores"].ToString();
                LoadPercentage = systemItem["LoadPercentage"].ToString();
                LogicalProcessorsCount = systemItem["NumberOfLogicalProcessors"].ToString();
                Name = systemItem["Name"].ToString();
                Status = systemItem["Status"].ToString();
            }

            ParentProcessName = AppDomain.CurrentDomain.FriendlyName;
        }
        #endregion Initialize

        #region RefreshPerformanceData
        public override void RefreshPerformanceData(object state)
        {
            LogicalCores = new List<LogicalCore>();

            #region RawCalculation
            // CPU Performance
            // Raw Calculation : ~200-250 ms faster than formatted 
            //string CpuPerformanceQueryRaw = "SELECT * FROM Win32_PerfRawData_PerfOS_Processor";
            //ManagementObjectSearcher ManagementObjectSearcherRaw = new ManagementObjectSearcher("root\\CIMV2", CpuPerformanceQueryRaw);
            //foreach (var systemItem in ManagementObjectSearcherRaw.Get())
            //{
            //    string ItemName = systemItem["Name"].ToString();
            //    UInt64 RawTimeStampCurrent = Convert.ToUInt64(systemItem["Timestamp_Sys100NS"]);

            //    if (ItemName == "_Total")
            //    {
            //        if (_RawTimeStampPrev > 0 && _RawCpuPrev > 0)
            //        {
            //            TotalCPU = GetPerfValueFromRaw(CookingType.PERF_100NSEC_TIMER_INV, _RawCpuPrev, Convert.ToInt64(systemItem["PercentProcessorTime"]), _RawTimeStampPrev, RawTimeStampCurrent);
            //            TotalUserCPU = GetPerfValueFromRaw(CookingType.PERF_100NSEC_TIMER, _RawUserCpuPrev, Convert.ToInt64(systemItem["PercentUserTime"]), _RawTimeStampPrev, RawTimeStampCurrent);
            //        }

            //        _RawCpuPrev = Convert.ToInt64(systemItem["PercentProcessorTime"]);
            //        _RawUserCpuPrev = Convert.ToInt64(systemItem["PercentUserTime"]);
            //        _RawTimeStampPrev = Convert.ToUInt64(systemItem["Timestamp_Sys100NS"]);
            //    }
            //    else
            //    {
            //        LogicalCores.Add(new LogicalCore()
            //        {
            //            CoreId = ItemName,
            //            PercentProcessorTime = systemItem["PercentProcessorTime"].ToString(),
            //            PercentUserTime = systemItem["PercentUserTime"].ToString()
            //        });
            //    }
            //} 
            #endregion RawCalculation

            #region Formatted Calculation
            string CpuPerformanceQuery = "SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor";
            ManagementObjectSearcher ManagementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", CpuPerformanceQuery);
            foreach (var systemItem in ManagementObjectSearcher.Get())
            {
                string ItemName = systemItem["Name"].ToString();
                if (ItemName == "_Total")
                {
                    TotalCPU = systemItem["PercentProcessorTime"].ToString();
                    TotalUserCPU = systemItem["PercentUserTime"].ToString();
                }
                else
                {
                    LogicalCores.Add(new LogicalCore()
                    {
                        CoreId = ItemName,
                        PercentProcessorTime = systemItem["PercentProcessorTime"].ToString(),
                        PercentUserTime = systemItem["PercentUserTime"].ToString()
                    });
                }
            }
            #endregion Formatted Calculation

            #region Formatted - ManagementClass
            //ManagementClass ManagementClass = new ManagementClass("Win32_PerfFormattedData_PerfOS_Processor");
            //foreach (ManagementObject managementObject in ManagementClass.GetInstances())
            //{
            //    string ItemName = managementObject["Name"].ToString();
            //    if (ItemName == "_Total")
            //    {
            //        TotalCPU = managementObject["PercentProcessorTime"].ToString();
            //        TotalUserCPU = managementObject["PercentUserTime"].ToString();
            //    }
            //    else
            //    {
            //        LogicalCores.Add(new LogicalCore()
            //        {
            //            CoreId = ItemName,
            //            PercentProcessorTime = managementObject["PercentProcessorTime"].ToString(),
            //            PercentUserTime = managementObject["PercentUserTime"].ToString()
            //        });
            //    }
            //}
            #endregion Formatted - ManagementClass

            base.RefreshPerformanceData(state);
        }
        #endregion RefreshPerformanceData
        #endregion Methods..
    }
}
