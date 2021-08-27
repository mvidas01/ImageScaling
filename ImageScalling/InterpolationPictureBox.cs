using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageScalling
{
    //Пикчер бокс без встроенной интерполяции
    public class InterpolationPictureBox : PictureBox
    {
        public InterpolationMode InterpolationMode { get; set; }

        public InterpolationPictureBox()
        {
            InterpolationMode = InterpolationMode.NearestNeighbor;
        }
        protected override void OnPaint(PaintEventArgs eventArgs)
        {
            eventArgs.Graphics.InterpolationMode = InterpolationMode;
            base.OnPaint(eventArgs);
        }

    }
}
