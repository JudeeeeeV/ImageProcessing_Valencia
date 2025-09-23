using System;
using System.Drawing;
using System.Windows.Forms;
using ImageProcessing_Valencia;

namespace ImageProcessing_Valencia
{
    public partial class Form1 : Form
    {
        private BasicImageProcess basicImageProcessor;
        private SubtractProcess subtractImageProcessor;

        public Form1()
        {
            InitializeComponent();
            basicImageProcessor = new BasicImageProcess();
            subtractImageProcessor = new SubtractProcess();
        }

        private void SetInputPictureBox(Bitmap bmp)
        {
            pbInput.SizeMode = PictureBoxSizeMode.Zoom;
            pbInput.Image = bmp;
        }

        private void SetOutputPictureBox(Bitmap bmp)
        {
            pbOutput.SizeMode = PictureBoxSizeMode.Zoom;
            pbOutput.Image = bmp;
        }

        private void btnLoadInputImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog { Filter = "Image Files|*.png;*.jpg;*.jpeg" };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                var image = basicImageProcessor.LoadImage(filePath);
                SetInputPictureBox(image);
            }
        }

        private void btnSaveBasicImage_Click(object sender, EventArgs e)
        {
            if (basicImageProcessor.IsOutputNull())
                return;

            var dialog = new SaveFileDialog { Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg" };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                basicImageProcessor.SaveImage(filePath);
            }
        }

        private void btnClearBasicMode_Click(object sender, EventArgs e)
        {
            basicImageProcessor.ClearImages();
            SetInputPictureBox(null);
            SetOutputPictureBox(null);
        }

        private void btnCopyImage_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.CopyImage();
            SetOutputPictureBox(image);
        }

        private void btnApplyInvert_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.InvertImage();
            SetOutputPictureBox(image);
        }

        private void btnApplyGrayscale_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.ConvertToGrayscale();
            SetOutputPictureBox(image);
        }

        private void btnApplySepia_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.ApplySepia();
            SetOutputPictureBox(image);
        }

        private void btnShowHistogram_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.GenerateHistogram();
            SetOutputPictureBox(image);
        }

        // =======================
        // SUBTRACT MODE
        // =======================

        private void SetForegroundPictureBox(Bitmap bmp)
        {
            pbForeground.SizeMode = PictureBoxSizeMode.Zoom;
            pbForeground.Image = bmp;
        }

        private void SetBackgroundPictureBox(Bitmap bmp)
        {
            pbBackground.SizeMode = PictureBoxSizeMode.Zoom;
            pbBackground.Image = bmp;
        }

        private void SetSubtractPictureBox(Bitmap bmp)
        {
            pbSubtracted.SizeMode = PictureBoxSizeMode.Zoom;
            pbSubtracted.Image = bmp;
        }

        private void btnLoadForegroundImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog { Filter = "Image Files|*.png;*.jpg;*.jpeg" };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                var image = subtractImageProcessor.LoadForeground(filePath);
                SetForegroundPictureBox(image);
            }
        }

        private void btnLoadBackgroundImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog { Filter = "Image Files|*.png;*.jpg;*.jpeg" };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                var image = subtractImageProcessor.LoadBackground(filePath);
                SetBackgroundPictureBox(image);
            }
        }

        private void btnSaveSubtractImage_Click(object sender, EventArgs e)
        {
            if (subtractImageProcessor.IsOutputNull())
                return;

            var dialog = new SaveFileDialog { Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg" };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                subtractImageProcessor.SaveImage(filePath);
            }
        }

        private void btnClearSubtractMode_Click(object sender, EventArgs e)
        {
            subtractImageProcessor.ClearImages();
            SetForegroundPictureBox(null);
            SetBackgroundPictureBox(null);
            SetSubtractPictureBox(null);
        }

        private void btnSubtractImages_Click(object sender, EventArgs e)
        {
            var image = subtractImageProcessor.SubtractImages();
            SetSubtractPictureBox(image);
        }
    }
}
