using DarkUI.Forms;
using GFDLibrary.Textures;
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
        public PictureBox pictureBox_Eyes = new PictureBox() { Visible = false, SizeMode = PictureBoxSizeMode.Normal };
        public PictureBox pictureBox_Mouth = new PictureBox() { Visible = false, SizeMode = PictureBoxSizeMode.Normal };

        private void SetOverlayImages()
        {
            pictureBox_Eyes.Parent = pictureBox_Tex;
            pictureBox_Mouth.Parent = pictureBox_Tex;
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
