//Copyright(c) 2011 Bernhard Elbl

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in
//all copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//THE SOFTWARE.

using System;

namespace Be.Windows.Forms
{
    internal sealed class MemoryDataBlock : DataBlock
    {
        byte[] _data;

        public MemoryDataBlock(byte data)
        {
            _data = new byte[] { data };
        }

        public MemoryDataBlock(byte[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            _data = (byte[])data.Clone();
        }

        public override long Length
        {
            get
            {
                return _data.LongLength;
            }
        }

        public byte[] Data
        {
            get
            {
                return _data;
            }
        }

        public void AddByteToEnd(byte value)
        {
            byte[] newData = new byte[_data.LongLength + 1];
            _data.CopyTo(newData, 0);
            newData[newData.LongLength - 1] = value;
            _data = newData;
        }

        public void AddByteToStart(byte value)
        {
            byte[] newData = new byte[_data.LongLength + 1];
            newData[0] = value;
            _data.CopyTo(newData, 1);
            _data = newData;
        }

        public void InsertBytes(long position, byte[] data)
        {
            byte[] newData = new byte[_data.LongLength + data.LongLength];
            if (position > 0)
            {
                Array.Copy(_data, 0, newData, 0, position);
            }
            Array.Copy(data, 0, newData, position, data.LongLength);
            if (position < _data.LongLength)
            {
                Array.Copy(_data, position, newData, position + data.LongLength, _data.LongLength - position);
            }
            _data = newData;
        }

        public override void RemoveBytes(long position, long count)
        {
            byte[] newData = new byte[_data.LongLength - count];

            if (position > 0)
            {
                Array.Copy(_data, 0, newData, 0, position);
            }
            if (position + count < _data.LongLength)
            {
                Array.Copy(_data, position + count, newData, position, newData.LongLength - position);
            }

            _data = newData;
        }
    }
}
