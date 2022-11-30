using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace PRO3_Color_Reduction
{
    public class SaveContextMenu : ContextMenuStrip
    {
        public Bitmap image;

        public SaveContextMenu(Bitmap _image = null) : base()
        {
            image = _image;
            Opening += contextMenuStrip_Opening;
        }

        void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Items.Clear();
            
            Items.Add("Save Image", image, new EventHandler(toolStripSaveImage_Click));
        }

        private void toolStripSaveImage_Click(object sender, EventArgs e)
        {
            if (image == null) return;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "png";
            dialog.AddExtension = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(dialog.FileName, ImageFormat.Png);
            }
        }
    }
}
