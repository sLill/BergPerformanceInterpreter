using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BergDataServices
{
    public class BergNamedPipeServer : IDisposable
    {
        #region Member Variables..
        private string _PipeName = "BergNamedPipe5";
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #endregion Constructors..

        #region Methods..
        #region Dispose
        public void Dispose()
        {

        }
        #endregion Dispose
        #region Read
        public byte[] Read()
        {
            byte[] Result = null;

            using (NamedPipeServerStream namedPipeServer = new NamedPipeServerStream(_PipeName, PipeDirection.InOut, 1))
            {
                try
                {
                    namedPipeServer.WaitForConnection();

                    using (StreamReader reader = new StreamReader(namedPipeServer))
                    {
                        Result = Encoding.ASCII.GetBytes(reader.ReadToEnd());
                    }
                }
                catch
                {
                    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} Timed Out");
                }
            }

            return Result;
        }
        #endregion Read
        #endregion Methods..
    }
}
