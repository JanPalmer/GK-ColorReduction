
namespace PRO3_Color_Reduction
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelFilter = new System.Windows.Forms.Label();
            this.pictureBox_ErrorDiffusion = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBarPopularity = new System.Windows.Forms.ProgressBar();
            this.pictureBox_PopularityAlgorithm = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBarKMeans = new System.Windows.Forms.ProgressBar();
            this.pictureBox_K_MeansReduction = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar_KValue = new System.Windows.Forms.TrackBar();
            this.buttonSetK = new System.Windows.Forms.Button();
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.trackBarKMeans = new System.Windows.Forms.TrackBar();
            this.labelEpsilonValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ErrorDiffusion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PopularityAlgorithm)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_K_MeansReduction)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_KValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKMeans)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.42783F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.24176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.75824F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 687);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 403);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(954, 281);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.labelFilter);
            this.groupBox1.Controls.Add(this.pictureBox_ErrorDiffusion);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error Diffusion";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(206, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 19);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(106, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(6, 19);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(107, 15);
            this.labelFilter.TabIndex = 1;
            this.labelFilter.Text = "Select Filter Matrix:";
            // 
            // pictureBox_ErrorDiffusion
            // 
            this.pictureBox_ErrorDiffusion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_ErrorDiffusion.Location = new System.Drawing.Point(6, 80);
            this.pictureBox_ErrorDiffusion.Name = "pictureBox_ErrorDiffusion";
            this.pictureBox_ErrorDiffusion.Size = new System.Drawing.Size(299, 189);
            this.pictureBox_ErrorDiffusion.TabIndex = 0;
            this.pictureBox_ErrorDiffusion.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.progressBarPopularity);
            this.groupBox2.Controls.Add(this.pictureBox_PopularityAlgorithm);
            this.groupBox2.Location = new System.Drawing.Point(321, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 275);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Popularity Algorithm";
            // 
            // progressBarPopularity
            // 
            this.progressBarPopularity.Location = new System.Drawing.Point(7, 64);
            this.progressBarPopularity.Name = "progressBarPopularity";
            this.progressBarPopularity.Size = new System.Drawing.Size(299, 10);
            this.progressBarPopularity.Step = 1;
            this.progressBarPopularity.TabIndex = 2;
            // 
            // pictureBox_PopularityAlgorithm
            // 
            this.pictureBox_PopularityAlgorithm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_PopularityAlgorithm.Location = new System.Drawing.Point(7, 80);
            this.pictureBox_PopularityAlgorithm.Name = "pictureBox_PopularityAlgorithm";
            this.pictureBox_PopularityAlgorithm.Size = new System.Drawing.Size(299, 189);
            this.pictureBox_PopularityAlgorithm.TabIndex = 1;
            this.pictureBox_PopularityAlgorithm.TabStop = false;
            this.pictureBox_PopularityAlgorithm.Click += new System.EventHandler(this.pictureBox_PopularityAlgorithm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.labelEpsilonValue);
            this.groupBox3.Controls.Add(this.trackBarKMeans);
            this.groupBox3.Controls.Add(this.progressBarKMeans);
            this.groupBox3.Controls.Add(this.pictureBox_K_MeansReduction);
            this.groupBox3.Location = new System.Drawing.Point(639, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 275);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "K-Means Reduction";
            // 
            // progressBarKMeans
            // 
            this.progressBarKMeans.Location = new System.Drawing.Point(6, 64);
            this.progressBarKMeans.Name = "progressBarKMeans";
            this.progressBarKMeans.Size = new System.Drawing.Size(299, 10);
            this.progressBarKMeans.Step = 1;
            this.progressBarKMeans.TabIndex = 2;
            // 
            // pictureBox_K_MeansReduction
            // 
            this.pictureBox_K_MeansReduction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_K_MeansReduction.Location = new System.Drawing.Point(6, 80);
            this.pictureBox_K_MeansReduction.Name = "pictureBox_K_MeansReduction";
            this.pictureBox_K_MeansReduction.Size = new System.Drawing.Size(300, 189);
            this.pictureBox_K_MeansReduction.TabIndex = 1;
            this.pictureBox_K_MeansReduction.TabStop = false;
            this.pictureBox_K_MeansReduction.Click += new System.EventHandler(this.pictureBox_K_MeansReduction_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.buttonLoadImage, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(954, 394);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(718, 3);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadImage.TabIndex = 3;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.trackBar_KValue);
            this.panel1.Controls.Add(this.buttonSetK);
            this.panel1.Controls.Add(this.pictureBox_Main);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 388);
            this.panel1.TabIndex = 0;
            // 
            // trackBar_KValue
            // 
            this.trackBar_KValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar_KValue.Location = new System.Drawing.Point(605, 0);
            this.trackBar_KValue.Maximum = 256;
            this.trackBar_KValue.Minimum = 1;
            this.trackBar_KValue.Name = "trackBar_KValue";
            this.trackBar_KValue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_KValue.Size = new System.Drawing.Size(45, 312);
            this.trackBar_KValue.TabIndex = 1;
            this.trackBar_KValue.Value = 10;
            this.trackBar_KValue.ValueChanged += new System.EventHandler(this.trackBar_KValue_ValueChanged);
            // 
            // buttonSetK
            // 
            this.buttonSetK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetK.Location = new System.Drawing.Point(567, 318);
            this.buttonSetK.Name = "buttonSetK";
            this.buttonSetK.Size = new System.Drawing.Size(112, 67);
            this.buttonSetK.TabIndex = 2;
            this.buttonSetK.Text = "Cluster Image to K Colors";
            this.buttonSetK.UseVisualStyleBackColor = true;
            this.buttonSetK.Click += new System.EventHandler(this.buttonSetK_Click);
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_Main.Location = new System.Drawing.Point(6, 3);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(555, 382);
            this.pictureBox_Main.TabIndex = 0;
            this.pictureBox_Main.TabStop = false;
            this.pictureBox_Main.Click += new System.EventHandler(this.pictureBox_Main_Click);
            // 
            // trackBarKMeans
            // 
            this.trackBarKMeans.Location = new System.Drawing.Point(6, 19);
            this.trackBarKMeans.Maximum = 50;
            this.trackBarKMeans.Minimum = 1;
            this.trackBarKMeans.Name = "trackBarKMeans";
            this.trackBarKMeans.Size = new System.Drawing.Size(299, 45);
            this.trackBarKMeans.TabIndex = 3;
            this.trackBarKMeans.Value = 11;
            this.trackBarKMeans.ValueChanged += new System.EventHandler(this.trackBarKMeans_ValueChanged);
            // 
            // labelEpsilonValue
            // 
            this.labelEpsilonValue.AutoSize = true;
            this.labelEpsilonValue.Location = new System.Drawing.Point(90, 49);
            this.labelEpsilonValue.Name = "labelEpsilonValue";
            this.labelEpsilonValue.Size = new System.Drawing.Size(76, 15);
            this.labelEpsilonValue.TabIndex = 4;
            this.labelEpsilonValue.Text = "Epsilon Value";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Color Reduction";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ErrorDiffusion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PopularityAlgorithm)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_K_MeansReduction)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_KValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKMeans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.PictureBox pictureBox_ErrorDiffusion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox_PopularityAlgorithm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox_K_MeansReduction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonSetK;
        private System.Windows.Forms.TrackBar trackBar_KValue;
        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.ProgressBar progressBarPopularity;
        private System.Windows.Forms.ProgressBar progressBarKMeans;
        private System.Windows.Forms.TrackBar trackBarKMeans;
        private System.Windows.Forms.Label labelEpsilonValue;
    }
}

