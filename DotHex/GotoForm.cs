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
    public partial class GotoForm : Form
    {
        private HexBox hexBox;

        public GotoForm(HexBox hexBox)
        {
            InitializeComponent();
            this.hexBox = hexBox;
        }

        private void Goto()
        {
            uint pos;
            try
            {
                pos = Convert.ToUInt32(textBox1.Text, 10);
            }
            catch(Exception e0)
            {
                try
                {
                    pos = Convert.ToUInt32(textBox1.Text, 16);
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Insert a valid offset!\n" + e1.Message);
                    return;
                }
            }

            if (pos < hexBox.ByteProvider.Length)
            {
                hexBox.SelectionStart = pos;
                hexBox.SelectionLength = 1;
            }
            else MessageBox.Show("Insert a valid offset!\nValue greater than file length.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Goto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Goto();
            }
        }
    }
}
