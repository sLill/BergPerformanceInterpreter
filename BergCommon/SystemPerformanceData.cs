using System.Management;

namespace BergCommon
{
    public class SystemPerformanceData : BergPerformanceData
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #region SystemPerformanceData
        public SystemPerformanceData(int updateInterval)
            : base() { }
        #endregion SystemPerformanceData
        #endregion Constructors..

        #region Methods..
        #region Initialize
        public override void Initialize()
        {
            base.Initialize();

            ManagementObjectSearcher ManagementObjectSearcher = new ManagementObjectSearcher();

            // System Perfomance
            string SystemPerformanceQuery = "SELECT * FROM Win32_PerfRawData_PerfOS_System";
            ManagementObjectSearcher.Query = new ObjectQuery(SystemPerformanceQuery);
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
