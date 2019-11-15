using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BustupParamEditor;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace BustupParamEditorGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static string OpenFile()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            string filePath = "";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                filePath = dialog.FileName;
            }
            return filePath;
        }

        public static string OpenFolder()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            string folderPath = "";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                folderPath = dialog.FileName;
            }
            return folderPath;
        }

        public static void Save(ParamEntry pEntry, string paramFilePath)
        {
            ParamEntry.Write(pEntry.EntryData, 8, pEntry.OffsetX);
            if (pEntry.Type == ParamEntry.ParamType.Normal)
            {
                ParamEntry.Write(pEntry.EntryData, 12, pEntry.OffsetY);
                ParamEntry.Write(pEntry.EntryData, 16, pEntry.EyePositionX);
                ParamEntry.Write(pEntry.EntryData, 20, pEntry.EyepositionY);
                ParamEntry.Write(pEntry.EntryData, 24, pEntry.MouthPositionX);
                ParamEntry.Write(pEntry.EntryData, 28, pEntry.MouthPositionY);
                ParamEntry.WriteShort(pEntry.EntryData, 34, pEntry.InitialAnimation);
            }
            else
            {
                ParamEntry.Write(pEntry.EntryData, 12, pEntry.EyePositionX);
                ParamEntry.Write(pEntry.EntryData, 16, pEntry.EyepositionY);
                ParamEntry.Write(pEntry.EntryData, 20, pEntry.MouthPositionX);
                ParamEntry.Write(pEntry.EntryData, 28, pEntry.MouthPositionY);
                ParamEntry.WriteShort(pEntry.EntryData, 30, pEntry.InitialAnimation);
            }
            pEntry.Replace(pEntry.EntryData, pEntry.EntryIndex, paramFilePath, pEntry.Type);
        }
    }
}
