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

namespace DotHex
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.caseBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.findHexBox = new Be.Windows.Forms.HexBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(159, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(240, 4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // caseBox
            // 
            this.caseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.caseBox.AutoSize = true;
            this.caseBox.Location = new System.Drawing.Point(3, 10);
            this.caseBox.Name = "caseBox";
            this.caseBox.Size = new System.Drawing.Size(102, 17);
            this.caseBox.TabIndex = 4;
            this.caseBox.Text = "Case insensitive";
            this.caseBox.UseVisualStyleBackColor = true;
            this.caseBox.CheckedChanged += new System.EventHandler(this.caseBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.caseBox);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 31);
            this.panel1.TabIndex = 5;
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
            this.findHexBox.Size = new System.Drawing.Size(318, 155);
            this.findHexBox.StringViewVisible = true;
            this.findHexBox.TabIndex = 0;
            this.findHexBox.VScrollBarVisible = true;
            this.findHexBox.TextChanged += new System.EventHandler(this.findHexBox_TextChanged);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 186);
            this.ControlBox = false;
            this.Controls.Add(this.findHexBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(334, 202);
            this.Name = "FindForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Find";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Be.Windows.Forms.HexBox findHexBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.CheckBox caseBox;
        private System.Windows.Forms.Panel panel1;
    }
}