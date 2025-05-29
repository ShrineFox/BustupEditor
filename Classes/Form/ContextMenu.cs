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
            if (listBox_Sprites.SelectedItems.Count > 0 && copiedParams != new Bustup())
            {
                foreach (var selection in listBox_Sprites.SelectedItems)
                {
                    Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem.Copy();
                    Bustup newBustup = copiedParams.Copy();

                    // Preserve bustup names and IDs
                    newBustup.Name = selectedBustup.Name;
                    newBustup.MajorID = selectedBustup.MajorID;
                    newBustup.MinorID = selectedBustup.MinorID;
                    newBustup.SubID = selectedBustup.SubID;

                    int bustupIndex = bustupProject.Bustups.IndexOf(bustupProject.Bustups.First(x => x.Name.Equals(selection.ToString())));
                    if (bustupIndex != -1)
                    {
                        bustupProject.Bustups[bustupIndex] = newBustup;
                    }
                }
                
                UpdateFormCtrlValues();
                UpdateSpriteList();
            }
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
