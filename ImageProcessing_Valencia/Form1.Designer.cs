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
            this.btnClearSubtractMode = new System.Windows.Forms.Button();
            this.btnSaveSubtractImage = new System.Windows.Forms.Button();
            this.btnClearBasicMode = new System.Windows.Forms.Button();
            this.btnShowHistogram = new System.Windows.Forms.Button();
            this.btnApplySepia = new System.Windows.Forms.Button();
            this.btnApplyGrayscale = new System.Windows.Forms.Button();
            this.btnApplyInvert = new System.Windows.Forms.Button();
            this.btnCopyImage = new System.Windows.Forms.Button();
            this.btnLoadForegroundImage = new System.Windows.Forms.Button();
            this.lblSubtracted = new System.Windows.Forms.Label();
            this.btnSaveBasicImage = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnLoadBackgroundImage = new System.Windows.Forms.Button();
            this.pbForeground = new System.Windows.Forms.PictureBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.dlgColorPicker = new System.Windows.Forms.ColorDialog();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.btnSubtractImages = new System.Windows.Forms.Button();
            this.pbSubtracted = new System.Windows.Forms.PictureBox();
            this.tabSubtractMode = new System.Windows.Forms.TabPage();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.fswWatcher = new System.IO.FileSystemWatcher();
            this.tabBasicMode = new System.Windows.Forms.TabPage();
            this.btnLoadBasicImage = new System.Windows.Forms.Button();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbForeground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtracted)).BeginInit();
            this.tabSubtractMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswWatcher)).BeginInit();
            this.tabBasicMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
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
            // btnSaveSubtractImage
            // 
            this.btnSaveSubtractImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveSubtractImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSubtractImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveSubtractImage.ForeColor = System.Drawing.Color.White;
            this.btnSaveSubtractImage.Location = new System.Drawing.Point(434, 472);
            this.btnSaveSubtractImage.Name = "btnSaveSubtractImage";
            this.btnSaveSubtractImage.Size = new System.Drawing.Size(100, 23);
            this.btnSaveSubtractImage.TabIndex = 17;
            this.btnSaveSubtractImage.Text = "Save";
            this.btnSaveSubtractImage.UseVisualStyleBackColor = false;
            this.btnSaveSubtractImage.Click += new System.EventHandler(this.btnSaveSubtractImage_Click);
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
            this.lblSubtracted.Location = new System.Drawing.Point(340, 158);
            this.lblSubtracted.Name = "lblSubtracted";
            this.lblSubtracted.Size = new System.Drawing.Size(133, 20);
            this.lblSubtracted.TabIndex = 15;
            this.lblSubtracted.Text = "Subtracted Image";
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
            // pbOutput
            // 
            this.pbOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutput.Location = new System.Drawing.Point(415, 45);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(377, 383);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOutput.TabIndex = 1;
            this.pbOutput.TabStop = false;
            // 
            // btnSubtractImages
            // 
            this.btnSubtractImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubtractImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtractImages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubtractImages.ForeColor = System.Drawing.Color.White;
            this.btnSubtractImages.Location = new System.Drawing.Point(271, 472);
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
            this.pbSubtracted.Location = new System.Drawing.Point(271, 181);
            this.pbSubtracted.Name = "pbSubtracted";
            this.pbSubtracted.Size = new System.Drawing.Size(263, 285);
            this.pbSubtracted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubtracted.TabIndex = 25;
            this.pbSubtracted.TabStop = false;
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
            this.tabSubtractMode.Text = "Subtract Mode";
            this.tabSubtractMode.UseVisualStyleBackColor = true;
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBackground.Location = new System.Drawing.Point(550, 4);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(242, 246);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackground.TabIndex = 24;
            this.pbBackground.TabStop = false;
            // 
            // fswWatcher
            // 
            this.fswWatcher.EnableRaisingEvents = true;
            this.fswWatcher.SynchronizingObject = this;
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
            this.tabBasicMode.Text = "Basic Mode";
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
            // 
            // pbInput
            // 
            this.pbInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInput.Location = new System.Drawing.Point(0, 45);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(399, 383);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInput.TabIndex = 0;
            this.pbInput.TabStop = false;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabBasicMode);
            this.tcMain.Controls.Add(this.tabSubtractMode);
            this.tcMain.Location = new System.Drawing.Point(10, 10);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(800, 530);
            this.tcMain.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbForeground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtracted)).EndInit();
            this.tabSubtractMode.ResumeLayout(false);
            this.tabSubtractMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswWatcher)).EndInit();
            this.tabBasicMode.ResumeLayout(false);
            this.tabBasicMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.btnLoadBasicImage.Click += new System.EventHandler(this.btnLoadInputImage_Click);
            this.btnSubtractImages.Click += new System.EventHandler(this.btnSubtractImages_Click);

        }



        #endregion

        private System.Windows.Forms.Button btnClearSubtractMode;
        private System.Windows.Forms.Button btnSaveSubtractImage;
        private System.Windows.Forms.Button btnClearBasicMode;
        private System.Windows.Forms.Button btnShowHistogram;
        private System.Windows.Forms.Button btnApplySepia;
        private System.Windows.Forms.Button btnApplyGrayscale;
        private System.Windows.Forms.Button btnApplyInvert;
        private System.Windows.Forms.Button btnCopyImage;
        private System.Windows.Forms.Button btnLoadForegroundImage;
        private System.Windows.Forms.Label lblSubtracted;
        private System.Windows.Forms.Button btnSaveBasicImage;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnLoadBackgroundImage;
        private System.Windows.Forms.PictureBox pbForeground;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ColorDialog dlgColorPicker;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.Button btnSubtractImages;
        private System.Windows.Forms.PictureBox pbSubtracted;
        private System.Windows.Forms.TabPage tabSubtractMode;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.IO.FileSystemWatcher fswWatcher;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabBasicMode;
        private System.Windows.Forms.PictureBox pbInput;
        private Button btnLoadBasicImage;
    }
}

