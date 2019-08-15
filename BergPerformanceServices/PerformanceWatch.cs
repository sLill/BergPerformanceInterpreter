﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BergPerformanceServices
{
    public class PerformanceWatch
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Properties..
        public string Name { get; private set; }
        #endregion Properties..

        #region Constructors..
        #region PerformanceWatch
        private PerformanceWatch()
        {
        }
        #endregion PerformanceWatch

        #region PerformanceWatch
        public PerformanceWatch(string name)
        {
            Name = name;
        }
        #endregion PerformanceWatch
        #endregion Constructors..

        #region Methods..
        #region Deserialize
        public static PerformanceWatch Deserialize(byte[] data)
        {
            PerformanceWatch Result = new PerformanceWatch();

            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                using (BinaryReader reader = new BinaryReader(memoryStream))
                {
                    Result.Name = reader.ReadString();
                }
            }

            return Result;
        }
        #endregion Deserialize

        #region Serialize
        public byte[] Serialize()
        {
            byte[] Result;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(memoryStream))
                {
                    writer.Write(Name);
                }

                Result = memoryStream.ToArray();
            }

            return Result;
        }
        #endregion Serialize
        #endregion Methods..
    }
}
