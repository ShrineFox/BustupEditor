using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BustupParamEditor.IO;

namespace BustupParamEditor
{
    public class ParamEntry
    {
        public int EntryIndex { get; set; }
        public int EntryID { get; set; }
        public short CharacterId { get; set; }
        public short ExpressionId { get; set; }
        public short OutfitId { get; set; }

        public float OffsetX { get; set; }
        public float OffsetY { get; set; }

        public float EyePositionX { get; set; }
        public float EyepositionY { get; set; }

        public float MouthPositionX { get; set; }
        public float MouthPositionY { get; set; }

        public short InitialAnimation { get; set; }

        public enum ParamType { Normal, Assist }

        public ParamType Type { get; set; }

        public byte[] EntryData { get; set; }

        public void Read(List<byte[]> entries, int paramId)
        {
            EntryData = entries[paramId];
            using (MemoryStream memStream = new MemoryStream(EntryData))
            using (EndianBinaryReader reader = new EndianBinaryReader(memStream, Endianness.BigEndian))
            {
                CharacterId = reader.ReadInt16(); //2
                ExpressionId = reader.ReadInt16(); //4
                OutfitId = reader.ReadInt16(); //6
                reader.ReadBytes(2); //8
                OffsetX = reader.ReadSingle(); //12

                if (reader.BaseStream.Length == 32)
                {
                    EyePositionX = reader.ReadSingle(); //16
                    EyepositionY = reader.ReadSingle(); //20
                    MouthPositionX = reader.ReadSingle(); //24
                    MouthPositionY = reader.ReadSingle(); //28
                    reader.ReadBytes(2); //30
                    InitialAnimation = reader.ReadInt16(); //32
                    Type = ParamType.Assist;
                }
                else if (reader.BaseStream.Length == 40)
                {
                    OffsetY = reader.ReadSingle(); //16
                    EyePositionX = reader.ReadSingle(); //20
                    EyepositionY = reader.ReadSingle(); //24
                    MouthPositionX = reader.ReadSingle(); //28
                    MouthPositionY = reader.ReadSingle(); //32
                    reader.ReadBytes(2); //34
                    InitialAnimation = reader.ReadInt16(); //36
                    reader.ReadSingle(); //40
                    Type = ParamType.Normal;
                }
                EntryIndex = paramId;
            }
        }

        public void Replace(byte[] entry, int index, string path, ParamType type)
        {
            EntryData = entry;
            using (FileStream stream = new FileStream(path, FileMode.Open))
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                if (type == ParamEntry.ParamType.Assist)
                    writer.BaseStream.Position = (index * 32);
                else if (type == ParamEntry.ParamType.Normal)
                    writer.BaseStream.Position = (index * 40);

                long pos = writer.BaseStream.Position;
                if (entry != null && entry.Length > 0)
                    writer.Write(entry);
            }
        }

        public static byte[] Write(byte[] entry, long position, float newValue)
        {
            using (MemoryStream memStream = new MemoryStream(entry))
            using (EndianBinaryWriter writer = new EndianBinaryWriter(memStream, Endianness.BigEndian))
            {
                writer.BaseStream.Seek(position, SeekOrigin.Begin);
                writer.Write(newValue);
            }
            return entry;
        }

        public static byte[] WriteShort(byte[] entry, long position, short newValue)
        {
            using (MemoryStream memStream = new MemoryStream(entry))
            using (EndianBinaryWriter writer = new EndianBinaryWriter(memStream, Endianness.BigEndian))
            {
                writer.BaseStream.Seek(position, SeekOrigin.Begin);
                writer.Write(newValue);
            }
            return entry;
        }
    }
}
