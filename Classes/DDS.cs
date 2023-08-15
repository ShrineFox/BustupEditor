using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CSharpImageLibrary;

// code from https://github.com/tge-was-taken/GFD-Studio
namespace BustupEditor
{
    public class DDS
    {
        public static Bitmap Decode(byte[] data)
        {
            try
            {
                // Prefer DDSCodec -- handles alpha properly but doesn't handle non pow 2 textures & DX10+ formats
                return DDSCodec.DecompressImage(data);
            }
            catch (Exception)
            {
            }

            try
            {
                // Image engine SUCKS at alpha handling, but its better than nothing
                return DecodeDDSWithImageEngine(data);
            }
            catch (Exception)
            {
            }

            // RIP
            Trace.WriteLine("Failed to decode DDS texture");
            return new Bitmap(32, 32, PixelFormat.Format32bppArgb);
        }

        private static Bitmap DecodeDDSWithImageEngine(byte[] data)
        {
            var ddsImage = new ImageEngineImage(data);
            return ImageEngineImageToBitmap(ddsImage);
        }

        private static Bitmap ImageEngineImageToBitmap(ImageEngineImage image)
        {
            // save the image to bmp
            var bitmapStream = new MemoryStream();

            try
            {
                image.Save(bitmapStream, new ImageFormats.ImageEngineFormatDetails(ImageEngineFormat.PNG), MipHandling.KeepTopOnly, 0, 0, false);
            }
            catch (NullReferenceException /* good library */ )
            {
                image.Save(bitmapStream, new ImageFormats.ImageEngineFormatDetails(ImageEngineFormat.PNG), MipHandling.KeepTopOnly);
            }

            // load the saved bmp into a new bitmap
            return new Bitmap(bitmapStream);
        }
    }
}
