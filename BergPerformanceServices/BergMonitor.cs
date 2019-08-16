using BergCommon;
using BergDataServices;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

[assembly: InternalsVisibleTo("BergUI")]
namespace BergPerformanceServices
{
    public class BergMonitor
    {
        #region Member Variables..
        protected object _UpdateLock = new object();
        protected static int _UpdateInterval = -1;
        protected Timer _UpdateTimer;
        internal bool _UseLocalDataSource = false;
        internal bool _IsHost = false;
        #endregion Member Variables..

        #region Properties..
        protected BergNamedPipeClient BergNamedPipeClient;

        protected BergPerformanceData PerformanceData { get; set; }
        #endregion Properties..

        #region Delegates/Events
        public event EventHandler DataUpdated;
        #endregion Delegates/Events

        #region Constructors..
        #region BergMonitor
        protected BergMonitor(int updateInterval)
        {
            _UpdateInterval = updateInterval;
            BergNamedPipeClient = new BergNamedPipeClient();
            _UpdateTimer = new Timer(RefreshPerformanceData, new AutoResetEvent(true), 0, _UpdateInterval);
        }
        #endregion BergMonitor
        #endregion Constructors..

        #region Methods..
        #region PerformanceDataUpdated
        protected void PerformanceDataUpdated()
        {
            DataUpdated?.Invoke(PerformanceData, EventArgs.Empty);
        }
        #endregion PerformanceDataUpdated

        #region RefreshPerformanceData
        protected virtual void RefreshPerformanceData(object state)
        {
            if (Monitor.TryEnter(_UpdateLock))
            {
                if (PerformanceData != null)
                {
                    if (!_IsHost || _IsHost && _UseLocalDataSource)
                    {
                        PerformanceData.RefreshPerformanceData(state);
                        PerformanceDataUpdated();
                    }

                    if (!_IsHost)
                    {
                        WritePerformanceDataToStream();
                    }
                }

                Monitor.Exit(_UpdateLock);
            }
        }
        #endregion RefreshPerformanceData

        #region WritePerformanceDataToStream
        protected virtual void WritePerformanceDataToStream()
        {
            byte[] performanceDataByteArray = PerformanceData.Serialize();
            BergNamedPipeClient.Write(performanceDataByteArray);
        }
        #endregion WritePerformanceDataToStream
        #endregion Methods..
    }
}
