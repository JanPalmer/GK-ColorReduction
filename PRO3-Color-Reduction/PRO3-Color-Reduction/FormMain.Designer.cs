
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxErrorDiffusionK3Colors = new System.Windows.Forms.CheckBox();
            this.checkBoxErrorDiffusion = new System.Windows.Forms.CheckBox();
            this.progressBarErrorDiffusion = new System.Windows.Forms.ProgressBar();
            this.radioButtonStucky = new System.Windows.Forms.RadioButton();
            this.radioButtonBurkes = new System.Windows.Forms.RadioButton();
            this.radioButtonFloydSteinberg = new System.Windows.Forms.RadioButton();
            this.labelFilter = new System.Windows.Forms.Label();
            this.pictureBox_ErrorDiffusion = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxPopularityAlgorithm = new System.Windows.Forms.CheckBox();
            this.progressBarPopularity = new System.Windows.Forms.ProgressBar();
            this.pictureBox_PopularityAlgorithm = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxKMeansReduction = new System.Windows.Forms.CheckBox();
            this.labelEpsilonValue = new System.Windows.Forms.Label();
            this.trackBarKMeans = new System.Windows.Forms.TrackBar();
            this.progressBarKMeans = new System.Windows.Forms.ProgressBar();
            this.pictureBox_K_MeansReduction = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.imageGallery = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.trackBar_KValue = new System.Windows.Forms.TrackBar();
            this.buttonSetK = new System.Windows.Forms.Button();
            this.toolTipK3Colors = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ErrorDiffusion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PopularityAlgorithm)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKMeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_K_MeansReduction)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_KValue)).BeginInit();
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
            this.groupBox1.Controls.Add(this.checkBoxErrorDiffusionK3Colors);
            this.groupBox1.Controls.Add(this.checkBoxErrorDiffusion);
            this.groupBox1.Controls.Add(this.progressBarErrorDiffusion);
            this.groupBox1.Controls.Add(this.radioButtonStucky);
            this.groupBox1.Controls.Add(this.radioButtonBurkes);
            this.groupBox1.Controls.Add(this.radioButtonFloydSteinberg);
            this.groupBox1.Controls.Add(this.labelFilter);
            this.groupBox1.Controls.Add(this.pictureBox_ErrorDiffusion);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error Diffusion";
            // 
            // checkBoxErrorDiffusionK3Colors
            // 
            this.checkBoxErrorDiffusionK3Colors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxErrorDiffusionK3Colors.Location = new System.Drawing.Point(191, 19);
            this.checkBoxErrorDiffusionK3Colors.Name = "checkBoxErrorDiffusionK3Colors";
            this.checkBoxErrorDiffusionK3Colors.Size = new System.Drawing.Size(116, 19);
            this.checkBoxErrorDiffusionK3Colors.TabIndex = 7;
            this.checkBoxErrorDiffusionK3Colors.Text = "Use K*K*K Colors";
            this.checkBoxErrorDiffusionK3Colors.UseVisualStyleBackColor = true;
            this.checkBoxErrorDiffusionK3Colors.Click += new System.EventHandler(this.checkBoxErrorDiffusionK3Colors_Click);
            // 
            // checkBoxErrorDiffusion
            // 
            this.checkBoxErrorDiffusion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxErrorDiffusion.AutoSize = true;
            this.checkBoxErrorDiffusion.Checked = true;
            this.checkBoxErrorDiffusion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxErrorDiffusion.Location = new System.Drawing.Point(191, 0);
            this.checkBoxErrorDiffusion.Name = "checkBoxErrorDiffusion";
            this.checkBoxErrorDiffusion.Size = new System.Drawing.Size(114, 19);
            this.checkBoxErrorDiffusion.TabIndex = 6;
            this.checkBoxErrorDiffusion.Text = "Use This Method";
            this.checkBoxErrorDiffusion.UseVisualStyleBackColor = true;
            this.checkBoxErrorDiffusion.Click += new System.EventHandler(this.checkBoxErrorDiffusion_Click);
            // 
            // progressBarErrorDiffusion
            // 
            this.progressBarErrorDiffusion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarErrorDiffusion.Location = new System.Drawing.Point(6, 64);
            this.progressBarErrorDiffusion.Name = "progressBarErrorDiffusion";
            this.progressBarErrorDiffusion.Size = new System.Drawing.Size(299, 10);
            this.progressBarErrorDiffusion.TabIndex = 5;
            // 
            // radioButtonStucky
            // 
            this.radioButtonStucky.AutoSize = true;
            this.radioButtonStucky.Location = new System.Drawing.Point(185, 37);
            this.radioButtonStucky.Name = "radioButtonStucky";
            this.radioButtonStucky.Size = new System.Drawing.Size(60, 19);
            this.radioButtonStucky.TabIndex = 4;
            this.radioButtonStucky.Text = "Stucky";
            this.radioButtonStucky.UseVisualStyleBackColor = true;
            this.radioButtonStucky.CheckedChanged += new System.EventHandler(this.radioButtonStucky_CheckedChanged);
            // 
            // radioButtonBurkes
            // 
            this.radioButtonBurkes.AutoSize = true;
            this.radioButtonBurkes.Location = new System.Drawing.Point(119, 37);
            this.radioButtonBurkes.Name = "radioButtonBurkes";
            this.radioButtonBurkes.Size = new System.Drawing.Size(60, 19);
            this.radioButtonBurkes.TabIndex = 3;
            this.radioButtonBurkes.Text = "Burkes";
            this.radioButtonBurkes.UseVisualStyleBackColor = true;
            this.radioButtonBurkes.CheckedChanged += new System.EventHandler(this.radioButtonBurkes_CheckedChanged);
            // 
            // radioButtonFloydSteinberg
            // 
            this.radioButtonFloydSteinberg.AutoSize = true;
            this.radioButtonFloydSteinberg.Checked = true;
            this.radioButtonFloydSteinberg.Location = new System.Drawing.Point(6, 37);
            this.radioButtonFloydSteinberg.Name = "radioButtonFloydSteinberg";
            this.radioButtonFloydSteinberg.Size = new System.Drawing.Size(109, 19);
            this.radioButtonFloydSteinberg.TabIndex = 2;
            this.radioButtonFloydSteinberg.TabStop = true;
            this.radioButtonFloydSteinberg.Text = "Floyd-Steinberg";
            this.radioButtonFloydSteinberg.UseVisualStyleBackColor = true;
            this.radioButtonFloydSteinberg.CheckedChanged += new System.EventHandler(this.radioButtonFloydSteinberg_CheckedChanged);
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
            this.pictureBox_ErrorDiffusion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_ErrorDiffusion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_ErrorDiffusion.Location = new System.Drawing.Point(6, 80);
            this.pictureBox_ErrorDiffusion.Name = "pictureBox_ErrorDiffusion";
            this.pictureBox_ErrorDiffusion.Size = new System.Drawing.Size(299, 189);
            this.pictureBox_ErrorDiffusion.TabIndex = 0;
            this.pictureBox_ErrorDiffusion.TabStop = false;
            this.pictureBox_ErrorDiffusion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ErrorDiffusion_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxPopularityAlgorithm);
            this.groupBox2.Controls.Add(this.progressBarPopularity);
            this.groupBox2.Controls.Add(this.pictureBox_PopularityAlgorithm);
            this.groupBox2.Location = new System.Drawing.Point(321, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 275);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Popularity Algorithm";
            // 
            // checkBoxPopularityAlgorithm
            // 
            this.checkBoxPopularityAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPopularityAlgorithm.AutoSize = true;
            this.checkBoxPopularityAlgorithm.Checked = true;
            this.checkBoxPopularityAlgorithm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPopularityAlgorithm.Location = new System.Drawing.Point(192, 0);
            this.checkBoxPopularityAlgorithm.Name = "checkBoxPopularityAlgorithm";
            this.checkBoxPopularityAlgorithm.Size = new System.Drawing.Size(114, 19);
            this.checkBoxPopularityAlgorithm.TabIndex = 7;
            this.checkBoxPopularityAlgorithm.Text = "Use This Method";
            this.checkBoxPopularityAlgorithm.UseVisualStyleBackColor = true;
            this.checkBoxPopularityAlgorithm.Click += new System.EventHandler(this.checkBoxPopularityAlgorithm_Click);
            // 
            // progressBarPopularity
            // 
            this.progressBarPopularity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarPopularity.Location = new System.Drawing.Point(7, 64);
            this.progressBarPopularity.Name = "progressBarPopularity";
            this.progressBarPopularity.Size = new System.Drawing.Size(299, 10);
            this.progressBarPopularity.Step = 1;
            this.progressBarPopularity.TabIndex = 2;
            // 
            // pictureBox_PopularityAlgorithm
            // 
            this.pictureBox_PopularityAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_PopularityAlgorithm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_PopularityAlgorithm.Location = new System.Drawing.Point(7, 80);
            this.pictureBox_PopularityAlgorithm.Name = "pictureBox_PopularityAlgorithm";
            this.pictureBox_PopularityAlgorithm.Size = new System.Drawing.Size(299, 189);
            this.pictureBox_PopularityAlgorithm.TabIndex = 1;
            this.pictureBox_PopularityAlgorithm.TabStop = false;
            this.pictureBox_PopularityAlgorithm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_PopularityAlgorithm_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkBoxKMeansReduction);
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
            // checkBoxKMeansReduction
            // 
            this.checkBoxKMeansReduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxKMeansReduction.AutoSize = true;
            this.checkBoxKMeansReduction.Checked = true;
            this.checkBoxKMeansReduction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKMeansReduction.Location = new System.Drawing.Point(191, 0);
            this.checkBoxKMeansReduction.Name = "checkBoxKMeansReduction";
            this.checkBoxKMeansReduction.Size = new System.Drawing.Size(114, 19);
            this.checkBoxKMeansReduction.TabIndex = 8;
            this.checkBoxKMeansReduction.Text = "Use This Method";
            this.checkBoxKMeansReduction.UseVisualStyleBackColor = true;
            this.checkBoxKMeansReduction.Click += new System.EventHandler(this.checkBoxKMeansReduction_Click);
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
            // trackBarKMeans
            // 
            this.trackBarKMeans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarKMeans.Location = new System.Drawing.Point(6, 19);
            this.trackBarKMeans.Maximum = 50;
            this.trackBarKMeans.Minimum = 1;
            this.trackBarKMeans.Name = "trackBarKMeans";
            this.trackBarKMeans.Size = new System.Drawing.Size(299, 45);
            this.trackBarKMeans.TabIndex = 3;
            this.trackBarKMeans.Value = 11;
            this.trackBarKMeans.ValueChanged += new System.EventHandler(this.trackBarKMeans_ValueChanged);
            // 
            // progressBarKMeans
            // 
            this.progressBarKMeans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarKMeans.Location = new System.Drawing.Point(6, 64);
            this.progressBarKMeans.Name = "progressBarKMeans";
            this.progressBarKMeans.Size = new System.Drawing.Size(299, 10);
            this.progressBarKMeans.Step = 1;
            this.progressBarKMeans.TabIndex = 2;
            // 
            // pictureBox_K_MeansReduction
            // 
            this.pictureBox_K_MeansReduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_K_MeansReduction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_K_MeansReduction.Location = new System.Drawing.Point(6, 80);
            this.pictureBox_K_MeansReduction.Name = "pictureBox_K_MeansReduction";
            this.pictureBox_K_MeansReduction.Size = new System.Drawing.Size(300, 189);
            this.pictureBox_K_MeansReduction.TabIndex = 1;
            this.pictureBox_K_MeansReduction.TabStop = false;
            this.pictureBox_K_MeansReduction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_K_MeansReduction_MouseDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel3.Controls.Add(this.imageGallery, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox_Main, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(954, 394);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // imageGallery
            // 
            this.imageGallery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageGallery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageGallery.Location = new System.Drawing.Point(697, 3);
            this.imageGallery.Name = "imageGallery";
            this.imageGallery.Size = new System.Drawing.Size(254, 388);
            this.imageGallery.TabIndex = 1;
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_Main.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(578, 388);
            this.pictureBox_Main.TabIndex = 0;
            this.pictureBox_Main.TabStop = false;
            this.pictureBox_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Main_MouseDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.buttonLoadImage);
            this.groupBox4.Controls.Add(this.trackBar_KValue);
            this.groupBox4.Controls.Add(this.buttonSetK);
            this.groupBox4.Location = new System.Drawing.Point(587, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(104, 388);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Main Window Controls";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "128";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(68, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "1";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLoadImage.Location = new System.Drawing.Point(3, 311);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(98, 32);
            this.buttonLoadImage.TabIndex = 3;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // trackBar_KValue
            // 
            this.trackBar_KValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_KValue.Location = new System.Drawing.Point(36, 36);
            this.trackBar_KValue.Maximum = 128;
            this.trackBar_KValue.Minimum = 1;
            this.trackBar_KValue.Name = "trackBar_KValue";
            this.trackBar_KValue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_KValue.Size = new System.Drawing.Size(45, 269);
            this.trackBar_KValue.TabIndex = 1;
            this.trackBar_KValue.Value = 10;
            this.trackBar_KValue.ValueChanged += new System.EventHandler(this.trackBar_KValue_ValueChanged);
            // 
            // buttonSetK
            // 
            this.buttonSetK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSetK.Location = new System.Drawing.Point(3, 343);
            this.buttonSetK.Name = "buttonSetK";
            this.buttonSetK.Size = new System.Drawing.Size(98, 42);
            this.buttonSetK.TabIndex = 2;
            this.buttonSetK.Text = "Cluster Image to K Colors";
            this.buttonSetK.UseVisualStyleBackColor = true;
            this.buttonSetK.Click += new System.EventHandler(this.buttonSetK_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Color Reduction";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ErrorDiffusion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PopularityAlgorithm)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKMeans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_K_MeansReduction)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_KValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonStucky;
        private System.Windows.Forms.RadioButton radioButtonBurkes;
        private System.Windows.Forms.RadioButton radioButtonFloydSteinberg;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.PictureBox pictureBox_ErrorDiffusion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox_PopularityAlgorithm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox_K_MeansReduction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonSetK;
        private System.Windows.Forms.TrackBar trackBar_KValue;
        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.ProgressBar progressBarPopularity;
        private System.Windows.Forms.ProgressBar progressBarKMeans;
        private System.Windows.Forms.TrackBar trackBarKMeans;
        private System.Windows.Forms.Label labelEpsilonValue;
        private System.Windows.Forms.ProgressBar progressBarErrorDiffusion;
        private System.Windows.Forms.FlowLayoutPanel imageGallery;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxErrorDiffusion;
        private System.Windows.Forms.CheckBox checkBoxPopularityAlgorithm;
        private System.Windows.Forms.CheckBox checkBoxKMeansReduction;
        private System.Windows.Forms.CheckBox checkBoxErrorDiffusionK3Colors;
        private System.Windows.Forms.ToolTip toolTipK3Colors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

