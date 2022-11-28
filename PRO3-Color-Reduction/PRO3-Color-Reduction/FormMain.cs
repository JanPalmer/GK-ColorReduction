using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO3_Color_Reduction
{
    public partial class MainForm : Form
    {
        private Bitmap bitmapMain, bitmapErrorDiffusion, bitmapPopularity, bitmapKMeans;
        private Bitmap bitmapMainResized, bitmapErrorDiffusionResized, bitmapPopularityResized, bitmapKMeansResized;
        public int k;

        public MainForm()
        {
            InitializeComponent();

            k = trackBar_KValue.Value;
            buttonSetK.Text = $"Cluster Image to {k} Colors";
        }



        private void DisplayEnlargedPicture(Bitmap toDisplay)
        {
            if (toDisplay == null) return;
            EnlargedPicture form = new EnlargedPicture();
            form.SetPicture(toDisplay);
            form.ShowDialog();
        }

        private void trackBarKMeans_ValueChanged(object sender, EventArgs e)
        {
            labelEpsilonValue.Text = $"Epsilon Value = {trackBarKMeans.Value}";
        }

        private void pictureBox_Main_Click(object sender, EventArgs e)
        {
            DisplayEnlargedPicture(bitmapMain);
        }
        private void pictureBox_PopularityAlgorithm_Click(object sender, EventArgs e)
        {
            DisplayEnlargedPicture(bitmapPopularity);
        }
        private void pictureBox_K_MeansReduction_Click(object sender, EventArgs e)
        {
            DisplayEnlargedPicture(bitmapKMeans);
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmapMain = new Bitmap(fileDialog.FileName);
                bitmapMainResized = new Bitmap(bitmapMain, pictureBox_Main.Size);
                pictureBox_Main.Image = bitmapMainResized;
                pictureBox_Main.Invalidate();
            }
        }

        private void trackBar_KValue_ValueChanged(object sender, EventArgs e)
        {
            k = trackBar_KValue.Value;
            buttonSetK.Text = $"Cluster Image to {k} Colors";
        }

        private void buttonSetK_Click(object sender, EventArgs e)
        {
            if (bitmapMain == null) return;

            progressBarKMeans.Value = 0;
            progressBarPopularity.Value = 0;

            bitmapPopularity = ColorReduction.PopularityQuantization(bitmapMain, k, progressBarPopularity);
            bitmapPopularityResized = new Bitmap(bitmapPopularity, pictureBox_PopularityAlgorithm.Size);
            pictureBox_PopularityAlgorithm.Image = bitmapPopularityResized;

            bitmapKMeans = ColorReduction.KMeansQuantization(bitmapMain, k, trackBarKMeans.Value, progressBarKMeans);
            bitmapKMeansResized = new Bitmap(bitmapKMeans, pictureBox_K_MeansReduction.Size);
            pictureBox_K_MeansReduction.Image = bitmapKMeansResized;
        }
    }
}
