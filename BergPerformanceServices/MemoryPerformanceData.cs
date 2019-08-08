using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace BergPerformanceServices
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
            :base(updateInterval) { }
        #endregion MemoryPerformanceData
        #endregion Constructors..

        #region Methods..
        #region Initialize
        protected override void Initialize()
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
        protected override void GetPerformanceUpdate(object state)
        {
            base.GetPerformanceUpdate(state);
        }
        #endregion GetPerformanceUpdate
        #endregion Methods..
    }
}
