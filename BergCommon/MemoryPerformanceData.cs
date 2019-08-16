using System.Management;

namespace BergCommon
{
    public class MemoryPerformanceData : BergPerformanceData
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #region MemoryPerformanceData
        public MemoryPerformanceData(int updateInterval)
            :base() { }
        #endregion MemoryPerformanceData
        #endregion Constructors..

        #region Methods..
        #region Initialize
        public override void Initialize()
        {
            base.Initialize();

            ManagementObjectSearcher ManagementObjectSearcher = new ManagementObjectSearcher();

            // Memory Information
            string MemoryInformationQuery = "SELECT * FROM Win32_PhysicalMemory";
            ManagementObjectSearcher.Query = new ObjectQuery(MemoryInformationQuery);

            // Memory Performance
            string MemoryPerformanceQuery = "SELECT * FROM Win32_PerfFormattedData_PerfOS_Memory";
            ManagementObjectSearcher.Query = new ObjectQuery(MemoryPerformanceQuery);
        }
        #endregion Initialize

        #region GetPerformanceUpdate
        public override void RefreshPerformanceData(object state)
        {
            base.RefreshPerformanceData(state);
        }
        #endregion GetPerformanceUpdate
        #endregion Methods..
    }
}
