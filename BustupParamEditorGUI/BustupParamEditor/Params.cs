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

        public static int GetEntryIndex(List<byte[]> paramEntries, int characterId, int expressionId, int outfitId)
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
                    if (entryCharacterId == characterId && entryExpressionId == expressionId && entryOutfitId == outfitId)
                        return i;
                }
                i++;
            }
            return -1;
        }


    }
}
