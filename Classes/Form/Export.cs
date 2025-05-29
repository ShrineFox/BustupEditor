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
using GFDLibrary;
using GFDLibrary.Textures;
using System.Drawing;
using static BustupEditor.MainForm;
using System.Drawing.Imaging;
using BCnEncoder.Shared.ImageFiles;
using Scarlet.IO.ImageFormats;

namespace BustupEditor
{
    public partial class MainForm : DarkForm
    {
        private void Export_Click(object sender, EventArgs e)
        {
            string exportFolder = WinFormsDialogs.SelectFolder("Choose Output folder...");

            ExportDat(exportFolder);
            ExportP5RPCBustupBins(exportFolder);

            MessageBox.Show($"Done exporting new files to:\n\n{exportFolder}");
        }

        private void ExportDat(string exportFolder)
        {
            string outputFile = exportFolder;
            if (bustupProject.Type == BustupType.Portrait)
                outputFile = Path.Combine(outputFile, $"DATA//BUSTUP_PARAM.DAT");
            else if (bustupProject.Type == BustupType.Navigator)
                outputFile = Path.Combine(outputFile, "MSGASSISTBUSTUPPARAM.DAT");

            Directory.CreateDirectory(Path.GetDirectoryName(outputFile));

            using (FileStream stream = new FileStream(outputFile, FileMode.OpenOrCreate))
            using (EndianBinaryWriter writer = new EndianBinaryWriter(stream, Endianness.BigEndian))
            {
                foreach (var bustup in bustupProject.Bustups)
                {
                    writer.Write(bustup.MajorID);
                    writer.Write(bustup.MinorID);

                    if (bustupProject.Type == BustupType.Portrait)
                    {
                        writer.Write(bustup.SubID);
                        writer.Write(new byte[2]);
                    }

                    writer.Write(bustup.BasePos_X);
                    writer.Write(bustup.BasePos_Y);
                    writer.Write(bustup.EyePos_X);
                    writer.Write(bustup.EyePos_Y);
                    writer.Write(bustup.MouthPos_X);
                    writer.Write(bustup.MouthPos_Y);

                    writer.Write(new byte[2]);
                    writer.Write((short)bustup.AnimType);

                    if (bustupProject.Type == BustupType.Portrait)
                        writer.Write(new byte[4]);
                }
            }
        }

        private void ExportP5RPCBustupBins(string exportFolder)
        {
            if (bustupProject.Type == BustupType.Navigator)
                exportFolder = Path.Combine(exportFolder, "BUSTUP");

            Directory.CreateDirectory(exportFolder);

            // TO DO: More performant way to do this, maybe pre-convert images to DDS
            // and keep them in a list to avoid making duplicates in memory?
            foreach (var bustup in bustupProject.Bustups.Where(x => !string.IsNullOrEmpty(x.BaseImgPath)))
            {
                byte[] baseImg = GetDDSDataFromImagePath(bustup.BaseImgPath);
                byte[] blinkImg1 = GetBlankDDS();
                byte[] blinkImg2 = GetBlankDDS();
                byte[] mouthImg1 = GetBlankDDS();
                byte[] mouthImg2 = GetBlankDDS();
                byte[] mouthImg3 = GetBlankDDS();

                if (!string.IsNullOrEmpty(bustup.BlinkImg1Path))
                    blinkImg1 = GetDDSDataFromImagePath(bustup.BlinkImg1Path);
                if (!string.IsNullOrEmpty(bustup.BlinkImg2Path))
                    blinkImg2 = GetDDSDataFromImagePath(bustup.BlinkImg2Path);
                if (!string.IsNullOrEmpty(bustup.MouthImg1Path))
                    mouthImg1 = GetDDSDataFromImagePath(bustup.MouthImg1Path);
                if (!string.IsNullOrEmpty(bustup.MouthImg2Path))
                    mouthImg2 = GetDDSDataFromImagePath(bustup.MouthImg2Path);
                if (!string.IsNullOrEmpty(bustup.MouthImg3Path))
                    mouthImg3 = GetDDSDataFromImagePath(bustup.MouthImg3Path);

                string exportBin = Path.Combine(exportFolder, "B" + bustup.Name + ".BIN");
                using (FileStream stream = new FileStream(exportBin, FileMode.OpenOrCreate))
                using (EndianBinaryWriter writer = new EndianBinaryWriter(stream, Endianness.BigEndian))
                {
                    writer.Write(6); // image count

                    for (int i = 0; i < 6; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                WriteName(writer, "b" + bustup.Name + ".dds");
                                writer.Write(baseImg.Length);
                                writer.Write(baseImg);
                                break;
                            case 1:
                                WriteName(writer, "b" + bustup.Name + "_e1.dds");
                                writer.Write(blinkImg1.Length);
                                writer.Write(blinkImg1);
                                break;
                            case 2:
                                WriteName(writer, "b" + bustup.Name + "_e2.dds");
                                writer.Write(blinkImg2.Length);
                                writer.Write(blinkImg2);
                                break;
                            case 3:
                                WriteName(writer, "b" + bustup.Name + "_m1.dds");
                                writer.Write(mouthImg1.Length);
                                writer.Write(mouthImg1);
                                break;
                            case 4:
                                WriteName(writer, "b" + bustup.Name + "_m2.dds");
                                writer.Write(mouthImg2.Length);
                                writer.Write(mouthImg2);
                                break;
                            case 5:
                                WriteName(writer, "b" + bustup.Name + "_m3.dds");
                                writer.Write(mouthImg3.Length);
                                writer.Write(mouthImg3);
                                break;

                        }
                    }
                }
            }
        }

        private byte[] GetBlankDDS()
        {
            var texture = TextureEncoder.Encode("temp.dds", TextureFormat.DDS, new Bitmap(4, 4, PixelFormat.Format32bppArgb));
            return texture.Data;
        }

        private byte[] GetDDSDataFromImagePath(string imgPath)
        {
            string extension = Path.GetExtension(imgPath).ToLowerInvariant();
            switch (extension)
            {
                case ".dds":
                    return File.ReadAllBytes(imgPath);
                case ".png":
                    var texture = TextureEncoder.Encode("temp.dds", TextureFormat.DDS, new Bitmap(imgPath));
                    return texture.Data;
            }

            return null;
        }

        public static void WriteName(EndianBinaryWriter writer, string name)
        {
            byte[] nameBytes = Encoding.ASCII.GetBytes(name);
            writer.Write(nameBytes);
            int padAmount = 32 - nameBytes.Length;
            writer.Write(new byte[padAmount]);
        }

        private void ExtractBustups_Click(object sender, EventArgs e)
        {
            var selection = WinFormsDialogs.SelectFile("Select Bustups To Extract...", true, new string[] { "BIN (.bin)" });
            if (selection.Count > 0 && !string.IsNullOrEmpty(selection.First()))
            {
                foreach(var bin in selection)
                {
                    ExtractP5RPCBustupBIN(bin, Path.Combine(Path.GetDirectoryName(bin), "Extracted"));
                }
            }

            MessageBox.Show("Done exporting bustups to Extracted folder.");
        }
    }
}
