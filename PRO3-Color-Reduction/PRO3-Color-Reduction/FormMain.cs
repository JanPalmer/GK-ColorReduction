using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private ColorReduction.ErrorDiffusionMatrix selectedFilter = ColorReduction.ErrorDiffusionMatrix.FloydSteinberg;

        public int k;
        private bool useErrorDiffusion, usePopularity, useKMeansReduction;
        private bool useK3Colors;

        private SaveContextMenu saveContextMenuErrorDiffusion, saveContextMenuPopularity, saveContextMenuKMeans;

        public MainForm()
        {
            InitializeComponent();

            k = trackBar_KValue.Value;
            buttonSetK.Text = $"Cluster Image to {k} Colors";
            labelEpsilonValue.Text = $"Epsilon Value = {trackBarKMeans.Value}";
            useErrorDiffusion = checkBoxErrorDiffusion.Checked;
            usePopularity = checkBoxPopularityAlgorithm.Checked;
            useKMeansReduction = checkBoxKMeansReduction.Checked;
            useK3Colors = checkBoxErrorDiffusionK3Colors.Checked;

            pictureBox_Main.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_ErrorDiffusion.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_PopularityAlgorithm.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_K_MeansReduction.BackgroundImageLayout = ImageLayout.Zoom;
            InitializeTooltip();
            LoadExampleImages();
        }

        private void InitializeTooltip()
        {
            string toolTipText = "Unchecked - Color reduction will use exactly 'k' colors, evenly distributed from values 0x000000 (black) through 0xFFFFFF (white)\n" +
                "Checked - Color reduction will use 'k*k*k' colors, meaning that each color component (red, green, blue) will have k possible values";
            toolTipK3Colors.SetToolTip(checkBoxErrorDiffusionK3Colors, toolTipText);
            toolTipText = "LMB - See the rendered picture in its original scale\n" +
                "RMB - Open context menu for saving the rendered image (might require two clicks)";
            toolTipK3Colors.SetToolTip(pictureBox_ErrorDiffusion, toolTipText);
            toolTipK3Colors.SetToolTip(pictureBox_PopularityAlgorithm, toolTipText);
            toolTipK3Colors.SetToolTip(pictureBox_K_MeansReduction, toolTipText);
            toolTipText = "LMB - See the rendered picture in its original scale";
            toolTipK3Colors.SetToolTip(pictureBox_Main, toolTipText);
            toolTipK3Colors.AutoPopDelay = 32000;
            toolTipK3Colors.InitialDelay = 400;
        }

        private void LoadExampleImages()
        {
            string path1 = "..\\..\\..\\Images\\img1.jpg";
            string path2 = "..\\..\\..\\Images\\img2.jpg";
            string path3 = "..\\..\\..\\Images\\img3.jpg";
            string path4 = "..\\..\\..\\Images\\img4.jpg";
            string path5 = "..\\..\\..\\Images\\img5.jpg";
            string path6 = "..\\..\\..\\Images\\img6.jpg";
            string path7 = "..\\..\\..\\Images\\img7.jpg";
            string path8 = "..\\..\\..\\Images\\img8.jpg";
            string path9 = "..\\..\\..\\Images\\img9.jpg";
            DisplayImageInGallery(new Bitmap(path1));
            DisplayImageInGallery(new Bitmap(path2));
            DisplayImageInGallery(new Bitmap(path3));
            DisplayImageInGallery(new Bitmap(path4));
            DisplayImageInGallery(new Bitmap(path5));
            DisplayImageInGallery(new Bitmap(path6));
            DisplayImageInGallery(new Bitmap(path7));
            DisplayImageInGallery(new Bitmap(path8));
            DisplayImageInGallery(new Bitmap(path9));
        }

        private void DisplayImageInGallery(Bitmap bitmap)
        {
            Button newButton = new Button();
            newButton.Height = 70;
            newButton.Width = 120;
            newButton.MouseDown += ImageGalleryButton_MouseDown;
            newButton.BackgroundImage = bitmap;
            newButton.BackgroundImageLayout = ImageLayout.Zoom;
            imageGallery.Controls.Add(newButton);
        }

        private void ImageGalleryButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender.GetType() != typeof(Button)) return;

            Button button = (Button)sender;
            bitmapMain = (Bitmap)button.BackgroundImage;
            pictureBox_Main.BackgroundImage = bitmapMain;
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

        // Error Diffusion Method Matrix Choice - radio buttons
        private void radioButtonFloydSteinberg_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFloydSteinberg.Checked == true)
                selectedFilter = ColorReduction.ErrorDiffusionMatrix.FloydSteinberg;
        }
        private void radioButtonBurkes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBurkes.Checked == true)
                selectedFilter = ColorReduction.ErrorDiffusionMatrix.Burkes;
        }
        private void radioButtonStucky_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStucky.Checked == true)
                selectedFilter = ColorReduction.ErrorDiffusionMatrix.Stucky;
        }


        // CheckBoxes
        private void checkBoxPopularityAlgorithm_Click(object sender, EventArgs e)
        {
            usePopularity = checkBoxPopularityAlgorithm.Checked;
        }
        private void checkBoxKMeansReduction_Click(object sender, EventArgs e)
        {
            useKMeansReduction = checkBoxKMeansReduction.Checked;
        }

        private void checkBoxErrorDiffusionK3Colors_Click(object sender, EventArgs e)
        {
            useK3Colors = checkBoxErrorDiffusionK3Colors.Checked;
        }

        private void checkBoxErrorDiffusion_Click(object sender, EventArgs e)
        {
            useErrorDiffusion = checkBoxErrorDiffusion.Checked;
        }

        // Clicking PictureBoxes


        private void pictureBox_Main_MouseDown(object sender, MouseEventArgs e)
        {
            DisplayEnlargedPicture(bitmapMain);
        }
        private void pictureBox_ErrorDiffusion_MouseDown(object sender, MouseEventArgs e)
        {
            if (bitmapErrorDiffusion == null) return;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    DisplayEnlargedPicture(bitmapErrorDiffusion);
                    break;
            }
        }
        private void pictureBox_PopularityAlgorithm_MouseDown(object sender, MouseEventArgs e)
        {
            if (bitmapPopularity == null) return;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    DisplayEnlargedPicture(bitmapPopularity);
                    break;
            }
        }
        private void pictureBox_K_MeansReduction_MouseDown(object sender, MouseEventArgs e)
        {
            if (bitmapKMeans == null) return;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    DisplayEnlargedPicture(bitmapKMeans);
                    break;
            }
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmapMain = new Bitmap(fileDialog.FileName);
                pictureBox_Main.BackgroundImage = bitmapMain;
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
            progressBarErrorDiffusion.Value = 0;

            if (useErrorDiffusion)
            {
                bitmapErrorDiffusion = ColorReduction.ErrorDiffusionQuantization(bitmapMain, k, selectedFilter, useK3Colors, progressBarErrorDiffusion);
                pictureBox_ErrorDiffusion.BackgroundImage = bitmapErrorDiffusion;
                saveContextMenuErrorDiffusion = new SaveContextMenu(bitmapErrorDiffusion);
                pictureBox_ErrorDiffusion.ContextMenuStrip = saveContextMenuErrorDiffusion;
            }

            if (usePopularity)
            {
                bitmapPopularity = ColorReduction.PopularityQuantization(bitmapMain, k, progressBarPopularity);
                pictureBox_PopularityAlgorithm.BackgroundImage = bitmapPopularity;
                saveContextMenuPopularity = new SaveContextMenu(bitmapPopularity);
                pictureBox_PopularityAlgorithm.ContextMenuStrip = saveContextMenuPopularity;
            }

            if (useKMeansReduction)
            {
                bitmapKMeans = ColorReduction.KMeansQuantization(bitmapMain, k, trackBarKMeans.Value, progressBarKMeans);
                pictureBox_K_MeansReduction.BackgroundImage = bitmapKMeans;
                saveContextMenuKMeans = new SaveContextMenu(bitmapKMeans);
                pictureBox_K_MeansReduction.ContextMenuStrip = saveContextMenuKMeans;
            }
        }
    }
}
