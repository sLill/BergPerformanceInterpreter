using BergPerformanceServices;
using System;

namespace BergUI
{
    public interface IBergPerformanceControl
    {
        #region Propertiess..
        BergPerformanceData PerformanceData { get; set; }
        #endregion Propertiess..

        #region Methods..
        #region Events..
        #region OnPerformanceDataUpdated
        void OnPerformanceDataUpdated(object sender, EventArgs e);
        #endregion OnPerformanceDataUpdated
        #endregion Events..

        #region InitializeControls
        void InitializeControls();
        #endregion InitializeControls

        #region InitializeData
        void InitializeData();
        #endregion InitializeData
        #endregion Methods..
    }
}
