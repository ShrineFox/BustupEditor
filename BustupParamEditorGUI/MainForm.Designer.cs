using System.Windows.Forms;

namespace BustupParamEditorGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox_Base = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBustupParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBustupDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_OpenImgFolder = new System.Windows.Forms.Button();
            this.numUpDwn_OffsetX = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_OffsetY = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_EyePosY = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_EyePosX = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_MouthPosY = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_MouthPosX = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_EyeFrame = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_MouthFrame = new System.Windows.Forms.NumericUpDown();
            this.btn_RepackBin = new System.Windows.Forms.Button();
            this.lbl_InitAnim = new System.Windows.Forms.Label();
            this.comboBox_InitAnim = new System.Windows.Forms.ComboBox();
            this.btn_CreateBin = new System.Windows.Forms.Button();
            this.renameEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Base)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_OffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_OffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_EyePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_EyePosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_MouthPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_MouthPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_EyeFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_MouthFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 303);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.Listbox_SelectionChanged);
            // 
            // pictureBox_Base
            // 
            this.pictureBox_Base.Location = new System.Drawing.Point(219, 39);
            this.pictureBox_Base.MaximumSize = new System.Drawing.Size(512, 512);
            this.pictureBox_Base.MinimumSize = new System.Drawing.Size(512, 512);
            this.pictureBox_Base.Name = "pictureBox_Base";
            this.pictureBox_Base.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_Base.TabIndex = 2;
            this.pictureBox_Base.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Position Offset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Eye Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mouth Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Eye Frame";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mouth Frame";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.addToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBustupParamsToolStripMenuItem,
            this.openBustupDirectoryToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openBustupParamsToolStripMenuItem
            // 
            this.openBustupParamsToolStripMenuItem.Name = "openBustupParamsToolStripMenuItem";
            this.openBustupParamsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openBustupParamsToolStripMenuItem.Text = "Open Params";
            this.openBustupParamsToolStripMenuItem.Click += new System.EventHandler(this.OpenParams_Click);
            // 
            // openBustupDirectoryToolStripMenuItem
            // 
            this.openBustupDirectoryToolStripMenuItem.Enabled = false;
            this.openBustupDirectoryToolStripMenuItem.Name = "openBustupDirectoryToolStripMenuItem";
            this.openBustupDirectoryToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openBustupDirectoryToolStripMenuItem.Text = "Open Bustup Directory";
            this.openBustupDirectoryToolStripMenuItem.Click += new System.EventHandler(this.OpenBustups_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveParams_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyParametersToolStripMenuItem,
            this.pasteParametersToolStripMenuItem,
            this.renameEntryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyParametersToolStripMenuItem
            // 
            this.copyParametersToolStripMenuItem.Name = "copyParametersToolStripMenuItem";
            this.copyParametersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyParametersToolStripMenuItem.Text = "Copy Parameters";
            this.copyParametersToolStripMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pasteParametersToolStripMenuItem
            // 
            this.pasteParametersToolStripMenuItem.Name = "pasteParametersToolStripMenuItem";
            this.pasteParametersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteParametersToolStripMenuItem.Text = "Paste Parameters";
            this.pasteParametersToolStripMenuItem.Click += new System.EventHandler(this.Paste_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parameterEntryToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.addToolStripMenuItem.Text = "Add...";
            // 
            // parameterEntryToolStripMenuItem
            // 
            this.parameterEntryToolStripMenuItem.Name = "parameterEntryToolStripMenuItem";
            this.parameterEntryToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.parameterEntryToolStripMenuItem.Text = "Parameter Entry";
            this.parameterEntryToolStripMenuItem.Click += new System.EventHandler(this.ParameterEntryToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // btn_OpenImgFolder
            // 
            this.btn_OpenImgFolder.Enabled = false;
            this.btn_OpenImgFolder.Location = new System.Drawing.Point(103, 346);
            this.btn_OpenImgFolder.Name = "btn_OpenImgFolder";
            this.btn_OpenImgFolder.Size = new System.Drawing.Size(110, 23);
            this.btn_OpenImgFolder.TabIndex = 27;
            this.btn_OpenImgFolder.Text = "Open Image Folder";
            this.btn_OpenImgFolder.UseVisualStyleBackColor = true;
            this.btn_OpenImgFolder.Click += new System.EventHandler(this.OpenImgFolder_Click);
            // 
            // numUpDwn_OffsetX
            // 
            this.numUpDwn_OffsetX.Enabled = false;
            this.numUpDwn_OffsetX.Location = new System.Drawing.Point(32, 369);
            this.numUpDwn_OffsetX.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numUpDwn_OffsetX.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            -2147483648});
            this.numUpDwn_OffsetX.Name = "numUpDwn_OffsetX";
            this.numUpDwn_OffsetX.Size = new System.Drawing.Size(58, 20);
            this.numUpDwn_OffsetX.TabIndex = 28;
            // 
            // numUpDwn_OffsetY
            // 
            this.numUpDwn_OffsetY.Enabled = false;
            this.numUpDwn_OffsetY.Location = new System.Drawing.Point(32, 391);
            this.numUpDwn_OffsetY.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numUpDwn_OffsetY.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            -2147483648});
            this.numUpDwn_OffsetY.Name = "numUpDwn_OffsetY";
            this.numUpDwn_OffsetY.Size = new System.Drawing.Size(58, 20);
            this.numUpDwn_OffsetY.TabIndex = 29;
            // 
            // numUpDwn_EyePosY
            // 
            this.numUpDwn_EyePosY.Enabled = false;
            this.numUpDwn_EyePosY.Location = new System.Drawing.Point(32, 459);
            this.numUpDwn_EyePosY.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numUpDwn_EyePosY.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            -2147483648});
            this.numUpDwn_EyePosY.Name = "numUpDwn_EyePosY";
            this.numUpDwn_EyePosY.Size = new System.Drawing.Size(58, 20);
            this.numUpDwn_EyePosY.TabIndex = 31;
            this.numUpDwn_EyePosY.ValueChanged += new System.EventHandler(this.EyePositionY_ValueChanged);
            // 
            // numUpDwn_EyePosX
            // 
            this.numUpDwn_EyePosX.Enabled = false;
            this.numUpDwn_EyePosX.Location = new System.Drawing.Point(32, 437);
            this.numUpDwn_EyePosX.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numUpDwn_EyePosX.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            -2147483648});
            this.numUpDwn_EyePosX.Name = "numUpDwn_EyePosX";
            this.numUpDwn_EyePosX.Size = new System.Drawing.Size(58, 20);
            this.numUpDwn_EyePosX.TabIndex = 30;
            this.numUpDwn_EyePosX.ValueChanged += new System.EventHandler(this.EyePositionX_ValueChanged);
            // 
            // numUpDwn_MouthPosY
            // 
            this.numUpDwn_MouthPosY.Enabled = false;
            this.numUpDwn_MouthPosY.Location = new System.Drawing.Point(126, 459);
            this.numUpDwn_MouthPosY.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numUpDwn_MouthPosY.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            -2147483648});
            this.numUpDwn_MouthPosY.Name = "numUpDwn_MouthPosY";
            this.numUpDwn_MouthPosY.Size = new System.Drawing.Size(58, 20);
            this.numUpDwn_MouthPosY.TabIndex = 33;
            this.numUpDwn_MouthPosY.ValueChanged += new System.EventHandler(this.MouthPositionY_ValueChanged);
            // 
            // numUpDwn_MouthPosX
            // 
            this.numUpDwn_MouthPosX.Enabled = false;
            this.numUpDwn_MouthPosX.Location = new System.Drawing.Point(126, 437);
            this.numUpDwn_MouthPosX.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numUpDwn_MouthPosX.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            -2147483648});
            this.numUpDwn_MouthPosX.Name = "numUpDwn_MouthPosX";
            this.numUpDwn_MouthPosX.Size = new System.Drawing.Size(58, 20);
            this.numUpDwn_MouthPosX.TabIndex = 32;
            this.numUpDwn_MouthPosX.ValueChanged += new System.EventHandler(this.MouthPositionX_ValueChanged);
            // 
            // numUpDwn_EyeFrame
            // 
            this.numUpDwn_EyeFrame.Enabled = false;
            this.numUpDwn_EyeFrame.Location = new System.Drawing.Point(32, 504);
            this.numUpDwn_EyeFrame.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDwn_EyeFrame.Name = "numUpDwn_EyeFrame";
            this.numUpDwn_EyeFrame.Size = new System.Drawing.Size(58, 20);
            this.numUpDwn_EyeFrame.TabIndex = 34;
            this.numUpDwn_EyeFrame.ValueChanged += new System.EventHandler(this.EyeFrame_ValueChanged);
            // 
            // numUpDwn_MouthFrame
            // 
            this.numUpDwn_MouthFrame.Enabled = false;
            this.numUpDwn_MouthFrame.Location = new System.Drawing.Point(126, 504);
            this.numUpDwn_MouthFrame.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUpDwn_MouthFrame.Name = "numUpDwn_MouthFrame";
            this.numUpDwn_MouthFrame.Size = new System.Drawing.Size(58, 20);
            this.numUpDwn_MouthFrame.TabIndex = 35;
            this.numUpDwn_MouthFrame.ValueChanged += new System.EventHandler(this.MouthFrame_ValueChanged);
            // 
            // btn_RepackBin
            // 
            this.btn_RepackBin.Enabled = false;
            this.btn_RepackBin.Location = new System.Drawing.Point(103, 372);
            this.btn_RepackBin.Name = "btn_RepackBin";
            this.btn_RepackBin.Size = new System.Drawing.Size(110, 23);
            this.btn_RepackBin.TabIndex = 36;
            this.btn_RepackBin.Text = "Repack Bustup .bin";
            this.btn_RepackBin.UseVisualStyleBackColor = true;
            this.btn_RepackBin.Click += new System.EventHandler(this.RepackBin_Click);
            // 
            // lbl_InitAnim
            // 
            this.lbl_InitAnim.AutoSize = true;
            this.lbl_InitAnim.Location = new System.Drawing.Point(10, 537);
            this.lbl_InitAnim.Name = "lbl_InitAnim";
            this.lbl_InitAnim.Size = new System.Drawing.Size(83, 13);
            this.lbl_InitAnim.TabIndex = 37;
            this.lbl_InitAnim.Text = "Initial Animation:";
            // 
            // comboBox_InitAnim
            // 
            this.comboBox_InitAnim.Enabled = false;
            this.comboBox_InitAnim.FormattingEnabled = true;
            this.comboBox_InitAnim.Items.AddRange(new object[] {
            "None",
            "Eyes",
            "Mouth",
            "F08",
            "Eyes_Mouth",
            "Eyes_Mouth_F08"});
            this.comboBox_InitAnim.Location = new System.Drawing.Point(99, 532);
            this.comboBox_InitAnim.Name = "comboBox_InitAnim";
            this.comboBox_InitAnim.Size = new System.Drawing.Size(114, 21);
            this.comboBox_InitAnim.TabIndex = 39;
            // 
            // btn_CreateBin
            // 
            this.btn_CreateBin.Enabled = false;
            this.btn_CreateBin.Location = new System.Drawing.Point(103, 397);
            this.btn_CreateBin.Name = "btn_CreateBin";
            this.btn_CreateBin.Size = new System.Drawing.Size(110, 23);
            this.btn_CreateBin.TabIndex = 40;
            this.btn_CreateBin.Text = "Create Bustup .bin";
            this.btn_CreateBin.UseVisualStyleBackColor = true;
            this.btn_CreateBin.Click += new System.EventHandler(this.CreateBustupBin_Click);
            // 
            // renameEntryToolStripMenuItem
            // 
            this.renameEntryToolStripMenuItem.Name = "renameEntryToolStripMenuItem";
            this.renameEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renameEntryToolStripMenuItem.Text = "Rename Entry";
            this.renameEntryToolStripMenuItem.Click += new System.EventHandler(this.ToolstripRenameEntry_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 559);
            this.Controls.Add(this.btn_CreateBin);
            this.Controls.Add(this.comboBox_InitAnim);
            this.Controls.Add(this.lbl_InitAnim);
            this.Controls.Add(this.btn_RepackBin);
            this.Controls.Add(this.numUpDwn_MouthFrame);
            this.Controls.Add(this.numUpDwn_EyeFrame);
            this.Controls.Add(this.numUpDwn_MouthPosY);
            this.Controls.Add(this.numUpDwn_MouthPosX);
            this.Controls.Add(this.numUpDwn_EyePosY);
            this.Controls.Add(this.numUpDwn_EyePosX);
            this.Controls.Add(this.numUpDwn_OffsetY);
            this.Controls.Add(this.numUpDwn_OffsetX);
            this.Controls.Add(this.btn_OpenImgFolder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Base);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(755, 598);
            this.MinimumSize = new System.Drawing.Size(755, 598);
            this.Name = "MainForm";
            this.Text = "BustupParamEditor GUI";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Base)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_OffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_OffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_EyePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_EyePosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_MouthPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_MouthPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_EyeFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_MouthFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox_Base;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openBustupParamsToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btn_OpenImgFolder;
        private NumericUpDown numUpDwn_OffsetX;
        private NumericUpDown numUpDwn_OffsetY;
        private NumericUpDown numUpDwn_EyePosY;
        private NumericUpDown numUpDwn_EyePosX;
        private NumericUpDown numUpDwn_MouthPosY;
        private NumericUpDown numUpDwn_MouthPosX;
        private NumericUpDown numUpDwn_EyeFrame;
        private NumericUpDown numUpDwn_MouthFrame;
        private ToolStripMenuItem openBustupDirectoryToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyParametersToolStripMenuItem;
        private ToolStripMenuItem pasteParametersToolStripMenuItem;
        private Button btn_RepackBin;
        private Label lbl_InitAnim;
        private ComboBox comboBox_InitAnim;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem parameterEntryToolStripMenuItem;
        private Button btn_CreateBin;
        private ToolStripMenuItem renameEntryToolStripMenuItem;
    }
}

