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
    public partial class ReplaceForm : Form
    {
        private Be.Windows.Forms.HexBox findHexBox;
        private Be.Windows.Forms.HexBox replHexBox;

        private HexBox hexBox;
        private FindOptions findOptions = new FindOptions();
        private bool findChanged = true;
        private bool replChanged = true;
        private byte[] replBytes = new byte[] { };

        public ReplaceForm(HexBox hexBox)
        {
            InitializeComponent();
            // 
            // findHexBox
            // 
            this.findHexBox.BackColor = System.Drawing.SystemColors.Window;
            this.findHexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findHexBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.findHexBox.Location = new System.Drawing.Point(0, 0);
            this.findHexBox.Name = "findHexBox";
            this.findHexBox.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.findHexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.findHexBox.Size = new System.Drawing.Size(387, 106);
            this.findHexBox.StringViewVisible = true;
            this.findHexBox.TabIndex = 5;
            this.findHexBox.VScrollBarVisible = true;
            this.findHexBox.TextChanged += new System.EventHandler(this.findHexBox_TextChanged);
            // 
            // replHexBox
            // 
            this.replHexBox.BackColor = System.Drawing.SystemColors.Window;
            this.replHexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replHexBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replHexBox.Location = new System.Drawing.Point(0, 0);
            this.replHexBox.Name = "replHexBox";
            this.replHexBox.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.replHexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.replHexBox.Size = new System.Drawing.Size(387, 102);
            this.replHexBox.StringViewVisible = true;
            this.replHexBox.TabIndex = 9;
            this.replHexBox.VScrollBarVisible = true;
            this.replHexBox.TextChanged += new System.EventHandler(this.replHexBox_TextChanged);

            this.hexBox = hexBox;
            findHexBox.ByteProvider = new DynamicByteProvider(new byte[] { });
            replHexBox.ByteProvider = new DynamicByteProvider(replBytes);
            findOptions.Type = FindType.Hex;
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void caseBox_CheckedChanged(object sender, EventArgs e)
        {
            findOptions.MatchCase = !caseBox.Checked;
        }

        private long Next()
        {
            if (findChanged)
            {
                findOptions.Hex = new byte[findHexBox.ByteProvider.Length];
                for (long i = 0; i < findHexBox.ByteProvider.Length; ++i)
                {
                    findOptions.Hex[i] = findHexBox.ByteProvider.ReadByte(i);
                }
                findChanged = false;
            }

            return hexBox.Find(findOptions);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if(Next() == -1)
            {
                MessageBox.Show("Pattern not found.");
            }
        }

        private void Replace()
        {
            if (replChanged)
            {
                replBytes = new byte[replHexBox.ByteProvider.Length];
                for (long i = 0; i < replHexBox.ByteProvider.Length; ++i)
                {
                    replBytes[i] = replHexBox.ByteProvider.ReadByte(i);
                }
                replChanged = false;
            }

            long start = hexBox.SelectionStart;
            hexBox.ByteProvider.DeleteBytes(start, hexBox.SelectionLength);
            hexBox.ByteProvider.InsertBytes(start, replBytes);
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            Replace();
            Next();
        }

        private void findHexBox_TextChanged(object sender, EventArgs e)
        {
            findChanged = true;
        }

        private void replHexBox_TextChanged(object sender, EventArgs e)
        {
            replChanged = true;
        }

        private void replaceAllBtn_Click(object sender, EventArgs e)
        {
            while (Next() != -1)
                Replace();
        }
    }
}
