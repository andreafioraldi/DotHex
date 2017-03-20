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
using System.Drawing;
using System.Runtime.InteropServices;

namespace Be.Windows.Forms
{
	internal static class NativeMethods
	{
		// Caret definitions
		[DllImport("user32.dll", SetLastError=true)]
		public static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

		[DllImport("user32.dll", SetLastError=true)]
		public static extern bool ShowCaret(IntPtr hWnd);

		[DllImport("user32.dll", SetLastError=true)]
		public static extern bool DestroyCaret();

		[DllImport("user32.dll", SetLastError=true)]
		public static extern bool SetCaretPos(int X, int Y);

		// Key definitions
		public const int WM_KEYDOWN = 0x100;
		public const int WM_KEYUP = 0x101;
		public const int WM_CHAR = 0x102;
	}
}
