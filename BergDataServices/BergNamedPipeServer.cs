﻿using System;
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
            List<byte> Result = new List<byte>();
            using (NamedPipeServerStream namedPipeServerStream = new NamedPipeServerStream(_PipeName, PipeDirection.InOut, 1))
            {
                try
                {
                    namedPipeServerStream.WaitForConnection();

                    byte[] byteBlock = new byte[4096];
                    while (namedPipeServerStream.Read(byteBlock, 0, byteBlock.Length) > 0)
                    {
                        Result.AddRange(byteBlock);
                    }
                }
                catch
                {
                    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} Timed Out");
                }
            }

            return Result.ToArray();
        }
        #endregion Read
        #endregion Methods..
    }
}
