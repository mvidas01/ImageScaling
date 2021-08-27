using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageScalling
{
    public static class ImageInterpolation
    {
        public static Bitmap ResizeImage(Image image, InterpolationMode interpolationMode, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);

            result.SetResolution(width, height);

            DrawImage(image, result, interpolationMode);

            return result;
        }
        public static Bitmap ResizeImage(Image image, InterpolationMode interpolationMode, int scale)
        {
            
            Bitmap result = new Bitmap(image.Width * scale , image.Height * scale);

            result.SetResolution(image.HorizontalResolution * scale, image.VerticalResolution * scale);

            DrawImage(image, result, interpolationMode);

            return result;
        }

        private static void DrawImage(Image image, Bitmap result, InterpolationMode interpolationMode)
        {
            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = interpolationMode;
                graphics.SmoothingMode = SmoothingMode.HighQuality;

                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
            }
        }

    }
}
