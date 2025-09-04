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

        private void OpenImageFolder_Click(object sender, EventArgs e)
        {
            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            string ddsPath = $"B{selectedBustup.MajorID.ToString("000")}_{selectedBustup.MinorID.ToString("000")}";

            if (bustupProject.Type == BustupType.Portrait)
                ddsPath += $"_{selectedBustup.SubID.ToString("00")}";

            ddsPath = Path.Combine(txt_ImagesPath.Text, ddsPath);
            if (Directory.Exists(ddsPath))
                Exe.Run("explorer.exe", ddsPath);
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem.Copy();
            copiedParams = selectedBustup.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            HandlePaste();
        }

        private void HandlePaste(bool withImages = false)
        {
            if (listBox_Sprites.SelectedItems.Count > 0 && copiedParams != null)
            {
                Bustup tempBustup = copiedParams.Copy();

                foreach (var selection in listBox_Sprites.SelectedItems)
                {
                    Bustup selectedBustup = (Bustup)selection;

                    // Update animation parameters
                    selectedBustup.AnimType = tempBustup.AnimType;
                    selectedBustup.BasePos_X = tempBustup.BasePos_X;
                    selectedBustup.BasePos_Y = tempBustup.BasePos_Y;
                    selectedBustup.EyePos_X = tempBustup.EyePos_X;
                    selectedBustup.EyePos_Y = tempBustup.EyePos_Y;
                    selectedBustup.MouthPos_X = tempBustup.MouthPos_X;
                    selectedBustup.MouthPos_Y = tempBustup.MouthPos_Y;

                    if (withImages)
                    {
                        selectedBustup.BaseImgPath = tempBustup.BaseImgPath;
                        selectedBustup.BlinkImg1Path = tempBustup.BlinkImg1Path;
                        selectedBustup.BlinkImg2Path = tempBustup.BlinkImg2Path;
                        selectedBustup.MouthImg1Path = tempBustup.MouthImg1Path;
                        selectedBustup.MouthImg2Path = tempBustup.MouthImg2Path;
                        selectedBustup.MouthImg3Path = tempBustup.MouthImg3Path;
                    }
                }

                UpdateFormCtrlValues();
                UpdateSpriteList();
            }
        }

        private void PasteWithImages_Click(object sender, EventArgs e)
        {
            HandlePaste(true);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            bustupProject.Bustups.Add(new Bustup());
            bindingSource_ListBox.ResetBindings(false);
            listBox_Sprites.SelectedIndex = listBox_Sprites.Items.Count - 1;

            UpdateSpriteList();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listBox_Sprites.SelectedItems.Count > 0)
            {
                int selectedIndex = listBox_Sprites.SelectedIndex;

                // Remove all highlighted bustup entries
                foreach (var selection in listBox_Sprites.SelectedItems)
                {
                    Bustup selectedBustup = (Bustup)selection;
                    bustupProject.Bustups.Remove(selectedBustup);
                }

                UpdateSpriteList();

                // Restore previous selection
                if (listBox_Sprites.Items.Count - 1 >= selectedIndex)
                    listBox_Sprites.SelectedIndex = selectedIndex;
            }
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                Remove_Click(sender, e);
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                Copy_Click(sender, e);
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
                Paste_Click(sender, e);
        }
    }
}
