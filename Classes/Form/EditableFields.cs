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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BustupEditor
{
    public partial class MainForm : DarkForm
    {
        private void UpdateSpriteList()
        {
            listBox_Sprites.Items.Clear();
            foreach (var bustup in bustupProject.Bustups)
                listBox_Sprites.Items.Add(bustup.Name);
        }

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

            Bustup selectedBustup = null;

            if (bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                selectedBustup = bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString()));
            else
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

            LoadBustupPreview(selectedBustup.MajorID, selectedBustup.MinorID, selectedBustup.SubID);

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
                "txt_MouthImg3Browse" })
            {
                WinForms.GetControl(this, str).Enabled = enabled;
            }
        }

        private void MajorID_Changed(object sender, EventArgs e)
        {
            if (!num_MajorID.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MajorID = Convert.ToUInt16(num_MajorID.Value);
        }

        private void MinorID_Changed(object sender, EventArgs e)
        {
            if (!num_MinorID.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MinorID = Convert.ToUInt16(num_MinorID.Value);
        }

        private void SubID_Changed(object sender, EventArgs e)
        {
            if (!num_SubID.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).SubID = Convert.ToUInt16(num_SubID.Value);
        }

        private void BasePosX_Changed(object sender, EventArgs e)
        {
            if (!num_BasePosX.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).BasePos_X = Convert.ToSingle(num_BasePosX.Value);
        }

        private void BasePosY_Changed(object sender, EventArgs e)
        {
            if (!num_BasePosY.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).BasePos_Y = Convert.ToSingle(num_BasePosY.Value);
        }

        private void EyePosX_Changed(object sender, EventArgs e)
        {
            if (!num_EyePosX.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).EyePos_X = Convert.ToSingle(num_EyePosX.Value);

            pictureBox_Eyes.Location = ScalePoint(Convert.ToDouble(num_EyePosX.Value), Convert.ToDouble(num_EyePosY.Value));
        }

        private void EyePosY_Changed(object sender, EventArgs e)
        {
            if (!num_EyePosY.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).EyePos_Y = Convert.ToSingle(num_EyePosY.Value);

            pictureBox_Eyes.Location = ScalePoint(Convert.ToDouble(num_EyePosX.Value), Convert.ToDouble(num_EyePosY.Value));
        }

        private void MouthPosX_Changed(object sender, EventArgs e)
        {
            if (!num_MouthPosX.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MouthPos_X = Convert.ToSingle(num_MouthPosX.Value);

            pictureBox_Mouth.Location = ScalePoint(Convert.ToDouble(num_MouthPosX.Value), Convert.ToDouble(num_MouthPosY.Value));
        }

        private void MouthPosY_Changed(object sender, EventArgs e)
        {
            if (!num_MouthPosY.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;
            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MouthPos_Y = Convert.ToSingle(num_MouthPosY.Value);

            pictureBox_Mouth.Location = ScalePoint(Convert.ToDouble(num_MouthPosX.Value), Convert.ToDouble(num_MouthPosY.Value));
        }

        private void Animation_Changed(object sender, EventArgs e)
        {
            if (!comboBox_Animation.Enabled)
                return;
            if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                return;

            bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).AnimType = (AnimationType)Enum.Parse(typeof(AnimationType), comboBox_Animation.SelectedItem.ToString());
        }

        private void ImagePath_Changed(object sender, EventArgs e)
        {
            DarkTextBox txtBox = sender as DarkTextBox;

            if (!txtBox.Enabled)
                return;

            switch (txtBox.Name)
            {
                case "txt_BaseImgBrowse":
                    if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                        return;
                    bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).BaseImgPath = txtBox.Text;
                    break;
                case "txt_BlinkImg1Browse":
                    if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                        return;
                    bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).BlinkImg1Path = txtBox.Text;
                    break;
                case "txt_BlinkImg2Browse":
                    if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                        return;
                    bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).BlinkImg2Path = txtBox.Text;
                    break;
                case "txt_MouthImg1Browse":
                    if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                        return;
                    bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MouthImg1Path = txtBox.Text;
                    break;
                case "txt_MouthImg2Browse":
                    if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                        return;
                    bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MouthImg2Path = txtBox.Text;
                    break;
                case "txt_MouthImg3Browse":
                    if (!bustupProject.Bustups.Any(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())))
                        return;
                    bustupProject.Bustups.First(x => x.Name.Equals(listBox_Sprites.SelectedItem.ToString())).MouthImg3Path = txtBox.Text;
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
            int eyeFrame = Convert.ToInt32(num_EyeFrame.Value);
            if (eyeFrame == 0)
            {
                pictureBox_Eyes.Visible = false;
                return;
            }

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
            {
                var ddsFiles = Directory.GetFiles(ddsPath, "*.DDS", SearchOption.TopDirectoryOnly);

                if (ddsFiles.Length >= eyeFrame + 1)
                {
                    string dds = ddsFiles[eyeFrame];
                    Bitmap ddsBitmap = ScaleBitmap(DDS.Decode(File.ReadAllBytes(dds)));
                    pictureBox_Eyes.Image = ddsBitmap;
                    pictureBox_Eyes.Size = ddsBitmap.Size;
                    pictureBox_Eyes.Location = ScalePoint(Convert.ToDouble(selectedBustup.EyePos_X), Convert.ToDouble(selectedBustup.EyePos_Y));
                    pictureBox_Eyes.Visible = true;
                    return;
                }
            }

            pictureBox_Eyes.Visible = false;
        }

        private Point ScalePoint(double x, double y)
        {
            return new Point((int)Math.Ceiling(x * ((double)bustupProject.Scale / (double)50)), (int)Math.Ceiling(y * ((double)bustupProject.Scale / (double)50)));
        }

        private void MouthFrame_Changed(object sender, EventArgs e)
        {
            int mouthFrame = Convert.ToInt32(num_MouthFrame.Value);
            if (mouthFrame == 0)
            {
                pictureBox_Mouth.Visible = false;
                return;
            }
            mouthFrame = mouthFrame + 2;

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
            {
                var ddsFiles = Directory.GetFiles(ddsPath, "*.DDS", SearchOption.TopDirectoryOnly);

                if (ddsFiles.Length >= mouthFrame + 1)
                {
                    string dds = ddsFiles[mouthFrame];
                    Bitmap ddsBitmap = ScaleBitmap(DDS.Decode(File.ReadAllBytes(dds)));
                    pictureBox_Mouth.Image = ddsBitmap;
                    pictureBox_Mouth.Size = ddsBitmap.Size;
                    pictureBox_Mouth.Location = ScalePoint(Convert.ToDouble(selectedBustup.MouthPos_X), Convert.ToDouble(selectedBustup.MouthPos_Y));
                    pictureBox_Mouth.Visible = true;
                    return;
                }
            }

            pictureBox_Mouth.Visible = false;
        }

        private void PreviewScale_Changed(object sender, EventArgs e)
        {
            bustupProject.Scale = Convert.ToInt32(num_Scale.Value);
        }
    }
}
