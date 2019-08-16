using System;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace BergDataServices
{
    public class BergNamedPipeClient
    {
        #region Member Variables..
        private string _PipeName = "BergNamedPipe7";
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #endregion Constructors..

        #region Methods..
        #region Write
        public void Write(byte[] buffer)
        {
            using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(_PipeName))
            {
                try
                {
                    namedPipeClientStream.Connect(1000);
                    namedPipeClientStream.Write(buffer, 0, buffer.Length);

                    Console.WriteLine($"Wrote {buffer.Length} bytes");
                }
                catch
                {
                    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} Timed Out");
                }
            }
        }
        #endregion Write

        #region WriteByteAsync
        public async void WriteByteAsync(byte value)
        {
            using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(_PipeName))
            {               
                await namedPipeClientStream.ConnectAsync();
                await Task.Run(() => namedPipeClientStream.WriteByte(value)).ConfigureAwait(false);
            }
        }
        #endregion WriteByteAsync

        #endregion Methods..
    }
}
