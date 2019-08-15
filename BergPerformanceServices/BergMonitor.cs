using BergDataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        public BergNamedPipeClient BergNamedPipeClient;

        public BergPerformanceData PerformanceData { get; protected set; }
        #endregion Properties..

        #region Constructors..
        #region BergMonitor
        public BergMonitor(int updateInterval)
        {
            _UpdateInterval = updateInterval;
            BergNamedPipeClient = new BergNamedPipeClient();
            _UpdateTimer = new Timer(RefreshPerformanceData, new AutoResetEvent(true), 0, _UpdateInterval);
        }
        #endregion BergMonitor
        #endregion Constructors..

        #region Methods..
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
