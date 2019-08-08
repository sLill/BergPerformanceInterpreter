using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BergDataServices
{
    public class BergNamedPipeClient
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #region BergNamedPipeClient
        public BergNamedPipeClient()
        {
            //using (NamedPipeClientStream pipeClient =
            //new NamedPipeClientStream(".", "testpipe", PipeDirection.In))
            //{

            //    // Connect to the pipe or wait until the pipe is available.
            //    Console.Write("Attempting to connect to pipe...");
            //    pipeClient.Connect();

            //    Console.WriteLine("Connected to pipe.");
            //    Console.WriteLine("There are currently {0} pipe server instances open.",
            //       pipeClient.NumberOfServerInstances);
            //    using (StreamReader sr = new StreamReader(pipeClient))
            //    {
            //        // Display the read text to the console
            //        string temp;
            //        while ((temp = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine("Received from server: {0}", temp);
            //        }
            //    }
            //}
        }
        #endregion BergNamedPipeClient
        #endregion Constructors..

        #region Methods..

        #endregion Methods..
    }
}
