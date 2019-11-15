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
            if (File.Exists("LastOpenedParamsPath.txt"))
            try
            {
                LoadParams(File.ReadAllText("LastOpenedParamsPath.txt"));
                bustupDirPath = File.ReadAllText("LastOpenedBustupsPath.txt");
            }
            catch { }
        }

        //List of all bustup parameter entries
        public static List<byte[]> paramEntries = new List<byte[]>();
        //Currently selected parameter entry
        ParamEntry pEntry = new ParamEntry();
        //Latest opened parameter file type
        public static ParamEntry.ParamType pType;
        //Copied parameter entry
        ParamEntry copiedParamEntry = new ParamEntry();
        //Currently opened param file path
        public string paramFilePath;
        //List of bin names
        List<string> fileNames = new List<string>();

        //Currently selected bustup folder
        public static string bustupDirPath;
        public string selectedBustup;
        public string extractedBustupDir;

        public string[] pngs;
        public PictureBox pictureBox_Eyes = new PictureBox();
        public PictureBox pictureBox_Mouth = new PictureBox();

        private void OpenParams_Click(object sender, EventArgs e)
        {
            string filePath = Program.OpenFile();
            LoadParams(filePath);
            File.WriteAllText("LastOpenedParamsPath.txt", filePath);
        }

        private void LoadParams(string filePath)
        {
            if (filePath != "")
            {
                listBox1.Items.Clear();
                if (Validation.ParamFilePath(filePath, out paramEntries))
                {
                    //List bin names to choose from
                    ParamEntry testParamEntry = new ParamEntry();
                    fileNames.Clear();
                    int i = 0;
                    foreach (var entry in paramEntries)
                    {
                        testParamEntry.Read(paramEntries, i);
                        pType = testParamEntry.Type;
                        if (pType == ParamEntry.ParamType.Normal)
                            fileNames.Add($"b{Int32.Parse(testParamEntry.CharacterId.ToString(), System.Globalization.NumberStyles.HexNumber).ToString("X3")}_{Int32.Parse(testParamEntry.ExpressionId.ToString(), System.Globalization.NumberStyles.HexNumber).ToString("X3")}_{Int32.Parse(testParamEntry.OutfitId.ToString(), System.Globalization.NumberStyles.HexNumber).ToString("X2")}.bin");
                        else if (pType == ParamEntry.ParamType.Assist)
                            fileNames.Add($"b{Int32.Parse(testParamEntry.CharacterId.ToString(), System.Globalization.NumberStyles.HexNumber).ToString("X3")}_{Int32.Parse(testParamEntry.ExpressionId.ToString(), System.Globalization.NumberStyles.HexNumber).ToString("X3")}.bin");
                        i++;
                    }
                    foreach (var fileName in fileNames)
                        listBox1.Items.Add(fileName);

                    listBox1.Enabled = true;
                    //Enable controls
                    saveToolStripMenuItem.Enabled = true;
                    openBustupDirectoryToolStripMenuItem.Enabled = true;
                    comboBox_InitAnim.Enabled = true;
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
                btn_CreateBin.Enabled = false;
                btn_OpenImgFolder.Enabled = false;
                btn_RepackBin.Enabled = false;
                numUpDwn_EyeFrame.Enabled = false;
                numUpDwn_MouthFrame.Enabled = false;
                comboBox_InitAnim.Enabled = false;
                if (previousSelectedIndex != -1)
                {
                    // Prompt to save changes if form != data entry on leave
                    if (numUpDwn_OffsetX.Text != pEntry.OffsetX.ToString() ||
                        numUpDwn_OffsetY.Text != pEntry.OffsetY.ToString() ||
                        numUpDwn_EyePosX.Text != pEntry.EyePositionX.ToString() ||
                        numUpDwn_EyePosY.Text != pEntry.EyepositionY.ToString() ||
                        numUpDwn_MouthPosX.Text != pEntry.MouthPositionX.ToString() ||
                        numUpDwn_MouthPosY.Text != pEntry.MouthPositionY.ToString() || 
                        comboBox_InitAnim.SelectedIndex != Params.GetInitAnim(pEntry.InitialAnimation))
                    {
                        DialogResult result = MessageBox.Show($"Save changes to {listBox1.Items[previousSelectedIndex].ToString()}?\nYour changes will be discarded if you select No.", "Unsaved Changes", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            pEntry.OffsetX = float.Parse(numUpDwn_OffsetX.Text); pEntry.OffsetY = float.Parse(numUpDwn_OffsetY.Text);
                            pEntry.EyePositionX = float.Parse(numUpDwn_EyePosX.Text); pEntry.EyepositionY = float.Parse(numUpDwn_EyePosY.Text);
                            pEntry.MouthPositionX = float.Parse(numUpDwn_MouthPosX.Text); pEntry.MouthPositionY = float.Parse(numUpDwn_MouthPosY.Text);
                            pEntry.InitialAnimation = Params.SetInitAnim(comboBox_InitAnim.SelectedIndex);
                            if (pEntry.EntryData != null)
                                Program.Save(pEntry, paramFilePath);
                        }
                    }
                }
                // Attempt to load new data from selected param entry into form
                try {
                    pEntry = Validation.SelectedEntry(paramEntries, listBox1.SelectedItem.ToString());
                    numUpDwn_OffsetX.Text = pEntry.OffsetX.ToString(); numUpDwn_OffsetY.Text = pEntry.OffsetY.ToString();
                    numUpDwn_EyePosX.Text = pEntry.EyePositionX.ToString(); numUpDwn_EyePosY.Text = pEntry.EyepositionY.ToString();
                    numUpDwn_MouthPosX.Text = pEntry.MouthPositionX.ToString(); numUpDwn_MouthPosY.Text = pEntry.MouthPositionY.ToString();
                    comboBox_InitAnim.SelectedIndex = Params.GetInitAnim(pEntry.InitialAnimation);
                    previousSelectedIndex = listBox1.SelectedIndex;
                    numUpDwn_OffsetX.Enabled = true; numUpDwn_OffsetY.Enabled = true;
                    numUpDwn_EyePosX.Enabled = true; numUpDwn_EyePosY.Enabled = true;
                    numUpDwn_MouthPosX.Enabled = true; numUpDwn_MouthPosY.Enabled = true;
                    comboBox_InitAnim.Enabled = true;

                    selectedBustup = $"{bustupDirPath}\\{listBox1.SelectedItem.ToString()}";
                    
                    if (bustupDirPath != "" && File.Exists(selectedBustup))
                    {
                        btn_OpenImgFolder.Enabled = true;
                        btn_RepackBin.Enabled = true;
                        btn_CreateBin.Enabled = false;
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
                        btn_CreateBin.Enabled = true;
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
            pEntry.InitialAnimation = Params.SetInitAnim(comboBox_InitAnim.SelectedIndex);
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
                pEntry.InitialAnimation = Params.SetInitAnim(comboBox_InitAnim.SelectedIndex);
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
                File.WriteAllText("LastOpenedBustupsPath.txt", folderPath);
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            copiedParamEntry.OffsetX = Convert.ToSingle(numUpDwn_OffsetX.Text); copiedParamEntry.OffsetY = Convert.ToSingle(numUpDwn_OffsetY.Text);
            copiedParamEntry.EyePositionX = Convert.ToSingle(numUpDwn_EyePosX.Text); copiedParamEntry.EyepositionY = Convert.ToSingle(numUpDwn_EyePosY.Text);
            copiedParamEntry.MouthPositionX = Convert.ToSingle(numUpDwn_MouthPosX.Text); copiedParamEntry.MouthPositionY = Convert.ToSingle(numUpDwn_MouthPosY.Text);
            copiedParamEntry.InitialAnimation = Params.SetInitAnim(comboBox_InitAnim.SelectedIndex);
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            numUpDwn_OffsetX.Text = copiedParamEntry.OffsetX.ToString(); numUpDwn_OffsetY.Text = copiedParamEntry.OffsetY.ToString();
            numUpDwn_EyePosX.Text = copiedParamEntry.EyePositionX.ToString(); numUpDwn_EyePosY.Text = copiedParamEntry.EyepositionY.ToString();
            numUpDwn_MouthPosX.Text = copiedParamEntry.MouthPositionX.ToString(); numUpDwn_MouthPosY.Text = copiedParamEntry.MouthPositionY.ToString();
            comboBox_InitAnim.SelectedIndex = Params.GetInitAnim(copiedParamEntry.InitialAnimation);
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
            MessageBox.Show($"BustupParamEditor GUI by ShrineFox\nBased on DDS2Tool and BustupParamEditor\nUsing TGEnigma's EndianHelper library\nshrinefox.com\n\nFor use with Persona 5's bustup parameter .bin files.", "About BustupParamEditorGUI", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        private void ParameterEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Make sure params file is open
            if (paramEntries.Count <= 0)
                return;

            //Open param entry creation form
            bool alreadyExists = false;
            bool createBin = false;
            string fileName = "";
            if (bustupDirPath != null)
            {
                using (var entryDialog = new AddParam())
                {
                    if (entryDialog.ShowDialog() != DialogResult.OK)
                        return;
                    try
                    {
                        createBin = AddParam.Result.createBin;
                        fileName = AddParam.Result.fileName;
                        alreadyExists = AddParam.Result.alreadyExists;
                    }
                    catch
                    {
                    }
                }
                if (alreadyExists)
                    return;

                //Create .bin and/or add entry
                if (pType == BustupParamEditor.ParamEntry.ParamType.Assist)
                {
                    if (createBin && !File.Exists($"{bustupDirPath}\\{fileName}"))
                        DDS2.Create(bustupDirPath, fileName, true);
                    Params.AddEntry(paramFilePath, fileName, true);
                }
                else if (pType == BustupParamEditor.ParamEntry.ParamType.Normal)
                {
                    if (createBin && !File.Exists($"{bustupDirPath}\\{fileName}"))
                        DDS2.Create(bustupDirPath, fileName, false);
                    Params.AddEntry(paramFilePath, fileName, false);
                }
                //Reload file and select new entry
                LoadParams(paramFilePath);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            else
                MessageBox.Show("Please set your Bustup .bin Directory path first!");
        }

        private void CreateBustupBin_Click(object sender, EventArgs e)
        {
            int lastSelectedIndex = listBox1.SelectedIndex;
            //Create BIN based on selected entry
            if (pType == BustupParamEditor.ParamEntry.ParamType.Assist)
                DDS2.Create(bustupDirPath, listBox1.SelectedItem.ToString(), true);
            else if (pType == BustupParamEditor.ParamEntry.ParamType.Normal)
                DDS2.Create(bustupDirPath, listBox1.SelectedItem.ToString(), false);
            //Reload file at previously selected index
            LoadParams(paramFilePath);
            listBox1.SelectedIndex = lastSelectedIndex;
        }

        private void ToolstripRenameEntry_Click(object sender, EventArgs e)
        {
            //Make sure params file is open
            if (paramEntries.Count <= 0)
                return;

            //Open param entry creation form
            bool alreadyExists = false;
            bool createBin = false;
            string fileName = "";
            if (bustupDirPath != null)
            {
                using (var entryDialog = new AddParam())
                {
                    if (entryDialog.ShowDialog() != DialogResult.OK)
                        return;
                    try
                    {
                        createBin = AddParam.Result.createBin;
                        fileName = AddParam.Result.fileName;
                        alreadyExists = AddParam.Result.alreadyExists;
                    }
                    catch
                    {
                    }
                }
                if (alreadyExists)
                    return;

                //Create .bin and/or add entry
                if (pType == BustupParamEditor.ParamEntry.ParamType.Assist)
                {
                    if (createBin && !File.Exists($"{bustupDirPath}\\{fileName}"))
                        DDS2.Create(bustupDirPath, fileName, true);
                    Params.RenameEntry(paramFilePath, fileName, true, listBox1.SelectedIndex);
                }
                else if (pType == BustupParamEditor.ParamEntry.ParamType.Normal)
                {
                    if (createBin && !File.Exists($"{bustupDirPath}\\{fileName}"))
                        DDS2.Create(bustupDirPath, fileName, false);
                    Params.RenameEntry(paramFilePath, fileName, false, listBox1.SelectedIndex);
                }
                //Reload file and select new entry
                LoadParams(paramFilePath);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            else
                MessageBox.Show("Please set your Bustup .bin Directory path first!");
        }
    }
}
