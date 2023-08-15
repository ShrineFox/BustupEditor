using DarkUI.Forms;

namespace BustupEditor
{
    partial class MainForm : DarkForm
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
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_Sprites = new System.Windows.Forms.ListBox();
            this.darkContextMenu_Sprites = new DarkUI.Controls.DarkContextMenu();
            this.addSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_BustupSettings = new System.Windows.Forms.GroupBox();
            this.panel_BustupSettings = new System.Windows.Forms.Panel();
            this.tlp_BustupSettings = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_BustupID = new System.Windows.Forms.TableLayoutPanel();
            this.num_SubID = new DarkUI.Controls.DarkNumericUpDown();
            this.num_MinorID = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_MajorID = new DarkUI.Controls.DarkLabel();
            this.lbl_MinorID = new DarkUI.Controls.DarkLabel();
            this.num_MajorID = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_SubID = new DarkUI.Controls.DarkLabel();
            this.comboBox_Animation = new System.Windows.Forms.ComboBox();
            this.lbl_Animation = new DarkUI.Controls.DarkLabel();
            this.tlp_MouthPos = new System.Windows.Forms.TableLayoutPanel();
            this.num_MouthPosY = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_MouthPosX = new DarkUI.Controls.DarkLabel();
            this.lbl_MouthPosY = new DarkUI.Controls.DarkLabel();
            this.num_MouthPosX = new DarkUI.Controls.DarkNumericUpDown();
            this.tlp_EyePos = new System.Windows.Forms.TableLayoutPanel();
            this.num_EyePosY = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_EyePosX = new DarkUI.Controls.DarkLabel();
            this.lbl_EyePosY = new DarkUI.Controls.DarkLabel();
            this.num_EyePosX = new DarkUI.Controls.DarkNumericUpDown();
            this.tlp_BasePos = new System.Windows.Forms.TableLayoutPanel();
            this.num_BasePosY = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_BasePosX = new DarkUI.Controls.DarkLabel();
            this.lbl_BasePosY = new DarkUI.Controls.DarkLabel();
            this.num_BasePosX = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_MouthPos = new DarkUI.Controls.DarkLabel();
            this.lbl_EyePos = new DarkUI.Controls.DarkLabel();
            this.lbl_BasePos = new DarkUI.Controls.DarkLabel();
            this.groupBox_Texture = new DarkUI.Controls.DarkGroupBox();
            this.darkContextMenu_Texture = new DarkUI.Controls.DarkContextMenu();
            this.groupBox_PreviewSettings = new System.Windows.Forms.GroupBox();
            this.panel_PreviewSettings = new System.Windows.Forms.Panel();
            this.tlp_PreviewSettings = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ImagesPath = new DarkUI.Controls.DarkLabel();
            this.tlp_ImagesPath = new System.Windows.Forms.TableLayoutPanel();
            this.txt_ImagesPath = new DarkUI.Controls.DarkTextBox();
            this.btn_ImagesPath = new DarkUI.Controls.DarkButton();
            this.tlp_PreviewFrame = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_EyeFrame = new DarkUI.Controls.DarkLabel();
            this.num_MouthFrame = new DarkUI.Controls.DarkNumericUpDown();
            this.lbl_MouthFrame = new DarkUI.Controls.DarkLabel();
            this.num_EyeFrame = new DarkUI.Controls.DarkNumericUpDown();
            this.darkMenuStrip_MainMenu = new DarkUI.Controls.DarkMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Scale = new DarkUI.Controls.DarkLabel();
            this.num_Scale = new DarkUI.Controls.DarkNumericUpDown();
            this.pnl_ImgPreview = new System.Windows.Forms.Panel();
            this.pictureBox_Tex = new System.Windows.Forms.PictureBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp_Main.SuspendLayout();
            this.darkContextMenu_Sprites.SuspendLayout();
            this.groupBox_BustupSettings.SuspendLayout();
            this.panel_BustupSettings.SuspendLayout();
            this.tlp_BustupSettings.SuspendLayout();
            this.tlp_BustupID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SubID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MajorID)).BeginInit();
            this.tlp_MouthPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MouthPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MouthPosX)).BeginInit();
            this.tlp_EyePos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_EyePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EyePosX)).BeginInit();
            this.tlp_BasePos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BasePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_BasePosX)).BeginInit();
            this.groupBox_Texture.SuspendLayout();
            this.darkContextMenu_Texture.SuspendLayout();
            this.groupBox_PreviewSettings.SuspendLayout();
            this.panel_PreviewSettings.SuspendLayout();
            this.tlp_PreviewSettings.SuspendLayout();
            this.tlp_ImagesPath.SuspendLayout();
            this.tlp_PreviewFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MouthFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EyeFrame)).BeginInit();
            this.darkMenuStrip_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Scale)).BeginInit();
            this.pnl_ImgPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tex)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.Controls.Add(this.listBox_Sprites, 0, 0);
            this.tlp_Main.Controls.Add(this.groupBox_BustupSettings, 0, 1);
            this.tlp_Main.Controls.Add(this.groupBox_Texture, 1, 0);
            this.tlp_Main.Controls.Add(this.groupBox_PreviewSettings, 1, 2);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 28);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 3;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Main.Size = new System.Drawing.Size(982, 575);
            this.tlp_Main.TabIndex = 0;
            // 
            // listBox_Sprites
            // 
            this.listBox_Sprites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.listBox_Sprites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Sprites.ContextMenuStrip = this.darkContextMenu_Sprites;
            this.listBox_Sprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Sprites.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox_Sprites.FormattingEnabled = true;
            this.listBox_Sprites.ItemHeight = 16;
            this.listBox_Sprites.Location = new System.Drawing.Point(3, 3);
            this.listBox_Sprites.Name = "listBox_Sprites";
            this.listBox_Sprites.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_Sprites.Size = new System.Drawing.Size(485, 281);
            this.listBox_Sprites.TabIndex = 1;
            this.listBox_Sprites.SelectedIndexChanged += new System.EventHandler(this.SelectedBustup_Changed);
            this.listBox_Sprites.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // darkContextMenu_Sprites
            // 
            this.darkContextMenu_Sprites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkContextMenu_Sprites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkContextMenu_Sprites.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkContextMenu_Sprites.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSpriteToolStripMenuItem,
            this.removeSelectedToolStripMenuItem,
            this.renameSelectedToolStripMenuItem,
            this.copySelectedToolStripMenuItem,
            this.pasteSelectedToolStripMenuItem,
            this.openImageFolderToolStripMenuItem1});
            this.darkContextMenu_Sprites.Name = "darkContextMenu_Sprites";
            this.darkContextMenu_Sprites.Size = new System.Drawing.Size(207, 148);
            // 
            // addSpriteToolStripMenuItem
            // 
            this.addSpriteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.addSpriteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.addSpriteToolStripMenuItem.Name = "addSpriteToolStripMenuItem";
            this.addSpriteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addSpriteToolStripMenuItem.Text = "Add";
            this.addSpriteToolStripMenuItem.Click += new System.EventHandler(this.Add_Click);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.removeSelectedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.removeSelectedToolStripMenuItem.Text = "Remove";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.Remove_Click);
            // 
            // renameSelectedToolStripMenuItem
            // 
            this.renameSelectedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.renameSelectedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.renameSelectedToolStripMenuItem.Name = "renameSelectedToolStripMenuItem";
            this.renameSelectedToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.renameSelectedToolStripMenuItem.Text = "Rename";
            this.renameSelectedToolStripMenuItem.Click += new System.EventHandler(this.Rename_Click);
            // 
            // groupBox_BustupSettings
            // 
            this.groupBox_BustupSettings.Controls.Add(this.panel_BustupSettings);
            this.groupBox_BustupSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_BustupSettings.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox_BustupSettings.Location = new System.Drawing.Point(3, 290);
            this.groupBox_BustupSettings.Name = "groupBox_BustupSettings";
            this.tlp_Main.SetRowSpan(this.groupBox_BustupSettings, 2);
            this.groupBox_BustupSettings.Size = new System.Drawing.Size(485, 282);
            this.groupBox_BustupSettings.TabIndex = 2;
            this.groupBox_BustupSettings.TabStop = false;
            this.groupBox_BustupSettings.Text = "Bustup Parameters";
            // 
            // panel_BustupSettings
            // 
            this.panel_BustupSettings.AutoScroll = true;
            this.panel_BustupSettings.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.panel_BustupSettings.Controls.Add(this.tlp_BustupSettings);
            this.panel_BustupSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BustupSettings.Location = new System.Drawing.Point(3, 18);
            this.panel_BustupSettings.Name = "panel_BustupSettings";
            this.panel_BustupSettings.Size = new System.Drawing.Size(479, 261);
            this.panel_BustupSettings.TabIndex = 0;
            // 
            // tlp_BustupSettings
            // 
            this.tlp_BustupSettings.AutoSize = true;
            this.tlp_BustupSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_BustupSettings.ColumnCount = 2;
            this.tlp_BustupSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_BustupSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_BustupSettings.Controls.Add(this.tlp_BustupID, 0, 0);
            this.tlp_BustupSettings.Controls.Add(this.comboBox_Animation, 1, 4);
            this.tlp_BustupSettings.Controls.Add(this.lbl_Animation, 0, 4);
            this.tlp_BustupSettings.Controls.Add(this.tlp_MouthPos, 1, 3);
            this.tlp_BustupSettings.Controls.Add(this.tlp_EyePos, 1, 2);
            this.tlp_BustupSettings.Controls.Add(this.tlp_BasePos, 1, 1);
            this.tlp_BustupSettings.Controls.Add(this.lbl_MouthPos, 0, 3);
            this.tlp_BustupSettings.Controls.Add(this.lbl_EyePos, 0, 2);
            this.tlp_BustupSettings.Controls.Add(this.lbl_BasePos, 0, 1);
            this.tlp_BustupSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_BustupSettings.Location = new System.Drawing.Point(0, 0);
            this.tlp_BustupSettings.Name = "tlp_BustupSettings";
            this.tlp_BustupSettings.RowCount = 5;
            this.tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_BustupSettings.Size = new System.Drawing.Size(479, 250);
            this.tlp_BustupSettings.TabIndex = 1;
            // 
            // tlp_BustupID
            // 
            this.tlp_BustupID.ColumnCount = 6;
            this.tlp_BustupSettings.SetColumnSpan(this.tlp_BustupID, 2);
            this.tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_BustupID.Controls.Add(this.num_SubID, 5, 0);
            this.tlp_BustupID.Controls.Add(this.num_MinorID, 3, 0);
            this.tlp_BustupID.Controls.Add(this.lbl_MajorID, 0, 0);
            this.tlp_BustupID.Controls.Add(this.lbl_MinorID, 2, 0);
            this.tlp_BustupID.Controls.Add(this.num_MajorID, 1, 0);
            this.tlp_BustupID.Controls.Add(this.lbl_SubID, 4, 0);
            this.tlp_BustupID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_BustupID.Location = new System.Drawing.Point(3, 3);
            this.tlp_BustupID.Name = "tlp_BustupID";
            this.tlp_BustupID.RowCount = 1;
            this.tlp_BustupID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_BustupID.Size = new System.Drawing.Size(473, 44);
            this.tlp_BustupID.TabIndex = 8;
            // 
            // num_SubID
            // 
            this.num_SubID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_SubID.Location = new System.Drawing.Point(415, 11);
            this.num_SubID.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.num_SubID.Name = "num_SubID";
            this.num_SubID.Size = new System.Drawing.Size(55, 22);
            this.num_SubID.TabIndex = 5;
            this.num_SubID.ValueChanged += new System.EventHandler(this.SubID_Changed);
            // 
            // num_MinorID
            // 
            this.num_MinorID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_MinorID.Location = new System.Drawing.Point(258, 11);
            this.num_MinorID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_MinorID.Name = "num_MinorID";
            this.num_MinorID.Size = new System.Drawing.Size(53, 22);
            this.num_MinorID.TabIndex = 3;
            this.num_MinorID.ValueChanged += new System.EventHandler(this.MinorID_Changed);
            // 
            // lbl_MajorID
            // 
            this.lbl_MajorID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_MajorID.AutoSize = true;
            this.lbl_MajorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_MajorID.Location = new System.Drawing.Point(11, 14);
            this.lbl_MajorID.Name = "lbl_MajorID";
            this.lbl_MajorID.Size = new System.Drawing.Size(84, 16);
            this.lbl_MajorID.TabIndex = 0;
            this.lbl_MajorID.Text = "Character ID:";
            // 
            // lbl_MinorID
            // 
            this.lbl_MinorID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_MinorID.AutoSize = true;
            this.lbl_MinorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_MinorID.Location = new System.Drawing.Point(175, 6);
            this.lbl_MinorID.Name = "lbl_MinorID";
            this.lbl_MinorID.Size = new System.Drawing.Size(77, 32);
            this.lbl_MinorID.TabIndex = 1;
            this.lbl_MinorID.Text = "Expression ID:";
            // 
            // num_MajorID
            // 
            this.num_MajorID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_MajorID.Location = new System.Drawing.Point(101, 11);
            this.num_MajorID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_MajorID.Name = "num_MajorID";
            this.num_MajorID.Size = new System.Drawing.Size(53, 22);
            this.num_MajorID.TabIndex = 2;
            this.num_MajorID.ValueChanged += new System.EventHandler(this.MajorID_Changed);
            // 
            // lbl_SubID
            // 
            this.lbl_SubID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_SubID.AutoSize = true;
            this.lbl_SubID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_SubID.Location = new System.Drawing.Point(354, 14);
            this.lbl_SubID.Name = "lbl_SubID";
            this.lbl_SubID.Size = new System.Drawing.Size(55, 16);
            this.lbl_SubID.TabIndex = 4;
            this.lbl_SubID.Text = "Outfit ID:";
            // 
            // comboBox_Animation
            // 
            this.comboBox_Animation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_Animation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.comboBox_Animation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Animation.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_Animation.FormattingEnabled = true;
            this.comboBox_Animation.Items.AddRange(new object[] {
            "None",
            "Eyes",
            "Mouth",
            "Eyes_Mouth",
            "Eyes_Mouth_ExcludeAlpha",
            "Unknown"});
            this.comboBox_Animation.Location = new System.Drawing.Point(98, 216);
            this.comboBox_Animation.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBox_Animation.Name = "comboBox_Animation";
            this.comboBox_Animation.Size = new System.Drawing.Size(185, 24);
            this.comboBox_Animation.TabIndex = 7;
            this.comboBox_Animation.SelectedIndexChanged += new System.EventHandler(this.Animation_Changed);
            // 
            // lbl_Animation
            // 
            this.lbl_Animation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Animation.AutoSize = true;
            this.lbl_Animation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Animation.Location = new System.Drawing.Point(3, 217);
            this.lbl_Animation.Name = "lbl_Animation";
            this.lbl_Animation.Size = new System.Drawing.Size(89, 16);
            this.lbl_Animation.TabIndex = 6;
            this.lbl_Animation.Text = "Animation:";
            // 
            // tlp_MouthPos
            // 
            this.tlp_MouthPos.ColumnCount = 4;
            this.tlp_MouthPos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_MouthPos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_MouthPos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_MouthPos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_MouthPos.Controls.Add(this.num_MouthPosY, 3, 0);
            this.tlp_MouthPos.Controls.Add(this.lbl_MouthPosX, 0, 0);
            this.tlp_MouthPos.Controls.Add(this.lbl_MouthPosY, 2, 0);
            this.tlp_MouthPos.Controls.Add(this.num_MouthPosX, 1, 0);
            this.tlp_MouthPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_MouthPos.Location = new System.Drawing.Point(98, 153);
            this.tlp_MouthPos.Name = "tlp_MouthPos";
            this.tlp_MouthPos.RowCount = 1;
            this.tlp_MouthPos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_MouthPos.Size = new System.Drawing.Size(378, 44);
            this.tlp_MouthPos.TabIndex = 5;
            // 
            // num_MouthPosY
            // 
            this.num_MouthPosY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_MouthPosY.Location = new System.Drawing.Point(266, 11);
            this.num_MouthPosY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_MouthPosY.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.num_MouthPosY.Name = "num_MouthPosY";
            this.num_MouthPosY.Size = new System.Drawing.Size(107, 22);
            this.num_MouthPosY.TabIndex = 3;
            this.num_MouthPosY.ValueChanged += new System.EventHandler(this.MouthPosY_Changed);
            // 
            // lbl_MouthPosX
            // 
            this.lbl_MouthPosX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_MouthPosX.AutoSize = true;
            this.lbl_MouthPosX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_MouthPosX.Location = new System.Drawing.Point(54, 14);
            this.lbl_MouthPosX.Name = "lbl_MouthPosX";
            this.lbl_MouthPosX.Size = new System.Drawing.Size(18, 16);
            this.lbl_MouthPosX.TabIndex = 0;
            this.lbl_MouthPosX.Text = "X:";
            // 
            // lbl_MouthPosY
            // 
            this.lbl_MouthPosY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_MouthPosY.AutoSize = true;
            this.lbl_MouthPosY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_MouthPosY.Location = new System.Drawing.Point(241, 14);
            this.lbl_MouthPosY.Name = "lbl_MouthPosY";
            this.lbl_MouthPosY.Size = new System.Drawing.Size(19, 16);
            this.lbl_MouthPosY.TabIndex = 1;
            this.lbl_MouthPosY.Text = "Y:";
            // 
            // num_MouthPosX
            // 
            this.num_MouthPosX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_MouthPosX.Location = new System.Drawing.Point(78, 11);
            this.num_MouthPosX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_MouthPosX.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.num_MouthPosX.Name = "num_MouthPosX";
            this.num_MouthPosX.Size = new System.Drawing.Size(107, 22);
            this.num_MouthPosX.TabIndex = 2;
            this.num_MouthPosX.ValueChanged += new System.EventHandler(this.MouthPosX_Changed);
            // 
            // tlp_EyePos
            // 
            this.tlp_EyePos.ColumnCount = 4;
            this.tlp_EyePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_EyePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_EyePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_EyePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_EyePos.Controls.Add(this.num_EyePosY, 3, 0);
            this.tlp_EyePos.Controls.Add(this.lbl_EyePosX, 0, 0);
            this.tlp_EyePos.Controls.Add(this.lbl_EyePosY, 2, 0);
            this.tlp_EyePos.Controls.Add(this.num_EyePosX, 1, 0);
            this.tlp_EyePos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_EyePos.Location = new System.Drawing.Point(98, 103);
            this.tlp_EyePos.Name = "tlp_EyePos";
            this.tlp_EyePos.RowCount = 1;
            this.tlp_EyePos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_EyePos.Size = new System.Drawing.Size(378, 44);
            this.tlp_EyePos.TabIndex = 3;
            // 
            // num_EyePosY
            // 
            this.num_EyePosY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_EyePosY.Location = new System.Drawing.Point(266, 11);
            this.num_EyePosY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_EyePosY.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.num_EyePosY.Name = "num_EyePosY";
            this.num_EyePosY.Size = new System.Drawing.Size(107, 22);
            this.num_EyePosY.TabIndex = 3;
            this.num_EyePosY.ValueChanged += new System.EventHandler(this.EyePosY_Changed);
            // 
            // lbl_EyePosX
            // 
            this.lbl_EyePosX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_EyePosX.AutoSize = true;
            this.lbl_EyePosX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_EyePosX.Location = new System.Drawing.Point(54, 14);
            this.lbl_EyePosX.Name = "lbl_EyePosX";
            this.lbl_EyePosX.Size = new System.Drawing.Size(18, 16);
            this.lbl_EyePosX.TabIndex = 0;
            this.lbl_EyePosX.Text = "X:";
            // 
            // lbl_EyePosY
            // 
            this.lbl_EyePosY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_EyePosY.AutoSize = true;
            this.lbl_EyePosY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_EyePosY.Location = new System.Drawing.Point(241, 14);
            this.lbl_EyePosY.Name = "lbl_EyePosY";
            this.lbl_EyePosY.Size = new System.Drawing.Size(19, 16);
            this.lbl_EyePosY.TabIndex = 1;
            this.lbl_EyePosY.Text = "Y:";
            // 
            // num_EyePosX
            // 
            this.num_EyePosX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_EyePosX.Location = new System.Drawing.Point(78, 11);
            this.num_EyePosX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_EyePosX.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.num_EyePosX.Name = "num_EyePosX";
            this.num_EyePosX.Size = new System.Drawing.Size(107, 22);
            this.num_EyePosX.TabIndex = 2;
            this.num_EyePosX.ValueChanged += new System.EventHandler(this.EyePosX_Changed);
            // 
            // tlp_BasePos
            // 
            this.tlp_BasePos.ColumnCount = 4;
            this.tlp_BasePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_BasePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_BasePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_BasePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_BasePos.Controls.Add(this.num_BasePosY, 3, 0);
            this.tlp_BasePos.Controls.Add(this.lbl_BasePosX, 0, 0);
            this.tlp_BasePos.Controls.Add(this.lbl_BasePosY, 2, 0);
            this.tlp_BasePos.Controls.Add(this.num_BasePosX, 1, 0);
            this.tlp_BasePos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_BasePos.Location = new System.Drawing.Point(98, 53);
            this.tlp_BasePos.Name = "tlp_BasePos";
            this.tlp_BasePos.RowCount = 1;
            this.tlp_BasePos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_BasePos.Size = new System.Drawing.Size(378, 44);
            this.tlp_BasePos.TabIndex = 1;
            // 
            // num_BasePosY
            // 
            this.num_BasePosY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_BasePosY.Location = new System.Drawing.Point(266, 11);
            this.num_BasePosY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_BasePosY.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.num_BasePosY.Name = "num_BasePosY";
            this.num_BasePosY.Size = new System.Drawing.Size(107, 22);
            this.num_BasePosY.TabIndex = 3;
            this.num_BasePosY.ValueChanged += new System.EventHandler(this.BasePosY_Changed);
            // 
            // lbl_BasePosX
            // 
            this.lbl_BasePosX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_BasePosX.AutoSize = true;
            this.lbl_BasePosX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_BasePosX.Location = new System.Drawing.Point(54, 14);
            this.lbl_BasePosX.Name = "lbl_BasePosX";
            this.lbl_BasePosX.Size = new System.Drawing.Size(18, 16);
            this.lbl_BasePosX.TabIndex = 0;
            this.lbl_BasePosX.Text = "X:";
            // 
            // lbl_BasePosY
            // 
            this.lbl_BasePosY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_BasePosY.AutoSize = true;
            this.lbl_BasePosY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_BasePosY.Location = new System.Drawing.Point(241, 14);
            this.lbl_BasePosY.Name = "lbl_BasePosY";
            this.lbl_BasePosY.Size = new System.Drawing.Size(19, 16);
            this.lbl_BasePosY.TabIndex = 1;
            this.lbl_BasePosY.Text = "Y:";
            // 
            // num_BasePosX
            // 
            this.num_BasePosX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_BasePosX.Location = new System.Drawing.Point(78, 11);
            this.num_BasePosX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_BasePosX.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.num_BasePosX.Name = "num_BasePosX";
            this.num_BasePosX.Size = new System.Drawing.Size(107, 22);
            this.num_BasePosX.TabIndex = 2;
            this.num_BasePosX.ValueChanged += new System.EventHandler(this.BasePosX_Changed);
            // 
            // lbl_MouthPos
            // 
            this.lbl_MouthPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MouthPos.AutoSize = true;
            this.lbl_MouthPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_MouthPos.Location = new System.Drawing.Point(3, 159);
            this.lbl_MouthPos.Name = "lbl_MouthPos";
            this.lbl_MouthPos.Size = new System.Drawing.Size(89, 32);
            this.lbl_MouthPos.TabIndex = 4;
            this.lbl_MouthPos.Text = "Mouth Position:";
            // 
            // lbl_EyePos
            // 
            this.lbl_EyePos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EyePos.AutoSize = true;
            this.lbl_EyePos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_EyePos.Location = new System.Drawing.Point(3, 117);
            this.lbl_EyePos.Name = "lbl_EyePos";
            this.lbl_EyePos.Size = new System.Drawing.Size(89, 16);
            this.lbl_EyePos.TabIndex = 2;
            this.lbl_EyePos.Text = "Eye Position:";
            // 
            // lbl_BasePos
            // 
            this.lbl_BasePos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BasePos.AutoSize = true;
            this.lbl_BasePos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_BasePos.Location = new System.Drawing.Point(3, 59);
            this.lbl_BasePos.Name = "lbl_BasePos";
            this.lbl_BasePos.Size = new System.Drawing.Size(89, 32);
            this.lbl_BasePos.TabIndex = 0;
            this.lbl_BasePos.Text = "Base Position:";
            // 
            // groupBox_Texture
            // 
            this.groupBox_Texture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.groupBox_Texture.Controls.Add(this.pnl_ImgPreview);
            this.groupBox_Texture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Texture.Location = new System.Drawing.Point(494, 3);
            this.groupBox_Texture.Name = "groupBox_Texture";
            this.tlp_Main.SetRowSpan(this.groupBox_Texture, 2);
            this.groupBox_Texture.Size = new System.Drawing.Size(485, 424);
            this.groupBox_Texture.TabIndex = 4;
            this.groupBox_Texture.TabStop = false;
            this.groupBox_Texture.Text = "Bustup Texture";
            // 
            // darkContextMenu_Texture
            // 
            this.darkContextMenu_Texture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkContextMenu_Texture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkContextMenu_Texture.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkContextMenu_Texture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageFolderToolStripMenuItem});
            this.darkContextMenu_Texture.Name = "darkContextMenu_Texture";
            this.darkContextMenu_Texture.Size = new System.Drawing.Size(207, 28);
            // 
            // groupBox_PreviewSettings
            // 
            this.groupBox_PreviewSettings.Controls.Add(this.panel_PreviewSettings);
            this.groupBox_PreviewSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_PreviewSettings.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox_PreviewSettings.Location = new System.Drawing.Point(494, 433);
            this.groupBox_PreviewSettings.Name = "groupBox_PreviewSettings";
            this.groupBox_PreviewSettings.Size = new System.Drawing.Size(485, 139);
            this.groupBox_PreviewSettings.TabIndex = 3;
            this.groupBox_PreviewSettings.TabStop = false;
            this.groupBox_PreviewSettings.Text = "Preview Settings";
            // 
            // panel_PreviewSettings
            // 
            this.panel_PreviewSettings.AutoScroll = true;
            this.panel_PreviewSettings.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.panel_PreviewSettings.Controls.Add(this.tlp_PreviewSettings);
            this.panel_PreviewSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PreviewSettings.Location = new System.Drawing.Point(3, 18);
            this.panel_PreviewSettings.Name = "panel_PreviewSettings";
            this.panel_PreviewSettings.Size = new System.Drawing.Size(479, 118);
            this.panel_PreviewSettings.TabIndex = 0;
            // 
            // tlp_PreviewSettings
            // 
            this.tlp_PreviewSettings.AutoSize = true;
            this.tlp_PreviewSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_PreviewSettings.ColumnCount = 2;
            this.tlp_PreviewSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_PreviewSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_PreviewSettings.Controls.Add(this.lbl_ImagesPath, 0, 0);
            this.tlp_PreviewSettings.Controls.Add(this.tlp_ImagesPath, 1, 0);
            this.tlp_PreviewSettings.Controls.Add(this.tlp_PreviewFrame, 0, 1);
            this.tlp_PreviewSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_PreviewSettings.Location = new System.Drawing.Point(0, 0);
            this.tlp_PreviewSettings.Name = "tlp_PreviewSettings";
            this.tlp_PreviewSettings.RowCount = 1;
            this.tlp_PreviewSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_PreviewSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_PreviewSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_PreviewSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_PreviewSettings.Size = new System.Drawing.Size(479, 100);
            this.tlp_PreviewSettings.TabIndex = 2;
            // 
            // lbl_ImagesPath
            // 
            this.lbl_ImagesPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_ImagesPath.AutoSize = true;
            this.lbl_ImagesPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_ImagesPath.Location = new System.Drawing.Point(37, 9);
            this.lbl_ImagesPath.Name = "lbl_ImagesPath";
            this.lbl_ImagesPath.Size = new System.Drawing.Size(55, 32);
            this.lbl_ImagesPath.TabIndex = 3;
            this.lbl_ImagesPath.Text = "Images Folder:";
            // 
            // tlp_ImagesPath
            // 
            this.tlp_ImagesPath.ColumnCount = 2;
            this.tlp_ImagesPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp_ImagesPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ImagesPath.Controls.Add(this.txt_ImagesPath, 0, 0);
            this.tlp_ImagesPath.Controls.Add(this.btn_ImagesPath, 1, 0);
            this.tlp_ImagesPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ImagesPath.Location = new System.Drawing.Point(98, 3);
            this.tlp_ImagesPath.Name = "tlp_ImagesPath";
            this.tlp_ImagesPath.RowCount = 1;
            this.tlp_ImagesPath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ImagesPath.Size = new System.Drawing.Size(378, 44);
            this.tlp_ImagesPath.TabIndex = 2;
            // 
            // txt_ImagesPath
            // 
            this.txt_ImagesPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ImagesPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_ImagesPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ImagesPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_ImagesPath.Location = new System.Drawing.Point(3, 11);
            this.txt_ImagesPath.Name = "txt_ImagesPath";
            this.txt_ImagesPath.Size = new System.Drawing.Size(277, 22);
            this.txt_ImagesPath.TabIndex = 0;
            this.txt_ImagesPath.TextChanged += new System.EventHandler(this.ImagePath_Changed);
            // 
            // btn_ImagesPath
            // 
            this.btn_ImagesPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_ImagesPath.Location = new System.Drawing.Point(286, 10);
            this.btn_ImagesPath.Name = "btn_ImagesPath";
            this.btn_ImagesPath.Padding = new System.Windows.Forms.Padding(5);
            this.btn_ImagesPath.Size = new System.Drawing.Size(48, 23);
            this.btn_ImagesPath.TabIndex = 1;
            this.btn_ImagesPath.Text = "...";
            this.btn_ImagesPath.Click += new System.EventHandler(this.BrowseImagePath_Click);
            // 
            // tlp_PreviewFrame
            // 
            this.tlp_PreviewFrame.ColumnCount = 6;
            this.tlp_PreviewSettings.SetColumnSpan(this.tlp_PreviewFrame, 2);
            this.tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_PreviewFrame.Controls.Add(this.lbl_EyeFrame, 0, 0);
            this.tlp_PreviewFrame.Controls.Add(this.num_MouthFrame, 3, 0);
            this.tlp_PreviewFrame.Controls.Add(this.lbl_MouthFrame, 2, 0);
            this.tlp_PreviewFrame.Controls.Add(this.num_EyeFrame, 1, 0);
            this.tlp_PreviewFrame.Controls.Add(this.lbl_Scale, 4, 0);
            this.tlp_PreviewFrame.Controls.Add(this.num_Scale, 5, 0);
            this.tlp_PreviewFrame.Location = new System.Drawing.Point(3, 53);
            this.tlp_PreviewFrame.Name = "tlp_PreviewFrame";
            this.tlp_PreviewFrame.RowCount = 1;
            this.tlp_PreviewFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_PreviewFrame.Size = new System.Drawing.Size(473, 44);
            this.tlp_PreviewFrame.TabIndex = 1;
            // 
            // lbl_EyeFrame
            // 
            this.lbl_EyeFrame.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_EyeFrame.AutoSize = true;
            this.lbl_EyeFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_EyeFrame.Location = new System.Drawing.Point(18, 6);
            this.lbl_EyeFrame.Name = "lbl_EyeFrame";
            this.lbl_EyeFrame.Size = new System.Drawing.Size(49, 32);
            this.lbl_EyeFrame.TabIndex = 4;
            this.lbl_EyeFrame.Text = "Eye Frame:";
            // 
            // num_MouthFrame
            // 
            this.num_MouthFrame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_MouthFrame.Location = new System.Drawing.Point(213, 11);
            this.num_MouthFrame.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_MouthFrame.Name = "num_MouthFrame";
            this.num_MouthFrame.Size = new System.Drawing.Size(64, 22);
            this.num_MouthFrame.TabIndex = 3;
            this.num_MouthFrame.ValueChanged += new System.EventHandler(this.MouthFrame_Changed);
            // 
            // lbl_MouthFrame
            // 
            this.lbl_MouthFrame.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_MouthFrame.AutoSize = true;
            this.lbl_MouthFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_MouthFrame.Location = new System.Drawing.Point(158, 6);
            this.lbl_MouthFrame.Name = "lbl_MouthFrame";
            this.lbl_MouthFrame.Size = new System.Drawing.Size(49, 32);
            this.lbl_MouthFrame.TabIndex = 1;
            this.lbl_MouthFrame.Text = "Mouth Frame:";
            // 
            // num_EyeFrame
            // 
            this.num_EyeFrame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_EyeFrame.Location = new System.Drawing.Point(73, 11);
            this.num_EyeFrame.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_EyeFrame.Name = "num_EyeFrame";
            this.num_EyeFrame.Size = new System.Drawing.Size(64, 22);
            this.num_EyeFrame.TabIndex = 2;
            this.num_EyeFrame.ValueChanged += new System.EventHandler(this.EyeFrame_Changed);
            // 
            // darkMenuStrip_MainMenu
            // 
            this.darkMenuStrip_MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkMenuStrip_MainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkMenuStrip_MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.darkMenuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.darkMenuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.darkMenuStrip_MainMenu.Name = "darkMenuStrip_MainMenu";
            this.darkMenuStrip_MainMenu.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.darkMenuStrip_MainMenu.Size = new System.Drawing.Size(982, 28);
            this.darkMenuStrip_MainMenu.TabIndex = 1;
            this.darkMenuStrip_MainMenu.Text = "darkMenuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.loadToolStripMenuItem.Text = "Load Project";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadPreset_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.saveToolStripMenuItem.Text = "Save Project";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SavePreset_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.importToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.Import_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // lbl_Scale
            // 
            this.lbl_Scale.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Scale.AutoSize = true;
            this.lbl_Scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Scale.Location = new System.Drawing.Point(313, 6);
            this.lbl_Scale.Name = "lbl_Scale";
            this.lbl_Scale.Size = new System.Drawing.Size(58, 32);
            this.lbl_Scale.TabIndex = 5;
            this.lbl_Scale.Text = "Preview Scale:";
            // 
            // num_Scale
            // 
            this.num_Scale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num_Scale.Location = new System.Drawing.Point(377, 11);
            this.num_Scale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Scale.Name = "num_Scale";
            this.num_Scale.Size = new System.Drawing.Size(64, 22);
            this.num_Scale.TabIndex = 6;
            this.num_Scale.Tag = "";
            this.num_Scale.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_Scale.ValueChanged += new System.EventHandler(this.PreviewScale_Changed);
            // 
            // pnl_ImgPreview
            // 
            this.pnl_ImgPreview.AutoScroll = true;
            this.pnl_ImgPreview.AutoSize = true;
            this.pnl_ImgPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_ImgPreview.Controls.Add(this.pictureBox_Tex);
            this.pnl_ImgPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ImgPreview.Location = new System.Drawing.Point(3, 18);
            this.pnl_ImgPreview.Name = "pnl_ImgPreview";
            this.pnl_ImgPreview.Size = new System.Drawing.Size(479, 403);
            this.pnl_ImgPreview.TabIndex = 0;
            // 
            // pictureBox_Tex
            // 
            this.pictureBox_Tex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.pictureBox_Tex.ContextMenuStrip = this.darkContextMenu_Texture;
            this.pictureBox_Tex.Location = new System.Drawing.Point(8, 8);
            this.pictureBox_Tex.Name = "pictureBox_Tex";
            this.pictureBox_Tex.Size = new System.Drawing.Size(479, 402);
            this.pictureBox_Tex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Tex.TabIndex = 2;
            this.pictureBox_Tex.TabStop = false;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.Add_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.removeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.Remove_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.renameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.Rename_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.Paste_Click);
            // 
            // openImageFolderToolStripMenuItem
            // 
            this.openImageFolderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.openImageFolderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openImageFolderToolStripMenuItem.Name = "openImageFolderToolStripMenuItem";
            this.openImageFolderToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.openImageFolderToolStripMenuItem.Text = "Open Image Folder";
            this.openImageFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenImageFolder_Click);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.copySelectedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.copySelectedToolStripMenuItem.Text = "Copy";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pasteSelectedToolStripMenuItem
            // 
            this.pasteSelectedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pasteSelectedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pasteSelectedToolStripMenuItem.Name = "pasteSelectedToolStripMenuItem";
            this.pasteSelectedToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.pasteSelectedToolStripMenuItem.Text = "Paste";
            // 
            // openImageFolderToolStripMenuItem1
            // 
            this.openImageFolderToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.openImageFolderToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openImageFolderToolStripMenuItem1.Name = "openImageFolderToolStripMenuItem1";
            this.openImageFolderToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.openImageFolderToolStripMenuItem1.Text = "Open Image Folder";
            this.openImageFolderToolStripMenuItem1.Click += new System.EventHandler(this.OpenImageFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.tlp_Main);
            this.Controls.Add(this.darkMenuStrip_MainMenu);
            this.MainMenuStrip = this.darkMenuStrip_MainMenu;
            this.MinimumSize = new System.Drawing.Size(650, 475);
            this.Name = "MainForm";
            this.Text = "BustupEditor";
            this.tlp_Main.ResumeLayout(false);
            this.darkContextMenu_Sprites.ResumeLayout(false);
            this.groupBox_BustupSettings.ResumeLayout(false);
            this.panel_BustupSettings.ResumeLayout(false);
            this.panel_BustupSettings.PerformLayout();
            this.tlp_BustupSettings.ResumeLayout(false);
            this.tlp_BustupSettings.PerformLayout();
            this.tlp_BustupID.ResumeLayout(false);
            this.tlp_BustupID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SubID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MajorID)).EndInit();
            this.tlp_MouthPos.ResumeLayout(false);
            this.tlp_MouthPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MouthPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MouthPosX)).EndInit();
            this.tlp_EyePos.ResumeLayout(false);
            this.tlp_EyePos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_EyePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EyePosX)).EndInit();
            this.tlp_BasePos.ResumeLayout(false);
            this.tlp_BasePos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BasePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_BasePosX)).EndInit();
            this.groupBox_Texture.ResumeLayout(false);
            this.groupBox_Texture.PerformLayout();
            this.darkContextMenu_Texture.ResumeLayout(false);
            this.groupBox_PreviewSettings.ResumeLayout(false);
            this.panel_PreviewSettings.ResumeLayout(false);
            this.panel_PreviewSettings.PerformLayout();
            this.tlp_PreviewSettings.ResumeLayout(false);
            this.tlp_PreviewSettings.PerformLayout();
            this.tlp_ImagesPath.ResumeLayout(false);
            this.tlp_ImagesPath.PerformLayout();
            this.tlp_PreviewFrame.ResumeLayout(false);
            this.tlp_PreviewFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MouthFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EyeFrame)).EndInit();
            this.darkMenuStrip_MainMenu.ResumeLayout(false);
            this.darkMenuStrip_MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Scale)).EndInit();
            this.pnl_ImgPreview.ResumeLayout(false);
            this.pnl_ImgPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.ListBox listBox_Sprites;
        private System.Windows.Forms.GroupBox groupBox_BustupSettings;
        private System.Windows.Forms.GroupBox groupBox_PreviewSettings;
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSpriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameSelectedToolStripMenuItem;
        private DarkUI.Controls.DarkContextMenu darkContextMenu_Sprites;
        private DarkUI.Controls.DarkGroupBox groupBox_Texture;
        private DarkUI.Controls.DarkContextMenu darkContextMenu_Texture;
        private System.Windows.Forms.Panel panel_BustupSettings;
        private System.Windows.Forms.TableLayoutPanel tlp_BustupSettings;
        private System.Windows.Forms.Panel panel_PreviewSettings;
        private DarkUI.Controls.DarkLabel lbl_BasePos;
        private System.Windows.Forms.TableLayoutPanel tlp_BasePos;
        private DarkUI.Controls.DarkLabel lbl_BasePosX;
        private DarkUI.Controls.DarkLabel lbl_BasePosY;
        private DarkUI.Controls.DarkNumericUpDown num_BasePosX;
        private DarkUI.Controls.DarkNumericUpDown num_BasePosY;
        private DarkUI.Controls.DarkLabel lbl_EyePos;
        private System.Windows.Forms.TableLayoutPanel tlp_EyePos;
        private DarkUI.Controls.DarkNumericUpDown num_EyePosY;
        private DarkUI.Controls.DarkLabel lbl_EyePosX;
        private DarkUI.Controls.DarkLabel lbl_EyePosY;
        private DarkUI.Controls.DarkNumericUpDown num_EyePosX;
        private DarkUI.Controls.DarkLabel lbl_MouthPos;
        private System.Windows.Forms.TableLayoutPanel tlp_MouthPos;
        private DarkUI.Controls.DarkNumericUpDown num_MouthPosY;
        private DarkUI.Controls.DarkLabel lbl_MouthPosX;
        private DarkUI.Controls.DarkLabel lbl_MouthPosY;
        private DarkUI.Controls.DarkNumericUpDown num_MouthPosX;
        private DarkUI.Controls.DarkLabel lbl_Animation;
        private System.Windows.Forms.ComboBox comboBox_Animation;
        private System.Windows.Forms.TableLayoutPanel tlp_PreviewSettings;
        private System.Windows.Forms.TableLayoutPanel tlp_PreviewFrame;
        private DarkUI.Controls.DarkNumericUpDown num_MouthFrame;
        private DarkUI.Controls.DarkLabel lbl_MouthFrame;
        private DarkUI.Controls.DarkNumericUpDown num_EyeFrame;
        private DarkUI.Controls.DarkLabel lbl_EyeFrame;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlp_BustupID;
        private DarkUI.Controls.DarkNumericUpDown num_MinorID;
        private DarkUI.Controls.DarkLabel lbl_MajorID;
        private DarkUI.Controls.DarkLabel lbl_MinorID;
        private DarkUI.Controls.DarkNumericUpDown num_MajorID;
        private DarkUI.Controls.DarkNumericUpDown num_SubID;
        private DarkUI.Controls.DarkLabel lbl_SubID;
        private System.Windows.Forms.TableLayoutPanel tlp_ImagesPath;
        private DarkUI.Controls.DarkLabel lbl_ImagesPath;
        private DarkUI.Controls.DarkTextBox txt_ImagesPath;
        private DarkUI.Controls.DarkButton btn_ImagesPath;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private DarkUI.Controls.DarkLabel lbl_Scale;
        private DarkUI.Controls.DarkNumericUpDown num_Scale;
        private System.Windows.Forms.Panel pnl_ImgPreview;
        private System.Windows.Forms.PictureBox pictureBox_Tex;
        private System.Windows.Forms.ToolStripMenuItem openImageFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageFolderToolStripMenuItem1;
    }
}

