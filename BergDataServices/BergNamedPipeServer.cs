using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BergDataServices
{
    public class BergNamedPipeServer
    {
        #region Member Variables..
        private NamedPipeServerStream _NamedPipeServerStream;
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #region BergNamedPipeServer
        public BergNamedPipeServer()
        {
            _NamedPipeServerStream = new NamedPipeServerStream("BergPipeServer", PipeDirection.InOut, 4);
            //BergPipeServer.BeginWaitForConnection();
            int threadId = Thread.CurrentThread.ManagedThreadId;
            _NamedPipeServerStream.WaitForConnection();

            Console.WriteLine("Client connected on thread[{0}].", threadId);
            try
            {
                // Read the request from the client. Once the client has
                // written to the pipe its security token will be available.

                PerformanceDataStreamString ss = new PerformanceDataStreamString(_NamedPipeServerStream);

                // Verify our identity to the connected client using a
                // string that the client anticipates.

                ss.WriteString("I am the one true server!");
                string filename = ss.ReadString();

                // Read in the contents of the file while impersonating the client.
                //ReadFileToStream fileReader = new ReadFileToStream(ss, filename);

                //// Display the name of the user we are impersonating.
                //Console.WriteLine("Reading file: {0} on thread[{1}] as user: {2}.",
                //    filename, threadId, BergPipeServer.GetImpersonationUserName());
                //BergPipeServer.RunAsClient(fileReader.Start);
            }
            // Catch the IOException that is raised if the pipe is broken
            // or disconnected.
            catch (IOException e)
            {
                Console.WriteLine("ERROR: {0}", e.Message);
            }
            _NamedPipeServerStream.Close();
        }
        #endregion BergNamedPipeServer
        #endregion Constructors..

        #region Methods..
        #endregion Methods..
    }
}
