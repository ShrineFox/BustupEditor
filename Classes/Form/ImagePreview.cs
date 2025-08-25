using BCnEncoder.Shared.ImageFiles;
using DarkUI.Forms;
using GFDLibrary.Textures;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BustupEditor
{
    public partial class MainForm : DarkForm
    {
        private void UpdatePictureBox()
        {
            if (!num_BasePosX.Enabled || listBox_Sprites.SelectedItem == null)
                return;
            Bustup selectedBustup = (Bustup)listBox_Sprites.SelectedItem;

            Point dimensions = GetPictureBoxSize(selectedBustup);
            Bitmap bmp = new Bitmap(dimensions.X, dimensions.Y);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.CompositingMode = CompositingMode.SourceOver;

            Point location = new Point();

            // Draw bustup base
            gfx.DrawImage(GetExtractedImg(selectedBustup), new Point(0, 0));

            // Overlay eyes
            location = ScalePoint(Convert.ToDouble(num_EyePosX.Value), Convert.ToDouble(num_EyePosY.Value));
            gfx.DrawImage(GetExtractedImg(selectedBustup, isEyes:true), location);

            // Overlay mouth
            location = ScalePoint(Convert.ToDouble(num_MouthPosX.Value), Convert.ToDouble(num_MouthPosY.Value));
            gfx.DrawImage(GetExtractedImg(selectedBustup, isMouth: true), location);

            // Draw template overlay
            string overlayPng = "./Dependencies/event_overlay.png";
            location = ScalePoint(Convert.ToDouble(num_BasePosX.Value), Convert.ToDouble(num_BasePosY.Value));
            if (File.Exists(overlayPng))
                gfx.DrawImage(new Bitmap(overlayPng), location);

            pictureBox_Tex.BackgroundImage = bmp;
        }

        private Point GetPictureBoxSize(Bustup selectedBustup)
        {
            if (bustupProject.Type == BustupType.Portrait)
                return new Point(1536, 1536);
            else
                return new Point(1536, 1536); // TODO: set to navi dimensions
        }

        private Image GetExtractedBaseImg(Bustup selectedBustup)
        {
            string ddsDir = $"B{selectedBustup.MajorID.ToString("000")}_{selectedBustup.MinorID.ToString("000")}";

            if (bustupProject.Type == BustupType.Portrait)
                ddsDir += $"_{selectedBustup.SubID.ToString("00")}";

            ddsDir = Path.Combine(txt_ImagesPath.Text, ddsDir);
            if (Directory.Exists(ddsDir))
            {
                var ddsFiles = Directory.GetFiles(ddsDir, "*.DDS", SearchOption.TopDirectoryOnly);

                if (ddsFiles.Length > 0)
                {
                    string dds = ddsFiles[0];
                    return ScaleBitmap(ConvertDDSToBitmap(File.ReadAllBytes(dds)));
                }
            }

            return new Bitmap(1, 1);
        }

        private Bitmap GetExtractedImg(Bustup selectedBustup, bool isMouth = false, bool isEyes = false)
        {
            int offset = 0;
            int frame = 0;
            string imgPath = "";
            bool useExtractedImage = false;

            if (isMouth)
            {
                offset = 3;
                frame = Convert.ToInt32(num_MouthFrame.Value);
                // Set Mouth Img Path
                if (frame == 1 && File.Exists(selectedBustup.MouthImg1Path))
                    imgPath = selectedBustup.MouthImg1Path;
                else if (frame == 2 && File.Exists(selectedBustup.MouthImg2Path))
                    imgPath = selectedBustup.MouthImg2Path;
                else if (frame == 3 && File.Exists(selectedBustup.MouthImg3Path))
                    imgPath = selectedBustup.MouthImg3Path;
                else
                    useExtractedImage = true;
            }
            else if (isEyes)
            {
                offset = 1;
                frame = Convert.ToInt32(num_EyeFrame.Value);
                // Set Eyes Img Path
                if (frame == 1 && File.Exists(selectedBustup.BlinkImg1Path))
                    imgPath = selectedBustup.BlinkImg1Path;
                else if (frame == 2 && File.Exists(selectedBustup.BlinkImg2Path))
                    imgPath = selectedBustup.BlinkImg2Path;
                else
                    useExtractedImage = true;
            }
            else
            {
                // Set Base Img Path
                if (File.Exists(selectedBustup.BaseImgPath))
                {
                    imgPath = selectedBustup.BaseImgPath;
                }
                else
                    useExtractedImage = true;
            }

            if (useExtractedImage)
            {
                // Get the path to the bustup's folder in the extracted bustup dir
                string extractedDirName = $"B{selectedBustup.MajorID.ToString("000")}_{selectedBustup.MinorID.ToString("000")}";
                if (bustupProject.Type == BustupType.Portrait)
                    extractedDirName += $"_{selectedBustup.SubID.ToString("00")}";
                string extractedDir = Path.Combine(txt_ImagesPath.Text, extractedDirName);
                // Use original dds extracted from bustup BIN if no replacement specified
                if (Directory.Exists(extractedDir))
                {
                    var ddsFiles = Directory.GetFiles(extractedDir, "*.DDS", SearchOption.TopDirectoryOnly);

                    if (ddsFiles.Length >= offset + frame + 1)
                    {
                        imgPath = ddsFiles[offset + frame];
                    }
                }
            }

            // Return blank image if path is invalid
            if (!File.Exists(imgPath))
                return new Bitmap(1,1);

            // Return a bitmap scaled to the user's desired scale percentages
            return ScaleBitmap(ConvertDDSToBitmap(File.ReadAllBytes(imgPath)));
        }

        private void LoadBustupPreview(Bustup bustup)
        {
            string ddsPath = $"B{bustup.MajorID.ToString("000")}_{bustup.MinorID.ToString("000")}";
            if (bustupProject.Type == BustupType.Portrait)
                ddsPath += $"_{bustup.SubID.ToString("00")}";

            ddsPath = Path.Combine(txt_ImagesPath.Text, ddsPath);

            if (File.Exists(bustup.BaseImgPath))
            {
                string extension = Path.GetExtension(bustup.BaseImgPath).ToLowerInvariant();
                Bitmap bmp = null;

                switch (extension)
                {
                    case ".dds":
                        bmp = ScaleBitmap(ConvertDDSToBitmap(File.ReadAllBytes(bustup.BaseImgPath)));
                        break;
                    case ".png":
                        bmp = ScaleBitmap(new Bitmap(bustup.BaseImgPath));
                        break;
                }

                pictureBox_Tex.Image = bmp;
                return;
            }
            else if (Directory.Exists(ddsPath))
            {
                var ddsFiles = Directory.GetFiles(ddsPath, "*.DDS", SearchOption.TopDirectoryOnly);
                if (ddsFiles.Length > 0)
                {
                    Bitmap bmp = ScaleBitmap(ConvertDDSToBitmap(File.ReadAllBytes(ddsFiles[0])));
                    pictureBox_Tex.Image = bmp;
                    return;
                }
            }

            pictureBox_Tex.Image = null;
        }

        private Bitmap ScaleBitmap(Bitmap bmp)
        {
            return new Bitmap(bmp, new Size((int)Math.Ceiling((double)bmp.Width * ((double)bustupProject.Scale / (double)100)), (int)Math.Ceiling(((double)bmp.Height * ((double)bustupProject.Scale / (double)100)))));
        }

        private Bitmap ConvertDDSToBitmap(byte[] ddsBytes)
        {
            var texture = new Texture() { Data = ddsBytes, Format = TextureFormat.DDS };
            return TextureDecoder.Decode(texture);
        }
    }
}
