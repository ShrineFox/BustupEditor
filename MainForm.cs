using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using DarkUI.Controls;
using DarkUI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;

namespace BustupEditor
{
    public partial class MainForm : DarkForm
    {
        public MainForm()
        {
            InitializeComponent();
            SetMenuStripIcons();
            SetOverlayImages();
        }

        public PictureBox pictureBox_Eyes = new PictureBox() { Visible = false, SizeMode = PictureBoxSizeMode.Normal };
        public PictureBox pictureBox_Mouth = new PictureBox() { Visible = false, SizeMode = PictureBoxSizeMode.Normal };
        public Bustup copiedParams = new Bustup();

        private void SetOverlayImages()
        {
            pictureBox_Eyes.Parent = pictureBox_Tex;
            pictureBox_Mouth.Parent = pictureBox_Tex;
        }

        private void SetMenuStripIcons()
        {
            List<Tuple<string, string>> menuStripIcons = new List<Tuple<string, string>>() {
                new Tuple<string, string>("fileToolStripMenuItem", "disk"),
                new Tuple<string, string>("loadToolStripMenuItem", "folder_page"),
                new Tuple<string, string>("saveToolStripMenuItem", "disk_multiple"),
                new Tuple<string, string>("importToolStripMenuItem", "package_green"),
                new Tuple<string, string>("exportToolStripMenuItem", "package_go"),
                new Tuple<string, string>("editToolStripMenuItem", "book_edit"),
                new Tuple<string, string>("addToolStripMenuItem", "add"),
                new Tuple<string, string>("addSpriteToolStripMenuItem", "add"),
                new Tuple<string, string>("removeToolStripMenuItem", "delete"),
                new Tuple<string, string>("removeSelectedToolStripMenuItem", "delete"),
                new Tuple<string, string>("renameToolStripMenuItem", "textfield_rename"),
                new Tuple<string, string>("renameSelectedToolStripMenuItem", "textfield_rename"),
                new Tuple<string, string>("openImageFolderToolStripMenuItem", "folder_image"),
                new Tuple<string, string>("openImageFolderToolStripMenuItem1", "folder_image"),
                new Tuple<string, string>("copyToolStripMenuItem", "page_copy"),
                new Tuple<string, string>("copySelectedToolStripMenuItem", "page_copy"),
                new Tuple<string, string>("pasteToolStripMenuItem", "paste_plain"),
                new Tuple<string, string>("pasteSelectedToolStripMenuItem", "paste_plain"),
            };

            // Context Menu Strips
            foreach (DarkContextMenu menuStrip in new DarkContextMenu[] { darkContextMenu_Sprites, darkContextMenu_Texture })
                ApplyIconsFromList(menuStrip.Items, menuStripIcons);

            // Menu Strip Items
            foreach (DarkMenuStrip menuStrip in this.FlattenChildren<DarkMenuStrip>())
                ApplyIconsFromList(menuStrip.Items, menuStripIcons);
        }

        private void ApplyIconsFromList(ToolStripItemCollection items, List<Tuple<string, string>> menuStripIcons)
        {
            foreach (ToolStripMenuItem tsmi in items)
            {
                // Apply context menu icon
                if (menuStripIcons.Any(x => x.Item1 == tsmi.Name))
                    ApplyIconFromFile(tsmi, menuStripIcons);
                // Apply drop down menu icon
                foreach (ToolStripMenuItem tsmi2 in tsmi.DropDownItems)
                    if (menuStripIcons.Any(x => x.Item1 == tsmi2.Name))
                        ApplyIconFromFile(tsmi2, menuStripIcons);
            }
        }

