using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotHex
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    long num = Convert.ToInt64(textBox1.Text);
                    textBox2.Text = Convert.ToString(num, 16);
                    textBox3.Text = Convert.ToString(num, 8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    long num = Convert.ToInt64(textBox2.Text, 16);
                    textBox1.Text = Convert.ToString(num);
                    textBox3.Text = Convert.ToString(num, 8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    long num = Convert.ToInt64(textBox3.Text, 8);
                    textBox1.Text = Convert.ToString(num);
                    textBox2.Text = Convert.ToString(num, 16);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
