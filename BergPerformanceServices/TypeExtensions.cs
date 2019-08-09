using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BergPerformanceServices
{
    public static class TypeExtensions
    {
        #region Methods..
        #region GetPerfValueFromRaw
        /// <summary>
        /// PERF_100NSEC_TIMER_INV algorithm.
        /// </summary>
        /// <param name="dataPointTwo"></param>
        /// <param name="dataPointOne"></param>
        /// <param name="dateTwo"></param>
        /// <param name="dateOne"></param>
        /// <returns></returns>
        public static int GetPerfValueFromRaw(this string str, long dataPointTwo, long dataPointOne, UInt64 dateTwo, UInt64 dateOne)
        {
            int Result = 0;

            try
            {
                double DataDifference = (dataPointTwo - dataPointOne);
                double TimeDifference = (dateTwo - dateOne);
                double UsageRaw = (1 - (DataDifference / TimeDifference)) * 100;

                Result = (UsageRaw >= 0.5) ? Convert.ToInt32(Math.Ceiling(UsageRaw)) : 0;
            }
            catch { }

            // Return
            return Result;
        }
        #endregion GetPerfValueFromRaw
        #endregion Methods..
    }
}
