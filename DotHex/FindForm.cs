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
using System.Drawing;

namespace DotHex
{
    public partial class FindForm : Form
    {
        private HexBox findHexBox;

        private HexBox hexBox;
        private FindOptions findOptions = new FindOptions();

        public FindForm(HexBox hexBox)
        {
            InitializeComponent();

            findHexBox.BackColor = SystemColors.Window;
            findHexBox.Dock = DockStyle.Fill;
            findHexBox.Font = new Font("Segoe UI", 9F);
            findHexBox.Location = new Point(0, 0);
            findHexBox.Name = "findHexBox";
            findHexBox.SelectionBackColor = SystemColors.Highlight;
            findHexBox.ShadowSelectionColor = Color.FromArgb(100, 60, 188, 255);
            findHexBox.Size = new Size(318, 155);
            findHexBox.StringViewVisible = true;
            findHexBox.TabIndex = 0;
            findHexBox.VScrollBarVisible = true;

            Controls.Add(findHexBox);

            this.hexBox = hexBox;
            findHexBox.ByteProvider = new DynamicByteProvider(new byte[] { });
            findOptions.Type = FindType.Hex;
        }

        public void Next()
        {
            findOptions.Hex = new byte[findHexBox.ByteProvider.Length];
            for (long i = 0; i < findHexBox.ByteProvider.Length; ++i)
            {
                findOptions.Hex[i] = findHexBox.ByteProvider.ReadByte(i);
            }

            long pos = hexBox.Find(findOptions);
            if (pos == -1)
            {
                MessageBox.Show("Pattern not found.");
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void caseBox_CheckedChanged(object sender, EventArgs e)
        {
            findOptions.MatchCase = !caseBox.Enabled;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
