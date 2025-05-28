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
        public PictureBox pictureBox_Eyes = new PictureBox() { Visible = false, SizeMode = PictureBoxSizeMode.Normal };
        public PictureBox pictureBox_Mouth = new PictureBox() { Visible = false, SizeMode = PictureBoxSizeMode.Normal };

        private void SetOverlayImages()
        {
            pictureBox_Eyes.Parent = pictureBox_Tex;
            pictureBox_Mouth.Parent = pictureBox_Tex;
        }

        private void LoadBustupPreview(ushort majorID, ushort minorID, ushort subID)
        {
            string ddsPath = $"B{majorID.ToString("000")}_{minorID.ToString("000")}";
            if (bustupProject.Type == BustupType.Portrait)
                ddsPath += $"_{subID.ToString("00")}";

            ddsPath = Path.Combine(txt_ImagesPath.Text, ddsPath);
            if (Directory.Exists(ddsPath))
            {
                var ddsFiles = Directory.GetFiles(ddsPath, "*.DDS", SearchOption.TopDirectoryOnly);
                if (ddsFiles.Length > 0)
                {
                    Bitmap ddsBitmap = ScaleBitmap(DDS.Decode(File.ReadAllBytes(ddsFiles[0])));
                    pictureBox_Tex.Image = ddsBitmap;
                    return;
                }
            }

            pictureBox_Tex.Image = null;
        }

        private Bitmap ScaleBitmap(Bitmap bmp)
        {
            return new Bitmap(bmp, new Size((int)Math.Ceiling((double)bmp.Width * ((double)bustupProject.Scale / (double)100)), (int)Math.Ceiling(((double)bmp.Height * ((double)bustupProject.Scale / (double)100)))));
        }
    }
}
