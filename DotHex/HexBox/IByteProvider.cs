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
	/// <summary>
	/// Defines a byte provider for HexBox control
	/// </summary>
	public interface IByteProvider
	{
		/// <summary>
		/// Reads a byte from the provider
		/// </summary>
		/// <param name="index">the index of the byte to read</param>
		/// <returns>the byte to read</returns>
		byte ReadByte(long index);
		/// <summary>
		/// Writes a byte into the provider
		/// </summary>
		/// <param name="index">the index of the byte to write</param>
		/// <param name="value">the byte to write</param>
		void WriteByte(long index, byte value);
		/// <summary>
		/// Inserts bytes into the provider
		/// </summary>
		/// <param name="index"></param>
		/// <param name="bs"></param>
		/// <remarks>This method must raise the LengthChanged event.</remarks>
		void InsertBytes(long index, byte[] bs);
		/// <summary>
		/// Deletes bytes from the provider
		/// </summary>
		/// <param name="index">the start index of the bytes to delete</param>
		/// <param name="length">the length of the bytes to delete</param>
		/// <remarks>This method must raise the LengthChanged event.</remarks>
		void DeleteBytes(long index, long length);

		/// <summary>
		/// Returns the total length of bytes the byte provider is providing.
		/// </summary>
        long Length { get; }
		/// <summary>
		/// Occurs, when the Length property changed.
		/// </summary>
		event EventHandler LengthChanged;

		/// <summary>
		/// True, when changes are done.
		/// </summary>
		bool HasChanges();
		/// <summary>
		/// Applies changes.
		/// </summary>
		void ApplyChanges();
		/// <summary>
		/// Occurs, when bytes are changed.
		/// </summary>
		event EventHandler Changed;

		/// <summary>
		/// Returns a value if the WriteByte methods is supported by the provider.
		/// </summary>
		/// <returns>True, when it´s supported.</returns>
		bool SupportsWriteByte();
		/// <summary>
		/// Returns a value if the InsertBytes methods is supported by the provider.
		/// </summary>
		/// <returns>True, when it´s supported.</returns>
		bool SupportsInsertBytes();
		/// <summary>
		/// Returns a value if the DeleteBytes methods is supported by the provider.
		/// </summary>
		/// <returns>True, when it´s supported.</returns>
		bool SupportsDeleteBytes();
	}
}
