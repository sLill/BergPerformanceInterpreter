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

        #region ListenContinuously
        public void ListenContinuously()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    using (NamedPipeServerStream namedPipeServer = new NamedPipeServerStream("BergNamedPipe5", PipeDirection.InOut, 4))
                    {
                        await namedPipeServer.WaitForConnectionAsync();
                        await Task.Run(() => Console.WriteLine(namedPipeServer.ReadByte()));
                    }
                }
            });
        }
        #endregion ListenContinuously
        #endregion Methods..
    }
}
