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
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EditPage = new System.Windows.Forms.TabPage();
            this.StringsPage = new System.Windows.Forms.TabPage();
            this.stringsList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveListBtn = new System.Windows.Forms.Button();
            this.searchStrBtn = new System.Windows.Forms.Button();
            this.alphanumAsciiBox = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.extAsciiBox = new System.Windows.Forms.RadioButton();
            this.strMinimumBox = new System.Windows.Forms.NumericUpDown();
            this.AsciiBox = new System.Windows.Forms.RadioButton();
            this.Interpretation = new System.Windows.Forms.TabPage();
            this.calcUTFnBinBox = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.unicodeBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.f64Box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.f32Box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.binBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.u64Box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.i64Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.u8Box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.i8Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.u32Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.i32Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.u16Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.littleEndianBox = new System.Windows.Forms.CheckBox();
            this.i16Box = new System.Windows.Forms.TextBox();
            this.selectedLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.menuSaveAs = new System.Windows.Forms.MenuItem();
            this.menuReset = new System.Windows.Forms.MenuItem();
            this.menuClose = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuEdit = new System.Windows.Forms.MenuItem();
            this.menuCut = new System.Windows.Forms.MenuItem();
            this.menuCopy = new System.Windows.Forms.MenuItem();
            this.menuPaste = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuCopyHex = new System.Windows.Forms.MenuItem();
            this.menuSelectAll = new System.Windows.Forms.MenuItem();
            this.menuDelete = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuFind = new System.Windows.Forms.MenuItem();
            this.menuFindNext = new System.Windows.Forms.MenuItem();
            this.menuReplace = new System.Windows.Forms.MenuItem();
            this.menuGoto = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuInsert = new System.Windows.Forms.MenuItem();
            this.menuTools = new System.Windows.Forms.MenuItem();
            this.menuCalculator = new System.Windows.Forms.MenuItem();
            this.menuConverter = new System.Windows.Forms.MenuItem();
            this.menuInfo = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.menuLicense = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dragDropLbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.StringsPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strMinimumBox)).BeginInit();
            this.Interpretation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.EditPage);
            this.tabControl1.Controls.Add(this.StringsPage);
            this.tabControl1.Controls.Add(this.Interpretation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 327);
            this.tabControl1.TabIndex = 1;
            // 
            // EditPage
            // 
            this.EditPage.Location = new System.Drawing.Point(4, 25);
            this.EditPage.Name = "EditPage";
            this.EditPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditPage.Size = new System.Drawing.Size(526, 298);
            this.EditPage.TabIndex = 0;
            this.EditPage.Text = "Editor";
            this.EditPage.UseVisualStyleBackColor = true;
            // 
            // StringsPage
            // 
            this.StringsPage.Controls.Add(this.stringsList);
            this.StringsPage.Controls.Add(this.panel1);
            this.StringsPage.Location = new System.Drawing.Point(4, 25);
            this.StringsPage.Name = "StringsPage";
            this.StringsPage.Padding = new System.Windows.Forms.Padding(3);
            this.StringsPage.Size = new System.Drawing.Size(526, 298);
            this.StringsPage.TabIndex = 1;
            this.StringsPage.Text = "Strings";
            this.StringsPage.UseVisualStyleBackColor = true;
            // 
            // stringsList
            // 
            this.stringsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stringsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stringsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringsList.FormattingEnabled = true;
            this.stringsList.ItemHeight = 18;
            this.stringsList.Location = new System.Drawing.Point(3, 54);
            this.stringsList.Name = "stringsList";
            this.stringsList.Size = new System.Drawing.Size(520, 241);
            this.stringsList.TabIndex = 6;
            this.stringsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.stringsList_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveListBtn);
            this.panel1.Controls.Add(this.searchStrBtn);
            this.panel1.Controls.Add(this.alphanumAsciiBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.extAsciiBox);
            this.panel1.Controls.Add(this.strMinimumBox);
            this.panel1.Controls.Add(this.AsciiBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 51);
            this.panel1.TabIndex = 11;
            // 
            // saveListBtn
            // 
            this.saveListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveListBtn.Location = new System.Drawing.Point(442, 3);
            this.saveListBtn.Name = "saveListBtn";
            this.saveListBtn.Size = new System.Drawing.Size(73, 23);
            this.saveListBtn.TabIndex = 11;
            this.saveListBtn.Text = "Save list";
            this.saveListBtn.UseVisualStyleBackColor = true;
            this.saveListBtn.Click += new System.EventHandler(this.saveListBtn_Click);
            // 
            // searchStrBtn
            // 
            this.searchStrBtn.Location = new System.Drawing.Point(3, 3);
            this.searchStrBtn.Name = "searchStrBtn";
            this.searchStrBtn.Size = new System.Drawing.Size(92, 23);
            this.searchStrBtn.TabIndex = 0;
            this.searchStrBtn.Text = "Search strings";
            this.searchStrBtn.UseVisualStyleBackColor = true;
            this.searchStrBtn.Click += new System.EventHandler(this.searchStrBtn_Click);
            // 
            // alphanumAsciiBox
            // 
            this.alphanumAsciiBox.AutoSize = true;
            this.alphanumAsciiBox.Checked = true;
            this.alphanumAsciiBox.Location = new System.Drawing.Point(174, 29);
            this.alphanumAsciiBox.Name = "alphanumAsciiBox";
            this.alphanumAsciiBox.Size = new System.Drawing.Size(135, 17);
            this.alphanumAsciiBox.TabIndex = 10;
            this.alphanumAsciiBox.TabStop = true;
            this.alphanumAsciiBox.Text = "ASCII - only _0-9A-Za-z";
            this.alphanumAsciiBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum number of characters:";
            // 
            // extAsciiBox
            // 
            this.extAsciiBox.AutoSize = true;
            this.extAsciiBox.Location = new System.Drawing.Point(68, 29);
            this.extAsciiBox.Name = "extAsciiBox";
            this.extAsciiBox.Size = new System.Drawing.Size(100, 17);
            this.extAsciiBox.TabIndex = 9;
            this.extAsciiBox.Text = "Extended ASCII";
            this.extAsciiBox.UseVisualStyleBackColor = true;
            // 
            // strMinimumBox
            // 
            this.strMinimumBox.Location = new System.Drawing.Point(275, 6);
            this.strMinimumBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.strMinimumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.strMinimumBox.Name = "strMinimumBox";
            this.strMinimumBox.Size = new System.Drawing.Size(51, 20);
            this.strMinimumBox.TabIndex = 4;
            this.strMinimumBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // AsciiBox
            // 
            this.AsciiBox.AutoSize = true;
            this.AsciiBox.Location = new System.Drawing.Point(10, 29);
            this.AsciiBox.Name = "AsciiBox";
            this.AsciiBox.Size = new System.Drawing.Size(52, 17);
            this.AsciiBox.TabIndex = 8;
            this.AsciiBox.Text = "ASCII";
            this.AsciiBox.UseVisualStyleBackColor = true;
            // 
            // Interpretation
            // 
            this.Interpretation.Controls.Add(this.calcUTFnBinBox);
            this.Interpretation.Controls.Add(this.label14);
            this.Interpretation.Controls.Add(this.unicodeBox);
            this.Interpretation.Controls.Add(this.label12);
            this.Interpretation.Controls.Add(this.f64Box);
            this.Interpretation.Controls.Add(this.label13);
            this.Interpretation.Controls.Add(this.f32Box);
            this.Interpretation.Controls.Add(this.label11);
            this.Interpretation.Controls.Add(this.binBox);
            this.Interpretation.Controls.Add(this.label9);
            this.Interpretation.Controls.Add(this.u64Box);
            this.Interpretation.Controls.Add(this.label10);
            this.Interpretation.Controls.Add(this.i64Box);
            this.Interpretation.Controls.Add(this.label7);
            this.Interpretation.Controls.Add(this.u8Box);
            this.Interpretation.Controls.Add(this.label8);
            this.Interpretation.Controls.Add(this.i8Box);
            this.Interpretation.Controls.Add(this.label6);
            this.Interpretation.Controls.Add(this.u32Box);
            this.Interpretation.Controls.Add(this.label5);
            this.Interpretation.Controls.Add(this.i32Box);
            this.Interpretation.Controls.Add(this.label4);
            this.Interpretation.Controls.Add(this.u16Box);
            this.Interpretation.Controls.Add(this.label3);
            this.Interpretation.Controls.Add(this.littleEndianBox);
            this.Interpretation.Controls.Add(this.i16Box);
            this.Interpretation.Controls.Add(this.selectedLbl);
            this.Interpretation.Controls.Add(this.label2);
            this.Interpretation.Location = new System.Drawing.Point(4, 25);
            this.Interpretation.Name = "Interpretation";
            this.Interpretation.Padding = new System.Windows.Forms.Padding(3);
            this.Interpretation.Size = new System.Drawing.Size(526, 298);
            this.Interpretation.TabIndex = 2;
            this.Interpretation.Text = "Interpretation";
            this.Interpretation.UseVisualStyleBackColor = true;
            this.Interpretation.Enter += new System.EventHandler(this.Interpretation_Enter);
            // 
            // calcUTFnBinBox
            // 
            this.calcUTFnBinBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calcUTFnBinBox.Location = new System.Drawing.Point(98, 251);
            this.calcUTFnBinBox.Name = "calcUTFnBinBox";
            this.calcUTFnBinBox.Size = new System.Drawing.Size(154, 23);
            this.calcUTFnBinBox.TabIndex = 27;
            this.calcUTFnBinBox.Text = "Calculate UTF16 and binary";
            this.calcUTFnBinBox.UseVisualStyleBackColor = true;
            this.calcUTFnBinBox.Click += new System.EventHandler(this.calcUTFnBinBox_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "UTF16 string";
            // 
            // unicodeBox
            // 
            this.unicodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.unicodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unicodeBox.Location = new System.Drawing.Point(7, 208);
            this.unicodeBox.Multiline = true;
            this.unicodeBox.Name = "unicodeBox";
            this.unicodeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unicodeBox.Size = new System.Drawing.Size(245, 38);
            this.unicodeBox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "64 bit float";
            // 
            // f64Box
            // 
            this.f64Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f64Box.Location = new System.Drawing.Point(132, 157);
            this.f64Box.Name = "f64Box";
            this.f64Box.Size = new System.Drawing.Size(120, 20);
            this.f64Box.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "32 bit float";
            // 
            // f32Box
            // 
            this.f32Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f32Box.Location = new System.Drawing.Point(7, 157);
            this.f32Box.Name = "f32Box";
            this.f32Box.Size = new System.Drawing.Size(120, 20);
            this.f32Box.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Binary";
            // 
            // binBox
            // 
            this.binBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.binBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.binBox.Location = new System.Drawing.Point(274, 157);
            this.binBox.Multiline = true;
            this.binBox.Name = "binBox";
            this.binBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.binBox.Size = new System.Drawing.Size(245, 113);
            this.binBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Unsigned 64 bit int";
            // 
            // u64Box
            // 
            this.u64Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u64Box.Location = new System.Drawing.Point(399, 108);
            this.u64Box.Name = "u64Box";
            this.u64Box.Size = new System.Drawing.Size(120, 20);
            this.u64Box.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Signed 64 bit int";
            // 
            // i64Box
            // 
            this.i64Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.i64Box.Location = new System.Drawing.Point(274, 108);
            this.i64Box.Name = "i64Box";
            this.i64Box.Size = new System.Drawing.Size(120, 20);
            this.i64Box.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Unsigned 8 bit int";
            // 
            // u8Box
            // 
            this.u8Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u8Box.Location = new System.Drawing.Point(132, 57);
            this.u8Box.Name = "u8Box";
            this.u8Box.Size = new System.Drawing.Size(120, 20);
            this.u8Box.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Signed 8 bit int";
            // 
            // i8Box
            // 
            this.i8Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.i8Box.Location = new System.Drawing.Point(7, 57);
            this.i8Box.Name = "i8Box";
            this.i8Box.Size = new System.Drawing.Size(120, 20);
            this.i8Box.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unsigned 32 bit int";
            // 
            // u32Box
            // 
            this.u32Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u32Box.Location = new System.Drawing.Point(399, 57);
            this.u32Box.Name = "u32Box";
            this.u32Box.Size = new System.Drawing.Size(120, 20);
            this.u32Box.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Signed 32 bit int";
            // 
            // i32Box
            // 
            this.i32Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.i32Box.Location = new System.Drawing.Point(274, 57);
            this.i32Box.Name = "i32Box";
            this.i32Box.Size = new System.Drawing.Size(120, 20);
            this.i32Box.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unsigned 16 bit int";
            // 
            // u16Box
            // 
            this.u16Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u16Box.Location = new System.Drawing.Point(132, 108);
            this.u16Box.Name = "u16Box";
            this.u16Box.Size = new System.Drawing.Size(120, 20);
            this.u16Box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Signed 16 bit int";
            // 
            // littleEndianBox
            // 
            this.littleEndianBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.littleEndianBox.AutoSize = true;
            this.littleEndianBox.Checked = true;
            this.littleEndianBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.littleEndianBox.Location = new System.Drawing.Point(8, 255);
            this.littleEndianBox.Name = "littleEndianBox";
            this.littleEndianBox.Size = new System.Drawing.Size(84, 17);
            this.littleEndianBox.TabIndex = 3;
            this.littleEndianBox.Text = "Little Endian";
            this.littleEndianBox.UseVisualStyleBackColor = true;
            this.littleEndianBox.CheckedChanged += new System.EventHandler(this.littleEndianBox_CheckedChanged);
            // 
            // i16Box
            // 
            this.i16Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.i16Box.Location = new System.Drawing.Point(7, 108);
            this.i16Box.Name = "i16Box";
            this.i16Box.Size = new System.Drawing.Size(120, 20);
            this.i16Box.TabIndex = 2;
            // 
            // selectedLbl
            // 
            this.selectedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedLbl.Location = new System.Drawing.Point(102, 6);
            this.selectedLbl.Name = "selectedLbl";
            this.selectedLbl.Size = new System.Drawing.Size(418, 18);
            this.selectedLbl.TabIndex = 1;
            this.selectedLbl.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Processed bytes:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuTools,
            this.menuInfo});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOpen,
            this.menuSave,
            this.menuSaveAs,
            this.menuReset,
            this.menuClose,
            this.menuItem1,
            this.menuItem2});
            this.menuFile.Text = "File";
            // 
            // menuOpen
            // 
            this.menuOpen.Index = 0;
            this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Enabled = false;
            this.menuSave.Index = 1;
            this.menuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Enabled = false;
            this.menuSaveAs.Index = 2;
            this.menuSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.menuSaveAs.Text = "Save as";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // menuReset
            // 
            this.menuReset.Enabled = false;
            this.menuReset.Index = 3;
            this.menuReset.Text = "Reset";
            this.menuReset.Click += new System.EventHandler(this.menuReset_Click);
            // 
            // menuClose
            // 
            this.menuClose.Enabled = false;
            this.menuClose.Index = 4;
            this.menuClose.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
            this.menuClose.Text = "Close";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 5;
            this.menuItem1.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 6;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItem2.Text = "Exit";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Enabled = false;
            this.menuEdit.Index = 1;
            this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuCut,
            this.menuCopy,
            this.menuPaste,
            this.menuItem3,
            this.menuCopyHex,
            this.menuSelectAll,
            this.menuDelete,
            this.menuItem4,
            this.menuFind,
            this.menuFindNext,
            this.menuReplace,
            this.menuGoto,
            this.menuItem5,
            this.menuInsert});
            this.menuEdit.Text = "Edit";
            // 
            // menuCut
            // 
            this.menuCut.Index = 0;
            this.menuCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuCut.Text = "Cut";
            this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
            // 
            // menuCopy
            // 
            this.menuCopy.Index = 1;
            this.menuCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuCopy.Text = "Copy";
            this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Index = 2;
            this.menuPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuPaste.Text = "Paste";
            this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "-";
            // 
            // menuCopyHex
            // 
            this.menuCopyHex.Index = 4;
            this.menuCopyHex.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftC;
            this.menuCopyHex.Text = "Copy Hex";
            this.menuCopyHex.Click += new System.EventHandler(this.menuCopyHex_Click);
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Index = 5;
            this.menuSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuSelectAll.Text = "Select all";
            this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Index = 6;
            this.menuDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.menuDelete.Text = "Delete";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 7;
            this.menuItem4.Text = "-";
            // 
            // menuFind
            // 
            this.menuFind.Index = 8;
            this.menuFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.menuFind.Text = "Find";
            this.menuFind.Click += new System.EventHandler(this.menuFind_Click);
            // 
            // menuFindNext
            // 
            this.menuFindNext.Index = 9;
            this.menuFindNext.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.menuFindNext.Text = "Find next";
            this.menuFindNext.Click += new System.EventHandler(this.menuFindNext_Click);
            // 
            // menuReplace
            // 
            this.menuReplace.Index = 10;
            this.menuReplace.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.menuReplace.Text = "Replace";
            this.menuReplace.Click += new System.EventHandler(this.menuReplace_Click);
            // 
            // menuGoto
            // 
            this.menuGoto.Index = 11;
            this.menuGoto.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.menuGoto.Text = "Goto";
            this.menuGoto.Click += new System.EventHandler(this.menuGoto_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 12;
            this.menuItem5.Text = "-";
            // 
            // menuInsert
            // 
            this.menuInsert.Index = 13;
            this.menuInsert.Shortcut = System.Windows.Forms.Shortcut.Ins;
            this.menuInsert.Text = "Insert mode";
            this.menuInsert.Click += new System.EventHandler(this.menuInsert_Click);
            // 
            // menuTools
            // 
            this.menuTools.Index = 2;
            this.menuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuCalculator,
            this.menuConverter});
            this.menuTools.Text = "Tools";
            // 
            // menuCalculator
            // 
            this.menuCalculator.Index = 0;
            this.menuCalculator.Text = "Calculator";
            this.menuCalculator.Click += new System.EventHandler(this.menuCalculator_Click);
            // 
            // menuConverter
            // 
            this.menuConverter.Index = 1;
            this.menuConverter.Text = "Converter";
            this.menuConverter.Click += new System.EventHandler(this.menuConverter_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.Index = 3;
            this.menuInfo.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuAbout,
            this.menuLicense});
            this.menuInfo.Text = "Info";
            // 
            // menuAbout
            // 
            this.menuAbout.Index = 0;
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuLicense
            // 
            this.menuLicense.Index = 1;
            this.menuLicense.Text = "License";
            this.menuLicense.Click += new System.EventHandler(this.menuLicense_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dragDropLbl
            // 
            this.dragDropLbl.AllowDrop = true;
            this.dragDropLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dragDropLbl.Location = new System.Drawing.Point(0, 0);
            this.dragDropLbl.Name = "dragDropLbl";
            this.dragDropLbl.Size = new System.Drawing.Size(534, 327);
            this.dragDropLbl.TabIndex = 0;
            this.dragDropLbl.Text = "Drag and drop a file here";
            this.dragDropLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dragDropLbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropLbl_DragDrop);
            this.dragDropLbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDropLbl_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 327);
            this.Controls.Add(this.dragDropLbl);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(550, 366);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "DotHex";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.StringsPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strMinimumBox)).EndInit();
            this.Interpretation.ResumeLayout(false);
            this.Interpretation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EditPage;
        private System.Windows.Forms.TabPage StringsPage;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchStrBtn;
        private System.Windows.Forms.MenuItem menuOpen;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.MenuItem menuSaveAs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage Interpretation;
        private System.Windows.Forms.Label selectedLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown strMinimumBox;
        private System.Windows.Forms.ListBox stringsList;
        private System.Windows.Forms.RadioButton alphanumAsciiBox;
        private System.Windows.Forms.RadioButton extAsciiBox;
        private System.Windows.Forms.RadioButton AsciiBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuItem menuEdit;
        private System.Windows.Forms.TextBox i16Box;
        private System.Windows.Forms.CheckBox littleEndianBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox u64Box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox i64Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox u8Box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox i8Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox u32Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox i32Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox u16Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox binBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox f64Box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox f32Box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox unicodeBox;
        private System.Windows.Forms.MenuItem menuReset;
        private System.Windows.Forms.MenuItem menuClose;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button calcUTFnBinBox;
        private System.Windows.Forms.MenuItem menuCut;
        private System.Windows.Forms.MenuItem menuCopy;
        private System.Windows.Forms.MenuItem menuPaste;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuCopyHex;
        private System.Windows.Forms.MenuItem menuSelectAll;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuFind;
        private System.Windows.Forms.MenuItem menuReplace;
        private System.Windows.Forms.MenuItem menuTools;
        private System.Windows.Forms.MenuItem menuInfo;
        private System.Windows.Forms.MenuItem menuAbout;
        private System.Windows.Forms.MenuItem menuLicense;
        private System.Windows.Forms.MenuItem menuCalculator;
        private System.Windows.Forms.MenuItem menuGoto;
        private System.Windows.Forms.Label dragDropLbl;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuInsert;
        private System.Windows.Forms.MenuItem menuDelete;
        private System.Windows.Forms.MenuItem menuFindNext;
        private System.Windows.Forms.MenuItem menuConverter;
        private System.Windows.Forms.Button saveListBtn;
    }
}

