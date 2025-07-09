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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            listBox_Sprites = new System.Windows.Forms.ListBox();
            darkContextMenu_Sprites = new DarkUI.Controls.DarkContextMenu();
            addSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openImageFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            groupBox_BustupSettings = new System.Windows.Forms.GroupBox();
            panel_BustupSettings = new System.Windows.Forms.Panel();
            pnl_BustupSettings = new System.Windows.Forms.Panel();
            tlp_BustupSettings = new System.Windows.Forms.TableLayoutPanel();
            txt_OutfitName = new DarkUI.Controls.DarkTextBox();
            txt_ExpressionName = new DarkUI.Controls.DarkTextBox();
            txt_CharaName = new DarkUI.Controls.DarkTextBox();
            tlp_MouthImg3Browse = new System.Windows.Forms.TableLayoutPanel();
            txt_MouthImg3Browse = new DarkUI.Controls.DarkTextBox();
            btn_MouthImg3Browse = new DarkUI.Controls.DarkButton();
            tlp_MouthImg2Browse = new System.Windows.Forms.TableLayoutPanel();
            txt_MouthImg2Browse = new DarkUI.Controls.DarkTextBox();
            btn_MouthImg2Browse = new DarkUI.Controls.DarkButton();
            tlp_MouthImg1Browse = new System.Windows.Forms.TableLayoutPanel();
            txt_MouthImg1Browse = new DarkUI.Controls.DarkTextBox();
            btn_MouthImg1Browse = new DarkUI.Controls.DarkButton();
            tlp_BlinkImg2Browse = new System.Windows.Forms.TableLayoutPanel();
            txt_BlinkImg2Browse = new DarkUI.Controls.DarkTextBox();
            btn_BlinkImg2Browse = new DarkUI.Controls.DarkButton();
            tlp_BlinkImg1Browse = new System.Windows.Forms.TableLayoutPanel();
            txt_BlinkImg1Browse = new DarkUI.Controls.DarkTextBox();
            btn_BlinkImg1Browse = new DarkUI.Controls.DarkButton();
            lbl_BlinkImg1Browse = new DarkUI.Controls.DarkLabel();
            lbl_BaseImage = new DarkUI.Controls.DarkLabel();
            tlp_BaseImgBrowse = new System.Windows.Forms.TableLayoutPanel();
            txt_BaseImgBrowse = new DarkUI.Controls.DarkTextBox();
            btn_BaseImgBrowse = new DarkUI.Controls.DarkButton();
            tlp_BustupID = new System.Windows.Forms.TableLayoutPanel();
            num_SubID = new DarkUI.Controls.DarkNumericUpDown();
            num_MinorID = new DarkUI.Controls.DarkNumericUpDown();
            lbl_MajorID = new DarkUI.Controls.DarkLabel();
            lbl_MinorID = new DarkUI.Controls.DarkLabel();
            num_MajorID = new DarkUI.Controls.DarkNumericUpDown();
            lbl_SubID = new DarkUI.Controls.DarkLabel();
            comboBox_Animation = new System.Windows.Forms.ComboBox();
            lbl_Animation = new DarkUI.Controls.DarkLabel();
            tlp_MouthPos = new System.Windows.Forms.TableLayoutPanel();
            num_MouthPosY = new DarkUI.Controls.DarkNumericUpDown();
            lbl_MouthPosX = new DarkUI.Controls.DarkLabel();
            lbl_MouthPosY = new DarkUI.Controls.DarkLabel();
            num_MouthPosX = new DarkUI.Controls.DarkNumericUpDown();
            tlp_EyePos = new System.Windows.Forms.TableLayoutPanel();
            num_EyePosY = new DarkUI.Controls.DarkNumericUpDown();
            lbl_EyePosX = new DarkUI.Controls.DarkLabel();
            lbl_EyePosY = new DarkUI.Controls.DarkLabel();
            num_EyePosX = new DarkUI.Controls.DarkNumericUpDown();
            tlp_BasePos = new System.Windows.Forms.TableLayoutPanel();
            num_BasePosY = new DarkUI.Controls.DarkNumericUpDown();
            lbl_BasePosX = new DarkUI.Controls.DarkLabel();
            lbl_BasePosY = new DarkUI.Controls.DarkLabel();
            num_BasePosX = new DarkUI.Controls.DarkNumericUpDown();
            lbl_MouthPos = new DarkUI.Controls.DarkLabel();
            lbl_EyePos = new DarkUI.Controls.DarkLabel();
            lbl_BasePos = new DarkUI.Controls.DarkLabel();
            lbl_BlinkImg2Browse = new DarkUI.Controls.DarkLabel();
            lbl_MouthImg1Browse = new DarkUI.Controls.DarkLabel();
            lbl_MouthImg2Browse = new DarkUI.Controls.DarkLabel();
            lbl_MouthImg3Browse = new DarkUI.Controls.DarkLabel();
            lbl_CharaName = new DarkUI.Controls.DarkLabel();
            lbl_ExpressionName = new DarkUI.Controls.DarkLabel();
            lbl_OutfitName = new DarkUI.Controls.DarkLabel();
            groupBox_Texture = new DarkUI.Controls.DarkGroupBox();
            pnl_ImgPreview = new System.Windows.Forms.Panel();
            pictureBox_Tex = new System.Windows.Forms.PictureBox();
            darkContextMenu_Texture = new DarkUI.Controls.DarkContextMenu();
            openImageFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBox_PreviewSettings = new System.Windows.Forms.GroupBox();
            panel_PreviewSettings = new System.Windows.Forms.Panel();
            tlp_PreviewSettings = new System.Windows.Forms.TableLayoutPanel();
            lbl_ImagesPath = new DarkUI.Controls.DarkLabel();
            tlp_ImagesPath = new System.Windows.Forms.TableLayoutPanel();
            txt_ImagesPath = new DarkUI.Controls.DarkTextBox();
            btn_ImagesPath = new DarkUI.Controls.DarkButton();
            tlp_PreviewFrame = new System.Windows.Forms.TableLayoutPanel();
            lbl_EyeFrame = new DarkUI.Controls.DarkLabel();
            num_MouthFrame = new DarkUI.Controls.DarkNumericUpDown();
            lbl_MouthFrame = new DarkUI.Controls.DarkLabel();
            num_EyeFrame = new DarkUI.Controls.DarkNumericUpDown();
            lbl_Scale = new DarkUI.Controls.DarkLabel();
            num_Scale = new DarkUI.Controls.DarkNumericUpDown();
            darkMenuStrip_MainMenu = new DarkUI.Controls.DarkMenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            p5RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eventBustupProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            naviBustupProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            p5PS3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eventBustupProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            naviBustupProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            paramsDATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bustupBINsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            extractBustupBINsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            applyImgPathToAllWithSameExpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importNamesFromJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tlp_Main.SuspendLayout();
            darkContextMenu_Sprites.SuspendLayout();
            groupBox_BustupSettings.SuspendLayout();
            panel_BustupSettings.SuspendLayout();
            pnl_BustupSettings.SuspendLayout();
            tlp_BustupSettings.SuspendLayout();
            tlp_MouthImg3Browse.SuspendLayout();
            tlp_MouthImg2Browse.SuspendLayout();
            tlp_MouthImg1Browse.SuspendLayout();
            tlp_BlinkImg2Browse.SuspendLayout();
            tlp_BlinkImg1Browse.SuspendLayout();
            tlp_BaseImgBrowse.SuspendLayout();
            tlp_BustupID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_SubID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_MinorID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_MajorID).BeginInit();
            tlp_MouthPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_MouthPosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_MouthPosX).BeginInit();
            tlp_EyePos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_EyePosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_EyePosX).BeginInit();
            tlp_BasePos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_BasePosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_BasePosX).BeginInit();
            groupBox_Texture.SuspendLayout();
            pnl_ImgPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Tex).BeginInit();
            darkContextMenu_Texture.SuspendLayout();
            groupBox_PreviewSettings.SuspendLayout();
            panel_PreviewSettings.SuspendLayout();
            tlp_PreviewSettings.SuspendLayout();
            tlp_ImagesPath.SuspendLayout();
            tlp_PreviewFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_MouthFrame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_EyeFrame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Scale).BeginInit();
            darkMenuStrip_MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_Main
            // 
            tlp_Main.AllowDrop = true;
            tlp_Main.ColumnCount = 2;
            tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Main.Controls.Add(listBox_Sprites, 0, 0);
            tlp_Main.Controls.Add(groupBox_BustupSettings, 0, 1);
            tlp_Main.Controls.Add(groupBox_Texture, 1, 0);
            tlp_Main.Controls.Add(groupBox_PreviewSettings, 1, 2);
            tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_Main.Location = new System.Drawing.Point(0, 28);
            tlp_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_Main.Name = "tlp_Main";
            tlp_Main.RowCount = 3;
            tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_Main.Size = new System.Drawing.Size(982, 726);
            tlp_Main.TabIndex = 0;
            // 
            // listBox_Sprites
            // 
            listBox_Sprites.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            listBox_Sprites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listBox_Sprites.ContextMenuStrip = darkContextMenu_Sprites;
            listBox_Sprites.Dock = System.Windows.Forms.DockStyle.Fill;
            listBox_Sprites.ForeColor = System.Drawing.SystemColors.ScrollBar;
            listBox_Sprites.FormattingEnabled = true;
            listBox_Sprites.Location = new System.Drawing.Point(3, 4);
            listBox_Sprites.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listBox_Sprites.Name = "listBox_Sprites";
            listBox_Sprites.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            listBox_Sprites.Size = new System.Drawing.Size(485, 355);
            listBox_Sprites.TabIndex = 1;
            listBox_Sprites.SelectedIndexChanged += SelectedBustup_Changed;
            listBox_Sprites.KeyDown += KeyDown;
            // 
            // darkContextMenu_Sprites
            // 
            darkContextMenu_Sprites.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            darkContextMenu_Sprites.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            darkContextMenu_Sprites.ImageScalingSize = new System.Drawing.Size(20, 20);
            darkContextMenu_Sprites.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { addSpriteToolStripMenuItem, removeSelectedToolStripMenuItem, copySelectedToolStripMenuItem, pasteSelectedToolStripMenuItem, openImageFolderToolStripMenuItem1 });
            darkContextMenu_Sprites.Name = "darkContextMenu_Sprites";
            darkContextMenu_Sprites.Size = new System.Drawing.Size(207, 124);
            // 
            // addSpriteToolStripMenuItem
            // 
            addSpriteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            addSpriteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            addSpriteToolStripMenuItem.Name = "addSpriteToolStripMenuItem";
            addSpriteToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            addSpriteToolStripMenuItem.Text = "Add";
            addSpriteToolStripMenuItem.Click += Add_Click;
            // 
            // removeSelectedToolStripMenuItem
            // 
            removeSelectedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            removeSelectedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            removeSelectedToolStripMenuItem.Text = "Remove";
            removeSelectedToolStripMenuItem.Click += Remove_Click;
            // 
            // copySelectedToolStripMenuItem
            // 
            copySelectedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            copySelectedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            copySelectedToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            copySelectedToolStripMenuItem.Text = "Copy";
            copySelectedToolStripMenuItem.Click += Copy_Click;
            // 
            // pasteSelectedToolStripMenuItem
            // 
            pasteSelectedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            pasteSelectedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            pasteSelectedToolStripMenuItem.Name = "pasteSelectedToolStripMenuItem";
            pasteSelectedToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            pasteSelectedToolStripMenuItem.Text = "Paste";
            // 
            // openImageFolderToolStripMenuItem1
            // 
            openImageFolderToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            openImageFolderToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            openImageFolderToolStripMenuItem1.Name = "openImageFolderToolStripMenuItem1";
            openImageFolderToolStripMenuItem1.Size = new System.Drawing.Size(206, 24);
            openImageFolderToolStripMenuItem1.Text = "Open Image Folder";
            openImageFolderToolStripMenuItem1.Click += OpenImageFolder_Click;
            // 
            // groupBox_BustupSettings
            // 
            groupBox_BustupSettings.Controls.Add(panel_BustupSettings);
            groupBox_BustupSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_BustupSettings.ForeColor = System.Drawing.SystemColors.ScrollBar;
            groupBox_BustupSettings.Location = new System.Drawing.Point(3, 367);
            groupBox_BustupSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox_BustupSettings.Name = "groupBox_BustupSettings";
            groupBox_BustupSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_Main.SetRowSpan(groupBox_BustupSettings, 2);
            groupBox_BustupSettings.Size = new System.Drawing.Size(485, 355);
            groupBox_BustupSettings.TabIndex = 2;
            groupBox_BustupSettings.TabStop = false;
            groupBox_BustupSettings.Text = "Bustup Parameters";
            // 
            // panel_BustupSettings
            // 
            panel_BustupSettings.AutoScroll = true;
            panel_BustupSettings.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            panel_BustupSettings.Controls.Add(pnl_BustupSettings);
            panel_BustupSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_BustupSettings.Location = new System.Drawing.Point(3, 24);
            panel_BustupSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel_BustupSettings.Name = "panel_BustupSettings";
            panel_BustupSettings.Size = new System.Drawing.Size(479, 327);
            panel_BustupSettings.TabIndex = 0;
            // 
            // pnl_BustupSettings
            // 
            pnl_BustupSettings.AutoSize = true;
            pnl_BustupSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnl_BustupSettings.Controls.Add(tlp_BustupSettings);
            pnl_BustupSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_BustupSettings.Location = new System.Drawing.Point(0, 0);
            pnl_BustupSettings.Margin = new System.Windows.Forms.Padding(0);
            pnl_BustupSettings.Name = "pnl_BustupSettings";
            pnl_BustupSettings.Size = new System.Drawing.Size(479, 327);
            pnl_BustupSettings.TabIndex = 2;
            // 
            // tlp_BustupSettings
            // 
            tlp_BustupSettings.AutoScroll = true;
            tlp_BustupSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tlp_BustupSettings.ColumnCount = 3;
            tlp_BustupSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            tlp_BustupSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.35294F));
            tlp_BustupSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlp_BustupSettings.Controls.Add(txt_OutfitName, 1, 13);
            tlp_BustupSettings.Controls.Add(txt_ExpressionName, 1, 12);
            tlp_BustupSettings.Controls.Add(txt_CharaName, 1, 11);
            tlp_BustupSettings.Controls.Add(tlp_MouthImg3Browse, 1, 10);
            tlp_BustupSettings.Controls.Add(tlp_MouthImg2Browse, 1, 9);
            tlp_BustupSettings.Controls.Add(tlp_MouthImg1Browse, 1, 8);
            tlp_BustupSettings.Controls.Add(tlp_BlinkImg2Browse, 1, 7);
            tlp_BustupSettings.Controls.Add(tlp_BlinkImg1Browse, 1, 6);
            tlp_BustupSettings.Controls.Add(lbl_BlinkImg1Browse, 0, 6);
            tlp_BustupSettings.Controls.Add(lbl_BaseImage, 0, 5);
            tlp_BustupSettings.Controls.Add(tlp_BaseImgBrowse, 1, 5);
            tlp_BustupSettings.Controls.Add(tlp_BustupID, 0, 0);
            tlp_BustupSettings.Controls.Add(comboBox_Animation, 1, 4);
            tlp_BustupSettings.Controls.Add(lbl_Animation, 0, 4);
            tlp_BustupSettings.Controls.Add(tlp_MouthPos, 1, 3);
            tlp_BustupSettings.Controls.Add(tlp_EyePos, 1, 2);
            tlp_BustupSettings.Controls.Add(tlp_BasePos, 1, 1);
            tlp_BustupSettings.Controls.Add(lbl_MouthPos, 0, 3);
            tlp_BustupSettings.Controls.Add(lbl_EyePos, 0, 2);
            tlp_BustupSettings.Controls.Add(lbl_BasePos, 0, 1);
            tlp_BustupSettings.Controls.Add(lbl_BlinkImg2Browse, 0, 7);
            tlp_BustupSettings.Controls.Add(lbl_MouthImg1Browse, 0, 8);
            tlp_BustupSettings.Controls.Add(lbl_MouthImg2Browse, 0, 9);
            tlp_BustupSettings.Controls.Add(lbl_MouthImg3Browse, 0, 10);
            tlp_BustupSettings.Controls.Add(lbl_CharaName, 0, 11);
            tlp_BustupSettings.Controls.Add(lbl_ExpressionName, 0, 12);
            tlp_BustupSettings.Controls.Add(lbl_OutfitName, 0, 13);
            tlp_BustupSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_BustupSettings.Location = new System.Drawing.Point(0, 0);
            tlp_BustupSettings.Margin = new System.Windows.Forms.Padding(0);
            tlp_BustupSettings.Name = "tlp_BustupSettings";
            tlp_BustupSettings.RowCount = 15;
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_BustupSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlp_BustupSettings.Size = new System.Drawing.Size(479, 327);
            tlp_BustupSettings.TabIndex = 1;
            // 
            // txt_OutfitName
            // 
            txt_OutfitName.AllowDrop = true;
            txt_OutfitName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_OutfitName.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txt_OutfitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_OutfitName.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txt_OutfitName.Location = new System.Drawing.Point(87, 823);
            txt_OutfitName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_OutfitName.Name = "txt_OutfitName";
            txt_OutfitName.Size = new System.Drawing.Size(388, 27);
            txt_OutfitName.TabIndex = 26;
            txt_OutfitName.TextChanged += ImagePath_Changed;
            // 
            // txt_ExpressionName
            // 
            txt_ExpressionName.AllowDrop = true;
            txt_ExpressionName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_ExpressionName.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txt_ExpressionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_ExpressionName.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txt_ExpressionName.Location = new System.Drawing.Point(87, 761);
            txt_ExpressionName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_ExpressionName.Name = "txt_ExpressionName";
            txt_ExpressionName.Size = new System.Drawing.Size(388, 27);
            txt_ExpressionName.TabIndex = 25;
            txt_ExpressionName.TextChanged += ImagePath_Changed;
            // 
            // txt_CharaName
            // 
            txt_CharaName.AllowDrop = true;
            txt_CharaName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_CharaName.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txt_CharaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_CharaName.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txt_CharaName.Location = new System.Drawing.Point(87, 699);
            txt_CharaName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_CharaName.Name = "txt_CharaName";
            txt_CharaName.Size = new System.Drawing.Size(388, 27);
            txt_CharaName.TabIndex = 24;
            txt_CharaName.TextChanged += ImagePath_Changed;
            // 
            // tlp_MouthImg3Browse
            // 
            tlp_MouthImg3Browse.AllowDrop = true;
            tlp_MouthImg3Browse.ColumnCount = 2;
            tlp_MouthImg3Browse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tlp_MouthImg3Browse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_MouthImg3Browse.Controls.Add(txt_MouthImg3Browse, 0, 0);
            tlp_MouthImg3Browse.Controls.Add(btn_MouthImg3Browse, 1, 0);
            tlp_MouthImg3Browse.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_MouthImg3Browse.Location = new System.Drawing.Point(87, 624);
            tlp_MouthImg3Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_MouthImg3Browse.Name = "tlp_MouthImg3Browse";
            tlp_MouthImg3Browse.RowCount = 1;
            tlp_MouthImg3Browse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_MouthImg3Browse.Size = new System.Drawing.Size(388, 54);
            tlp_MouthImg3Browse.TabIndex = 20;
            // 
            // txt_MouthImg3Browse
            // 
            txt_MouthImg3Browse.AllowDrop = true;
            txt_MouthImg3Browse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_MouthImg3Browse.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txt_MouthImg3Browse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_MouthImg3Browse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txt_MouthImg3Browse.Location = new System.Drawing.Point(3, 13);
            txt_MouthImg3Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_MouthImg3Browse.Name = "txt_MouthImg3Browse";
            txt_MouthImg3Browse.Size = new System.Drawing.Size(285, 27);
            txt_MouthImg3Browse.TabIndex = 0;
            txt_MouthImg3Browse.TextChanged += ImagePath_Changed;
            txt_MouthImg3Browse.DragDrop += DragDrop_Txt;
            txt_MouthImg3Browse.DragEnter += DragEnter;
            // 
            // btn_MouthImg3Browse
            // 
            btn_MouthImg3Browse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_MouthImg3Browse.Location = new System.Drawing.Point(294, 12);
            btn_MouthImg3Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_MouthImg3Browse.Name = "btn_MouthImg3Browse";
            btn_MouthImg3Browse.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btn_MouthImg3Browse.Size = new System.Drawing.Size(48, 29);
            btn_MouthImg3Browse.TabIndex = 1;
            btn_MouthImg3Browse.Text = "...";
            btn_MouthImg3Browse.Click += BrowseImagePath_Click;
            // 
            // tlp_MouthImg2Browse
            // 
            tlp_MouthImg2Browse.AllowDrop = true;
            tlp_MouthImg2Browse.ColumnCount = 2;
            tlp_MouthImg2Browse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tlp_MouthImg2Browse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_MouthImg2Browse.Controls.Add(txt_MouthImg2Browse, 0, 0);
            tlp_MouthImg2Browse.Controls.Add(btn_MouthImg2Browse, 1, 0);
            tlp_MouthImg2Browse.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_MouthImg2Browse.Location = new System.Drawing.Point(87, 562);
            tlp_MouthImg2Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_MouthImg2Browse.Name = "tlp_MouthImg2Browse";
            tlp_MouthImg2Browse.RowCount = 1;
            tlp_MouthImg2Browse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_MouthImg2Browse.Size = new System.Drawing.Size(388, 54);
            tlp_MouthImg2Browse.TabIndex = 19;
            // 
            // txt_MouthImg2Browse
            // 
            txt_MouthImg2Browse.AllowDrop = true;
            txt_MouthImg2Browse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_MouthImg2Browse.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txt_MouthImg2Browse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_MouthImg2Browse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txt_MouthImg2Browse.Location = new System.Drawing.Point(3, 13);
            txt_MouthImg2Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_MouthImg2Browse.Name = "txt_MouthImg2Browse";
            txt_MouthImg2Browse.Size = new System.Drawing.Size(285, 27);
            txt_MouthImg2Browse.TabIndex = 0;
            txt_MouthImg2Browse.TextChanged += ImagePath_Changed;
            txt_MouthImg2Browse.DragDrop += DragDrop_Txt;
            txt_MouthImg2Browse.DragEnter += DragEnter;
            // 
            // btn_MouthImg2Browse
            // 
            btn_MouthImg2Browse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_MouthImg2Browse.Location = new System.Drawing.Point(294, 12);
            btn_MouthImg2Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_MouthImg2Browse.Name = "btn_MouthImg2Browse";
            btn_MouthImg2Browse.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btn_MouthImg2Browse.Size = new System.Drawing.Size(48, 29);
            btn_MouthImg2Browse.TabIndex = 1;
            btn_MouthImg2Browse.Text = "...";
            btn_MouthImg2Browse.Click += BrowseImagePath_Click;
            // 
            // tlp_MouthImg1Browse
            // 
            tlp_MouthImg1Browse.AllowDrop = true;
            tlp_MouthImg1Browse.ColumnCount = 2;
            tlp_MouthImg1Browse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tlp_MouthImg1Browse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_MouthImg1Browse.Controls.Add(txt_MouthImg1Browse, 0, 0);
            tlp_MouthImg1Browse.Controls.Add(btn_MouthImg1Browse, 1, 0);
            tlp_MouthImg1Browse.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_MouthImg1Browse.Location = new System.Drawing.Point(87, 500);
            tlp_MouthImg1Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_MouthImg1Browse.Name = "tlp_MouthImg1Browse";
            tlp_MouthImg1Browse.RowCount = 1;
            tlp_MouthImg1Browse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_MouthImg1Browse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            tlp_MouthImg1Browse.Size = new System.Drawing.Size(388, 54);
            tlp_MouthImg1Browse.TabIndex = 18;
            // 
            // txt_MouthImg1Browse
            // 
            txt_MouthImg1Browse.AllowDrop = true;
            txt_MouthImg1Browse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_MouthImg1Browse.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txt_MouthImg1Browse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_MouthImg1Browse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txt_MouthImg1Browse.Location = new System.Drawing.Point(3, 13);
            txt_MouthImg1Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_MouthImg1Browse.Name = "txt_MouthImg1Browse";
            txt_MouthImg1Browse.Size = new System.Drawing.Size(285, 27);
            txt_MouthImg1Browse.TabIndex = 0;
            txt_MouthImg1Browse.TextChanged += ImagePath_Changed;
            txt_MouthImg1Browse.DragDrop += DragDrop_Txt;
            txt_MouthImg1Browse.DragEnter += DragEnter;
            // 
            // btn_MouthImg1Browse
            // 
            btn_MouthImg1Browse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_MouthImg1Browse.Location = new System.Drawing.Point(294, 12);
            btn_MouthImg1Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_MouthImg1Browse.Name = "btn_MouthImg1Browse";
            btn_MouthImg1Browse.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btn_MouthImg1Browse.Size = new System.Drawing.Size(48, 29);
            btn_MouthImg1Browse.TabIndex = 1;
            btn_MouthImg1Browse.Text = "...";
            btn_MouthImg1Browse.Click += BrowseImagePath_Click;
            // 
            // tlp_BlinkImg2Browse
            // 
            tlp_BlinkImg2Browse.AllowDrop = true;
            tlp_BlinkImg2Browse.ColumnCount = 2;
            tlp_BlinkImg2Browse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tlp_BlinkImg2Browse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_BlinkImg2Browse.Controls.Add(txt_BlinkImg2Browse, 0, 0);
            tlp_BlinkImg2Browse.Controls.Add(btn_BlinkImg2Browse, 1, 0);
            tlp_BlinkImg2Browse.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_BlinkImg2Browse.Location = new System.Drawing.Point(87, 438);
            tlp_BlinkImg2Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_BlinkImg2Browse.Name = "tlp_BlinkImg2Browse";
            tlp_BlinkImg2Browse.RowCount = 1;
            tlp_BlinkImg2Browse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_BlinkImg2Browse.Size = new System.Drawing.Size(388, 54);
            tlp_BlinkImg2Browse.TabIndex = 17;
            // 
            // txt_BlinkImg2Browse
            // 
            txt_BlinkImg2Browse.AllowDrop = true;
            txt_BlinkImg2Browse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_BlinkImg2Browse.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txt_BlinkImg2Browse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_BlinkImg2Browse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txt_BlinkImg2Browse.Location = new System.Drawing.Point(3, 13);
            txt_BlinkImg2Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_BlinkImg2Browse.Name = "txt_BlinkImg2Browse";
            txt_BlinkImg2Browse.Size = new System.Drawing.Size(285, 27);
            txt_BlinkImg2Browse.TabIndex = 0;
            txt_BlinkImg2Browse.TextChanged += ImagePath_Changed;
            txt_BlinkImg2Browse.DragDrop += DragDrop_Txt;
            txt_BlinkImg2Browse.DragEnter += DragEnter;
            // 
            // btn_BlinkImg2Browse
            // 
            btn_BlinkImg2Browse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_BlinkImg2Browse.Location = new System.Drawing.Point(294, 12);
            btn_BlinkImg2Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_BlinkImg2Browse.Name = "btn_BlinkImg2Browse";
            btn_BlinkImg2Browse.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btn_BlinkImg2Browse.Size = new System.Drawing.Size(48, 29);
            btn_BlinkImg2Browse.TabIndex = 1;
            btn_BlinkImg2Browse.Text = "...";
            btn_BlinkImg2Browse.Click += BrowseImagePath_Click;
            // 
            // tlp_BlinkImg1Browse
            // 
            tlp_BlinkImg1Browse.AllowDrop = true;
            tlp_BlinkImg1Browse.ColumnCount = 2;
            tlp_BlinkImg1Browse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tlp_BlinkImg1Browse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_BlinkImg1Browse.Controls.Add(txt_BlinkImg1Browse, 0, 0);
            tlp_BlinkImg1Browse.Controls.Add(btn_BlinkImg1Browse, 1, 0);
            tlp_BlinkImg1Browse.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_BlinkImg1Browse.Location = new System.Drawing.Point(87, 376);
            tlp_BlinkImg1Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_BlinkImg1Browse.Name = "tlp_BlinkImg1Browse";
            tlp_BlinkImg1Browse.RowCount = 1;
            tlp_BlinkImg1Browse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_BlinkImg1Browse.Size = new System.Drawing.Size(388, 54);
            tlp_BlinkImg1Browse.TabIndex = 16;
            // 
            // txt_BlinkImg1Browse
            // 
            txt_BlinkImg1Browse.AllowDrop = true;
            txt_BlinkImg1Browse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_BlinkImg1Browse.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txt_BlinkImg1Browse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_BlinkImg1Browse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txt_BlinkImg1Browse.Location = new System.Drawing.Point(3, 13);
            txt_BlinkImg1Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_BlinkImg1Browse.Name = "txt_BlinkImg1Browse";
            txt_BlinkImg1Browse.Size = new System.Drawing.Size(285, 27);
            txt_BlinkImg1Browse.TabIndex = 0;
            txt_BlinkImg1Browse.TextChanged += ImagePath_Changed;
            txt_BlinkImg1Browse.DragDrop += DragDrop_Txt;
            txt_BlinkImg1Browse.DragEnter += DragEnter;
            // 
            // btn_BlinkImg1Browse
            // 
            btn_BlinkImg1Browse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_BlinkImg1Browse.Location = new System.Drawing.Point(294, 12);
            btn_BlinkImg1Browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_BlinkImg1Browse.Name = "btn_BlinkImg1Browse";
            btn_BlinkImg1Browse.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btn_BlinkImg1Browse.Size = new System.Drawing.Size(48, 29);
            btn_BlinkImg1Browse.TabIndex = 1;
            btn_BlinkImg1Browse.Text = "...";
            btn_BlinkImg1Browse.Click += BrowseImagePath_Click;
            // 
            // lbl_BlinkImg1Browse
            // 
            lbl_BlinkImg1Browse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_BlinkImg1Browse.AutoSize = true;
            lbl_BlinkImg1Browse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_BlinkImg1Browse.Location = new System.Drawing.Point(3, 383);
            lbl_BlinkImg1Browse.Name = "lbl_BlinkImg1Browse";
            lbl_BlinkImg1Browse.Size = new System.Drawing.Size(78, 40);
            lbl_BlinkImg1Browse.TabIndex = 11;
            lbl_BlinkImg1Browse.Text = "Blink Img 1:";
            // 
            // lbl_BaseImage
            // 
            lbl_BaseImage.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_BaseImage.AutoSize = true;
            lbl_BaseImage.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_BaseImage.Location = new System.Drawing.Point(3, 331);
            lbl_BaseImage.Name = "lbl_BaseImage";
            lbl_BaseImage.Size = new System.Drawing.Size(78, 20);
            lbl_BaseImage.TabIndex = 10;
            lbl_BaseImage.Text = "Base Img:";
            // 
            // tlp_BaseImgBrowse
            // 
            tlp_BaseImgBrowse.AllowDrop = true;
            tlp_BaseImgBrowse.ColumnCount = 2;
            tlp_BaseImgBrowse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tlp_BaseImgBrowse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_BaseImgBrowse.Controls.Add(txt_BaseImgBrowse, 0, 0);
            tlp_BaseImgBrowse.Controls.Add(btn_BaseImgBrowse, 1, 0);
            tlp_BaseImgBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_BaseImgBrowse.Location = new System.Drawing.Point(87, 314);
            tlp_BaseImgBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_BaseImgBrowse.Name = "tlp_BaseImgBrowse";
            tlp_BaseImgBrowse.RowCount = 1;
            tlp_BaseImgBrowse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_BaseImgBrowse.Size = new System.Drawing.Size(388, 54);
            tlp_BaseImgBrowse.TabIndex = 9;
            // 
            // txt_BaseImgBrowse
            // 
            txt_BaseImgBrowse.AllowDrop = true;
            txt_BaseImgBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_BaseImgBrowse.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txt_BaseImgBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_BaseImgBrowse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txt_BaseImgBrowse.Location = new System.Drawing.Point(3, 13);
            txt_BaseImgBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_BaseImgBrowse.Name = "txt_BaseImgBrowse";
            txt_BaseImgBrowse.Size = new System.Drawing.Size(285, 27);
            txt_BaseImgBrowse.TabIndex = 0;
            txt_BaseImgBrowse.TextChanged += ImagePath_Changed;
            txt_BaseImgBrowse.DragDrop += DragDrop_Txt;
            txt_BaseImgBrowse.DragEnter += DragEnter;
            // 
            // btn_BaseImgBrowse
            // 
            btn_BaseImgBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_BaseImgBrowse.Location = new System.Drawing.Point(294, 12);
            btn_BaseImgBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_BaseImgBrowse.Name = "btn_BaseImgBrowse";
            btn_BaseImgBrowse.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btn_BaseImgBrowse.Size = new System.Drawing.Size(48, 29);
            btn_BaseImgBrowse.TabIndex = 1;
            btn_BaseImgBrowse.Text = "...";
            btn_BaseImgBrowse.Click += BrowseImagePath_Click;
            // 
            // tlp_BustupID
            // 
            tlp_BustupID.ColumnCount = 6;
            tlp_BustupSettings.SetColumnSpan(tlp_BustupID, 2);
            tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            tlp_BustupID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tlp_BustupID.Controls.Add(num_SubID, 5, 0);
            tlp_BustupID.Controls.Add(num_MinorID, 3, 0);
            tlp_BustupID.Controls.Add(lbl_MajorID, 0, 0);
            tlp_BustupID.Controls.Add(lbl_MinorID, 2, 0);
            tlp_BustupID.Controls.Add(num_MajorID, 1, 0);
            tlp_BustupID.Controls.Add(lbl_SubID, 4, 0);
            tlp_BustupID.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_BustupID.Location = new System.Drawing.Point(3, 4);
            tlp_BustupID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_BustupID.Name = "tlp_BustupID";
            tlp_BustupID.RowCount = 1;
            tlp_BustupID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_BustupID.Size = new System.Drawing.Size(472, 54);
            tlp_BustupID.TabIndex = 8;
            // 
            // num_SubID
            // 
            num_SubID.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            num_SubID.Location = new System.Drawing.Point(415, 13);
            num_SubID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_SubID.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            num_SubID.Name = "num_SubID";
            num_SubID.Size = new System.Drawing.Size(54, 27);
            num_SubID.TabIndex = 5;
            num_SubID.ValueChanged += SubID_Changed;
            // 
            // num_MinorID
            // 
            num_MinorID.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            num_MinorID.Location = new System.Drawing.Point(258, 13);
            num_MinorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_MinorID.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            num_MinorID.Name = "num_MinorID";
            num_MinorID.Size = new System.Drawing.Size(53, 27);
            num_MinorID.TabIndex = 3;
            num_MinorID.ValueChanged += MinorID_Changed;
            // 
            // lbl_MajorID
            // 
            lbl_MajorID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_MajorID.AutoSize = true;
            lbl_MajorID.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_MajorID.Location = new System.Drawing.Point(19, 7);
            lbl_MajorID.Name = "lbl_MajorID";
            lbl_MajorID.Size = new System.Drawing.Size(76, 40);
            lbl_MajorID.TabIndex = 0;
            lbl_MajorID.Text = "Character ID:";
            // 
            // lbl_MinorID
            // 
            lbl_MinorID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_MinorID.AutoSize = true;
            lbl_MinorID.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_MinorID.Location = new System.Drawing.Point(169, 7);
            lbl_MinorID.Name = "lbl_MinorID";
            lbl_MinorID.Size = new System.Drawing.Size(83, 40);
            lbl_MinorID.TabIndex = 1;
            lbl_MinorID.Text = "Expression ID:";
            // 
            // num_MajorID
            // 
            num_MajorID.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            num_MajorID.Location = new System.Drawing.Point(101, 13);
            num_MajorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_MajorID.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            num_MajorID.Name = "num_MajorID";
            num_MajorID.Size = new System.Drawing.Size(53, 27);
            num_MajorID.TabIndex = 2;
            num_MajorID.ValueChanged += MajorID_Changed;
            // 
            // lbl_SubID
            // 
            lbl_SubID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_SubID.AutoSize = true;
            lbl_SubID.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_SubID.Location = new System.Drawing.Point(340, 17);
            lbl_SubID.Name = "lbl_SubID";
            lbl_SubID.Size = new System.Drawing.Size(69, 20);
            lbl_SubID.TabIndex = 4;
            lbl_SubID.Text = "Outfit ID:";
            // 
            // comboBox_Animation
            // 
            comboBox_Animation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            comboBox_Animation.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            comboBox_Animation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_Animation.ForeColor = System.Drawing.Color.Silver;
            comboBox_Animation.FormattingEnabled = true;
            comboBox_Animation.Items.AddRange(new object[] { "None", "Eyes", "Mouth", "Eyes_Mouth", "Eyes_Mouth_ExcludeAlpha", "Unknown" });
            comboBox_Animation.Location = new System.Drawing.Point(87, 269);
            comboBox_Animation.Margin = new System.Windows.Forms.Padding(3, 12, 3, 4);
            comboBox_Animation.Name = "comboBox_Animation";
            comboBox_Animation.Size = new System.Drawing.Size(185, 28);
            comboBox_Animation.TabIndex = 7;
            comboBox_Animation.SelectedIndexChanged += Animation_Changed;
            // 
            // lbl_Animation
            // 
            lbl_Animation.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_Animation.AutoSize = true;
            lbl_Animation.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_Animation.Location = new System.Drawing.Point(3, 259);
            lbl_Animation.Name = "lbl_Animation";
            lbl_Animation.Size = new System.Drawing.Size(78, 40);
            lbl_Animation.TabIndex = 6;
            lbl_Animation.Text = "Animation:";
            // 
            // tlp_MouthPos
            // 
            tlp_MouthPos.ColumnCount = 4;
            tlp_MouthPos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp_MouthPos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tlp_MouthPos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp_MouthPos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tlp_MouthPos.Controls.Add(num_MouthPosY, 3, 0);
            tlp_MouthPos.Controls.Add(lbl_MouthPosX, 0, 0);
            tlp_MouthPos.Controls.Add(lbl_MouthPosY, 2, 0);
            tlp_MouthPos.Controls.Add(num_MouthPosX, 1, 0);
            tlp_MouthPos.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_MouthPos.Location = new System.Drawing.Point(87, 190);
            tlp_MouthPos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_MouthPos.Name = "tlp_MouthPos";
            tlp_MouthPos.RowCount = 1;
            tlp_MouthPos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_MouthPos.Size = new System.Drawing.Size(388, 54);
            tlp_MouthPos.TabIndex = 5;
            // 
            // num_MouthPosY
            // 
            num_MouthPosY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            num_MouthPosY.Location = new System.Drawing.Point(273, 13);
            num_MouthPosY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_MouthPosY.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_MouthPosY.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            num_MouthPosY.Name = "num_MouthPosY";
            num_MouthPosY.Size = new System.Drawing.Size(87, 27);
            num_MouthPosY.TabIndex = 3;
            num_MouthPosY.ValueChanged += MouthPosY_Changed;
            // 
            // lbl_MouthPosX
            // 
            lbl_MouthPosX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_MouthPosX.AutoSize = true;
            lbl_MouthPosX.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_MouthPosX.Location = new System.Drawing.Point(53, 17);
            lbl_MouthPosX.Name = "lbl_MouthPosX";
            lbl_MouthPosX.Size = new System.Drawing.Size(21, 20);
            lbl_MouthPosX.TabIndex = 0;
            lbl_MouthPosX.Text = "X:";
            // 
            // lbl_MouthPosY
            // 
            lbl_MouthPosY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_MouthPosY.AutoSize = true;
            lbl_MouthPosY.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_MouthPosY.Location = new System.Drawing.Point(247, 17);
            lbl_MouthPosY.Name = "lbl_MouthPosY";
            lbl_MouthPosY.Size = new System.Drawing.Size(20, 20);
            lbl_MouthPosY.TabIndex = 1;
            lbl_MouthPosY.Text = "Y:";
            // 
            // num_MouthPosX
            // 
            num_MouthPosX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            num_MouthPosX.Location = new System.Drawing.Point(80, 13);
            num_MouthPosX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_MouthPosX.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_MouthPosX.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            num_MouthPosX.Name = "num_MouthPosX";
            num_MouthPosX.Size = new System.Drawing.Size(84, 27);
            num_MouthPosX.TabIndex = 2;
            num_MouthPosX.ValueChanged += MouthPosX_Changed;
            // 
            // tlp_EyePos
            // 
            tlp_EyePos.ColumnCount = 4;
            tlp_EyePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp_EyePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tlp_EyePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp_EyePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tlp_EyePos.Controls.Add(num_EyePosY, 3, 0);
            tlp_EyePos.Controls.Add(lbl_EyePosX, 0, 0);
            tlp_EyePos.Controls.Add(lbl_EyePosY, 2, 0);
            tlp_EyePos.Controls.Add(num_EyePosX, 1, 0);
            tlp_EyePos.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_EyePos.Location = new System.Drawing.Point(87, 128);
            tlp_EyePos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_EyePos.Name = "tlp_EyePos";
            tlp_EyePos.RowCount = 1;
            tlp_EyePos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_EyePos.Size = new System.Drawing.Size(388, 54);
            tlp_EyePos.TabIndex = 3;
            // 
            // num_EyePosY
            // 
            num_EyePosY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            num_EyePosY.Location = new System.Drawing.Point(273, 13);
            num_EyePosY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_EyePosY.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_EyePosY.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            num_EyePosY.Name = "num_EyePosY";
            num_EyePosY.Size = new System.Drawing.Size(87, 27);
            num_EyePosY.TabIndex = 3;
            num_EyePosY.ValueChanged += EyePosY_Changed;
            // 
            // lbl_EyePosX
            // 
            lbl_EyePosX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_EyePosX.AutoSize = true;
            lbl_EyePosX.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_EyePosX.Location = new System.Drawing.Point(53, 17);
            lbl_EyePosX.Name = "lbl_EyePosX";
            lbl_EyePosX.Size = new System.Drawing.Size(21, 20);
            lbl_EyePosX.TabIndex = 0;
            lbl_EyePosX.Text = "X:";
            // 
            // lbl_EyePosY
            // 
            lbl_EyePosY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_EyePosY.AutoSize = true;
            lbl_EyePosY.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_EyePosY.Location = new System.Drawing.Point(247, 17);
            lbl_EyePosY.Name = "lbl_EyePosY";
            lbl_EyePosY.Size = new System.Drawing.Size(20, 20);
            lbl_EyePosY.TabIndex = 1;
            lbl_EyePosY.Text = "Y:";
            // 
            // num_EyePosX
            // 
            num_EyePosX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            num_EyePosX.Location = new System.Drawing.Point(80, 13);
            num_EyePosX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_EyePosX.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_EyePosX.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            num_EyePosX.Name = "num_EyePosX";
            num_EyePosX.Size = new System.Drawing.Size(84, 27);
            num_EyePosX.TabIndex = 2;
            num_EyePosX.ValueChanged += EyePosX_Changed;
            // 
            // tlp_BasePos
            // 
            tlp_BasePos.ColumnCount = 4;
            tlp_BasePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp_BasePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tlp_BasePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp_BasePos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tlp_BasePos.Controls.Add(num_BasePosY, 3, 0);
            tlp_BasePos.Controls.Add(lbl_BasePosX, 0, 0);
            tlp_BasePos.Controls.Add(lbl_BasePosY, 2, 0);
            tlp_BasePos.Controls.Add(num_BasePosX, 1, 0);
            tlp_BasePos.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_BasePos.Location = new System.Drawing.Point(87, 66);
            tlp_BasePos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_BasePos.Name = "tlp_BasePos";
            tlp_BasePos.RowCount = 1;
            tlp_BasePos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_BasePos.Size = new System.Drawing.Size(388, 54);
            tlp_BasePos.TabIndex = 1;
            // 
            // num_BasePosY
            // 
            num_BasePosY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            num_BasePosY.Location = new System.Drawing.Point(273, 13);
            num_BasePosY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_BasePosY.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_BasePosY.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            num_BasePosY.Name = "num_BasePosY";
            num_BasePosY.Size = new System.Drawing.Size(87, 27);
            num_BasePosY.TabIndex = 3;
            num_BasePosY.ValueChanged += BasePosY_Changed;
            // 
            // lbl_BasePosX
            // 
            lbl_BasePosX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_BasePosX.AutoSize = true;
            lbl_BasePosX.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_BasePosX.Location = new System.Drawing.Point(53, 17);
            lbl_BasePosX.Name = "lbl_BasePosX";
            lbl_BasePosX.Size = new System.Drawing.Size(21, 20);
            lbl_BasePosX.TabIndex = 0;
            lbl_BasePosX.Text = "X:";
            // 
            // lbl_BasePosY
            // 
            lbl_BasePosY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_BasePosY.AutoSize = true;
            lbl_BasePosY.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_BasePosY.Location = new System.Drawing.Point(247, 17);
            lbl_BasePosY.Name = "lbl_BasePosY";
            lbl_BasePosY.Size = new System.Drawing.Size(20, 20);
            lbl_BasePosY.TabIndex = 1;
            lbl_BasePosY.Text = "Y:";
            // 
            // num_BasePosX
            // 
            num_BasePosX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            num_BasePosX.Location = new System.Drawing.Point(80, 13);
            num_BasePosX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_BasePosX.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_BasePosX.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            num_BasePosX.Name = "num_BasePosX";
            num_BasePosX.Size = new System.Drawing.Size(84, 27);
            num_BasePosX.TabIndex = 2;
            num_BasePosX.ValueChanged += BasePosX_Changed;
            // 
            // lbl_MouthPos
            // 
            lbl_MouthPos.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_MouthPos.AutoSize = true;
            lbl_MouthPos.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_MouthPos.Location = new System.Drawing.Point(3, 197);
            lbl_MouthPos.Name = "lbl_MouthPos";
            lbl_MouthPos.Size = new System.Drawing.Size(78, 40);
            lbl_MouthPos.TabIndex = 4;
            lbl_MouthPos.Text = "Mouth Position:";
            // 
            // lbl_EyePos
            // 
            lbl_EyePos.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_EyePos.AutoSize = true;
            lbl_EyePos.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_EyePos.Location = new System.Drawing.Point(3, 135);
            lbl_EyePos.Name = "lbl_EyePos";
            lbl_EyePos.Size = new System.Drawing.Size(78, 40);
            lbl_EyePos.TabIndex = 2;
            lbl_EyePos.Text = "Eye Position:";
            // 
            // lbl_BasePos
            // 
            lbl_BasePos.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_BasePos.AutoSize = true;
            lbl_BasePos.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_BasePos.Location = new System.Drawing.Point(3, 73);
            lbl_BasePos.Name = "lbl_BasePos";
            lbl_BasePos.Size = new System.Drawing.Size(78, 40);
            lbl_BasePos.TabIndex = 0;
            lbl_BasePos.Text = "Base Position:";
            // 
            // lbl_BlinkImg2Browse
            // 
            lbl_BlinkImg2Browse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_BlinkImg2Browse.AutoSize = true;
            lbl_BlinkImg2Browse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_BlinkImg2Browse.Location = new System.Drawing.Point(3, 445);
            lbl_BlinkImg2Browse.Name = "lbl_BlinkImg2Browse";
            lbl_BlinkImg2Browse.Size = new System.Drawing.Size(78, 40);
            lbl_BlinkImg2Browse.TabIndex = 12;
            lbl_BlinkImg2Browse.Text = "Blink Img 2:";
            // 
            // lbl_MouthImg1Browse
            // 
            lbl_MouthImg1Browse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_MouthImg1Browse.AutoSize = true;
            lbl_MouthImg1Browse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_MouthImg1Browse.Location = new System.Drawing.Point(3, 507);
            lbl_MouthImg1Browse.Name = "lbl_MouthImg1Browse";
            lbl_MouthImg1Browse.Size = new System.Drawing.Size(78, 40);
            lbl_MouthImg1Browse.TabIndex = 13;
            lbl_MouthImg1Browse.Text = "Mouth Img 1:";
            // 
            // lbl_MouthImg2Browse
            // 
            lbl_MouthImg2Browse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_MouthImg2Browse.AutoSize = true;
            lbl_MouthImg2Browse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_MouthImg2Browse.Location = new System.Drawing.Point(3, 569);
            lbl_MouthImg2Browse.Name = "lbl_MouthImg2Browse";
            lbl_MouthImg2Browse.Size = new System.Drawing.Size(78, 40);
            lbl_MouthImg2Browse.TabIndex = 14;
            lbl_MouthImg2Browse.Text = "Mouth Img 2:";
            // 
            // lbl_MouthImg3Browse
            // 
            lbl_MouthImg3Browse.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_MouthImg3Browse.AutoSize = true;
            lbl_MouthImg3Browse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_MouthImg3Browse.Location = new System.Drawing.Point(3, 631);
            lbl_MouthImg3Browse.Name = "lbl_MouthImg3Browse";
            lbl_MouthImg3Browse.Size = new System.Drawing.Size(78, 40);
            lbl_MouthImg3Browse.TabIndex = 15;
            lbl_MouthImg3Browse.Text = "Mouth Img 3:";
            // 
            // lbl_CharaName
            // 
            lbl_CharaName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_CharaName.AutoSize = true;
            lbl_CharaName.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_CharaName.Location = new System.Drawing.Point(3, 693);
            lbl_CharaName.Name = "lbl_CharaName";
            lbl_CharaName.Size = new System.Drawing.Size(78, 40);
            lbl_CharaName.TabIndex = 21;
            lbl_CharaName.Text = "Chara Name:";
            // 
            // lbl_ExpressionName
            // 
            lbl_ExpressionName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_ExpressionName.AutoSize = true;
            lbl_ExpressionName.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_ExpressionName.Location = new System.Drawing.Point(3, 755);
            lbl_ExpressionName.Name = "lbl_ExpressionName";
            lbl_ExpressionName.Size = new System.Drawing.Size(78, 40);
            lbl_ExpressionName.TabIndex = 22;
            lbl_ExpressionName.Text = "Expression Name:";
            // 
            // lbl_OutfitName
            // 
            lbl_OutfitName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_OutfitName.AutoSize = true;
            lbl_OutfitName.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_OutfitName.Location = new System.Drawing.Point(3, 817);
            lbl_OutfitName.Name = "lbl_OutfitName";
            lbl_OutfitName.Size = new System.Drawing.Size(78, 40);
            lbl_OutfitName.TabIndex = 23;
            lbl_OutfitName.Text = "Outfit Name:";
            // 
            // groupBox_Texture
            // 
            groupBox_Texture.BorderColor = System.Drawing.Color.FromArgb(60, 63, 65);
            groupBox_Texture.Controls.Add(pnl_ImgPreview);
            groupBox_Texture.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_Texture.Location = new System.Drawing.Point(494, 4);
            groupBox_Texture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox_Texture.Name = "groupBox_Texture";
            groupBox_Texture.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_Main.SetRowSpan(groupBox_Texture, 2);
            groupBox_Texture.Size = new System.Drawing.Size(485, 536);
            groupBox_Texture.TabIndex = 4;
            groupBox_Texture.TabStop = false;
            groupBox_Texture.Text = "Bustup Texture";
            // 
            // pnl_ImgPreview
            // 
            pnl_ImgPreview.AllowDrop = true;
            pnl_ImgPreview.AutoScroll = true;
            pnl_ImgPreview.AutoSize = true;
            pnl_ImgPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnl_ImgPreview.Controls.Add(pictureBox_Tex);
            pnl_ImgPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_ImgPreview.Location = new System.Drawing.Point(3, 24);
            pnl_ImgPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnl_ImgPreview.Name = "pnl_ImgPreview";
            pnl_ImgPreview.Size = new System.Drawing.Size(479, 508);
            pnl_ImgPreview.TabIndex = 0;
            // 
            // pictureBox_Tex
            // 
            pictureBox_Tex.BackColor = System.Drawing.Color.FromArgb(50, 53, 55);
            pictureBox_Tex.ContextMenuStrip = darkContextMenu_Texture;
            pictureBox_Tex.Location = new System.Drawing.Point(8, 10);
            pictureBox_Tex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox_Tex.Name = "pictureBox_Tex";
            pictureBox_Tex.Size = new System.Drawing.Size(479, 402);
            pictureBox_Tex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox_Tex.TabIndex = 2;
            pictureBox_Tex.TabStop = false;
            // 
            // darkContextMenu_Texture
            // 
            darkContextMenu_Texture.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            darkContextMenu_Texture.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            darkContextMenu_Texture.ImageScalingSize = new System.Drawing.Size(20, 20);
            darkContextMenu_Texture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openImageFolderToolStripMenuItem });
            darkContextMenu_Texture.Name = "darkContextMenu_Texture";
            darkContextMenu_Texture.Size = new System.Drawing.Size(207, 28);
            // 
            // openImageFolderToolStripMenuItem
            // 
            openImageFolderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            openImageFolderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            openImageFolderToolStripMenuItem.Name = "openImageFolderToolStripMenuItem";
            openImageFolderToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            openImageFolderToolStripMenuItem.Text = "Open Image Folder";
            openImageFolderToolStripMenuItem.Click += OpenImageFolder_Click;
            // 
            // groupBox_PreviewSettings
            // 
            groupBox_PreviewSettings.Controls.Add(panel_PreviewSettings);
            groupBox_PreviewSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_PreviewSettings.ForeColor = System.Drawing.SystemColors.ScrollBar;
            groupBox_PreviewSettings.Location = new System.Drawing.Point(494, 548);
            groupBox_PreviewSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox_PreviewSettings.Name = "groupBox_PreviewSettings";
            groupBox_PreviewSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox_PreviewSettings.Size = new System.Drawing.Size(485, 174);
            groupBox_PreviewSettings.TabIndex = 3;
            groupBox_PreviewSettings.TabStop = false;
            groupBox_PreviewSettings.Text = "Preview Settings";
            // 
            // panel_PreviewSettings
            // 
            panel_PreviewSettings.AutoScroll = true;
            panel_PreviewSettings.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            panel_PreviewSettings.Controls.Add(tlp_PreviewSettings);
            panel_PreviewSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_PreviewSettings.Location = new System.Drawing.Point(3, 24);
            panel_PreviewSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel_PreviewSettings.Name = "panel_PreviewSettings";
            panel_PreviewSettings.Size = new System.Drawing.Size(479, 146);
            panel_PreviewSettings.TabIndex = 0;
            // 
            // tlp_PreviewSettings
            // 
            tlp_PreviewSettings.AutoSize = true;
            tlp_PreviewSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tlp_PreviewSettings.ColumnCount = 2;
            tlp_PreviewSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp_PreviewSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tlp_PreviewSettings.Controls.Add(lbl_ImagesPath, 0, 0);
            tlp_PreviewSettings.Controls.Add(tlp_ImagesPath, 1, 1);
            tlp_PreviewSettings.Controls.Add(tlp_PreviewFrame, 0, 0);
            tlp_PreviewSettings.Dock = System.Windows.Forms.DockStyle.Top;
            tlp_PreviewSettings.Location = new System.Drawing.Point(0, 0);
            tlp_PreviewSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_PreviewSettings.Name = "tlp_PreviewSettings";
            tlp_PreviewSettings.RowCount = 1;
            tlp_PreviewSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            tlp_PreviewSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            tlp_PreviewSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_PreviewSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tlp_PreviewSettings.Size = new System.Drawing.Size(479, 125);
            tlp_PreviewSettings.TabIndex = 2;
            // 
            // lbl_ImagesPath
            // 
            lbl_ImagesPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_ImagesPath.AutoSize = true;
            lbl_ImagesPath.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_ImagesPath.Location = new System.Drawing.Point(31, 73);
            lbl_ImagesPath.Name = "lbl_ImagesPath";
            lbl_ImagesPath.Size = new System.Drawing.Size(61, 40);
            lbl_ImagesPath.TabIndex = 3;
            lbl_ImagesPath.Text = "Images Folder:";
            // 
            // tlp_ImagesPath
            // 
            tlp_ImagesPath.AllowDrop = true;
            tlp_ImagesPath.ColumnCount = 2;
            tlp_ImagesPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tlp_ImagesPath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_ImagesPath.Controls.Add(txt_ImagesPath, 0, 0);
            tlp_ImagesPath.Controls.Add(btn_ImagesPath, 1, 0);
            tlp_ImagesPath.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_ImagesPath.Location = new System.Drawing.Point(98, 65);
            tlp_ImagesPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_ImagesPath.Name = "tlp_ImagesPath";
            tlp_ImagesPath.RowCount = 1;
            tlp_ImagesPath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_ImagesPath.Size = new System.Drawing.Size(378, 56);
            tlp_ImagesPath.TabIndex = 2;
            // 
            // txt_ImagesPath
            // 
            txt_ImagesPath.AllowDrop = true;
            txt_ImagesPath.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_ImagesPath.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            txt_ImagesPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_ImagesPath.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            txt_ImagesPath.Location = new System.Drawing.Point(3, 14);
            txt_ImagesPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_ImagesPath.Name = "txt_ImagesPath";
            txt_ImagesPath.Size = new System.Drawing.Size(277, 27);
            txt_ImagesPath.TabIndex = 0;
            txt_ImagesPath.TextChanged += ImagePath_Changed;
            txt_ImagesPath.DragDrop += DragDrop_Txt;
            txt_ImagesPath.DragEnter += DragEnter;
            // 
            // btn_ImagesPath
            // 
            btn_ImagesPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_ImagesPath.Location = new System.Drawing.Point(286, 13);
            btn_ImagesPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_ImagesPath.Name = "btn_ImagesPath";
            btn_ImagesPath.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btn_ImagesPath.Size = new System.Drawing.Size(48, 29);
            btn_ImagesPath.TabIndex = 1;
            btn_ImagesPath.Text = "...";
            btn_ImagesPath.Click += BrowseImagePath_Click;
            // 
            // tlp_PreviewFrame
            // 
            tlp_PreviewFrame.ColumnCount = 6;
            tlp_PreviewSettings.SetColumnSpan(tlp_PreviewFrame, 2);
            tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp_PreviewFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlp_PreviewFrame.Controls.Add(lbl_EyeFrame, 0, 0);
            tlp_PreviewFrame.Controls.Add(num_MouthFrame, 3, 0);
            tlp_PreviewFrame.Controls.Add(lbl_MouthFrame, 2, 0);
            tlp_PreviewFrame.Controls.Add(num_EyeFrame, 1, 0);
            tlp_PreviewFrame.Controls.Add(lbl_Scale, 4, 0);
            tlp_PreviewFrame.Controls.Add(num_Scale, 5, 0);
            tlp_PreviewFrame.Location = new System.Drawing.Point(3, 4);
            tlp_PreviewFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tlp_PreviewFrame.Name = "tlp_PreviewFrame";
            tlp_PreviewFrame.RowCount = 1;
            tlp_PreviewFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_PreviewFrame.Size = new System.Drawing.Size(473, 53);
            tlp_PreviewFrame.TabIndex = 1;
            // 
            // lbl_EyeFrame
            // 
            lbl_EyeFrame.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_EyeFrame.AutoSize = true;
            lbl_EyeFrame.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_EyeFrame.Location = new System.Drawing.Point(14, 6);
            lbl_EyeFrame.Name = "lbl_EyeFrame";
            lbl_EyeFrame.Size = new System.Drawing.Size(53, 40);
            lbl_EyeFrame.TabIndex = 4;
            lbl_EyeFrame.Text = "Eye Frame:";
            // 
            // num_MouthFrame
            // 
            num_MouthFrame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            num_MouthFrame.Location = new System.Drawing.Point(213, 13);
            num_MouthFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_MouthFrame.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            num_MouthFrame.Name = "num_MouthFrame";
            num_MouthFrame.Size = new System.Drawing.Size(64, 27);
            num_MouthFrame.TabIndex = 3;
            num_MouthFrame.ValueChanged += MouthFrame_Changed;
            // 
            // lbl_MouthFrame
            // 
            lbl_MouthFrame.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_MouthFrame.AutoSize = true;
            lbl_MouthFrame.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_MouthFrame.Location = new System.Drawing.Point(151, 6);
            lbl_MouthFrame.Name = "lbl_MouthFrame";
            lbl_MouthFrame.Size = new System.Drawing.Size(56, 40);
            lbl_MouthFrame.TabIndex = 1;
            lbl_MouthFrame.Text = "Mouth Frame:";
            // 
            // num_EyeFrame
            // 
            num_EyeFrame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            num_EyeFrame.Location = new System.Drawing.Point(73, 13);
            num_EyeFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_EyeFrame.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            num_EyeFrame.Name = "num_EyeFrame";
            num_EyeFrame.Size = new System.Drawing.Size(64, 27);
            num_EyeFrame.TabIndex = 2;
            num_EyeFrame.ValueChanged += EyeFrame_Changed;
            // 
            // lbl_Scale
            // 
            lbl_Scale.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_Scale.AutoSize = true;
            lbl_Scale.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            lbl_Scale.Location = new System.Drawing.Point(307, 6);
            lbl_Scale.Name = "lbl_Scale";
            lbl_Scale.Size = new System.Drawing.Size(64, 40);
            lbl_Scale.TabIndex = 5;
            lbl_Scale.Text = "Preview Scale:";
            // 
            // num_Scale
            // 
            num_Scale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            num_Scale.Location = new System.Drawing.Point(377, 13);
            num_Scale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            num_Scale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_Scale.Name = "num_Scale";
            num_Scale.Size = new System.Drawing.Size(64, 27);
            num_Scale.TabIndex = 6;
            num_Scale.Tag = "";
            num_Scale.Value = new decimal(new int[] { 50, 0, 0, 0 });
            num_Scale.ValueChanged += PreviewScale_Changed;
            // 
            // darkMenuStrip_MainMenu
            // 
            darkMenuStrip_MainMenu.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            darkMenuStrip_MainMenu.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            darkMenuStrip_MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            darkMenuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem });
            darkMenuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
            darkMenuStrip_MainMenu.Name = "darkMenuStrip_MainMenu";
            darkMenuStrip_MainMenu.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            darkMenuStrip_MainMenu.Size = new System.Drawing.Size(982, 28);
            darkMenuStrip_MainMenu.TabIndex = 1;
            darkMenuStrip_MainMenu.Text = "darkMenuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newProjectToolStripMenuItem, loadToolStripMenuItem, saveToolStripMenuItem, importToolStripMenuItem, exportToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            newProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            newProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { p5RToolStripMenuItem, p5PS3ToolStripMenuItem });
            newProjectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            newProjectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            newProjectToolStripMenuItem.Text = "New Project...";
            // 
            // p5RToolStripMenuItem
            // 
            p5RToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            p5RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { eventBustupProjectToolStripMenuItem, naviBustupProjectToolStripMenuItem });
            p5RToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            p5RToolStripMenuItem.Name = "p5RToolStripMenuItem";
            p5RToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            p5RToolStripMenuItem.Text = "P5R";
            // 
            // eventBustupProjectToolStripMenuItem
            // 
            eventBustupProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            eventBustupProjectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            eventBustupProjectToolStripMenuItem.Name = "eventBustupProjectToolStripMenuItem";
            eventBustupProjectToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            eventBustupProjectToolStripMenuItem.Text = "Event Bustup Project";
            eventBustupProjectToolStripMenuItem.Click += NewProj_P5R_Event_Click;
            // 
            // naviBustupProjectToolStripMenuItem
            // 
            naviBustupProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            naviBustupProjectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            naviBustupProjectToolStripMenuItem.Name = "naviBustupProjectToolStripMenuItem";
            naviBustupProjectToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            naviBustupProjectToolStripMenuItem.Text = "Navi Bustup Project";
            naviBustupProjectToolStripMenuItem.Click += NewProj_P5R_Navi_Click;
            // 
            // p5PS3ToolStripMenuItem
            // 
            p5PS3ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            p5PS3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { eventBustupProjectToolStripMenuItem1, naviBustupProjectToolStripMenuItem1 });
            p5PS3ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            p5PS3ToolStripMenuItem.Name = "p5PS3ToolStripMenuItem";
            p5PS3ToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            p5PS3ToolStripMenuItem.Text = "P5 PS3";
            // 
            // eventBustupProjectToolStripMenuItem1
            // 
            eventBustupProjectToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            eventBustupProjectToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            eventBustupProjectToolStripMenuItem1.Name = "eventBustupProjectToolStripMenuItem1";
            eventBustupProjectToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            eventBustupProjectToolStripMenuItem1.Text = "Event Bustup Project";
            eventBustupProjectToolStripMenuItem1.Click += NewProj_P5_PS3_Event_Click;
            // 
            // naviBustupProjectToolStripMenuItem1
            // 
            naviBustupProjectToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            naviBustupProjectToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            naviBustupProjectToolStripMenuItem1.Name = "naviBustupProjectToolStripMenuItem1";
            naviBustupProjectToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            naviBustupProjectToolStripMenuItem1.Text = "Navi Bustup Project";
            naviBustupProjectToolStripMenuItem1.Click += NewProj_P5_PS3_Navi_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            loadToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            loadToolStripMenuItem.Text = "Load Project";
            loadToolStripMenuItem.Click += LoadProject_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            saveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            saveToolStripMenuItem.Text = "Save Project";
            saveToolStripMenuItem.Click += SaveProject_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            importToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            importToolStripMenuItem.Text = "Import .DAT";
            importToolStripMenuItem.Click += Import_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { paramsDATToolStripMenuItem, bustupBINsToolStripMenuItem });
            exportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            exportToolStripMenuItem.Text = "Export...";
            exportToolStripMenuItem.Click += Export_Click;
            // 
            // paramsDATToolStripMenuItem
            // 
            paramsDATToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            paramsDATToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            paramsDATToolStripMenuItem.Name = "paramsDATToolStripMenuItem";
            paramsDATToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            paramsDATToolStripMenuItem.Text = "Params .DAT";
            paramsDATToolStripMenuItem.Click += ExportDAT_Click;
            // 
            // bustupBINsToolStripMenuItem
            // 
            bustupBINsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            bustupBINsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            bustupBINsToolStripMenuItem.Name = "bustupBINsToolStripMenuItem";
            bustupBINsToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            bustupBINsToolStripMenuItem.Text = "Bustup .BINs";
            bustupBINsToolStripMenuItem.Click += ExportBINs_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { addToolStripMenuItem, removeToolStripMenuItem, renameToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            addToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += Add_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            removeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += Remove_Click;
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            renameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            renameToolStripMenuItem.Text = "Rename";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            copyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += Copy_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            pasteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += Paste_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { extractBustupBINsToolStripMenuItem, applyImgPathToAllWithSameExpressionToolStripMenuItem, importNamesFromJSONToolStripMenuItem });
            toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // extractBustupBINsToolStripMenuItem
            // 
            extractBustupBINsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            extractBustupBINsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            extractBustupBINsToolStripMenuItem.Name = "extractBustupBINsToolStripMenuItem";
            extractBustupBINsToolStripMenuItem.Size = new System.Drawing.Size(385, 26);
            extractBustupBINsToolStripMenuItem.Text = "Extract Bustup .BINs";
            extractBustupBINsToolStripMenuItem.Click += ExtractBustups_Click;
            // 
            // applyImgPathToAllWithSameExpressionToolStripMenuItem
            // 
            applyImgPathToAllWithSameExpressionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            applyImgPathToAllWithSameExpressionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            applyImgPathToAllWithSameExpressionToolStripMenuItem.Name = "applyImgPathToAllWithSameExpressionToolStripMenuItem";
            applyImgPathToAllWithSameExpressionToolStripMenuItem.Size = new System.Drawing.Size(385, 26);
            applyImgPathToAllWithSameExpressionToolStripMenuItem.Text = "Apply Img Path To All With Same Expression";
            applyImgPathToAllWithSameExpressionToolStripMenuItem.Click += ApplyImagesToAll_SameExpression_Click;
            // 
            // importNamesFromJSONToolStripMenuItem
            // 
            importNamesFromJSONToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            importNamesFromJSONToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            importNamesFromJSONToolStripMenuItem.Name = "importNamesFromJSONToolStripMenuItem";
            importNamesFromJSONToolStripMenuItem.Size = new System.Drawing.Size(385, 26);
            importNamesFromJSONToolStripMenuItem.Text = "Import Names From JSON";
            importNamesFromJSONToolStripMenuItem.Click += importNamesFromJSONToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(982, 754);
            Controls.Add(tlp_Main);
            Controls.Add(darkMenuStrip_MainMenu);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = darkMenuStrip_MainMenu;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(650, 582);
            Name = "MainForm";
            Text = "BustupEditor";
            tlp_Main.ResumeLayout(false);
            darkContextMenu_Sprites.ResumeLayout(false);
            groupBox_BustupSettings.ResumeLayout(false);
            panel_BustupSettings.ResumeLayout(false);
            panel_BustupSettings.PerformLayout();
            pnl_BustupSettings.ResumeLayout(false);
            tlp_BustupSettings.ResumeLayout(false);
            tlp_BustupSettings.PerformLayout();
            tlp_MouthImg3Browse.ResumeLayout(false);
            tlp_MouthImg3Browse.PerformLayout();
            tlp_MouthImg2Browse.ResumeLayout(false);
            tlp_MouthImg2Browse.PerformLayout();
            tlp_MouthImg1Browse.ResumeLayout(false);
            tlp_MouthImg1Browse.PerformLayout();
            tlp_BlinkImg2Browse.ResumeLayout(false);
            tlp_BlinkImg2Browse.PerformLayout();
            tlp_BlinkImg1Browse.ResumeLayout(false);
            tlp_BlinkImg1Browse.PerformLayout();
            tlp_BaseImgBrowse.ResumeLayout(false);
            tlp_BaseImgBrowse.PerformLayout();
            tlp_BustupID.ResumeLayout(false);
            tlp_BustupID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_SubID).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_MinorID).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_MajorID).EndInit();
            tlp_MouthPos.ResumeLayout(false);
            tlp_MouthPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_MouthPosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_MouthPosX).EndInit();
            tlp_EyePos.ResumeLayout(false);
            tlp_EyePos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_EyePosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_EyePosX).EndInit();
            tlp_BasePos.ResumeLayout(false);
            tlp_BasePos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_BasePosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_BasePosX).EndInit();
            groupBox_Texture.ResumeLayout(false);
            groupBox_Texture.PerformLayout();
            pnl_ImgPreview.ResumeLayout(false);
            pnl_ImgPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Tex).EndInit();
            darkContextMenu_Texture.ResumeLayout(false);
            groupBox_PreviewSettings.ResumeLayout(false);
            panel_PreviewSettings.ResumeLayout(false);
            panel_PreviewSettings.PerformLayout();
            tlp_PreviewSettings.ResumeLayout(false);
            tlp_PreviewSettings.PerformLayout();
            tlp_ImagesPath.ResumeLayout(false);
            tlp_ImagesPath.PerformLayout();
            tlp_PreviewFrame.ResumeLayout(false);
            tlp_PreviewFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_MouthFrame).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_EyeFrame).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Scale).EndInit();
            darkMenuStrip_MainMenu.ResumeLayout(false);
            darkMenuStrip_MainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private DarkUI.Controls.DarkContextMenu darkContextMenu_Sprites;
        private DarkUI.Controls.DarkGroupBox groupBox_Texture;
        private DarkUI.Controls.DarkContextMenu darkContextMenu_Texture;
        private System.Windows.Forms.Panel panel_BustupSettings;
        private System.Windows.Forms.TableLayoutPanel tlp_BustupSettings;
        private System.Windows.Forms.Panel panel_PreviewSettings;
        private DarkUI.Controls.DarkLabel lbl_BasePos;
        private DarkUI.Controls.DarkLabel lbl_EyePos;
        private DarkUI.Controls.DarkLabel lbl_MouthPos;
        private DarkUI.Controls.DarkLabel lbl_Animation;
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
        private System.Windows.Forms.Panel pnl_BustupSettings;
        private System.Windows.Forms.TableLayoutPanel tlp_MouthImg1Browse;
        private DarkUI.Controls.DarkTextBox txt_MouthImg1Browse;
        private DarkUI.Controls.DarkButton btn_MouthImg1Browse;
        private System.Windows.Forms.TableLayoutPanel tlp_BlinkImg2Browse;
        private DarkUI.Controls.DarkTextBox txt_BlinkImg2Browse;
        private DarkUI.Controls.DarkButton btn_BlinkImg2Browse;
        private System.Windows.Forms.TableLayoutPanel tlp_BlinkImg1Browse;
        private DarkUI.Controls.DarkTextBox txt_BlinkImg1Browse;
        private DarkUI.Controls.DarkButton btn_BlinkImg1Browse;
        private DarkUI.Controls.DarkLabel lbl_BlinkImg1Browse;
        private DarkUI.Controls.DarkLabel lbl_BaseImage;
        private System.Windows.Forms.TableLayoutPanel tlp_BaseImgBrowse;
        private DarkUI.Controls.DarkTextBox txt_BaseImgBrowse;
        private DarkUI.Controls.DarkButton btn_BaseImgBrowse;
        private System.Windows.Forms.ComboBox comboBox_Animation;
        private System.Windows.Forms.TableLayoutPanel tlp_MouthPos;
        private DarkUI.Controls.DarkNumericUpDown num_MouthPosY;
        private DarkUI.Controls.DarkLabel lbl_MouthPosX;
        private DarkUI.Controls.DarkLabel lbl_MouthPosY;
        private DarkUI.Controls.DarkNumericUpDown num_MouthPosX;
        private System.Windows.Forms.TableLayoutPanel tlp_EyePos;
        private DarkUI.Controls.DarkNumericUpDown num_EyePosY;
        private DarkUI.Controls.DarkLabel lbl_EyePosX;
        private DarkUI.Controls.DarkLabel lbl_EyePosY;
        private DarkUI.Controls.DarkNumericUpDown num_EyePosX;
        private System.Windows.Forms.TableLayoutPanel tlp_BasePos;
        private DarkUI.Controls.DarkNumericUpDown num_BasePosY;
        private DarkUI.Controls.DarkLabel lbl_BasePosX;
        private DarkUI.Controls.DarkLabel lbl_BasePosY;
        private DarkUI.Controls.DarkNumericUpDown num_BasePosX;
        private DarkUI.Controls.DarkLabel lbl_BlinkImg2Browse;
        private DarkUI.Controls.DarkLabel lbl_MouthImg1Browse;
        private DarkUI.Controls.DarkLabel lbl_MouthImg2Browse;
        private DarkUI.Controls.DarkLabel lbl_MouthImg3Browse;
        private System.Windows.Forms.TableLayoutPanel tlp_MouthImg3Browse;
        private DarkUI.Controls.DarkTextBox txt_MouthImg3Browse;
        private DarkUI.Controls.DarkButton btn_MouthImg3Browse;
        private System.Windows.Forms.TableLayoutPanel tlp_MouthImg2Browse;
        private DarkUI.Controls.DarkTextBox txt_MouthImg2Browse;
        private DarkUI.Controls.DarkButton btn_MouthImg2Browse;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p5RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventBustupProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naviBustupProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p5PS3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventBustupProjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem naviBustupProjectToolStripMenuItem1;
        private DarkUI.Controls.DarkLabel lbl_CharaName;
        private DarkUI.Controls.DarkTextBox txt_ExpressionName;
        private DarkUI.Controls.DarkTextBox txt_CharaName;
        private DarkUI.Controls.DarkLabel lbl_ExpressionName;
        private DarkUI.Controls.DarkLabel lbl_OutfitName;
        private DarkUI.Controls.DarkTextBox txt_OutfitName;
        private System.Windows.Forms.ToolStripMenuItem paramsDATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bustupBINsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractBustupBINsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyImgPathToAllWithSameExpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importNamesFromJSONToolStripMenuItem;
    }
}

