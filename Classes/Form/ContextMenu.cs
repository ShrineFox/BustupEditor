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
        private void Rename_Click(object sender, EventArgs e)
        {
            if (listBox_Sprites.SelectedIndex != -1 && bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
            {
                RenameForm renameForm = new RenameForm(listBox_Sprites.SelectedItem.ToString());
                var result = renameForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string newName = renameForm.RenameText;
                    if (string.IsNullOrEmpty(newName))
                    {
                        MessageBox.Show("The name you provided is either null or empty.",
                            "Error: Invalid name");
                        return;
                    }

                    if (bustupProject.Bustups.Any(x => x.Name.Equals(renameForm.RenameText)))
                    {
                        MessageBox.Show("There is already an item with the same name! Please choose a different one.",
                            "Error: Duplicate entry name");
                        return;
                    }
                    else
                    {
                        bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).Name = renameForm.RenameText;
                    }
                }
                else
                    return;

                UpdateSpriteList();
            }
        }
        private void OpenImageFolder_Click(object sender, EventArgs e)
        {
            Bustup selectedBustup = null;
            if (bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                selectedBustup = bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString()));
            else
                return;

            string ddsPath = $"B{selectedBustup.MajorID.ToString("000")}_{selectedBustup.MinorID.ToString("000")}";

            if (bustupProject.Type == BustupType.Portrait)
                ddsPath += $"_{selectedBustup.SubID.ToString("00")}";

            ddsPath = Path.Combine(txt_ImagesPath.Text, ddsPath);
            if (Directory.Exists(ddsPath))
                Exe.Run("explorer.exe", ddsPath);
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                copiedParams = bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).Copy();
            else
                return;
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            if (listBox_Sprites.SelectedItems.Count > 0 && copiedParams != new Bustup())
            {
                foreach (var selection in listBox_Sprites.SelectedItems)
                {
                    if (bustupProject.Bustups.Any(x => x.Name.Equals(selection.ToString())))
                    {
                        Bustup selectedBustup = bustupProject.Bustups.First(x => x.Name.Equals(selection.ToString())).Copy();
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
                }
                UpdateFormCtrlValues();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            bustupProject.Bustups.Add(new Bustup());
            UpdateSpriteList();
            listBox_Sprites.SelectedIndex = listBox_Sprites.Items.Count - 1;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listBox_Sprites.SelectedItems.Count > 0)
            {
                int selectedIndex = listBox_Sprites.SelectedIndex;

                // Remove all highlighted bustup entries
                foreach (var selection in listBox_Sprites.SelectedItems)
                    if (bustupProject.Bustups.Any(x => x.Name.Equals(selection.ToString())))
                        bustupProject.Bustups.Remove(bustupProject.Bustups.First(x => x.Name.Equals(selection.ToString())));

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
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
                Rename_Click(sender, e);
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                Copy_Click(sender, e);
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
                Paste_Click(sender, e);
        }
    }
}
