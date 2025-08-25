using DarkUI.Controls;
using DarkUI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BustupEditor
{
    public partial class MainForm : DarkForm
    {
        private void DragEnter(object sender, DragEventArgs e)
        {

        }

        private void DragDrop_Txt(object sender, DragEventArgs e)
        {

        }

        private void SelectedBustup_Changed(object sender, EventArgs e)
        {
            UpdateFormCtrlValues();
        }

        private void UpdateFormCtrlValues()
        {
            num_EyeFrame.Value = 0;
            num_MouthFrame.Value = 0;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            if (listBox_Sprites.SelectedIndex == -1 || listBox_Sprites.SelectedIndex == 0)
                return;

            lastSelectedIndex = listBox_Sprites.SelectedIndex;

            if (selectedBustup == null)
                return;

            ToggleControls();

            txt_ImagesPath.Text = bustupProject.ImagesPath;

            num_MajorID.Value = selectedBustup.MajorID;
            num_MinorID.Value = selectedBustup.MinorID;
            num_SubID.Value = selectedBustup.SubID;

            if (bustupProject.Type == BustupType.Navigator)
                num_SubID.Enabled = false;
            else
                num_SubID.Enabled = true;

            num_BasePosX.Value = Convert.ToDecimal(selectedBustup.BasePos_X);
            num_BasePosY.Value = Convert.ToDecimal(selectedBustup.BasePos_Y);
            num_EyePosX.Value = Convert.ToDecimal(selectedBustup.EyePos_X);
            num_EyePosY.Value = Convert.ToDecimal(selectedBustup.EyePos_Y);
            num_MouthPosX.Value = Convert.ToDecimal(selectedBustup.MouthPos_X);
            num_MouthPosY.Value = Convert.ToDecimal(selectedBustup.MouthPos_Y);

            comboBox_Animation.SelectedIndex = comboBox_Animation.Items.IndexOf(
                Enum.GetName(typeof(AnimationType), selectedBustup.AnimType));

            txt_BaseImgBrowse.Text = selectedBustup.BaseImgPath;
            txt_BlinkImg1Browse.Text = selectedBustup.BlinkImg1Path;
            txt_BlinkImg2Browse.Text = selectedBustup.BlinkImg2Path;
            txt_MouthImg1Browse.Text = selectedBustup.MouthImg1Path;
            txt_MouthImg2Browse.Text = selectedBustup.MouthImg2Path;
            txt_MouthImg3Browse.Text = selectedBustup.MouthImg3Path;

            txt_CharaName.Text = selectedBustup.CharaName;
            txt_ExpressionName.Text = selectedBustup.ExpressionName;
            txt_OutfitName.Text = selectedBustup.OutfitName;

            LoadBustupPreview(selectedBustup);

            ToggleControls(true);
        }

        private void ToggleControls(bool enabled = false)
        {
            // Used to avoid getting into an infinite loop when updating
            // the values of the controls when a bustup is selected from the list

            foreach (var str in new string[] { "num_MajorID", "num_MinorID", "num_SubID",
                "num_BasePosX", "num_BasePosY", "num_EyePosX", "num_EyePosY",
                "num_MouthPosX", "num_MouthPosY", "comboBox_Animation", "txt_ImagesPath",
                "num_EyeFrame", "num_MouthFrame", "txt_BaseImgBrowse", "txt_BlinkImg1Browse",
                "txt_BlinkImg2Browse", "txt_MouthImg1Browse", "txt_MouthImg2Browse",
                "txt_MouthImg3Browse", "txt_CharaName", "txt_ExpressionName", "txt_OutfitName" })
            {
                WinForms.GetControl(this, str).Enabled = enabled;
            }
        }

        private void MajorID_Changed(object sender, EventArgs e)
        {
            if (!num_MajorID.Enabled)
                return;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            selectedBustup.MajorID = Convert.ToUInt16(num_MajorID.Value);
        }

        private void MinorID_Changed(object sender, EventArgs e)
        {
            if (!num_MinorID.Enabled)
                return;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            selectedBustup.MinorID = Convert.ToUInt16(num_MinorID.Value);
        }

        private void SubID_Changed(object sender, EventArgs e)
        {
            if (!num_SubID.Enabled)
                return;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            selectedBustup.SubID = Convert.ToUInt16(num_SubID.Value);
        }

        private void BasePosX_Changed(object sender, EventArgs e)
        {
            if (!num_BasePosX.Enabled)
                return;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            selectedBustup.BasePos_X = Convert.ToSingle(num_BasePosX.Value);
            UpdatePictureBox();
        }

        private void BasePosY_Changed(object sender, EventArgs e)
        {
            if (!num_BasePosY.Enabled)
                return;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            selectedBustup.BasePos_Y = Convert.ToSingle(num_BasePosY.Value);

            UpdatePictureBox();
        }

        private void EyePosX_Changed(object sender, EventArgs e)
        {
            if (!num_EyePosX.Enabled)
                return;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            selectedBustup.EyePos_X = Convert.ToSingle(num_EyePosX.Value);

            UpdatePictureBox();
        }

        private void EyePosY_Changed(object sender, EventArgs e)
        {
            if (!num_EyePosY.Enabled)
                return;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            selectedBustup.EyePos_Y = Convert.ToSingle(num_EyePosY.Value);

            UpdatePictureBox();
        }

        private void MouthPosX_Changed(object sender, EventArgs e)
        {
            if (!num_MouthPosX.Enabled)
                return;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            selectedBustup.MouthPos_X = Convert.ToSingle(num_MouthPosX.Value);

            UpdatePictureBox();
        }

        private void MouthPosY_Changed(object sender, EventArgs e)
        {
            if (!num_MouthPosY.Enabled)
                return;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            selectedBustup.MouthPos_Y = Convert.ToSingle(num_MouthPosY.Value);

            UpdatePictureBox();
        }

        private void Animation_Changed(object sender, EventArgs e)
        {
            if (!comboBox_Animation.Enabled)
                return;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            selectedBustup.AnimType = (AnimationType)Enum.Parse(typeof(AnimationType), comboBox_Animation.SelectedItem.ToString());
        }

        private void ImagePath_Changed(object sender, EventArgs e)
        {
            DarkTextBox txtBox = sender as DarkTextBox;

            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            if (!txtBox.Enabled)
                return;

            switch (txtBox.Name)
            {
                case "txt_BaseImgBrowse":
                    selectedBustup.BaseImgPath = txtBox.Text;
                    break;
                case "txt_BlinkImg1Browse":
                    selectedBustup.BlinkImg1Path = txtBox.Text;
                    break;
                case "txt_BlinkImg2Browse":
                    selectedBustup.BlinkImg2Path = txtBox.Text;
                    break;
                case "txt_MouthImg1Browse":
                    selectedBustup.MouthImg1Path = txtBox.Text;
                    break;
                case "txt_MouthImg2Browse":
                    selectedBustup.MouthImg2Path = txtBox.Text;
                    break;
                case "txt_MouthImg3Browse":
                    selectedBustup.MouthImg3Path = txtBox.Text;
                    break;
                case "txt_CharaName":
                    foreach(var bustup in bustupProject.Bustups.Where(x => x.MajorID == selectedBustup.MajorID))
                        bustup.CharaName = txtBox.Text;
                    break;
                case "txt_ExpressionName":
                    selectedBustup.ExpressionName = txtBox.Text;
                    break;
                case "txt_OutfitName":
                    selectedBustup.OutfitName = txtBox.Text;
                    break;
                case "txt_ImagesPath":
                    bustupProject.ImagesPath = txt_ImagesPath.Text;
                    break;
            }
        }

        private void BrowseImagePath_Click(object sender, EventArgs e)
        {
            DarkButton btn = sender as DarkButton;

            switch (btn.Name)
            {
                case "btn_ImagesPath":
                    txt_ImagesPath.Text = WinFormsDialogs.SelectFolder("Choose Extracted Bustup folder...");
                    break;
                case "btn_BaseImgBrowse":
                case "btn_BlinkImg1Browse":
                case "btn_BlinkImg2Browse":
                case "btn_MouthImg1Browse":
                case "btn_MouthImg2Browse":
                case "btn_MouthImg3Browse":
                    var selection = WinFormsDialogs.SelectFile("Select Base Image...", true, new string[] { "DDS (.dds)", "PNG (.png)" });
                    if (selection.Count > 0 && !string.IsNullOrEmpty(selection.First()))
                        WinForms.GetControl(this, btn.Name.Replace("btn", "txt")).Text = selection.First();
                    break;
            }
        }

        private void EyeFrame_Changed(object sender, EventArgs e)
        {
            UpdatePictureBox();
        }

        private Point ScalePoint(double x, double y)
        {
            return new Point((int)Math.Ceiling(x * ((double)bustupProject.Scale / (double)50)), (int)Math.Ceiling(y * ((double)bustupProject.Scale / (double)50)));
        }

        private void MouthFrame_Changed(object sender, EventArgs e)
        {
            UpdatePictureBox();
        }

        private void PreviewScale_Changed(object sender, EventArgs e)
        {
            bustupProject.Scale = Convert.ToInt32(num_Scale.Value);
        }

        private void ApplyImagesToAll_SameExpression_Click(object sender, EventArgs e)
        {
            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            foreach (var bustup in bustupProject.Bustups.Where(x => x.CharaName == selectedBustup.CharaName 
                && x.ExpressionName == selectedBustup.ExpressionName))
            {
                bustup.BaseImgPath = selectedBustup.BaseImgPath;
                bustup.BlinkImg1Path = selectedBustup.BlinkImg1Path;
                bustup.BlinkImg2Path = selectedBustup.BlinkImg2Path;
                bustup.MouthImg1Path = selectedBustup.MouthImg1Path;
                bustup.MouthImg2Path = selectedBustup.MouthImg2Path;
                bustup.MouthImg3Path = selectedBustup.MouthImg3Path;
            }
        }
    }
}
