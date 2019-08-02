using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace BergPerformanceDashboard
{
    public class DiskPerformanceData : PerformanceBase
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #region DiskPerformanceData
        public DiskPerformanceData(int updateInterval)
            : base(updateInterval) { }
        #endregion DiskPerformanceData
        #endregion Constructors..

        #region Methods..
        #region Initialize
        protected override void Initialize()
        {
            base.Initialize();

            ManagementObjectSearcher ManagementObjectSearcher = new ManagementObjectSearcher();
            
            // Disk Performance
            string DiskPerformanceQuery = "SELECT * FROM Win32_PerfFormattedData_PerfDisk_PhysicalDisk";
            ManagementObjectSearcher.Query = new ObjectQuery(DiskPerformanceQuery);

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
