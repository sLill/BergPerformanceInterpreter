using System.Management;
using System.Threading.Tasks;

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
            :base() { }
        #endregion ProcessPerformanceData
        #endregion Constructors..

        #region Methods..
        #region Initialize
        public override void Initialize()
        {
            base.Initialize();

            ManagementObjectSearcher ManagementObjectSearcher = new ManagementObjectSearcher();

            // Process Performance
            string ProcessPerformanceQuery = "SELECT * FROM Win32_PerfFormattedData_PerfProc_Process";
            ManagementObjectSearcher.Query = new ObjectQuery(ProcessPerformanceQuery);
        }
        #endregion Initialize

        #region GetPerformanceUpdate
        internal override void RefreshPerformanceData(object state)
        {
            base.RefreshPerformanceData(state);
        }
        #endregion GetPerformanceUpdate
        #endregion Methods..
    }
}
