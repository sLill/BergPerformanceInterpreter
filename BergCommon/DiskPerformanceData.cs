using System.Management;

namespace BergCommon
{
    public class DiskPerformanceData : BergPerformanceData
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #region DiskPerformanceData
        public DiskPerformanceData(int updateInterval)
            : base() { }
        #endregion DiskPerformanceData
        #endregion Constructors..

        #region Methods..
        #region Initialize
        public override void Initialize()
        {
            base.Initialize();

            ManagementObjectSearcher ManagementObjectSearcher = new ManagementObjectSearcher();
            
            // Disk Performance
            string DiskPerformanceQuery = "SELECT * FROM Win32_PerfFormattedData_PerfDisk_PhysicalDisk";
            ManagementObjectSearcher.Query = new ObjectQuery(DiskPerformanceQuery);

        }
        #endregion Initialize

        #region RefreshPerformanceData
        public override void RefreshPerformanceData(object state)
        {
            base.RefreshPerformanceData(state);
        }
        #endregion RefreshPerformanceData
        #endregion Methods..
    }
}
