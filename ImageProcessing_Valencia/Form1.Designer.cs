using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing_Valencia
{
    partial class Form1
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
            this.dlgColorPicker = new System.Windows.Forms.ColorDialog();
            this.fswWatcher = new System.IO.FileSystemWatcher();
            this.tabSubtractMode = new System.Windows.Forms.TabPage();
            this.btnSubtractImages = new System.Windows.Forms.Button();
            this.pbSubtracted = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.btnClearSubtractMode = new System.Windows.Forms.Button();
            this.btnLoadBackgroundImage = new System.Windows.Forms.Button();
            this.btnSaveSubtractImage = new System.Windows.Forms.Button();
            this.btnLoadForegroundImage = new System.Windows.Forms.Button();
            this.lblSubtracted = new System.Windows.Forms.Label();
            this.pbForeground = new System.Windows.Forms.PictureBox();
            this.tabBasicMode = new System.Windows.Forms.TabPage();
            this.btnLoadBasicImage = new System.Windows.Forms.Button();
            this.btnClearBasicMode = new System.Windows.Forms.Button();
            this.btnShowHistogram = new System.Windows.Forms.Button();
            this.btnApplySepia = new System.Windows.Forms.Button();
            this.btnApplyGrayscale = new System.Windows.Forms.Button();
            this.btnApplyInvert = new System.Windows.Forms.Button();
            this.btnCopyImage = new System.Windows.Forms.Button();
            this.btnSaveBasicImage = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.convolutionTab = new System.Windows.Forms.TabPage();
            this.labelEmbossing = new System.Windows.Forms.Label();
            this.btnConvolutionVerticalOnly = new System.Windows.Forms.Button();
            this.btnConvolutionHorizontalOnly = new System.Windows.Forms.Button();
            this.btnConvolutionLossy = new System.Windows.Forms.Button();
            this.btnConvolutionAllDirections = new System.Windows.Forms.Button();
            this.btnConvolutionHorizontalVertical = new System.Windows.Forms.Button();
            this.btnConvolutionLaplascian = new System.Windows.Forms.Button();
            this.btnConvolutionLoadImg = new System.Windows.Forms.Button();
            this.btnConvolutionClearImg = new System.Windows.Forms.Button();
            this.btnConvolutionMeanRemoval = new System.Windows.Forms.Button();
            this.btnConvolutionSharpen = new System.Windows.Forms.Button();
            this.btnConvolutionGaussianBlur = new System.Windows.Forms.Button();
            this.btnConvolutionSmooth = new System.Windows.Forms.Button();
            this.btnConvolutionSaveImg = new System.Windows.Forms.Button();
            this.labelConvolutionOutput = new System.Windows.Forms.Label();
            this.labelConvolutionInput = new System.Windows.Forms.Label();
            this.imgConvolutionOutput = new System.Windows.Forms.PictureBox();
            this.imgConvolutionInput = new System.Windows.Forms.PictureBox();
            this.tabWebcam = new System.Windows.Forms.TabPage();
            this.labelWebcamOutput = new System.Windows.Forms.Label();
            this.labelWebcam = new System.Windows.Forms.Label();
            this.checkBoxWebcam = new System.Windows.Forms.CheckBox();
            this.comboBoxWebcam = new System.Windows.Forms.ComboBox();
            this.btnWebcamGrayscale = new System.Windows.Forms.Button();
            this.btnWebcamSepia = new System.Windows.Forms.Button();
            this.btnWebcamClear = new System.Windows.Forms.Button();
            this.btnWebcamInvert = new System.Windows.Forms.Button();
            this.btnWebcamSubtract = new System.Windows.Forms.Button();
            this.pbWebcamOutput = new System.Windows.Forms.PictureBox();
            this.pbWebcam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fswWatcher)).BeginInit();
            this.tabSubtractMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtracted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForeground)).BeginInit();
            this.tabBasicMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            this.tcMain.SuspendLayout();
            this.convolutionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvolutionOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvolutionInput)).BeginInit();
            this.tabWebcam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebcamOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebcam)).BeginInit();
            this.SuspendLayout();
            // 
            // fswWatcher
            // 
            this.fswWatcher.EnableRaisingEvents = true;
            this.fswWatcher.SynchronizingObject = this;
            // 
            // tabSubtractMode
            // 
            this.tabSubtractMode.Controls.Add(this.btnSubtractImages);
            this.tabSubtractMode.Controls.Add(this.pbSubtracted);
            this.tabSubtractMode.Controls.Add(this.pbBackground);
            this.tabSubtractMode.Controls.Add(this.btnClearSubtractMode);
            this.tabSubtractMode.Controls.Add(this.btnLoadBackgroundImage);
            this.tabSubtractMode.Controls.Add(this.btnSaveSubtractImage);
            this.tabSubtractMode.Controls.Add(this.btnLoadForegroundImage);
            this.tabSubtractMode.Controls.Add(this.lblSubtracted);
            this.tabSubtractMode.Controls.Add(this.pbForeground);
            this.tabSubtractMode.Location = new System.Drawing.Point(4, 26);
            this.tabSubtractMode.Name = "tabSubtractMode";
            this.tabSubtractMode.Padding = new System.Windows.Forms.Padding(2);
            this.tabSubtractMode.Size = new System.Drawing.Size(792, 500);
            this.tabSubtractMode.TabIndex = 1;
            this.tabSubtractMode.Text = "Subtract Image Operations";
            this.tabSubtractMode.UseVisualStyleBackColor = true;
            // 
            // btnSubtractImages
            // 
            this.btnSubtractImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubtractImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtractImages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubtractImages.ForeColor = System.Drawing.Color.White;
            this.btnSubtractImages.Location = new System.Drawing.Point(268, 459);
            this.btnSubtractImages.Name = "btnSubtractImages";
            this.btnSubtractImages.Size = new System.Drawing.Size(100, 23);
            this.btnSubtractImages.TabIndex = 26;
            this.btnSubtractImages.Text = "Subtract";
            this.btnSubtractImages.UseVisualStyleBackColor = false;
            this.btnSubtractImages.Click += new System.EventHandler(this.btnSubtractImages_Click);
            // 
            // pbSubtracted
            // 
            this.pbSubtracted.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbSubtracted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSubtracted.Location = new System.Drawing.Point(268, 206);
            this.pbSubtracted.Name = "pbSubtracted";
            this.pbSubtracted.Size = new System.Drawing.Size(256, 247);
            this.pbSubtracted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubtracted.TabIndex = 25;
            this.pbSubtracted.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBackground.Location = new System.Drawing.Point(536, 3);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(256, 247);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackground.TabIndex = 24;
            this.pbBackground.TabStop = false;
            // 
            // btnClearSubtractMode
            // 
            this.btnClearSubtractMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearSubtractMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSubtractMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearSubtractMode.ForeColor = System.Drawing.Color.White;
            this.btnClearSubtractMode.Location = new System.Drawing.Point(337, 78);
            this.btnClearSubtractMode.Name = "btnClearSubtractMode";
            this.btnClearSubtractMode.Size = new System.Drawing.Size(136, 48);
            this.btnClearSubtractMode.TabIndex = 23;
            this.btnClearSubtractMode.Text = "Clear Images";
            this.btnClearSubtractMode.UseVisualStyleBackColor = false;
            this.btnClearSubtractMode.Click += new System.EventHandler(this.btnClearSubtractMode_Click);
            // 
            // btnLoadBackgroundImage
            // 
            this.btnLoadBackgroundImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoadBackgroundImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadBackgroundImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadBackgroundImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadBackgroundImage.Location = new System.Drawing.Point(628, 256);
            this.btnLoadBackgroundImage.Name = "btnLoadBackgroundImage";
            this.btnLoadBackgroundImage.Size = new System.Drawing.Size(120, 31);
            this.btnLoadBackgroundImage.TabIndex = 20;
            this.btnLoadBackgroundImage.Text = "Load Background";
            this.btnLoadBackgroundImage.UseVisualStyleBackColor = false;
            this.btnLoadBackgroundImage.Click += new System.EventHandler(this.btnLoadBackgroundImage_Click);
            // 
            // btnSaveSubtractImage
            // 
            this.btnSaveSubtractImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveSubtractImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSubtractImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveSubtractImage.ForeColor = System.Drawing.Color.White;
            this.btnSaveSubtractImage.Location = new System.Drawing.Point(424, 459);
            this.btnSaveSubtractImage.Name = "btnSaveSubtractImage";
            this.btnSaveSubtractImage.Size = new System.Drawing.Size(100, 23);
            this.btnSaveSubtractImage.TabIndex = 17;
            this.btnSaveSubtractImage.Text = "Save";
            this.btnSaveSubtractImage.UseVisualStyleBackColor = false;
            this.btnSaveSubtractImage.Click += new System.EventHandler(this.btnSaveSubtractImage_Click);
            // 
            // btnLoadForegroundImage
            // 
            this.btnLoadForegroundImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoadForegroundImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadForegroundImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadForegroundImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadForegroundImage.Location = new System.Drawing.Point(44, 256);
            this.btnLoadForegroundImage.Name = "btnLoadForegroundImage";
            this.btnLoadForegroundImage.Size = new System.Drawing.Size(137, 31);
            this.btnLoadForegroundImage.TabIndex = 16;
            this.btnLoadForegroundImage.Text = "Load Foreground";
            this.btnLoadForegroundImage.UseVisualStyleBackColor = false;
            this.btnLoadForegroundImage.Click += new System.EventHandler(this.btnLoadForegroundImage_Click);
            // 
            // lblSubtracted
            // 
            this.lblSubtracted.AutoSize = true;
            this.lblSubtracted.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtracted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSubtracted.Location = new System.Drawing.Point(337, 173);
            this.lblSubtracted.Name = "lblSubtracted";
            this.lblSubtracted.Size = new System.Drawing.Size(133, 20);
            this.lblSubtracted.TabIndex = 15;
            this.lblSubtracted.Text = "Subtracted Image";
            // 
            // pbForeground
            // 
            this.pbForeground.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbForeground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbForeground.Location = new System.Drawing.Point(0, 3);
            this.pbForeground.Name = "pbForeground";
            this.pbForeground.Size = new System.Drawing.Size(256, 247);
            this.pbForeground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbForeground.TabIndex = 12;
            this.pbForeground.TabStop = false;
            // 
            // tabBasicMode
            // 
            this.tabBasicMode.Controls.Add(this.btnLoadBasicImage);
            this.tabBasicMode.Controls.Add(this.btnClearBasicMode);
            this.tabBasicMode.Controls.Add(this.btnShowHistogram);
            this.tabBasicMode.Controls.Add(this.btnApplySepia);
            this.tabBasicMode.Controls.Add(this.btnApplyGrayscale);
            this.tabBasicMode.Controls.Add(this.btnApplyInvert);
            this.tabBasicMode.Controls.Add(this.btnCopyImage);
            this.tabBasicMode.Controls.Add(this.btnSaveBasicImage);
            this.tabBasicMode.Controls.Add(this.lblOutput);
            this.tabBasicMode.Controls.Add(this.lblInput);
            this.tabBasicMode.Controls.Add(this.pbOutput);
            this.tabBasicMode.Controls.Add(this.pbInput);
            this.tabBasicMode.Location = new System.Drawing.Point(4, 26);
            this.tabBasicMode.Name = "tabBasicMode";
            this.tabBasicMode.Padding = new System.Windows.Forms.Padding(2);
            this.tabBasicMode.Size = new System.Drawing.Size(792, 500);
            this.tabBasicMode.TabIndex = 0;
            this.tabBasicMode.Text = "Basic Image Operations";
            this.tabBasicMode.UseVisualStyleBackColor = true;
            // 
            // btnLoadBasicImage
            // 
            this.btnLoadBasicImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoadBasicImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadBasicImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadBasicImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadBasicImage.Location = new System.Drawing.Point(124, 459);
            this.btnLoadBasicImage.Name = "btnLoadBasicImage";
            this.btnLoadBasicImage.Size = new System.Drawing.Size(100, 23);
            this.btnLoadBasicImage.TabIndex = 13;
            this.btnLoadBasicImage.Text = "Load Image";
            this.btnLoadBasicImage.UseVisualStyleBackColor = false;
            this.btnLoadBasicImage.Click += new System.EventHandler(this.btnLoadInputImage_Click);
            // 
            // btnClearBasicMode
            // 
            this.btnClearBasicMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearBasicMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBasicMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearBasicMode.ForeColor = System.Drawing.Color.White;
            this.btnClearBasicMode.Location = new System.Drawing.Point(354, 452);
            this.btnClearBasicMode.Name = "btnClearBasicMode";
            this.btnClearBasicMode.Size = new System.Drawing.Size(100, 36);
            this.btnClearBasicMode.TabIndex = 11;
            this.btnClearBasicMode.Text = "Clear Images";
            this.btnClearBasicMode.UseVisualStyleBackColor = false;
            this.btnClearBasicMode.Click += new System.EventHandler(this.btnClearBasicMode_Click);
            // 
            // btnShowHistogram
            // 
            this.btnShowHistogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShowHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHistogram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowHistogram.ForeColor = System.Drawing.Color.White;
            this.btnShowHistogram.Location = new System.Drawing.Point(647, 14);
            this.btnShowHistogram.Name = "btnShowHistogram";
            this.btnShowHistogram.Size = new System.Drawing.Size(100, 25);
            this.btnShowHistogram.TabIndex = 10;
            this.btnShowHistogram.Text = "Histogram";
            this.btnShowHistogram.UseVisualStyleBackColor = false;
            this.btnShowHistogram.Click += new System.EventHandler(this.btnShowHistogram_Click);
            // 
            // btnApplySepia
            // 
            this.btnApplySepia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApplySepia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplySepia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplySepia.ForeColor = System.Drawing.Color.White;
            this.btnApplySepia.Location = new System.Drawing.Point(492, 14);
            this.btnApplySepia.Name = "btnApplySepia";
            this.btnApplySepia.Size = new System.Drawing.Size(100, 25);
            this.btnApplySepia.TabIndex = 9;
            this.btnApplySepia.Text = "Sepia";
            this.btnApplySepia.UseVisualStyleBackColor = false;
            this.btnApplySepia.Click += new System.EventHandler(this.btnApplySepia_Click);
            // 
            // btnApplyGrayscale
            // 
            this.btnApplyGrayscale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApplyGrayscale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyGrayscale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplyGrayscale.ForeColor = System.Drawing.Color.White;
            this.btnApplyGrayscale.Location = new System.Drawing.Point(345, 14);
            this.btnApplyGrayscale.Name = "btnApplyGrayscale";
            this.btnApplyGrayscale.Size = new System.Drawing.Size(100, 25);
            this.btnApplyGrayscale.TabIndex = 8;
            this.btnApplyGrayscale.Text = "Grayscale";
            this.btnApplyGrayscale.UseVisualStyleBackColor = false;
            this.btnApplyGrayscale.Click += new System.EventHandler(this.btnApplyGrayscale_Click);
            // 
            // btnApplyInvert
            // 
            this.btnApplyInvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApplyInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyInvert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplyInvert.ForeColor = System.Drawing.Color.White;
            this.btnApplyInvert.Location = new System.Drawing.Point(194, 14);
            this.btnApplyInvert.Name = "btnApplyInvert";
            this.btnApplyInvert.Size = new System.Drawing.Size(100, 25);
            this.btnApplyInvert.TabIndex = 7;
            this.btnApplyInvert.Text = "Invert";
            this.btnApplyInvert.UseVisualStyleBackColor = false;
            this.btnApplyInvert.Click += new System.EventHandler(this.btnApplyInvert_Click);
            // 
            // btnCopyImage
            // 
            this.btnCopyImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCopyImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCopyImage.ForeColor = System.Drawing.Color.White;
            this.btnCopyImage.Location = new System.Drawing.Point(36, 14);
            this.btnCopyImage.Name = "btnCopyImage";
            this.btnCopyImage.Size = new System.Drawing.Size(100, 25);
            this.btnCopyImage.TabIndex = 6;
            this.btnCopyImage.Text = "Copy";
            this.btnCopyImage.UseVisualStyleBackColor = false;
            this.btnCopyImage.Click += new System.EventHandler(this.btnCopyImage_Click);
            // 
            // btnSaveBasicImage
            // 
            this.btnSaveBasicImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveBasicImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBasicImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveBasicImage.ForeColor = System.Drawing.Color.White;
            this.btnSaveBasicImage.Location = new System.Drawing.Point(568, 459);
            this.btnSaveBasicImage.Name = "btnSaveBasicImage";
            this.btnSaveBasicImage.Size = new System.Drawing.Size(100, 23);
            this.btnSaveBasicImage.TabIndex = 5;
            this.btnSaveBasicImage.Text = "Save Image";
            this.btnSaveBasicImage.UseVisualStyleBackColor = false;
            this.btnSaveBasicImage.Click += new System.EventHandler(this.btnSaveBasicImage_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOutput.Location = new System.Drawing.Point(565, 435);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(107, 20);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output Image";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInput.Location = new System.Drawing.Point(126, 435);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(95, 20);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Input Image";
            // 
            // pbOutput
            // 
            this.pbOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.Location = new System.Drawing.Point(422, 45);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(370, 383);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOutput.TabIndex = 1;
            this.pbOutput.TabStop = false;
            // 
            // pbInput
            // 
            this.pbInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInput.Location = new System.Drawing.Point(0, 45);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(370, 383);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInput.TabIndex = 0;
            this.pbInput.TabStop = false;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabBasicMode);
            this.tcMain.Controls.Add(this.tabSubtractMode);
            this.tcMain.Controls.Add(this.convolutionTab);
            this.tcMain.Controls.Add(this.tabWebcam);
            this.tcMain.Location = new System.Drawing.Point(10, 10);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(800, 530);
            this.tcMain.TabIndex = 1;
            // 
            // convolutionTab
            // 
            this.convolutionTab.Controls.Add(this.labelEmbossing);
            this.convolutionTab.Controls.Add(this.btnConvolutionVerticalOnly);
            this.convolutionTab.Controls.Add(this.btnConvolutionHorizontalOnly);
            this.convolutionTab.Controls.Add(this.btnConvolutionLossy);
            this.convolutionTab.Controls.Add(this.btnConvolutionAllDirections);
            this.convolutionTab.Controls.Add(this.btnConvolutionHorizontalVertical);
            this.convolutionTab.Controls.Add(this.btnConvolutionLaplascian);
            this.convolutionTab.Controls.Add(this.btnConvolutionLoadImg);
            this.convolutionTab.Controls.Add(this.btnConvolutionClearImg);
            this.convolutionTab.Controls.Add(this.btnConvolutionMeanRemoval);
            this.convolutionTab.Controls.Add(this.btnConvolutionSharpen);
            this.convolutionTab.Controls.Add(this.btnConvolutionGaussianBlur);
            this.convolutionTab.Controls.Add(this.btnConvolutionSmooth);
            this.convolutionTab.Controls.Add(this.btnConvolutionSaveImg);
            this.convolutionTab.Controls.Add(this.labelConvolutionOutput);
            this.convolutionTab.Controls.Add(this.labelConvolutionInput);
            this.convolutionTab.Controls.Add(this.imgConvolutionOutput);
            this.convolutionTab.Controls.Add(this.imgConvolutionInput);
            this.convolutionTab.Location = new System.Drawing.Point(4, 26);
            this.convolutionTab.Name = "convolutionTab";
            this.convolutionTab.Padding = new System.Windows.Forms.Padding(3);
            this.convolutionTab.Size = new System.Drawing.Size(792, 500);
            this.convolutionTab.TabIndex = 2;
            this.convolutionTab.Text = "Convolution Matrix Operations";
            this.convolutionTab.UseVisualStyleBackColor = true;
            // 
            // labelEmbossing
            // 
            this.labelEmbossing.AutoSize = true;
            this.labelEmbossing.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelEmbossing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmbossing.Location = new System.Drawing.Point(352, 85);
            this.labelEmbossing.Name = "labelEmbossing";
            this.labelEmbossing.Size = new System.Drawing.Size(85, 20);
            this.labelEmbossing.TabIndex = 32;
            this.labelEmbossing.Text = "Embossing";
            // 
            // btnConvolutionVerticalOnly
            // 
            this.btnConvolutionVerticalOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionVerticalOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionVerticalOnly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionVerticalOnly.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionVerticalOnly.Location = new System.Drawing.Point(345, 375);
            this.btnConvolutionVerticalOnly.Name = "btnConvolutionVerticalOnly";
            this.btnConvolutionVerticalOnly.Size = new System.Drawing.Size(100, 25);
            this.btnConvolutionVerticalOnly.TabIndex = 31;
            this.btnConvolutionVerticalOnly.Text = "Vertical Only";
            this.btnConvolutionVerticalOnly.UseVisualStyleBackColor = false;
            this.btnConvolutionVerticalOnly.Click += new System.EventHandler(this.btnConvolutionVerticalOnly_Click);
            // 
            // btnConvolutionHorizontalOnly
            // 
            this.btnConvolutionHorizontalOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionHorizontalOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionHorizontalOnly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionHorizontalOnly.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionHorizontalOnly.Location = new System.Drawing.Point(345, 318);
            this.btnConvolutionHorizontalOnly.Name = "btnConvolutionHorizontalOnly";
            this.btnConvolutionHorizontalOnly.Size = new System.Drawing.Size(100, 40);
            this.btnConvolutionHorizontalOnly.TabIndex = 30;
            this.btnConvolutionHorizontalOnly.Text = "Horizontal Only";
            this.btnConvolutionHorizontalOnly.UseVisualStyleBackColor = false;
            this.btnConvolutionHorizontalOnly.Click += new System.EventHandler(this.btnConvolutionHorizontalOnly_Click);
            // 
            // btnConvolutionLossy
            // 
            this.btnConvolutionLossy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionLossy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionLossy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionLossy.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionLossy.Location = new System.Drawing.Point(345, 275);
            this.btnConvolutionLossy.Name = "btnConvolutionLossy";
            this.btnConvolutionLossy.Size = new System.Drawing.Size(100, 25);
            this.btnConvolutionLossy.TabIndex = 29;
            this.btnConvolutionLossy.Text = "Lossy";
            this.btnConvolutionLossy.UseVisualStyleBackColor = false;
            this.btnConvolutionLossy.Click += new System.EventHandler(this.btnConvolutionLossy_Click);
            // 
            // btnConvolutionAllDirections
            // 
            this.btnConvolutionAllDirections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionAllDirections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionAllDirections.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionAllDirections.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionAllDirections.Location = new System.Drawing.Point(345, 228);
            this.btnConvolutionAllDirections.Name = "btnConvolutionAllDirections";
            this.btnConvolutionAllDirections.Size = new System.Drawing.Size(100, 25);
            this.btnConvolutionAllDirections.TabIndex = 28;
            this.btnConvolutionAllDirections.Text = "All Directions";
            this.btnConvolutionAllDirections.UseVisualStyleBackColor = false;
            this.btnConvolutionAllDirections.Click += new System.EventHandler(this.btnConvolutionAllDirections_Click);
            // 
            // btnConvolutionHorizontalVertical
            // 
            this.btnConvolutionHorizontalVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionHorizontalVertical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionHorizontalVertical.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionHorizontalVertical.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionHorizontalVertical.Location = new System.Drawing.Point(345, 169);
            this.btnConvolutionHorizontalVertical.Name = "btnConvolutionHorizontalVertical";
            this.btnConvolutionHorizontalVertical.Size = new System.Drawing.Size(100, 42);
            this.btnConvolutionHorizontalVertical.TabIndex = 27;
            this.btnConvolutionHorizontalVertical.Text = "Horizontal Vertical";
            this.btnConvolutionHorizontalVertical.UseVisualStyleBackColor = false;
            this.btnConvolutionHorizontalVertical.Click += new System.EventHandler(this.btnConvolutionHorizontalVertical_Click);
            // 
            // btnConvolutionLaplascian
            // 
            this.btnConvolutionLaplascian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionLaplascian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionLaplascian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionLaplascian.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionLaplascian.Location = new System.Drawing.Point(345, 124);
            this.btnConvolutionLaplascian.Name = "btnConvolutionLaplascian";
            this.btnConvolutionLaplascian.Size = new System.Drawing.Size(100, 25);
            this.btnConvolutionLaplascian.TabIndex = 26;
            this.btnConvolutionLaplascian.Text = "Laplascian";
            this.btnConvolutionLaplascian.UseVisualStyleBackColor = false;
            this.btnConvolutionLaplascian.Click += new System.EventHandler(this.btnConvolutionLaplascian_Click);
            // 
            // btnConvolutionLoadImg
            // 
            this.btnConvolutionLoadImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionLoadImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionLoadImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionLoadImg.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionLoadImg.Location = new System.Drawing.Point(124, 458);
            this.btnConvolutionLoadImg.Name = "btnConvolutionLoadImg";
            this.btnConvolutionLoadImg.Size = new System.Drawing.Size(100, 23);
            this.btnConvolutionLoadImg.TabIndex = 25;
            this.btnConvolutionLoadImg.Text = "Load Image";
            this.btnConvolutionLoadImg.UseVisualStyleBackColor = false;
            this.btnConvolutionLoadImg.Click += new System.EventHandler(this.btnConvolutionLoadImg_Click);
            // 
            // btnConvolutionClearImg
            // 
            this.btnConvolutionClearImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionClearImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionClearImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionClearImg.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionClearImg.Location = new System.Drawing.Point(345, 451);
            this.btnConvolutionClearImg.Name = "btnConvolutionClearImg";
            this.btnConvolutionClearImg.Size = new System.Drawing.Size(100, 36);
            this.btnConvolutionClearImg.TabIndex = 24;
            this.btnConvolutionClearImg.Text = "Clear Images";
            this.btnConvolutionClearImg.UseVisualStyleBackColor = false;
            this.btnConvolutionClearImg.Click += new System.EventHandler(this.btnConvolutionClearImg_Click);
            // 
            // btnConvolutionMeanRemoval
            // 
            this.btnConvolutionMeanRemoval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionMeanRemoval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionMeanRemoval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionMeanRemoval.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionMeanRemoval.Location = new System.Drawing.Point(577, 13);
            this.btnConvolutionMeanRemoval.Name = "btnConvolutionMeanRemoval";
            this.btnConvolutionMeanRemoval.Size = new System.Drawing.Size(100, 25);
            this.btnConvolutionMeanRemoval.TabIndex = 22;
            this.btnConvolutionMeanRemoval.Text = "Mean Removal";
            this.btnConvolutionMeanRemoval.UseVisualStyleBackColor = false;
            this.btnConvolutionMeanRemoval.Click += new System.EventHandler(this.btnConvolutionMeanRemoval_Click);
            // 
            // btnConvolutionSharpen
            // 
            this.btnConvolutionSharpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionSharpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionSharpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionSharpen.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionSharpen.Location = new System.Drawing.Point(430, 13);
            this.btnConvolutionSharpen.Name = "btnConvolutionSharpen";
            this.btnConvolutionSharpen.Size = new System.Drawing.Size(100, 25);
            this.btnConvolutionSharpen.TabIndex = 21;
            this.btnConvolutionSharpen.Text = "Sharpen";
            this.btnConvolutionSharpen.UseVisualStyleBackColor = false;
            this.btnConvolutionSharpen.Click += new System.EventHandler(this.btnConvolutionSharpen_Click);
            // 
            // btnConvolutionGaussianBlur
            // 
            this.btnConvolutionGaussianBlur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionGaussianBlur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionGaussianBlur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionGaussianBlur.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionGaussianBlur.Location = new System.Drawing.Point(279, 13);
            this.btnConvolutionGaussianBlur.Name = "btnConvolutionGaussianBlur";
            this.btnConvolutionGaussianBlur.Size = new System.Drawing.Size(100, 25);
            this.btnConvolutionGaussianBlur.TabIndex = 20;
            this.btnConvolutionGaussianBlur.Text = "Gaussian Blur";
            this.btnConvolutionGaussianBlur.UseVisualStyleBackColor = false;
            this.btnConvolutionGaussianBlur.Click += new System.EventHandler(this.btnConvolutionGaussianBlur_Click);
            // 
            // btnConvolutionSmooth
            // 
            this.btnConvolutionSmooth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionSmooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionSmooth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionSmooth.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionSmooth.Location = new System.Drawing.Point(121, 13);
            this.btnConvolutionSmooth.Name = "btnConvolutionSmooth";
            this.btnConvolutionSmooth.Size = new System.Drawing.Size(100, 25);
            this.btnConvolutionSmooth.TabIndex = 19;
            this.btnConvolutionSmooth.Text = "Smooth";
            this.btnConvolutionSmooth.UseVisualStyleBackColor = false;
            this.btnConvolutionSmooth.Click += new System.EventHandler(this.btnConvolutionSmooth_Click);
            // 
            // btnConvolutionSaveImg
            // 
            this.btnConvolutionSaveImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConvolutionSaveImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvolutionSaveImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConvolutionSaveImg.ForeColor = System.Drawing.Color.White;
            this.btnConvolutionSaveImg.Location = new System.Drawing.Point(568, 458);
            this.btnConvolutionSaveImg.Name = "btnConvolutionSaveImg";
            this.btnConvolutionSaveImg.Size = new System.Drawing.Size(100, 23);
            this.btnConvolutionSaveImg.TabIndex = 18;
            this.btnConvolutionSaveImg.Text = "Save Image";
            this.btnConvolutionSaveImg.UseVisualStyleBackColor = false;
            this.btnConvolutionSaveImg.Click += new System.EventHandler(this.btnConvolutionSaveImg_Click);
            // 
            // labelConvolutionOutput
            // 
            this.labelConvolutionOutput.AutoSize = true;
            this.labelConvolutionOutput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelConvolutionOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelConvolutionOutput.Location = new System.Drawing.Point(565, 434);
            this.labelConvolutionOutput.Name = "labelConvolutionOutput";
            this.labelConvolutionOutput.Size = new System.Drawing.Size(107, 20);
            this.labelConvolutionOutput.TabIndex = 17;
            this.labelConvolutionOutput.Text = "Output Image";
            // 
            // labelConvolutionInput
            // 
            this.labelConvolutionInput.AutoSize = true;
            this.labelConvolutionInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelConvolutionInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelConvolutionInput.Location = new System.Drawing.Point(126, 434);
            this.labelConvolutionInput.Name = "labelConvolutionInput";
            this.labelConvolutionInput.Size = new System.Drawing.Size(95, 20);
            this.labelConvolutionInput.TabIndex = 16;
            this.labelConvolutionInput.Text = "Input Image";
            // 
            // imgConvolutionOutput
            // 
            this.imgConvolutionOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgConvolutionOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgConvolutionOutput.Location = new System.Drawing.Point(453, 66);
            this.imgConvolutionOutput.Name = "imgConvolutionOutput";
            this.imgConvolutionOutput.Size = new System.Drawing.Size(339, 361);
            this.imgConvolutionOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgConvolutionOutput.TabIndex = 15;
            this.imgConvolutionOutput.TabStop = false;
            // 
            // imgConvolutionInput
            // 
            this.imgConvolutionInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgConvolutionInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgConvolutionInput.Location = new System.Drawing.Point(0, 66);
            this.imgConvolutionInput.Name = "imgConvolutionInput";
            this.imgConvolutionInput.Size = new System.Drawing.Size(339, 361);
            this.imgConvolutionInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgConvolutionInput.TabIndex = 14;
            this.imgConvolutionInput.TabStop = false;
            // 
            // tabWebcam
            // 
            this.tabWebcam.Controls.Add(this.labelWebcamOutput);
            this.tabWebcam.Controls.Add(this.labelWebcam);
            this.tabWebcam.Controls.Add(this.checkBoxWebcam);
            this.tabWebcam.Controls.Add(this.comboBoxWebcam);
            this.tabWebcam.Controls.Add(this.btnWebcamGrayscale);
            this.tabWebcam.Controls.Add(this.btnWebcamSepia);
            this.tabWebcam.Controls.Add(this.btnWebcamClear);
            this.tabWebcam.Controls.Add(this.btnWebcamInvert);
            this.tabWebcam.Controls.Add(this.btnWebcamSubtract);
            this.tabWebcam.Controls.Add(this.pbWebcamOutput);
            this.tabWebcam.Controls.Add(this.pbWebcam);
            this.tabWebcam.Location = new System.Drawing.Point(4, 26);
            this.tabWebcam.Name = "tabWebcam";
            this.tabWebcam.Padding = new System.Windows.Forms.Padding(3);
            this.tabWebcam.Size = new System.Drawing.Size(792, 500);
            this.tabWebcam.TabIndex = 3;
            this.tabWebcam.Text = "Webcam Operations";
            this.tabWebcam.UseVisualStyleBackColor = true;
            // 
            // labelWebcamOutput
            // 
            this.labelWebcamOutput.AutoSize = true;
            this.labelWebcamOutput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelWebcamOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWebcamOutput.Location = new System.Drawing.Point(570, 437);
            this.labelWebcamOutput.Name = "labelWebcamOutput";
            this.labelWebcamOutput.Size = new System.Drawing.Size(107, 20);
            this.labelWebcamOutput.TabIndex = 21;
            this.labelWebcamOutput.Text = "Output Image";
            // 
            // labelWebcam
            // 
            this.labelWebcam.AutoSize = true;
            this.labelWebcam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelWebcam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWebcam.Location = new System.Drawing.Point(126, 437);
            this.labelWebcam.Name = "labelWebcam";
            this.labelWebcam.Size = new System.Drawing.Size(70, 20);
            this.labelWebcam.TabIndex = 20;
            this.labelWebcam.Text = "Webcam";
            // 
            // checkBoxWebcam
            // 
            this.checkBoxWebcam.AutoSize = true;
            this.checkBoxWebcam.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.checkBoxWebcam.FlatAppearance.BorderSize = 2;
            this.checkBoxWebcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxWebcam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.checkBoxWebcam.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxWebcam.Location = new System.Drawing.Point(319, 467);
            this.checkBoxWebcam.Name = "checkBoxWebcam";
            this.checkBoxWebcam.Size = new System.Drawing.Size(143, 23);
            this.checkBoxWebcam.TabIndex = 19;
            this.checkBoxWebcam.Text = "Activate Webcam";
            this.checkBoxWebcam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxWebcam.UseVisualStyleBackColor = true;
            this.checkBoxWebcam.CheckedChanged += new System.EventHandler(this.checkBoxWebcam_CheckedChanged);
            // 
            // comboBoxWebcam
            // 
            this.comboBoxWebcam.BackColor = System.Drawing.Color.Maroon;
            this.comboBoxWebcam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWebcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWebcam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxWebcam.ForeColor = System.Drawing.Color.White;
            this.comboBoxWebcam.FormattingEnabled = true;
            this.comboBoxWebcam.Items.AddRange(new object[] {
            "-- Select Webcam --"});
            this.comboBoxWebcam.Location = new System.Drawing.Point(298, 436);
            this.comboBoxWebcam.Name = "comboBoxWebcam";
            this.comboBoxWebcam.Size = new System.Drawing.Size(196, 25);
            this.comboBoxWebcam.TabIndex = 18;
            // 
            // btnWebcamGrayscale
            // 
            this.btnWebcamGrayscale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnWebcamGrayscale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebcamGrayscale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnWebcamGrayscale.ForeColor = System.Drawing.Color.White;
            this.btnWebcamGrayscale.Location = new System.Drawing.Point(646, 12);
            this.btnWebcamGrayscale.Name = "btnWebcamGrayscale";
            this.btnWebcamGrayscale.Size = new System.Drawing.Size(100, 25);
            this.btnWebcamGrayscale.TabIndex = 17;
            this.btnWebcamGrayscale.Text = "Grayscale";
            this.btnWebcamGrayscale.UseVisualStyleBackColor = false;
            this.btnWebcamGrayscale.Click += new System.EventHandler(this.btnWebcamGrayscale_Click);
            // 
            // btnWebcamSepia
            // 
            this.btnWebcamSepia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnWebcamSepia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebcamSepia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnWebcamSepia.ForeColor = System.Drawing.Color.White;
            this.btnWebcamSepia.Location = new System.Drawing.Point(491, 12);
            this.btnWebcamSepia.Name = "btnWebcamSepia";
            this.btnWebcamSepia.Size = new System.Drawing.Size(100, 25);
            this.btnWebcamSepia.TabIndex = 16;
            this.btnWebcamSepia.Text = "Sepia";
            this.btnWebcamSepia.UseVisualStyleBackColor = false;
            this.btnWebcamSepia.Click += new System.EventHandler(this.btnWebcamSepia_Click);
            // 
            // btnWebcamClear
            // 
            this.btnWebcamClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnWebcamClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebcamClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnWebcamClear.ForeColor = System.Drawing.Color.White;
            this.btnWebcamClear.Location = new System.Drawing.Point(344, 12);
            this.btnWebcamClear.Name = "btnWebcamClear";
            this.btnWebcamClear.Size = new System.Drawing.Size(100, 25);
            this.btnWebcamClear.TabIndex = 15;
            this.btnWebcamClear.Text = "Clear";
            this.btnWebcamClear.UseVisualStyleBackColor = false;
            this.btnWebcamClear.Click += new System.EventHandler(this.btnWebcamClear_Click);
            // 
            // btnWebcamInvert
            // 
            this.btnWebcamInvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnWebcamInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebcamInvert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnWebcamInvert.ForeColor = System.Drawing.Color.White;
            this.btnWebcamInvert.Location = new System.Drawing.Point(193, 12);
            this.btnWebcamInvert.Name = "btnWebcamInvert";
            this.btnWebcamInvert.Size = new System.Drawing.Size(100, 25);
            this.btnWebcamInvert.TabIndex = 14;
            this.btnWebcamInvert.Text = "Invert";
            this.btnWebcamInvert.UseVisualStyleBackColor = false;
            this.btnWebcamInvert.Click += new System.EventHandler(this.btnWebcamInvert_Click);
            // 
            // btnWebcamSubtract
            // 
            this.btnWebcamSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnWebcamSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebcamSubtract.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnWebcamSubtract.ForeColor = System.Drawing.Color.White;
            this.btnWebcamSubtract.Location = new System.Drawing.Point(35, 12);
            this.btnWebcamSubtract.Name = "btnWebcamSubtract";
            this.btnWebcamSubtract.Size = new System.Drawing.Size(100, 25);
            this.btnWebcamSubtract.TabIndex = 13;
            this.btnWebcamSubtract.Text = "Subtract";
            this.btnWebcamSubtract.UseMnemonic = false;
            this.btnWebcamSubtract.UseVisualStyleBackColor = false;
            this.btnWebcamSubtract.Click += new System.EventHandler(this.btnWebcamSubtract_Click);
            // 
            // pbWebcamOutput
            // 
            this.pbWebcamOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbWebcamOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWebcamOutput.Location = new System.Drawing.Point(422, 43);
            this.pbWebcamOutput.Name = "pbWebcamOutput";
            this.pbWebcamOutput.Size = new System.Drawing.Size(370, 383);
            this.pbWebcamOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWebcamOutput.TabIndex = 12;
            this.pbWebcamOutput.TabStop = false;
            // 
            // pbWebcam
            // 
            this.pbWebcam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbWebcam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWebcam.Location = new System.Drawing.Point(0, 43);
            this.pbWebcam.Name = "pbWebcam";
            this.pbWebcam.Size = new System.Drawing.Size(370, 383);
            this.pbWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWebcam.TabIndex = 11;
            this.pbWebcam.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Processing App - Valencia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fswWatcher)).EndInit();
            this.tabSubtractMode.ResumeLayout(false);
            this.tabSubtractMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtracted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForeground)).EndInit();
            this.tabBasicMode.ResumeLayout(false);
            this.tabBasicMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.convolutionTab.ResumeLayout(false);
            this.convolutionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvolutionOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvolutionInput)).EndInit();
            this.tabWebcam.ResumeLayout(false);
            this.tabWebcam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebcamOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebcam)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.ColorDialog dlgColorPicker;
        private System.IO.FileSystemWatcher fswWatcher;
        private TabControl tcMain;
        private TabPage tabBasicMode;
        private Button btnLoadBasicImage;
        private Button btnClearBasicMode;
        private Button btnShowHistogram;
        private Button btnApplySepia;
        private Button btnApplyGrayscale;
        private Button btnApplyInvert;
        private Button btnCopyImage;
        private Button btnSaveBasicImage;
        private Label lblOutput;
        private Label lblInput;
        private PictureBox pbOutput;
        private PictureBox pbInput;
        private TabPage tabSubtractMode;
        private Button btnSubtractImages;
        private PictureBox pbSubtracted;
        private PictureBox pbBackground;
        private Button btnClearSubtractMode;
        private Button btnLoadBackgroundImage;
        private Button btnSaveSubtractImage;
        private Button btnLoadForegroundImage;
        private Label lblSubtracted;
        private PictureBox pbForeground;
        private TabPage convolutionTab;
        private Button btnConvolutionLoadImg;
        private Button btnConvolutionClearImg;
        private Button btnConvolutionMeanRemoval;
        private Button btnConvolutionSharpen;
        private Button btnConvolutionGaussianBlur;
        private Button btnConvolutionSmooth;
        private Button btnConvolutionSaveImg;
        private Label labelConvolutionOutput;
        private Label labelConvolutionInput;
        private PictureBox imgConvolutionOutput;
        private PictureBox imgConvolutionInput;
        private Button btnConvolutionVerticalOnly;
        private Button btnConvolutionHorizontalOnly;
        private Button btnConvolutionLossy;
        private Button btnConvolutionAllDirections;
        private Button btnConvolutionHorizontalVertical;
        private Button btnConvolutionLaplascian;
        private Label labelEmbossing;
        private TabPage tabWebcam;
        private Button btnWebcamGrayscale;
        private Button btnWebcamSepia;
        private Button btnWebcamClear;
        private Button btnWebcamInvert;
        private Button btnWebcamSubtract;
        private PictureBox pbWebcamOutput;
        private PictureBox pbWebcam;
        private ComboBox comboBoxWebcam;
        private Label labelWebcamOutput;
        private Label labelWebcam;
        private CheckBox checkBoxWebcam;
    }
}

