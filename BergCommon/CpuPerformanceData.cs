using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Linq;
using System.Linq.Expressions;

namespace BergCommon
{
    [Serializable]
    public class CpuPerformanceData : BergPerformanceData
    {
        #region Member Variables..
        private (DateTime, double) _PreviousProcessCheck = (DateTime.Now, 0);
        //private long _RawCpuPrev = 0;
        //private long _RawUserCpuPrev = 0;
        //private UInt64 _RawTimeStampPrev = 0;
        #endregion Member Variables..

        #region Properties..
        public byte CoreCount { get; private set; }

        public Dictionary<ScopeType, byte> CpuUtilization = new Dictionary<ScopeType, byte>();

        public int CurrentClockSpeed { get; private set; }

        public int L2CacheSize { get; private set; }

        public int L3CacheSize { get; private set; }

        public List<LogicalCore> LogicalCores { get; private set; }

        public byte LoadPercentage { get; private set; }

        public byte LogicalProcessorsCount { get; private set; }

        public int MaxClockSpeed { get; private set; }

        public string Name { get; private set; }

        public string Status { get; private set; }

        public Dictionary<ScopeType, int> Threads = new Dictionary<ScopeType, int>();

        public int ThreadCount { get; private set; }
        #endregion Properties..

        #region Structs
        #region LogicalCore
        [Serializable]
        public struct LogicalCore
        {
            public string CoreId;
            public int PercentCpuTotal;
            public int PercentCpuProcess;
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

            using (ManagementObjectSearcher ManagementObjectSearcher = new ManagementObjectSearcher())
            {
                // CPU Information
                string CpuInformationQuery = "SELECT * FROM Win32_Processor";
                ManagementObjectSearcher.Query = new ObjectQuery(CpuInformationQuery);

                foreach (var systemItem in ManagementObjectSearcher.Get())
                {
                    L2CacheSize = Convert.ToInt32(systemItem.GetFieldValue("L2CacheSize"));
                    L3CacheSize = Convert.ToInt32(systemItem.GetFieldValue("L3CacheSize"));
                    CurrentClockSpeed = Convert.ToInt32(systemItem.GetFieldValue("CurrentClockSpeed"));
                    MaxClockSpeed = Convert.ToInt32(systemItem.GetFieldValue("MaxClockSpeed"));
                    ThreadCount = Convert.ToInt32(systemItem.GetFieldValue("ThreadCount"));
                    CoreCount = Convert.ToByte(systemItem.GetFieldValue("NumberOfCores"));
                    LoadPercentage = Convert.ToByte(systemItem.GetFieldValue("LoadPercentage"));
                    LogicalProcessorsCount = Convert.ToByte(systemItem.GetFieldValue("NumberOfLogicalProcessors"));
                    Name = systemItem.GetFieldValue("Name");
                    Status = systemItem.GetFieldValue("Status");
                }

                SystemName = Environment.MachineName;
                ParentProcessName = AppDomain.CurrentDomain.FriendlyName;
            }
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
            using (ManagementObjectSearcher ManagementObjectSearcher = new ManagementObjectSearcher())
            {
                ManagementObjectSearcher.Scope.Path.Path = "root\\CIMV2";

                // Process
                Process CurrentProcess = Process.GetCurrentProcess();
                Threads[ScopeType.Process] = CurrentProcess.Threads.Count;

                var CurrentProcessCheck = (DateTime.Now, CurrentProcess.TotalProcessorTime.TotalMilliseconds);
                CpuUtilization[ScopeType.Process] = Convert.ToByte(((CurrentProcessCheck.TotalMilliseconds - _PreviousProcessCheck.Item2) / (CurrentProcessCheck.Now - _PreviousProcessCheck.Item1).TotalMilliseconds) * 100 / Environment.ProcessorCount);
                _PreviousProcessCheck = CurrentProcessCheck;

                string Query = "SELECT * FROM Win32_PerfFormattedData_PerfProc_Process";
                ManagementObjectSearcher.Query.QueryString = Query;
                var CurrentProcessWMI = ManagementObjectSearcher.Get().Cast<ManagementObject>().Where(item => item["Name"].ToString() == CurrentProcess.ProcessName);

                // System
                Query = "SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor";
                ManagementObjectSearcher.Query.QueryString = Query;
                foreach (var systemItem in ManagementObjectSearcher.Get())
                {
                    string ItemName = systemItem.GetFieldValue("Name");
                    if (ItemName == "_Total")
                    {
                        CpuUtilization[ScopeType.System] = Convert.ToByte(systemItem.GetFieldValue("PercentProcessorTime"));
                    }
                    else
                    {
                        LogicalCores.Add(new LogicalCore()
                        {
                            CoreId = ItemName,
                            PercentCpuTotal = Convert.ToInt32(systemItem.GetFieldValue("PercentProcessorTime"))
                            //PercentCpuProcess = 
                        });
                    }
                }

                Query = "SELECT * FROM Win32_Thread";
                ManagementObjectSearcher.Query.QueryString = Query;
                Threads[ScopeType.System] = Process.GetProcesses().Sum(x => x.Threads.Count);
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
