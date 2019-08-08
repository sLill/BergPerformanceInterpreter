using System;
using System.Collections.Generic;
using System.Management;
using System.Threading;

namespace BergPerformanceServices
{
    public class CpuPerformanceData : BergPerformanceData
    {
        #region Member Variables..
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

        public string Status { get; private set; }

        public string ThreadCount { get; set; }

        public string TotalCPU { get; private set; }

        public string TotalUserCPU { get; private set; }
        #endregion Properties..

        #region Structs
        #region CpuCore
        public struct LogicalCore
        {
            public string CoreId;
            public string PercentProcessorTime;
            public string PercentUserTime;
        }
        #endregion CpuCore
        #endregion Structs

        #region Constructors..
        #region CpuPerformanceData
        public CpuPerformanceData(int updateInterval)
            : base(updateInterval) { }
        #endregion CpuPerformanceData
        #endregion Constructors..

        #region Methods..
        #region Initialize
        protected override void Initialize()
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
        }
        #endregion Initialize

        #region GetPerformanceUpdate
        protected override void GetPerformanceUpdate(object state)
        {
            if (Monitor.TryEnter(_UpdateLock))
            {
                LogicalCores = new List<LogicalCore>();

                // CPU Performance
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
                        foreach (var property in systemItem.Properties)
                        {
                            Console.WriteLine($"{property.Name} - {property.Value}");
                        }

                        LogicalCores.Add(new LogicalCore()
                        {
                            CoreId = ItemName,
                            PercentProcessorTime = systemItem["PercentProcessorTime"].ToString(),
                            PercentUserTime = systemItem["PercentUserTime"].ToString()
                        });
                    }
                }

                base.GetPerformanceUpdate(state);

                Monitor.Exit(_UpdateLock);
            }
        }
        #endregion GetPerformanceUpdate
        #endregion Methods..
    }
}
