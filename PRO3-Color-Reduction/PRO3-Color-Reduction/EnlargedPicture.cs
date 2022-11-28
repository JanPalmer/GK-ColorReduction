using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRO3_Color_Reduction
{
    public partial class EnlargedPicture : Form
    {
        private Bitmap approximateImage;

        public EnlargedPicture()
        {
            InitializeComponent();
        }

        private void SetPictureBox()
        {
            var pcbxSize = pictureBox_Enlarge.Size;
            pictureBox_Enlarge.SizeMode = approximateImage.Width > pcbxSize.Width || approximateImage.Height > pcbxSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        public void SetPicture(Bitmap bitmap)
        {
            approximateImage = bitmap;
            pictureBox_Enlarge.Image = approximateImage;
            SetPictureBox();
        }

        private void EnlargedPicture_Resize(object sender, EventArgs e)
        {
            SetPictureBox();
        }
    }
}
