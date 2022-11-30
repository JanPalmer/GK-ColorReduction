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

            InitializeTooltip();
            LoadExampleImages();
        }

        private void InitializeTooltip()
        {
            string toolTipText = "Unchecked - Color reduction will use exactly 'k' colors, evenly distributed from values 0x000000 (black) through 0xFFFFFF (white)\n" +
                "Checked - Color reduction will use 'k*k*k' colors, meaning that each color component (red, green, blue) will have k possible values";
            toolTipK3Colors.SetToolTip(checkBoxErrorDiffusionK3Colors, toolTipText);
            toolTipK3Colors.AutoPopDelay = 32000;
            toolTipK3Colors.InitialDelay = 400;
        }

        private void LoadExampleImages()
        {
            string path1 = "..\\..\\..\\Images\\img1.jpg";
            string path2 = "..\\..\\..\\Images\\img2.jpg";
            string path3 = "..\\..\\..\\Images\\img3.jpg";
            string path4 = "..\\..\\..\\Images\\img4.jpg";
            DisplayImageInGallery(new Bitmap(path1));
            DisplayImageInGallery(new Bitmap(path2));
            DisplayImageInGallery(new Bitmap(path3));
            DisplayImageInGallery(new Bitmap(path4));
        }

        private void DisplayImageInGallery(Bitmap bitmap)
        {
            Button newButton = new Button();
            newButton.Height = 60;
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
            bitmapMainResized = new Bitmap(bitmapMain, pictureBox_Main.Size);
            pictureBox_Main.Image = bitmapMainResized;
            pictureBox_Main.Invalidate();
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
                case MouseButtons.Right:
                    {
                        saveContextMenuErrorDiffusion.Show(pictureBox_ErrorDiffusion, new Point(e.X, e.Y));//places the menu at the pointer position
                    }
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
                case MouseButtons.Right:
                    {
                        saveContextMenuPopularity.Show(pictureBox_PopularityAlgorithm, new Point(e.X, e.Y));//places the menu at the pointer position
                    }
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
                case MouseButtons.Right:
                    {
                        saveContextMenuKMeans.Show(pictureBox_K_MeansReduction, new Point(e.X, e.Y));
                    }
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
            progressBarErrorDiffusion.Value = 0;

            if (useErrorDiffusion)
            {
                bitmapErrorDiffusion = ColorReduction.ErrorDiffusionQuantization(bitmapMain, k, selectedFilter, useK3Colors, progressBarErrorDiffusion);
                bitmapErrorDiffusionResized = new Bitmap(bitmapErrorDiffusion, pictureBox_ErrorDiffusion.Size);
                pictureBox_ErrorDiffusion.Image = bitmapErrorDiffusionResized;
                saveContextMenuErrorDiffusion = new SaveContextMenu(bitmapErrorDiffusion);
            }

            if (usePopularity)
            {
                bitmapPopularity = ColorReduction.PopularityQuantization(bitmapMain, k, progressBarPopularity);
                bitmapPopularityResized = new Bitmap(bitmapPopularity, pictureBox_PopularityAlgorithm.Size);
                pictureBox_PopularityAlgorithm.Image = bitmapPopularityResized;
                saveContextMenuPopularity = new SaveContextMenu(bitmapPopularity);
            }

            if (useKMeansReduction)
            {
                bitmapKMeans = ColorReduction.KMeansQuantization(bitmapMain, k, trackBarKMeans.Value, progressBarKMeans);
                bitmapKMeansResized = new Bitmap(bitmapKMeans, pictureBox_K_MeansReduction.Size);
                pictureBox_K_MeansReduction.Image = bitmapKMeansResized;
                saveContextMenuKMeans = new SaveContextMenu(bitmapKMeans);
            }
        }
    }
}
