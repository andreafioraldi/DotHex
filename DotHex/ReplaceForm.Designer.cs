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
    partial class ReplaceForm
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
            this.caseBox = new System.Windows.Forms.CheckBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.findHexBox = new Be.Windows.Forms.HexBox();
            this.replHexBox = new Be.Windows.Forms.HexBox();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.replaceAllBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // caseBox
            // 
            this.caseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.caseBox.AutoSize = true;
            this.caseBox.Location = new System.Drawing.Point(3, 8);
            this.caseBox.Name = "caseBox";
            this.caseBox.Size = new System.Drawing.Size(102, 17);
            this.caseBox.TabIndex = 8;
            this.caseBox.Text = "Case insensitive";
            this.caseBox.UseVisualStyleBackColor = true;
            this.caseBox.CheckedChanged += new System.EventHandler(this.caseBox_CheckedChanged);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(309, 31);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeBtn.Location = new System.Drawing.Point(3, 31);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // replaceBtn
            // 
            this.replaceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceBtn.Location = new System.Drawing.Point(228, 31);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(75, 23);
            this.replaceBtn.TabIndex = 11;
            this.replaceBtn.Text = "Replace";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // replaceAllBtn
            // 
            this.replaceAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceAllBtn.Location = new System.Drawing.Point(147, 31);
            this.replaceAllBtn.Name = "replaceAllBtn";
            this.replaceAllBtn.Size = new System.Drawing.Size(75, 23);
            this.replaceAllBtn.TabIndex = 12;
            this.replaceAllBtn.Text = "Replace all";
            this.replaceAllBtn.UseVisualStyleBackColor = true;
            this.replaceAllBtn.Click += new System.EventHandler(this.replaceAllBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.findHexBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.replHexBox);
            this.splitContainer1.Size = new System.Drawing.Size(387, 212);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.caseBox);
            this.panel1.Controls.Add(this.replaceAllBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.replaceBtn);
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 57);
            this.panel1.TabIndex = 14;
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 269);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(403, 285);
            this.Name = "ReplaceForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ReplaceForm";
            this.TopMost = true;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox caseBox;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.Button replaceAllBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
    }
}