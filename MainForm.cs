using DarkUI.Controls;
using DarkUI.Forms;
using GFDLibrary.Textures;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BustupEditor
{
    public partial class MainForm : DarkForm
    {
        public MainForm()
        {
            InitializeComponent();
            SetMenuStripIcons();
            SetOverlayImages();
            SetupSpriteList();
        }

        public static BindingSource bindingSource_ListBox = new BindingSource();
        public static int lastSelectedIndex = -1;

        private void SetupSpriteList()
        {
            bindingSource_ListBox.DataSource = bustupProject.Bustups;

            listBox_Sprites.DataSource = bindingSource_ListBox;
            listBox_Sprites.DisplayMember = "Name";
            listBox_Sprites.FormattingEnabled = true;
            listBox_Sprites.Format += ListBoxFormat;
        }

        private void ListBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            Bustup bustup = (Bustup)e.ListItem;
            e.Value = $"{bustup.MajorID.ToString("000")}_{bustup.MinorID.ToString("000")}_{bustup.SubID.ToString("00")} | {bustup.CharaName} {bustup.ExpressionName} ({bustup.OutfitName})";
        }

        public Bustup copiedParams = new Bustup(); // holds parameters for the last copied bustup

        private void SetMenuStripIcons()
        {
            MenuStripHelper.SetMenuStripIcons(MenuStripHelper.GetMenuStripIconPairs("./Dependencies/Icons.txt"), this);
        }

        private void UpdateSpriteList()
        {
            bindingSource_ListBox.DataSource = null;
            bindingSource_ListBox.DataSource = bustupProject.Bustups;
            bindingSource_ListBox.ResetBindings(false);

            if (lastSelectedIndex != -1 && lastSelectedIndex < bustupProject.Bustups.Count)
                listBox_Sprites.SelectedIndex = lastSelectedIndex;
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            string searchTxt = txt_Search.Text.ToLower();
            if (string.IsNullOrEmpty(searchTxt))
                return;
            if (e.KeyData == Keys.Enter)
            {
                // stop windows ding noise
                e.Handled = true;
                e.SuppressKeyPress = true;

                int i = listBox_Sprites.SelectedIndex + 1;
                while (i < listBox_Sprites.Items.Count)
                {
                    if (i == listBox_Sprites.SelectedIndex)
                        return;

                    var bup = (Bustup)listBox_Sprites.Items[i];

                    if (bup.CharaName.ToLower().Contains(searchTxt.ToLower()) ||
                        bup.ExpressionName.ToLower().Contains(searchTxt.ToLower()) ||
                        bup.OutfitName.ToLower().Contains(searchTxt.ToLower()) ||
                        bup.Name.ToLower().Contains(searchTxt.ToLower())
                        )
                    {
                        listBox_Sprites.SelectedIndex = i;
                        return;
                    }

                    if (i == listBox_Sprites.Items.Count - 1)
                        i = 0;
                    else
                        i++;
                }
            }
        }
    }
}
