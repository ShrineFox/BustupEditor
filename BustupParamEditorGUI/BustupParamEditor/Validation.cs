using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BustupParamEditor.IO;
using BustupParamEditorGUI;

namespace BustupParamEditor
{
    class Validation
    {
        public static bool ParamFilePath(string path, out List<byte[]> paramEntries)
        {
            paramEntries = new List<byte[]>();

            byte[] paramFile = File.ReadAllBytes(path);
            
            if (paramFile.Length >= 43840)
            {
                paramEntries = Params.GetParams(paramFile, 40);
            }
            else if (paramFile.Length >= 9216 && paramFile.Length < 43840)
            {
                paramEntries = Params.GetParams(paramFile, 32);
            }
            else
            {
                MessageBox.Show("Not a valid bustup param file. Please try again.");
                return false;
            }
            return true;
        }

        public static ParamEntry SelectedEntry(List<byte[]> paramEntries, string selectedEntryName)
        {
            ParamEntry pEntry = new ParamEntry();
            string[] bustupNameParts = selectedEntryName.TrimStart('b').Split(' ')[0].Replace(".bin","").Split('_');

            int paramId = 0;
            
            int characterId = Convert.ToInt32(bustupNameParts[0]);
            int expressionId = Convert.ToInt32(bustupNameParts[1]);
            int outfitId = 0;
            try
            {
                outfitId = Convert.ToInt32(bustupNameParts[2]);
            }
            catch
            {
            }
            bool isAssist = MainForm.pType == BustupParamEditor.ParamEntry.ParamType.Assist;
            paramId = Params.GetEntryIndex(paramEntries, characterId, expressionId, outfitId, isAssist);
            pEntry.Read(paramEntries, paramId);

            return pEntry;
        }
    }
}
