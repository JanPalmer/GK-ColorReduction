
namespace PRO3_Color_Reduction
{
    partial class EnlargedPicture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_Enlarge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Enlarge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Enlarge
            // 
            this.pictureBox_Enlarge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Enlarge.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Enlarge.Name = "pictureBox_Enlarge";
            this.pictureBox_Enlarge.Size = new System.Drawing.Size(776, 426);
            this.pictureBox_Enlarge.TabIndex = 0;
            this.pictureBox_Enlarge.TabStop = false;
            this.pictureBox_Enlarge.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Enlarge_MouseDown);
            // 
            // EnlargedPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_Enlarge);
            this.Name = "EnlargedPicture";
            this.Text = "Enlarged Picture";
            this.Resize += new System.EventHandler(this.EnlargedPicture_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Enlarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Enlarge;
    }
}