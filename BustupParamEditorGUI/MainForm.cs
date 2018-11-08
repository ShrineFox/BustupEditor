using BustupParamEditor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DDS2ToolGUI;
using System.IO;
using System.Drawing;

namespace BustupParamEditorGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //List of all bustup parameter entries
        public List<byte[]> paramEntries = new List<byte[]>();
        //Currently selected parameter entry
        ParamEntry pEntry = new ParamEntry();
        //Copied parameter entry
        ParamEntry copiedParamEntry = new ParamEntry();
        //Currently opened param file path
        public string paramFilePath;

        //Currently selected bustup folder
        public string bustupDirPath;
        public string selectedBustup;
        public string extractedBustupDir;

        public string[] pngs;
        public PictureBox pictureBox_Eyes = new PictureBox();
        public PictureBox pictureBox_Mouth = new PictureBox();

        private void OpenParams_Click(object sender, EventArgs e)
        {
            string filePath = Program.OpenFile();
            if (filePath != "")
            {
                listBox1.Items.Clear();
                if (Validation.ParamFilePath(filePath, out paramEntries))
                {
                    ParamEntry testParamEntry = new ParamEntry();
                    testParamEntry.Read(paramEntries, 0);
                    if (testParamEntry.Type == ParamEntry.ParamType.Normal)
                        foreach (var fileName in Filenames.NormalBustups())
                        {
                            listBox1.Items.Add(fileName);
                        }
                    else if (testParamEntry.Type == ParamEntry.ParamType.Assist)
                        foreach (var fileName in Filenames.AssistBustups())
                        {
                            listBox1.Items.Add(fileName);
                        }
                    listBox1.Enabled = true;

                    saveToolStripMenuItem.Enabled = true;
                    openBustupDirectoryToolStripMenuItem.Enabled = true;
                    listBox1.SelectedIndex = 0;
                    paramFilePath = filePath;
                }
            }
        }

        public int previousSelectedIndex = -1;

        private void Listbox_SelectionChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                numUpDwn_MouthFrame.Value = 0;
                numUpDwn_EyeFrame.Value = 0;
                btn_OpenImgFolder.Enabled = false;
                btn_RepackBin.Enabled = false;
                numUpDwn_EyeFrame.Enabled = false;
                numUpDwn_MouthFrame.Enabled = false;
                if (previousSelectedIndex != -1)
                {
                    if (numUpDwn_OffsetX.Text != pEntry.OffsetX.ToString() ||
                        numUpDwn_OffsetY.Text != pEntry.OffsetY.ToString() ||
                        numUpDwn_EyePosX.Text != pEntry.EyePositionX.ToString() ||
                        numUpDwn_EyePosY.Text != pEntry.EyepositionY.ToString() ||
                        numUpDwn_MouthPosX.Text != pEntry.MouthPositionX.ToString() ||
                        numUpDwn_MouthPosY.Text != pEntry.MouthPositionY.ToString())
                    {
                        DialogResult result = MessageBox.Show($"Save changes to {listBox1.Items[previousSelectedIndex].ToString()}?\nYour changes will be discarded if you select No.", "Unsaved Changes", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            pEntry.OffsetX = float.Parse(numUpDwn_OffsetX.Text); pEntry.OffsetY = float.Parse(numUpDwn_OffsetY.Text);
                            pEntry.EyePositionX = float.Parse(numUpDwn_EyePosX.Text); pEntry.EyepositionY = float.Parse(numUpDwn_EyePosY.Text);
                            pEntry.MouthPositionX = float.Parse(numUpDwn_MouthPosX.Text); pEntry.MouthPositionY = float.Parse(numUpDwn_MouthPosY.Text);
                            if (pEntry.EntryData != null)
                                Program.Save(pEntry, paramFilePath);
                        }
                    }
                }
                try {
                    numUpDwn_OffsetX.Enabled = true; numUpDwn_OffsetY.Enabled = true;
                    numUpDwn_EyePosX.Enabled = true; numUpDwn_EyePosY.Enabled = true;
                    numUpDwn_MouthPosX.Enabled = true; numUpDwn_MouthPosY.Enabled = true;
                    pEntry = Validation.SelectedEntry(paramEntries, listBox1.SelectedItem.ToString());
                    numUpDwn_OffsetX.Text = pEntry.OffsetX.ToString(); numUpDwn_OffsetY.Text = pEntry.OffsetY.ToString();
                    numUpDwn_EyePosX.Text = pEntry.EyePositionX.ToString(); numUpDwn_EyePosY.Text = pEntry.EyepositionY.ToString();
                    numUpDwn_MouthPosX.Text = pEntry.MouthPositionX.ToString(); numUpDwn_MouthPosY.Text = pEntry.MouthPositionY.ToString();
                    previousSelectedIndex = listBox1.SelectedIndex;

                    if (pEntry.Type == ParamEntry.ParamType.Normal)
                        selectedBustup = $"{bustupDirPath}\\b{pEntry.CharacterId.ToString("D3")}_{pEntry.ExpressionId.ToString("D3")}_{pEntry.OutfitId.ToString("D2")}.bin";
                    else
                        selectedBustup = $"{bustupDirPath}\\b{pEntry.CharacterId.ToString("D3")}_{pEntry.ExpressionId.ToString("D3")}.bin";
                    if (bustupDirPath != "" && File.Exists(selectedBustup))
                    {
                        btn_OpenImgFolder.Enabled = true;
                        btn_RepackBin.Enabled = true;
                        numUpDwn_EyeFrame.Enabled = true;
                        numUpDwn_MouthFrame.Enabled = true;
                        extractedBustupDir = DDS2.Extract(selectedBustup);
                        pngs = Directory.GetFiles($"{extractedBustupDir}\\PNG");
                        pictureBox_Base.ImageLocation = pngs[0];
                        pictureBox_Eyes.Parent = pictureBox_Base;
                        pictureBox_Mouth.Parent = pictureBox_Base;
                        pictureBox_Eyes.ImageLocation = pngs[1];
                        pictureBox_Mouth.ImageLocation = pngs[5];
                        pictureBox_Eyes.Size = new Size(Image.FromFile(pngs[2]).Width, Image.FromFile(pngs[2]).Height);
                        pictureBox_Mouth.Size = new Size(Image.FromFile(pngs[3]).Width, Image.FromFile(pngs[3]).Height);
                        pictureBox_Eyes.Location = new System.Drawing.Point(Convert.ToInt32(pEntry.EyePositionX), Convert.ToInt32(pEntry.EyepositionY));
                        pictureBox_Mouth.Location = new System.Drawing.Point(Convert.ToInt32(pEntry.MouthPositionX), Convert.ToInt32(pEntry.MouthPositionY));
                    }
                    else
                    {
                        pictureBox_Base.ImageLocation = null;
                        pictureBox_Mouth.ImageLocation = null;
                        pictureBox_Eyes.ImageLocation = null;
                    }
                }
                catch
                {
                    numUpDwn_OffsetX.Enabled = false; numUpDwn_OffsetY.Enabled = false;
                    numUpDwn_EyePosX.Enabled = false; numUpDwn_EyePosY.Enabled = false;
                    numUpDwn_MouthPosX.Enabled = false; numUpDwn_MouthPosY.Enabled = false;
                }
            }

        }

        private void SaveParams_Click(object sender, EventArgs e)
        {
            pEntry.OffsetX = float.Parse(numUpDwn_OffsetX.Text); pEntry.OffsetY = float.Parse(numUpDwn_OffsetY.Text);
            pEntry.EyePositionX = float.Parse(numUpDwn_EyePosX.Text); pEntry.EyepositionY = float.Parse(numUpDwn_EyePosY.Text);
            pEntry.MouthPositionX = float.Parse(numUpDwn_MouthPosX.Text); pEntry.MouthPositionY = float.Parse(numUpDwn_MouthPosY.Text);
            if (pEntry.EntryData != null)
                Program.Save(pEntry, paramFilePath);
        }

        private void KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S && saveToolStripMenuItem.Enabled)
            {
                pEntry.OffsetX = float.Parse(numUpDwn_OffsetX.Text); pEntry.OffsetY = float.Parse(numUpDwn_OffsetY.Text);
                pEntry.EyePositionX = float.Parse(numUpDwn_EyePosX.Text); pEntry.EyepositionY = float.Parse(numUpDwn_EyePosY.Text);
                pEntry.MouthPositionX = float.Parse(numUpDwn_MouthPosX.Text); pEntry.MouthPositionY = float.Parse(numUpDwn_MouthPosY.Text);
                if (pEntry.EntryData != null)
                    Program.Save(pEntry, paramFilePath);
            }
        }

        private void OpenBustups_Click(object sender, EventArgs e)
        {
            string folderPath = Program.OpenFolder();
            if (folderPath != "")
            {
                bustupDirPath = folderPath;
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            copiedParamEntry.OffsetX = Convert.ToSingle(numUpDwn_OffsetX.Text); copiedParamEntry.OffsetY = Convert.ToSingle(numUpDwn_OffsetY.Text);
            copiedParamEntry.EyePositionX = Convert.ToSingle(numUpDwn_EyePosX.Text); copiedParamEntry.EyepositionY = Convert.ToSingle(numUpDwn_EyePosY.Text);
            copiedParamEntry.MouthPositionX = Convert.ToSingle(numUpDwn_MouthPosX.Text); copiedParamEntry.MouthPositionY = Convert.ToSingle(numUpDwn_MouthPosY.Text);
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            numUpDwn_OffsetX.Text = copiedParamEntry.OffsetX.ToString(); numUpDwn_OffsetY.Text = copiedParamEntry.OffsetY.ToString();
            numUpDwn_EyePosX.Text = copiedParamEntry.EyePositionX.ToString(); numUpDwn_EyePosY.Text = copiedParamEntry.EyepositionY.ToString();
            numUpDwn_MouthPosX.Text = copiedParamEntry.MouthPositionX.ToString(); numUpDwn_MouthPosY.Text = copiedParamEntry.MouthPositionY.ToString();
        }

        private void OpenImgFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", extractedBustupDir); 
        }

        private void EyeFrame_ValueChanged(object sender, EventArgs e)
        {
            switch (numUpDwn_EyeFrame.Value)
            {
                case 0:
                    pictureBox_Eyes.ImageLocation = null;
                    pictureBox_Eyes.Visible = false;
                    break;
                case 1:
                    pictureBox_Eyes.Visible = true;
                    pictureBox_Eyes.ImageLocation = pngs[1];
                    break;
                case 2:
                    pictureBox_Eyes.Visible = true;
                    pictureBox_Eyes.ImageLocation = pngs[2];
                    break;
            }
        }

        private void MouthFrame_ValueChanged(object sender, EventArgs e)
        {
            switch (numUpDwn_MouthFrame.Value)
            {
                case 0:
                    pictureBox_Mouth.ImageLocation = null;
                    pictureBox_Mouth.Visible = false;
                    break;
                case 1:
                    pictureBox_Mouth.Visible = true;
                    pictureBox_Mouth.ImageLocation = pngs[3];
                    break;
                case 2:
                    pictureBox_Mouth.Visible = true;
                    pictureBox_Mouth.ImageLocation = pngs[4];
                    break;
                case 3:
                    pictureBox_Mouth.Visible = true;
                    pictureBox_Mouth.ImageLocation = pngs[5];
                    break;
            }
        }

        private void RepackBin_Click(object sender, EventArgs e)
        {
            DDS2.Repack(extractedBustupDir);
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"BustupParamEditor GUI by ShrineFox\nBased on DDS2Tool and BustupParamEditor\nUsing TGEnigma's EndianHelper library\namicitia.github.io\n\nFor use with Persona 5's bustup parameter .bin files.", "BustupParamEditor GUI - About", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void EyePositionX_ValueChanged(object sender, EventArgs e)
        {
            if (bustupDirPath != "" && File.Exists(selectedBustup))
                pictureBox_Eyes.Location = new System.Drawing.Point(Convert.ToInt32(numUpDwn_EyePosX.Text), Convert.ToInt32(numUpDwn_EyePosY.Text));
        }

        private void EyePositionY_ValueChanged(object sender, EventArgs e)
        {
            if (bustupDirPath != "" && File.Exists(selectedBustup))
                pictureBox_Eyes.Location = new System.Drawing.Point(Convert.ToInt32(numUpDwn_EyePosX.Text), Convert.ToInt32(numUpDwn_EyePosY.Text));
        }

        private void MouthPositionX_ValueChanged(object sender, EventArgs e)
        {
            if (bustupDirPath != "" && File.Exists(selectedBustup))
                pictureBox_Mouth.Location = new System.Drawing.Point(Convert.ToInt32(numUpDwn_MouthPosX.Text), Convert.ToInt32(numUpDwn_MouthPosY.Text));
        }

        private void MouthPositionY_ValueChanged(object sender, EventArgs e)
        {
            if (bustupDirPath != "" && File.Exists(selectedBustup))
                pictureBox_Mouth.Location = new System.Drawing.Point(Convert.ToInt32(numUpDwn_MouthPosX.Text), Convert.ToInt32(numUpDwn_MouthPosY.Text));
        }
    }
}
