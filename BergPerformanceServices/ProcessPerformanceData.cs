using System.Management;

namespace BergPerformanceServices
{
    public class ProcessPerformanceData : BergPerformanceData
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #region ProcessPerformanceData
        public ProcessPerformanceData(int updateInterval)
            :base(updateInterval) { }
        #endregion ProcessPerformanceData
        #endregion Constructors..

        #region Methods..
        #region Initialize
        protected override void Initialize()
        {
            base.Initialize();

            ManagementObjectSearcher ManagementObjectSearcher = new ManagementObjectSearcher();

            // Process Performance
            string ProcessPerformanceQuery = "SELECT * FROM Win32_PerfFormattedData_PerfProc_Process";
            ManagementObjectSearcher.Query = new ObjectQuery(ProcessPerformanceQuery);
        }
        #endregion Initialize

        #region GetPerformanceUpdate
        protected override void GetPerformanceUpdate(object state)
        {
            base.GetPerformanceUpdate(state);
        }
        #endregion GetPerformanceUpdate
        #endregion Methods..
    }
}
