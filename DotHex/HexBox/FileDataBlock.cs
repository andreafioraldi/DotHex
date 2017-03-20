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
    internal sealed class FileDataBlock : DataBlock
    {
        long _length;
        long _fileOffset;

        public FileDataBlock(long fileOffset, long length)
        {
            _fileOffset = fileOffset;
            _length = length;
        }

        public long FileOffset
        {
            get
            {
                return _fileOffset;
            }
        }

        public override long Length
        {
            get
            {
                return _length;
            }
        }

        public void SetFileOffset(long value)
        {
            _fileOffset = value;
        }

        public void RemoveBytesFromEnd(long count)
        {
            if (count > _length)
            {
                throw new ArgumentOutOfRangeException("count");
            }

            _length -= count;
        }

        public void RemoveBytesFromStart(long count)
        {
            if (count > _length)
            {
                throw new ArgumentOutOfRangeException("count");
            }

            _fileOffset += count;
            _length -= count;
        }

        public override void RemoveBytes(long position, long count)
        {
            if (position > _length)
            {
                throw new ArgumentOutOfRangeException("position");
            }

            if (position + count > _length)
            {
                throw new ArgumentOutOfRangeException("count");
            }

            long prefixLength = position;
            long prefixFileOffset = _fileOffset;

            long suffixLength = _length - count - prefixLength;
            long suffixFileOffset = _fileOffset + position + count;

            if (prefixLength > 0 && suffixLength > 0)
            {
                _fileOffset = prefixFileOffset;
                _length = prefixLength;
                _map.AddAfter(this, new FileDataBlock(suffixFileOffset, suffixLength));
                return;
            }

            if (prefixLength > 0)
            {
                _fileOffset = prefixFileOffset;
                _length = prefixLength;
            }
            else
            {
                _fileOffset = suffixFileOffset;
                _length = suffixLength;
            }
        }
    }
}
