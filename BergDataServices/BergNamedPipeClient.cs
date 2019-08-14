using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.Threading;

namespace BergDataServices
{
    public class BergNamedPipeClient
    {
        #region Member Variables..
        private string _PipeName = "BergNamedPipe5";
        private object _WriteLock = new object();
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #endregion Constructors..

        #region Methods..
        #region WriteAsync
        public void WriteAsync(byte[] buffer)
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
        #endregion WriteAsync

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
