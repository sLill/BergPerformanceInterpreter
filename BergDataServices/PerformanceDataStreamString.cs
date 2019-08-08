using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BergDataServices
{
    public class PerformanceDataStreamString
    {
        #region Member Variables..
        private Stream _IOStream;
        private UnicodeEncoding _StreamEncoding;
        #endregion Member Variables..

        #region Properties..
        #endregion Properties..

        #region Constructors..
        #region PerformanceDataStreamString
        public PerformanceDataStreamString(Stream ioStream)
        {
            this._IOStream = ioStream;
            _StreamEncoding = new UnicodeEncoding();
        }
        #endregion Constructors.. 
        #endregion PerformanceDataStreamString

        #region Methods..
        #region ReadString
        public string ReadString()
        {
            int ByteLength = 0;
            ByteLength = _IOStream.ReadByte() * 256;
            ByteLength += _IOStream.ReadByte();

            byte[] inBuffer = new byte[ByteLength];
            _IOStream.Read(inBuffer, 0, ByteLength);

            return _StreamEncoding.GetString(inBuffer);
        }
        #endregion ReadString

        #region WriteString
        public int WriteString(string dataString)
        {
            byte[] OutputBuffer = _StreamEncoding.GetBytes(dataString);
            int BufferLength = OutputBuffer.Length;

            if (BufferLength > UInt16.MaxValue)
            {
                BufferLength = (int)UInt16.MaxValue;
            }

            _IOStream.WriteByte((byte)(BufferLength / 256));
            _IOStream.WriteByte((byte)(BufferLength & 255));
            _IOStream.Write(OutputBuffer, 0, BufferLength);
            _IOStream.Flush();

            return OutputBuffer.Length + 2;
        }
        #endregion WriteString
        #endregion Methods..
    }
}
