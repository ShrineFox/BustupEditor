using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDS2ToolGUI
{
    class DDS2
    {
        public static bool ValidateDDS2(string filePath)
        {
            if (filePath.Length > 0 && File.Exists(filePath))
            {
                return true;
            }
            return false;
        }

        public static bool ValidateFolder(string filePath)
        {
            if (filePath.Length > 0 && Directory.Exists(filePath))
            {
                if (Directory.GetFiles(filePath, "*.DDS").Length > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static string Extract(string filePath)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {

                //Get BIN image count and name, make folder to extract DDS to if it doesn't exist already
                int dds2Count = ReadInt32(reader);
                string binName = Path.GetFileNameWithoutExtension(filePath);
                string dirName = $"{Path.GetDirectoryName(filePath)}\\{binName}";
                if (!Directory.Exists(dirName))
                {
                    Directory.CreateDirectory(dirName);

                    bool combine = false;

                    try
                    {
                        for (int i = dds2Count; i > 0; i--)
                        {
                            //Get name and size of DDS2 file
                            string dds2Name = ReadName(reader);
                            int dds2Size = ReadInt32(reader);
                            //If image count exists, extract in pairs... otherwise, extract single DDS images
                            int imageCount = ReadInt32(reader);

                            if (imageCount == 2)
                            {
                                combine = true;
                                for (int x = imageCount; x > 0; x--)
                                {
                                    string imageName = ReadName(reader);
                                    int ddsSize = ReadInt32(reader);
                                    byte[] ddsFile = reader.ReadBytes(ddsSize);
                                    using (FileStream stream = new FileStream($"{dirName}\\{imageName}", FileMode.Create))
                                    {
                                        using (BinaryWriter writer = new BinaryWriter(stream))
                                        {
                                            writer.Write(ddsFile);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                reader.BaseStream.Position -= 4;
                                for (int x = dds2Count; x > 0; x--)
                                {
                                    byte[] ddsFile = reader.ReadBytes(dds2Size);
                                    using (FileStream stream = new FileStream($"{dirName}\\{dds2Name}", FileMode.CreateNew))
                                    {
                                        using (BinaryWriter writer = new BinaryWriter(stream))
                                        {
                                            writer.Write(ddsFile);
                                        }
                                    }
                                    dds2Name = ReadName(reader);
                                    try
                                    {
                                        dds2Size = ReadInt32(reader);
                                    }
                                    catch { }
                                }

                            }

                            if (i != 1)
                                reader.ReadBytes(20);
                        }
                    }
                    catch
                    {

                    }


                    if (!Directory.Exists($"{dirName}\\PNG"))
                    {
                        Directory.CreateDirectory($"{dirName}\\PNG");
                        //If images are paired, convert to PNG in temp directory, combine, then save to new PNG folder
                        foreach (string ddsFile in Directory.GetFiles(dirName, "*.dds"))
                        {
                            Png.Convert(ddsFile);
                            if (!combine)
                            {
                                foreach (string pngFile in Directory.GetFiles(dirName, "*.png"))
                                {
                                    File.Move(pngFile, $"{dirName}\\PNG\\{Path.GetFileName(pngFile)}");
                                }
                            }
                        }

                        if (combine)
                        {
                            var tempDirectory = Path.Combine(Path.GetTempPath(), "DDS2Temp_" + Path.GetRandomFileName());
                            if (!Directory.Exists(tempDirectory))
                                Directory.CreateDirectory(tempDirectory);

                            List<string> pngFiles = new List<string>();
                            foreach (string pngFile in Directory.GetFiles(dirName, "*.png"))
                            {
                                string newpngLocation = $"{tempDirectory}\\{Path.GetFileName(pngFile)}";
                                File.Move(pngFile, newpngLocation);

                                pngFiles.Add(newpngLocation);
                            }
                            for (int i = 0; i < pngFiles.Count; i++)
                            {
                                Png.Combine(pngFiles[i + 1], pngFiles[i], dirName);
                                i++;
                            }
                        }
                    }
                }
                
                return dirName;
            }
        }

        public static void Repack(string filePath)
        {
            //Get all DDS files in folder
            List<string> ddsFiles = new List<string>();
            foreach (string ddsFile in Directory.GetFiles(filePath, "*.DDS"))
            {
                ddsFiles.Add(ddsFile);
            }

            //Determine if new DDS files are in pairs or not
            bool pairs = false;
            string s1 = Path.GetFileNameWithoutExtension(ddsFiles[0]) + "_b";
            string s2 = Path.GetFileNameWithoutExtension(ddsFiles[1]);

            int dds2Count = ddsFiles.Count;
            if ( s1 == s2 )
            {
                pairs = true;
                dds2Count = dds2Count / 2;
            }

            //Convert DDS files back into DDS2
            using (FileStream stream = new FileStream($"{Path.GetDirectoryName(filePath)}\\{Path.GetFileName(filePath)}.bin", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(ConvertInt32(dds2Count));
                    int x = 0;
                    for (int i = dds2Count; i >0; i--)
                    {
                        int ddsSize1 = 0;
                        int ddsSize2 = 0;
                        int dds2Size = 0;
                        if (pairs)
                        {
                            PadDds2Name32(writer, ddsFiles, x);
                            ddsSize1 = GetFileSize(ddsFiles[x]);
                            ddsSize2 = GetFileSize(ddsFiles[x + 1]);
                            dds2Size = ConvertInt32(ddsSize1 + ddsSize2 + 96);
                            writer.Write(dds2Size);
                            writer.Write(ConvertInt32(2));
                            PadDdsName32(writer, ddsFiles, x);
                            writer.Write(ConvertInt32(ddsSize1));
                            byte[] firstDDS = File.ReadAllBytes(ddsFiles[x]);
                            writer.Write(firstDDS);
                            x++;

                            PadDdsName32(writer, ddsFiles, x);
                            writer.Write(ConvertInt32(ddsSize2));
                            byte[] secondDDS = File.ReadAllBytes(ddsFiles[x]);
                            writer.Write(secondDDS);
                            x++;
                            writer.Write(new byte[20]);
                        }
                        else
                        {
                            PadDdsName32(writer, ddsFiles, x);
                            dds2Size = GetFileSize(ddsFiles[x]);
                            writer.Write(ConvertInt32(dds2Size));
                            byte[] ddsFile = File.ReadAllBytes(ddsFiles[x]);
                            writer.Write(ddsFile);
                            x++;
                        }
                    }
                }
            }
        }

        public static int ReadInt32(BinaryReader reader) //Read 32-bit value with endian shifted
        {
            return reader.ReadByte() << 24 | reader.ReadByte() << 16 | reader.ReadByte() << 8 | reader.ReadByte();
        }

        public static int ConvertInt32(int word)
        {
            byte[] bytes = BitConverter.GetBytes(word);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            int result = BitConverter.ToInt32(bytes, 0);
            return result;
        }

        public static string ReadName(BinaryReader reader) //Read DDS filename
        {
            return Encoding.ASCII.GetString(reader.ReadBytes(32)).TrimEnd('\0');
        }

        public static void PadDdsName32(BinaryWriter writer, List<string> ddsFiles, int x)
        {
            writer.Write(Encoding.ASCII.GetBytes(Path.GetFileName(ddsFiles[x])));
            int padAmount = 32 - Path.GetFileName(ddsFiles[x]).Length;
            writer.Write(new byte[padAmount]);
        }

        public static void PadDds2Name32(BinaryWriter writer, List<string> ddsFiles, int x)
        {
            writer.Write(Encoding.ASCII.GetBytes(Path.GetFileName($"{ddsFiles[x]}2 ")));
            int padAmount = 32 - Path.GetFileName($"{ddsFiles[x]}2 ").Length;
            writer.Write(new byte[padAmount]);
        }

        public static int GetFileSize(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            int length = (int)file.Length;
            return length;
        }

        public static IEnumerable<int> PatternAt(byte[] source, byte[] pattern)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source.Skip(i).Take(pattern.Length).SequenceEqual(pattern))
                {
                    yield return i;
                }
            }
        }

    }
}
