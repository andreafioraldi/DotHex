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
using System.Collections.Generic;
using System.Text;

namespace Be.Windows.Forms
{
	/// <summary>
	/// Defines the type of the Find operation.
	/// </summary>
	public enum FindType 
	{ 
		/// <summary>
		/// Used for Text Find operations
		/// </summary>
		Text, 
		/// <summary>
		/// Used for Hex Find operations
		/// </summary>
		Hex 
	}

	/// <summary>
	/// Defines all state information nee
	/// </summary>
	public class FindOptions
	{
		/// <summary>
		/// Gets or sets whether the Find options are valid
		/// </summary>
		public bool IsValid { get; set; }
		/// <summary>
		/// Gets the Find buffer used for case insensitive Find operations. This is the binary representation of Text.
		/// </summary>
		internal byte[] FindBuffer { get; private set; }
		/// <summary>
		/// Gets the Find buffer used for case sensitive Find operations. This is the binary representation of Text in lower case format.
		/// </summary>
		internal byte[] FindBufferLowerCase { get; private set; }
		/// <summary>
		/// Gets the Find buffer used for case sensitive Find operations. This is the binary representation of Text in upper case format.
		/// </summary>
		internal byte[] FindBufferUpperCase { get; private set; }
		/// <summary>
		/// Contains the MatchCase value
		/// </summary>
		bool _matchCase;
		/// <summary>
		/// Gets or sets the value, whether the Find operation is case sensitive or not.
		/// </summary>
		public bool MatchCase
		{
			get { return _matchCase; }
			set
			{
				_matchCase = value;
				UpdateFindBuffer();
			}
		}
		/// <summary>
		/// Contains the text that should be found.
		/// </summary>
		string _text;
		/// <summary>
		/// Gets or sets the text that should be found. Only used, when Type is FindType.Hex.
		/// </summary>
		public string Text
		{
			get { return _text; }
			set
			{
				_text = value;
				UpdateFindBuffer();
			}
		}
		/// <summary>
		/// Gets or sets the hex buffer that should be found. Only used, when Type is FindType.Hex.
		/// </summary>
		public byte[] Hex { get; set; }
		/// <summary>
		/// Gets or sets the type what should be searched.
		/// </summary>
		public FindType Type { get; set; }
		/// <summary>
		/// Updates the find buffer.
		/// </summary>
		void UpdateFindBuffer()
		{
			string text = this.Text != null ? this.Text : string.Empty;
			FindBuffer = ASCIIEncoding.ASCII.GetBytes(text);
			FindBufferLowerCase = ASCIIEncoding.ASCII.GetBytes(text.ToLower());
			FindBufferUpperCase = ASCIIEncoding.ASCII.GetBytes(text.ToUpper());
		}
}
}
