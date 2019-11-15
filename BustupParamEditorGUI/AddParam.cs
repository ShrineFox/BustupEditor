using BustupParamEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BustupParamEditorGUI
{
    public partial class AddParam : Form
    {
        public static ResultValue Result { get; private set; }
        private static string newFileName = "b000_000_00.bin";
        private static bool createNewBin = false;
        private static bool exists = false;
        public AddParam()
        {
            InitializeComponent();
            if (MainForm.pType == BustupParamEditor.ParamEntry.ParamType.Assist)
            {
                numUpDwn_OutfitID.Enabled = false;
                newFileName = "b000_000.bin";
            }
            checkBox_CreateBin.Text = $"Create {newFileName}";
        }

        private static int characterid = 000;
        private static int expressionid = 000;
        private static int outfitid = 00;

        private void AddEntry(object sender, EventArgs e)
        {
            bool isAssist = MainForm.pType == BustupParamEditor.ParamEntry.ParamType.Assist;
            createNewBin = checkBox_CreateBin.Enabled;
            if (Params.GetEntryIndex(MainForm.paramEntries, characterid, expressionid, outfitid, isAssist) != -1)
            {
                MessageBox.Show("A parameter entry with the same IDs already exists!");
                exists = true;
            }
            else if(checkBox_CreateBin.Enabled)
            {
                if (MainForm.bustupDirPath != null && File.Exists($"{MainForm.bustupDirPath}\\{newFileName}"))
                {
                    MessageBox.Show("A bustup .bin with the same IDs already exists!" +
                        "\nUncheck the box if you just want to create a param entry for it.");
                    createNewBin = false;
                    exists = true;
                    return;
                }
                else if (MainForm.bustupDirPath == null)
                {
                    MessageBox.Show("A bustup .bin cannot be created because the Bustup Directory has not been set." +
                        "\nUncheck the box if you just want to create a param entry.");
                    createNewBin = false;
                    return;
                }
            }
            
            Result = new ResultValue(this);
        }

        public class ResultValue
        {
            private readonly AddParam mParent;

            internal ResultValue(AddParam parent)
            {
                mParent = parent;
            }


            public string fileName => newFileName;
            public bool createBin => createNewBin;
            public bool alreadyExists => exists;
        }

        private void CharacterID_ValueChanged(object sender, EventArgs e)
        {
            characterid = Convert.ToInt32(numUpDwn_CharaID.Value);
            ValueChanged();
        }

        private void ExpressionID_ValueChanged(object sender, EventArgs e)
        {
            expressionid = Convert.ToInt32(numUpDwn_ExpressionID.Value);
            ValueChanged();
        }

        private void OutfitID_ValueChanged(object sender, EventArgs e)
        {
            outfitid = Convert.ToInt32(numUpDwn_OutfitID.Value);
            ValueChanged();
        }

        private void ValueChanged()
        {
            if (MainForm.pType == BustupParamEditor.ParamEntry.ParamType.Assist)
                newFileName = $"b{characterid.ToString("D3")}_{expressionid.ToString("D3")}.bin";
            else if (MainForm.pType == BustupParamEditor.ParamEntry.ParamType.Normal)
                newFileName = $"b{characterid.ToString("D3")}_{expressionid.ToString("D3")}_{outfitid.ToString("D2")}.bin";
            checkBox_CreateBin.Text = $"Create {newFileName}";
        }
    }
}
