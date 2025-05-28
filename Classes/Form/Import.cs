using DarkUI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BustupEditor
{
    public partial class MainForm : DarkForm
    {
        private void Import_Click(object sender, EventArgs e)
        {
            var selection = WinFormsDialogs.SelectFile("Load .DAT file...", true, new string[] { "Bustup Params (.dat)" });
            if (selection.Count == 0)
                return;

            txt_ImagesPath.Text = "";
            bustupProject = new BustupProject();

            ImportBustupData(selection[0]);
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
                    string ddsName = ReadDDSName(reader);
                    int ddsSize = reader.ReadInt32();
                    byte[] ddsFile = reader.ReadBytes(ddsSize);

                    if (ddsName.TrimEnd().EndsWith(".dds2"))
                    {
                        string outImgPath = Path.Combine(extractedPath, ddsName);
                        using (FileStream stream = new FileStream(Path.Combine(extractedPath, outImgPath), FileMode.Create))
                        using (BinaryWriter writer = new BinaryWriter(stream))
                            writer.Write(ddsFile);
                        ExtractDDS2(ddsFile, extractedPath);
                        bustupProject.Platform = PlatformType.PS3;
                    }
                    else
                    {
                        // Extract contents of dds file to output folder
                        string outImgPath = Path.Combine(extractedPath, ddsName);
                        using (FileStream stream = new FileStream(Path.Combine(extractedPath, outImgPath), FileMode.Create))
                        using (BinaryWriter writer = new BinaryWriter(stream))
                            writer.Write(ddsFile);
                    }
                }
            }
        }

        private void ExtractDDS2(byte[] dds2File, string extractedPath)
        {
            using (EndianBinaryReader reader = new EndianBinaryReader(new MemoryStream(dds2File), Endianness.BigEndian))
            {
                int imgCount = reader.ReadInt32();
                for (int i = imgCount; i > 0; i--)
                {
                    string ddsName = ReadDDSName(reader);
                    int ddsSize = reader.ReadInt32();
                    byte[] ddsFile = reader.ReadBytes(ddsSize);
                    using (FileStream stream = new FileStream($"{extractedPath}\\{ddsName}", FileMode.Create))
                    {
                        using (BinaryWriter writer = new BinaryWriter(stream))
                        {
                            writer.Write(ddsFile);
                        }
                    }

                }
            }
        }

        public static string ReadDDSName(BinaryReader reader)
        {
            return Encoding.ASCII.GetString(reader.ReadBytes(32)).TrimEnd('\0');
        }

        private void ImportBustupData(string bustupDatPath)
        {
            if (string.IsNullOrEmpty(bustupDatPath))
                return;

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

                var entryCount = reader.BaseStreamLength;
                if (bustupProject.Type == BustupType.Portrait)
                    entryCount = entryCount / 40;
                else if (bustupProject.Type == BustupType.Navigator)
                    entryCount = entryCount / 32;

                for (int i = 0; i < entryCount; i++)
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

                    int x = 1;
                    string name = bustup.Name;
                    while (bustups.Any(z => z.Name.Equals(bustup.Name)))
                    {
                        x++;
                        bustup.Name = $"{name} ({x})";
                    }

                    bustups.Add(bustup);
                }

                bustupProject.Bustups = bustups;
            }
        }
    }
}
