using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageScalling
{
    public partial class PictureForm : Form
    {
        private Image originalImage;

        public PictureForm(Image image, string title)
        {
            InitializeComponent();

            this.Text = title;
            originalImage = image;
            pictureBox.Image = originalImage;
        }
       

       
    }
    
}
