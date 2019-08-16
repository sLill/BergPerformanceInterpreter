using BergCommon;
using BergDataServices;
using System.Threading.Tasks;

namespace BergPerformanceServices
{
    public class BergCpuMonitor : BergMonitor
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #region BergCpuMonitor
        public BergCpuMonitor(int updateInterval)
            : base (updateInterval)
        {
            InitializeData();
        }
        #endregion BergCpuMonitor

        #region BergCpuMonitor
        internal BergCpuMonitor(int updateInterval, bool isHost, bool useLocalDataSource)
            : base(updateInterval)
        {
            _IsHost = isHost;
            _UseLocalDataSource = useLocalDataSource;

            InitializeData();
        }
        #endregion BergCpuMonitor
        #endregion Constructors..

        #region Methods..
        #region BeginWatch
        public void BeginWatch(string name)
        {
            ((CpuPerformanceData)PerformanceData).PerformanceWatchCollection[name] = new PerformanceWatch()
            {
                Active = true,
                Name = name
            };
        }
        #endregion BeginWatch

        #region EndWatch
        public void EndWatch(string name)
        {
            ((CpuPerformanceData)PerformanceData).PerformanceWatchCollection[name].Active = false;
        }
        #endregion EndWatch

        #region InitializeData
        public void InitializeData()
        {
            PerformanceData = new CpuPerformanceData();

            if (_IsHost && !_UseLocalDataSource)
            {
                // Initialize from stream
                using (BergNamedPipeServer bergNamedPipeServer = new BergNamedPipeServer())
                {
                    // Dedicates a new thread to listening explicitly for writes to the Berg named pipe
                    Task.Run(() =>
                    {
                        while (true)
                        {
                            byte[] performanceDataByteArray = bergNamedPipeServer.Read();
                            PerformanceData = (CpuPerformanceData)BergPerformanceData.Deserialize(performanceDataByteArray);
                            PerformanceDataUpdated();
                        }
                    });
                }
            }
            else
            {
                PerformanceData.Initialize();
            }
        }
        #endregion InitializeData
        #endregion Methods..
    }
}
