using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;

namespace BergPerformanceServices
{
    public class CpuPerformanceData : BergPerformanceData
    {
        #region Member Variables..
        private static int _UpdateInterval = -1;
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

        public string Status { get; private set; }

        public string ThreadCount { get; private set; }

        public string TotalCPU { get; private set; }

        public string TotalUserCPU { get; private set; }

        public Dictionary<string, PerformanceWatch> PerformanceWatchList = new Dictionary<string, PerformanceWatch>();
        #endregion Properties..

        #region Structs
        #region LogicalCore
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
        public CpuPerformanceData(int updateInterval)
            : base(updateInterval)
        {
            _UpdateInterval = updateInterval;
        }
        #endregion CpuPerformanceData

        #region CpuPerformanceData
        public CpuPerformanceData()
            : base() { }
        #endregion CpuPerformanceData
        #endregion Constructors..

        #region Methods..
        #region BeginWatch
        public void BeginWatch(string name)
        {
            PerformanceWatchList[name] = new PerformanceWatch(name);
        }
        #endregion BeginWatch

        #region EndWatch
        public void EndWatch(string name)
        {
            PerformanceWatchList.Remove(name);
        }
        #endregion EndWatch

        #region Deserialize
        public static CpuPerformanceData Deserialize(byte[] data)
        {
            CpuPerformanceData Result = new CpuPerformanceData();

            if (data.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(data))
                {
                    using (BinaryReader reader = new BinaryReader(memoryStream))
                    {
                        Result.CoreCount = reader.ReadString();
                        Result.CurrentClockSpeed = reader.ReadString();
                        Result.L2CacheSize = reader.ReadString();
                        Result.L3CacheSize = reader.ReadString();
                        Result.LoadPercentage = reader.ReadString();
                        Result.LogicalProcessorsCount = reader.ReadString();
                        Result.MaxClockSpeed = reader.ReadString();
                        Result.Name = reader.ReadString();
                        Result.Status = reader.ReadString();
                        Result.ThreadCount = reader.ReadString();
                        Result.TotalCPU = reader.ReadString();
                        Result.TotalUserCPU = reader.ReadString();

                        // Performance Watches
                        //var BinaryFormatter = new BinaryFormatter();
                        //Result.PerformanceWatchList = (Dictionary<string, PerformanceWatch>)BinaryFormatter.Deserialize(memoryStream);
                    }
                }
            }

            return Result;
        }
        #endregion Deserialize

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

        #region BroadcastPerformanceData
        protected override void BroadcastPerformanceData()
        {
            base.BroadcastPerformanceData();

            byte[] performanceDataByteArray = Serialize();
            BergNamedPipeClient.Write(performanceDataByteArray);
        }
        #endregion BroadcastPerformanceData

        #region GetPerformanceUpdate
        protected override void GetPerformanceUpdate(object state)
        {
            if (Monitor.TryEnter(_UpdateLock))
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

                BroadcastPerformanceData();

                base.GetPerformanceUpdate(state);
                Monitor.Exit(_UpdateLock);
            }
        }
        #endregion GetPerformanceUpdate

        #region Serialize
        protected byte[] Serialize()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(memoryStream))
                {
                    writer.Write(CoreCount ?? string.Empty);
                    writer.Write(CurrentClockSpeed ?? string.Empty);
                    writer.Write(L2CacheSize ?? string.Empty);
                    writer.Write(L3CacheSize ?? string.Empty);
                    writer.Write(LoadPercentage ?? string.Empty);
                    writer.Write(LogicalProcessorsCount ?? string.Empty);
                    writer.Write(MaxClockSpeed ?? string.Empty);
                    writer.Write(Name ?? string.Empty);
                    writer.Write(Status ?? string.Empty);
                    writer.Write(ThreadCount ?? string.Empty);
                    writer.Write(TotalCPU ?? string.Empty);
                    writer.Write(TotalUserCPU ?? string.Empty);
                    //public List<LogicalCore> LogicalCores );

                    // Performance Watches
                    foreach (var watch in PerformanceWatchList)
                    {
                        writer.Write(watch.Value.Serialize());
                    }
                }

                return memoryStream.ToArray();
            }
        }
        #endregion Serialize
        #endregion Methods..
    }
}
