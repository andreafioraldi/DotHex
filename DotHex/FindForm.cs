//Copyright 2017 Andrea Fioraldi <andreafioraldi@gmail.com>

//DotHex is free software; you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation; either version 3 of the License, or
//(at your option) any later version.

//Stout Compiler is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
//MA 02110-1301, USA.

using Be.Windows.Forms;
using System;
using System.Windows.Forms;

namespace DotHex
{
    public partial class FindForm : Form
    {
        private HexBox hexBox;
        private FindOptions findOptions = new FindOptions();
        private bool changed = true;

        public FindForm(HexBox hexBox)
        {
            InitializeComponent();
            this.hexBox = hexBox;
            findHexBox.ByteProvider = new DynamicByteProvider(new byte[] { });
            findOptions.Type = FindType.Hex;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                findOptions.Hex = new byte[findHexBox.ByteProvider.Length];
                for (long i = 0; i < findHexBox.ByteProvider.Length; ++i)
                {
                    findOptions.Hex[i] = findHexBox.ByteProvider.ReadByte(i);
                }
                changed = false;
            }

            long pos = hexBox.Find(findOptions);
            if(pos == -1)
            {
                MessageBox.Show("Pattern not found.");
            }
        }

        private void caseBox_CheckedChanged(object sender, EventArgs e)
        {
            findOptions.MatchCase = !caseBox.Enabled;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void findHexBox_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }
    }
}