        private void ApplyIconFromFile(ToolStripMenuItem tsmi, List<Tuple<string, string>> menuStripIcons)
        {
            tsmi.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                        $"Icons\\{menuStripIcons.Single(x => x.Item1 == tsmi.Name).Item2}.png"));
        }

        BustupProject bustupProject = new BustupProject();

        public class BustupProject
        {
            public string Name = "Untitled";
            public string ImagesPath = "./Images";
            public List<Bustup> Bustups = new List<Bustup>();
            public BustupType Type = BustupType.Unknown;
            public int Scale = 50;
        }

        public class Bustup
        {
            public string Name = "Untitled";
            public ushort MajorID = 0;
            public ushort MinorID = 0;
            public ushort SubID = 0;
            public float BasePos_X = 0;
            public float BasePos_Y = 0;
            public float EyePos_X = 0;
            public float EyePos_Y = 0;
            public float MouthPos_X = 0;
            public float MouthPos_Y = 0;
            public AnimationType AnimType = AnimationType.None;
        }

        public enum BustupType
        {
            Unknown,
            Portrait,
            Navigator
        }

        public enum AnimationType
        {
            None,
            Eyes,
            Mouth,
            Eyes_Mouth,
            Eyes_Mouth_ExcludeAlpha = 11,
            Unknown = 15
        }

        private void SavePreset_Click(object sender, EventArgs e)
        {
            var selection = WinFormsEvents.FilePath_Click("Save project file...", true, new string[] { "json (.json)" }, true);
            if (selection.Count == 0 || string.IsNullOrEmpty(selection[0]))
                return;

            string outPath = selection.First();
            if (!outPath.ToLower().EndsWith(".json"))
                outPath = outPath + ".json";

            File.WriteAllText(selection.First(), JsonConvert.SerializeObject(bustupProject, Newtonsoft.Json.Formatting.Indented));
            MessageBox.Show($"Saved project file to:\n{selection.First()}", "Project Saved Successfully");
        }

        private void LoadPreset_Click(object sender, EventArgs e)
        {
            var selection = WinFormsEvents.FilePath_Click("Load project file...", true, new string[] { "json (.json)" });
            if (selection.Count == 0 || string.IsNullOrEmpty(selection[0]))
                return;

            bustupProject = JsonConvert.DeserializeObject<BustupProject>(File.ReadAllText(selection.First()));

            UpdateSpriteList();
        }

        private void UpdateSpriteList()
        {
            listBox_Sprites.Items.Clear();
            foreach (var bustup in bustupProject.Bustups)
                listBox_Sprites.Items.Add(bustup.Name);
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if (listBox_Sprites.SelectedIndex != -1 && bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
            {
                RenameForm renameForm = new RenameForm(listBox_Sprites.SelectedItem.ToString());
                var result = renameForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string newName = renameForm.RenameText;
                    if (string.IsNullOrEmpty(newName))
                    {
                        MessageBox.Show("The name you provided is either null or empty.",
                            "Error: Invalid name");
                        return;
                    }

                    if (bustupProject.Bustups.Any(x => x.Name.Equals(renameForm.RenameText)))
                    {
                        MessageBox.Show("There is already an item with the same name! Please choose a different one.",
                            "Error: Duplicate entry name");
                        return;
                    }
                    else
                    {
                        bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).Name = renameForm.RenameText;
                    }
                }
                else
                    return;

                UpdateSpriteList();
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            var selection = WinFormsEvents.FilePath_Click("Load .DAT file...", true, new string[] { "Bustup Params (.dat)" });
            if (selection.Count == 0)
                return;

            txt_ImagesPath.Text = "";
            bustupProject = new BustupProject();

            GetBustupParamData(selection[0]);
            ExtractBustupImages(selection[0]);
            UpdateSpriteList();
        }

        private void ExtractBustupImages(string bustupDatPath)
        {
            string bustupDir = "";
            if (bustupProject.Type == BustupType.Portrait)
                bustupDir = Path.GetDirectoryName(Path.GetDirectoryName(bustupDatPath));
            else if (bustupProject.Type == BustupType.Navigator)
                bustupDir = Path.Combine(Path.GetDirectoryName(bustupDatPath), "BUSTUP");

            if (!Directory.Exists(bustupDir))
            {
                MessageBox.Show($"Could not find BUSTUP directory at corresponding location:\n\n" +
                    $"{bustupDir}");
                return;
            }
            else
            {
                foreach (var bin in Directory.GetFiles(bustupDir, "*.BIN", SearchOption.TopDirectoryOnly))
                    ExtractP5RPCBustupBIN(bin);
            }
        }

        private void ExtractP5RPCBustupBIN(string bin)
        {
            using (MemoryStream memStream = new MemoryStream(File.ReadAllBytes(bin)))
            using (EndianBinaryReader reader = new EndianBinaryReader(memStream, Endianness.BigEndian))
            {
                // Get number of images in BIN
                int ddsCount = reader.ReadInt32();

                string extractedPath = txt_ImagesPath.Text;

                // Get directory to extract images to
                if (!Directory.Exists(txt_ImagesPath.Text))
                {
                    extractedPath = Path.Combine(Path.GetDirectoryName(bin), "Extracted");
                    bustupProject.ImagesPath = extractedPath;
                    txt_ImagesPath.Text = extractedPath;
                    Directory.CreateDirectory(extractedPath);
                }
                extractedPath = Path.Combine(extractedPath, Path.GetFileNameWithoutExtension(bin));
                if (Directory.Exists(extractedPath))
                    return;

                Directory.CreateDirectory(extractedPath);

                for (int i = ddsCount; i > 0; i--)
                {
                    // Get name and size of DDS file
                    string ddsName = ReadName(reader);
                    int ddsSize = reader.ReadInt32();
                    byte[] ddsFile = reader.ReadBytes(ddsSize);
                    
                    // Extract contents of dds file to output folder
                    string outImgPath = Path.Combine(extractedPath, ddsName);
                    using (FileStream stream = new FileStream(Path.Combine(extractedPath, outImgPath), FileMode.Create))
                        using (BinaryWriter writer = new BinaryWriter(stream))
                            writer.Write(ddsFile);
                }
            }
        }

        public static string ReadName(BinaryReader reader)
        {
            //Read DDS filename
            return Encoding.ASCII.GetString(reader.ReadBytes(32)).TrimEnd('\0');
        }

        private void GetBustupParamData(string bustupDatPath)
        {
            using (MemoryStream memStream = new MemoryStream(File.ReadAllBytes(bustupDatPath)))
            using (EndianBinaryReader reader = new EndianBinaryReader(memStream, Endianness.BigEndian))
            {
                List<Bustup> bustups = new List<Bustup>();

                // Try to determine the type of bustup bin loaded
                if (bustupProject.Type == BustupType.Unknown)
                {
                    reader.ReadBytes(32); // Skip 32 bytes
                    ushort test = reader.ReadUInt16();

                    if (test == 0)
                        bustupProject.Type = BustupType.Portrait;
                    else
                        bustupProject.Type = BustupType.Navigator;

                    reader.BaseStream.Position = 0;
                }

                while (reader.BaseStream.Position + 32 < reader.BaseStreamLength)
                {
                    //MessageBox.Show($"{reader.BaseStream.Position} / {reader.BaseStreamLength}");
                    Bustup bustup = new Bustup();

                    // Load the first bit of data of bustup entry
                    bustup.MajorID = reader.ReadUInt16();
                    bustup.MinorID = reader.ReadUInt16();
                    
                    if (bustupProject.Type == BustupType.Portrait)
                    {
                        bustup.SubID = reader.ReadUInt16();
                        reader.ReadUInt16(); // skip 2 bytes
                    }

                    bustup.BasePos_X = reader.ReadSingle();
                    bustup.BasePos_Y = reader.ReadSingle();
                    bustup.EyePos_X = reader.ReadSingle();
                    bustup.EyePos_Y = reader.ReadSingle();
                    bustup.MouthPos_X = reader.ReadSingle();
                    bustup.MouthPos_Y = reader.ReadSingle();

                    reader.ReadBytes(2);
                    bustup.AnimType = (AnimationType)reader.ReadUInt16();

                    // Skip 4 bytes at end for portrait bustups
                    if (bustupProject.Type == BustupType.Portrait)
                        reader.ReadSingle();

                    // Assign unique name to bustup
                    bustup.Name = $"{bustup.MajorID.ToString("000")}_{bustup.MinorID.ToString("000")}";
                    if (bustupProject.Type == BustupType.Portrait)
                        bustup.Name += $"_{bustup.SubID.ToString("00")}";
                    
                    int i = 1;
                    string name = bustup.Name;
                    while (bustups.Any(x => x.Name.Equals(bustup.Name)))
                    {
                        i++;
                        bustup.Name = $"{name} ({i})";
                    }

                    bustups.Add(bustup);
                }

                bustupProject.Bustups = bustups;
            }
        }

        private void SelectedBustup_Changed(object sender, EventArgs e)
        {
            UpdateFormCtrlValues();
        }

        private void UpdateFormCtrlValues()
        {
            num_EyeFrame.Value = 0;
            num_MouthFrame.Value = 0;

            Bustup selectedBustup = null;

            if (bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                selectedBustup = bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString()));
            else
                return;

            ToggleControls();

            txt_ImagesPath.Text = bustupProject.ImagesPath;

            num_MajorID.Value = selectedBustup.MajorID;
            num_MinorID.Value = selectedBustup.MinorID;
            num_SubID.Value = selectedBustup.SubID;

            if (bustupProject.Type == BustupType.Navigator)
                num_SubID.Enabled = false;
            else
                num_SubID.Enabled = true;

            num_BasePosX.Value = Convert.ToDecimal(selectedBustup.BasePos_X);
            num_BasePosY.Value = Convert.ToDecimal(selectedBustup.BasePos_Y);
            num_EyePosX.Value = Convert.ToDecimal(selectedBustup.EyePos_X);
            num_EyePosY.Value = Convert.ToDecimal(selectedBustup.EyePos_Y);
            num_MouthPosX.Value = Convert.ToDecimal(selectedBustup.MouthPos_X);
            num_MouthPosY.Value = Convert.ToDecimal(selectedBustup.MouthPos_Y);

            comboBox_Animation.SelectedIndex = comboBox_Animation.Items.IndexOf(
                Enum.GetName(typeof(AnimationType), selectedBustup.AnimType));

            LoadBustupPreview(selectedBustup.MajorID, selectedBustup.MinorID, selectedBustup.SubID);

            ToggleControls(true);
        }

        private void ToggleControls(bool enabled = false)
        {
            foreach (var str in new string[] { "num_MajorID", "num_MinorID", "num_SubID", 
                "num_BasePosX", "num_BasePosY", "num_EyePosX", "num_EyePosY",
                "num_MouthPosX", "num_MouthPosY", "comboBox_Animation", "txt_ImagesPath",
                "num_EyeFrame", "num_MouthFrame" })
            {
                WinForms.GetControl(this, str).Enabled = enabled;
            }
        }

        private void LoadBustupPreview(ushort majorID, ushort minorID, ushort subID)
        {
            string ddsPath = $"B{majorID.ToString("000")}_{minorID.ToString("000")}";
            if (bustupProject.Type == BustupType.Portrait)
                ddsPath += $"_{subID.ToString("00")}";

            ddsPath = Path.Combine(txt_ImagesPath.Text, ddsPath);
            if (Directory.Exists(ddsPath))
            {
                var ddsFiles = Directory.GetFiles(ddsPath, "*.DDS", SearchOption.TopDirectoryOnly);
                if (ddsFiles.Length > 0)
                {
                    Bitmap ddsBitmap = ScaleBitmap(DDS.Decode(File.ReadAllBytes(ddsFiles[0])));
                    pictureBox_Tex.Image = ddsBitmap;
                    return;
                }
            }

            pictureBox_Tex.Image = null;
        }

        private Bitmap ScaleBitmap(Bitmap bmp)
        {
            return new Bitmap(bmp, new Size((int)Math.Ceiling((double)bmp.Width * ((double)bustupProject.Scale / (double)100)), (int)Math.Ceiling(((double)bmp.Height * ((double)bustupProject.Scale / (double)100)))));
        }

        private void MajorID_Changed(object sender, EventArgs e)
        {
            if (!num_MajorID.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MajorID = Convert.ToUInt16(num_MajorID.Value);
        }

        private void MinorID_Changed(object sender, EventArgs e)
        {
            if (!num_MinorID.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MinorID = Convert.ToUInt16(num_MinorID.Value);
        }

        private void SubID_Changed(object sender, EventArgs e)
        {
            if (!num_SubID.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).SubID = Convert.ToUInt16(num_SubID.Value);
        }

        private void BasePosX_Changed(object sender, EventArgs e)
        {
            if (!num_BasePosX.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).BasePos_X = Convert.ToSingle(num_BasePosX.Value);
        }

        private void BasePosY_Changed(object sender, EventArgs e)
        {
            if (!num_BasePosY.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).BasePos_Y = Convert.ToSingle(num_BasePosY.Value);
        }

        private void EyePosX_Changed(object sender, EventArgs e)
        {
            if (!num_EyePosX.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).EyePos_X = Convert.ToSingle(num_EyePosX.Value);

            pictureBox_Eyes.Location = ScalePoint(Convert.ToDouble(num_EyePosX.Value), Convert.ToDouble(num_EyePosY.Value));
        }

        private void EyePosY_Changed(object sender, EventArgs e)
        {
            if (!num_EyePosY.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).EyePos_Y = Convert.ToSingle(num_EyePosY.Value);

            pictureBox_Eyes.Location = ScalePoint(Convert.ToDouble(num_EyePosX.Value), Convert.ToDouble(num_EyePosY.Value));
        }

        private void MouthPosX_Changed(object sender, EventArgs e)
        {
            if (!num_MouthPosX.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MouthPos_X = Convert.ToSingle(num_MouthPosX.Value);

            pictureBox_Mouth.Location = ScalePoint(Convert.ToDouble(num_MouthPosX.Value), Convert.ToDouble(num_MouthPosY.Value));
        }

        private void MouthPosY_Changed(object sender, EventArgs e)
        {
            if (!num_MouthPosY.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MouthPos_Y = Convert.ToSingle(num_MouthPosY.Value);

            pictureBox_Mouth.Location = ScalePoint(Convert.ToDouble(num_MouthPosX.Value), Convert.ToDouble(num_MouthPosY.Value));
        }

        private void Animation_Changed(object sender, EventArgs e)
        {
            if (!comboBox_Animation.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;

            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).AnimType = (AnimationType)Enum.Parse(typeof(AnimationType), comboBox_Animation.SelectedItem.ToString());
        }

        private void ImagePath_Changed(object sender, EventArgs e)
        {
            if (!txt_ImagesPath.Enabled)
                return;

            bustupProject.ImagesPath = txt_ImagesPath.Text;
        }

        private void BrowseImagePath_Click(object sender, EventArgs e)
        {
            txt_ImagesPath.Text = WinFormsEvents.FolderPath_Click("Choose Extracted Bustup folder...");
        }

        private void EyeFrame_Changed(object sender, EventArgs e)
        {
            int eyeFrame = Convert.ToInt32(num_EyeFrame.Value);

            Bustup selectedBustup = null;
            if (bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                selectedBustup = bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString()));
            else
                return;

            string ddsPath = $"B{selectedBustup.MajorID.ToString("000")}_{selectedBustup.MinorID.ToString("000")}";
            if (bustupProject.Type == BustupType.Portrait)
                ddsPath += $"_{selectedBustup.SubID.ToString("00")}";

            ddsPath = Path.Combine(txt_ImagesPath.Text, ddsPath);
            if (Directory.Exists(ddsPath))
            {
                var ddsFiles = Directory.GetFiles(ddsPath, "*.DDS", SearchOption.TopDirectoryOnly);
                string dds = Path.GetFileName(ddsPath).ToLower() + "_e" + eyeFrame + ".dds";
                if (ddsFiles.Length > 0 && ddsFiles.Any(x => x.EndsWith(dds)))
                {
                    Bitmap ddsBitmap = ScaleBitmap(DDS.Decode(File.ReadAllBytes(ddsFiles.FirstOrDefault(x => x.EndsWith(dds)))));
                    pictureBox_Eyes.Image = ddsBitmap;
                    pictureBox_Eyes.Size = ddsBitmap.Size;
                    pictureBox_Eyes.Location = ScalePoint(Convert.ToDouble(selectedBustup.EyePos_X), Convert.ToDouble(selectedBustup.EyePos_Y));
                    pictureBox_Eyes.Visible = true;
                    return;
                }
            }

            pictureBox_Eyes.Visible = false;
        }

        private Point ScalePoint(double x, double y)
        {
            return new Point((int)Math.Ceiling(x * ((double)bustupProject.Scale / (double)50)), (int)Math.Ceiling(y * ((double)bustupProject.Scale / (double)50)));
        }

        private void MouthFrame_Changed(object sender, EventArgs e)
        {
            int mouthFrame = Convert.ToInt32(num_MouthFrame.Value);

            Bustup selectedBustup = null;
            if (bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                selectedBustup = bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString()));
            else
                return;

            string ddsPath = $"B{selectedBustup.MajorID.ToString("000")}_{selectedBustup.MinorID.ToString("000")}";
            if (bustupProject.Type == BustupType.Portrait)
                ddsPath += $"_{selectedBustup.SubID.ToString("00")}";

            ddsPath = Path.Combine(txt_ImagesPath.Text, ddsPath);
            if (Directory.Exists(ddsPath))
            {
                var ddsFiles = Directory.GetFiles(ddsPath, "*.DDS", SearchOption.TopDirectoryOnly);
                string dds = Path.GetFileName(ddsPath).ToLower() + "_m" + mouthFrame + ".dds";
                if (ddsFiles.Length > 0 && ddsFiles.Any(x => x.EndsWith(dds)))
                {
                    Bitmap ddsBitmap = ScaleBitmap(DDS.Decode(File.ReadAllBytes(ddsFiles.FirstOrDefault(x => x.EndsWith(dds)))));
                    pictureBox_Mouth.Image = ddsBitmap;
                    pictureBox_Mouth.Size = ddsBitmap.Size;
                    pictureBox_Mouth.Location = ScalePoint(Convert.ToDouble(selectedBustup.MouthPos_X), Convert.ToDouble(selectedBustup.MouthPos_Y));
                    pictureBox_Mouth.Visible = true;
                    return;
                }
            }

            pictureBox_Mouth.Visible = false;
        }

        private void PreviewScale_Changed(object sender, EventArgs e)
        {
            bustupProject.Scale = Convert.ToInt32(num_Scale.Value);
        }

        private void OpenImageFolder_Click(object sender, EventArgs e)
        {
            Bustup selectedBustup = null;
            if (bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                selectedBustup = bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString()));
            else
                return;

            string ddsPath = $"B{selectedBustup.MajorID.ToString("000")}_{selectedBustup.MinorID.ToString("000")}";
            if (bustupProject.Type == BustupType.Portrait)
                ddsPath += $"_{selectedBustup.SubID.ToString("00")}";

            ddsPath = Path.Combine(txt_ImagesPath.Text, ddsPath);
            if (Directory.Exists(ddsPath))
                Exe.Run("explorer.exe", ddsPath);
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                copiedParams = bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).Copy();
            else
                return;
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            if (listBox_Sprites.SelectedItems.Count > 0 && copiedParams != new Bustup())
            {
                foreach (var selection in listBox_Sprites.SelectedItems)
                {
                    if (bustupProject.Bustups.Any(x => x.Name.Equals(selection.ToString())))
                    {
                        Bustup selectedBustup = bustupProject.Bustups.First(x => x.Name.Equals(selection.ToString())).Copy();
                        Bustup newBustup = copiedParams.Copy();

                        // Preserve bustup names and IDs
                        newBustup.Name = selectedBustup.Name;
                        newBustup.MajorID = selectedBustup.MajorID;
                        newBustup.MinorID = selectedBustup.MinorID;
                        newBustup.SubID = selectedBustup.SubID;

                        int bustupIndex = bustupProject.Bustups.IndexOf(bustupProject.Bustups.First(x => x.Name.Equals(selection.ToString())));
                        if (bustupIndex != -1)
                        {
                            bustupProject.Bustups[bustupIndex] = newBustup;
                        }
                    }
                }
                UpdateFormCtrlValues();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            bustupProject.Bustups.Add(new Bustup());
            UpdateSpriteList();
            listBox_Sprites.SelectedIndex = listBox_Sprites.Items.Count - 1;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listBox_Sprites.SelectedItems.Count > 0)
            {
                int selectedIndex = listBox_Sprites.SelectedIndex;

                // Remove all highlighted bustup entries
                foreach (var selection in listBox_Sprites.SelectedItems)
                    if (bustupProject.Bustups.Any(x => x.Name.Equals(selection.ToString())))
                        bustupProject.Bustups.Remove(bustupProject.Bustups.First(x => x.Name.Equals(selection.ToString())));

                UpdateSpriteList();

                // Restore previous selection
                if (listBox_Sprites.Items.Count - 1 >= selectedIndex)
                    listBox_Sprites.SelectedIndex = selectedIndex;
            }
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                Remove_Click(sender, e);
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
                Rename_Click(sender, e);
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                Copy_Click(sender, e);
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
                Paste_Click(sender, e);
        }
    }

    public static class ControlExtensions
    {
        public static IEnumerable<Control> FlattenChildren<T>(this Control control)
        {
            return control.FlattenChildren().OfType<T>().Cast<Control>();
        }

        public static IEnumerable<Control> FlattenChildren(this Control control)
        {
            var children = control.Controls.Cast<Control>();
            return children.SelectMany(c => FlattenChildren(c)).Concat(children);
        }
    }
}
