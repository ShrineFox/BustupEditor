using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BustupParamEditor.IO;

namespace BustupParamEditor
{
    public class Params
    {
        public static List<byte[]> GetParams(byte[] paramFile, int paramSize)
        {
            int paramCount = paramFile.Length / paramSize;
            List<byte[]> paramEntries = new List<byte[]>();

            using (MemoryStream memStream = new MemoryStream(paramFile))
            using (BinaryReader reader = new BinaryReader(memStream))
            {
                for (int i = 0; i < paramCount; i++)
                {
                    paramEntries.Add(reader.ReadBytes(paramSize));
                }
            }

            return paramEntries;
        }

        public static int GetEntryIndex(List<byte[]> paramEntries, int characterId, int expressionId, int outfitId, bool isAssist)
        {
            int i = 0;
            foreach (byte[] entry in paramEntries)
            {
                using (MemoryStream memStream = new MemoryStream(entry))
                using (EndianBinaryReader reader = new EndianBinaryReader(memStream, Endianness.BigEndian))
                {
                    short entryCharacterId = reader.ReadInt16();
                    short entryExpressionId = reader.ReadInt16();
                    short entryOutfitId = reader.ReadInt16();
                    if (isAssist && entryCharacterId == characterId && entryExpressionId == expressionId)
                        return i;
                    else if (entryCharacterId == characterId && entryExpressionId == expressionId && entryOutfitId == outfitId)
                        return i;
                }
                i++;
            }
            return -1;
        }

        public static short SetInitAnim(int selectedIndex)
        {
            short newInitAnim = 0;
            switch (selectedIndex)
            {
                case 0:
                    newInitAnim = 0x00;
                    break;
                case 1:
                    newInitAnim = 0x01;
                    break;
                case 2:
                    newInitAnim = 0x02;
                    break;
                case 3:
                    newInitAnim = 0x08;
                    break;
                case 4:
                    newInitAnim = 0x03;
                    break;
                case 5:
                    newInitAnim = 0x0B;
                    break;
            }
            return newInitAnim;
        }

        public static int GetInitAnim(short initAnimType)
        {
            int comboBoxIndex = 0;
            switch (initAnimType)
            {
                case 0x00:
                    comboBoxIndex = 0;
                    break;
                case 0x01:
                    comboBoxIndex = 1;
                    break;
                case 0x02:
                    comboBoxIndex = 2;
                    break;
                case 0x08:
                    comboBoxIndex = 3;
                    break;
                case 0x03:
                    comboBoxIndex = 4;
                    break;
                case 0x0B:
                    comboBoxIndex = 5;
                    break;
            }
            return comboBoxIndex;
        }


        public static void AddEntry(string paramFilePath, string filename, bool isAssist)
        {
            string[] bustupNameParts = filename.TrimStart('b').Split(' ')[0].Replace(".bin", "").Split('_');

            using (FileStream fs = new FileStream(paramFilePath, FileMode.Open))
            using (EndianBinaryWriter writer = new EndianBinaryWriter(fs, Endianness.BigEndian))
            {
                writer.BaseStream.Position = writer.BaseStream.Length;
                writer.Write(Convert.ToInt16(bustupNameParts[0]));
                writer.Write(Convert.ToInt16(bustupNameParts[1]));
                if (!isAssist)
                    writer.Write(Convert.ToInt16(bustupNameParts[2]));
                else
                    writer.Write(Convert.ToInt16(0));

                if (!isAssist)
                    writer.Write(new byte[] { 0x00, 0x00, 0xC2, 0xD2, 0x00, 0x00, 0x41, 0xC8, 0x00, 0x00, 0x43, 0x8D, 0x00, 0x00, 0x43, 0x6E, 0x00, 0x00, 0x43, 0x80, 0x00, 0x00, 0x43, 0xA8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00 });
                else
                    writer.Write(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x42, 0xC4, 0x00, 0x00, 0x42, 0xC8, 0x00, 0x00, 0x42, 0xBC, 0x00, 0x00, 0x43, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03 });
            }
        }

        public static void RenameEntry(string paramFilePath, string filename, bool isAssist, int selectedIndex)
        {
            string[] bustupNameParts = filename.TrimStart('b').Split(' ')[0].Replace(".bin", "").Split('_');

            using (FileStream fs = new FileStream(paramFilePath, FileMode.Open))
            using (EndianBinaryWriter writer = new EndianBinaryWriter(fs, Endianness.BigEndian))
            {
                if (isAssist)
                    writer.BaseStream.Position = selectedIndex * 32;
                else
                    writer.BaseStream.Position = selectedIndex * 40;

                writer.Write(Convert.ToInt16(bustupNameParts[0]));
                writer.Write(Convert.ToInt16(bustupNameParts[1]));
                if (!isAssist)
                    writer.Write(Convert.ToInt16(bustupNameParts[2]));
                else
                    writer.Write(Convert.ToInt16(0));
            }
        }


    }
}
