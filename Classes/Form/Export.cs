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

            foreach (var bustupFolder in Directory.GetDirectories(txt_ImagesPath.Text))
            {
                string exportBin = Path.Combine(exportFolder, Path.GetFileName(bustupFolder) + ".BIN");
                using (FileStream stream = new FileStream(exportBin, FileMode.OpenOrCreate))
                using (EndianBinaryWriter writer = new EndianBinaryWriter(stream, Endianness.BigEndian))
                {
                    var ddsFiles = Directory.GetFiles(bustupFolder, "*.dds", SearchOption.TopDirectoryOnly);
                    writer.Write(ddsFiles.Length);

                    foreach (var dds in ddsFiles)
                    {
                        Byte[] ddsFile = File.ReadAllBytes(dds);

                        // Get name and size of DDS file
                        WriteName(writer, Path.GetFileName(dds));
                        writer.Write(ddsFile.Length);
                        writer.Write(ddsFile);
                    }
                }
            }
        }

        public static void WriteName(EndianBinaryWriter writer, string name)
        {
            byte[] nameBytes = Encoding.ASCII.GetBytes(name);
            writer.Write(nameBytes);
            int padAmount = 32 - nameBytes.Length;
            writer.Write(new byte[padAmount]);
        }
    }
}
