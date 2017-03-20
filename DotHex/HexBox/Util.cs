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
    static class Util
    {
        /// <summary>
        /// Contains true, if we are in design mode of Visual Studio
        /// </summary>
        private static bool _designMode;

        /// <summary>
        /// Initializes an instance of Util class
        /// </summary>
        static Util()
        {
            // design mode is true if host process is: Visual Studio, Visual Studio Express Versions (C#, VB, C++) or SharpDevelop
            var designerHosts = new List<string>() { "devenv", "vcsexpress", "vbexpress", "vcexpress", "sharpdevelop" };
            using (var process = System.Diagnostics.Process.GetCurrentProcess())
            {
                var processName = process.ProcessName.ToLower();
                _designMode = designerHosts.Contains(processName);
            }
        }

        /// <summary>
        /// Gets true, if we are in design mode of Visual Studio
        /// </summary>
        /// <remarks>
        /// In Visual Studio 2008 SP1 the designer is crashing sometimes on windows forms. 
        /// The DesignMode property of Control class is buggy and cannot be used, so use our own implementation instead.
        /// </remarks>
        public static bool DesignMode
        {
            get
            {
                return _designMode;
            }
        }

    }
}
