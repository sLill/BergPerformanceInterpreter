using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;

namespace BergDataServices
{
    public class BergNamedPipeClient
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #endregion Constructors..

        #region Methods..
        #region WriteByteAsync
        public async void WriteByteAsync(byte value)
        {
            using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream("BergNamedPipe5"))
            {
                await namedPipeClientStream.ConnectAsync();
                await Task.Run(() => namedPipeClientStream.WriteByte(value)).ConfigureAwait(false);
            }
        }
        #endregion WriteByteAsync

        #endregion Methods..
    }
}
