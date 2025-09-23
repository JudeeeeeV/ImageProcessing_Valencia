using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabada_IntSys1_ImageProcessingProgram;

namespace ImageProcessing_Valencia
{
    public partial class Form1 : Form
    {

        private BasicImageProcess _basicProcessor;
        private SubtractProcess _subtractProcessor;


        public Form1()
        {
            InitializeComponent();
            _basicProcessor = new BasicImageProcess();
            _subtractProcessor = new SubtractProcess();
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
            var dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg"
            };

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = dialog.FileName;

                var image = new Bitmap(filePath);
                _basicProcessor.OnLoadImage(filePath);

                SetInputPictureBox(image);
            }
        }

        private void btnSaveBasicImage_Click(object sender, EventArgs e)
        {
            if (_basicProcessor.isOutputNull())
                return;

            var dialog = new SaveFileDialog
            {
                Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg"
            };

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                _basicProcessor.OnSaveImage(filePath);
            }
        }

        private void btnClearBasicMode_Click(object sender, EventArgs e)
        {
            _basicProcessor.OnClear();
            SetInputPictureBox(null);
            SetOutputPictureBox(null);
        }

        private void btnCopyImage_Click(object sender, EventArgs e)
        {
            var image = _basicProcessor.OnCopy();
            SetOutputPictureBox(image);
        }

        private void btnApplyInvert_Click(object sender, EventArgs e)
        {
            var image = _basicProcessor.OnInvert();
            SetOutputPictureBox(image);
        }

        private void btnApplyGrayscale_Click(object sender, EventArgs e)
        {
            var image = _basicProcessor.OnGrayScale();
            SetOutputPictureBox(image);
        }

        private void btnApplySepia_Click(object sender, EventArgs e)
        {
            var image = _basicProcessor.OnSepia();
            SetOutputPictureBox(image);
        }

        private void btnShowHistogram_Click(object sender, EventArgs e)
        {
            var image = _basicProcessor.OnHistogram();
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
            var dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg"
            };

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = dialog.FileName;

                var image = new Bitmap(filePath);
                _subtractProcessor.OnLoadForeground(filePath);

                SetForegroundPictureBox(image);
            }
        }

        private void btnLoadBackgroundImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg"
            };

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = dialog.FileName;

                var image = new Bitmap(filePath);
                _subtractProcessor.OnLoadBackground(filePath);

                SetBackgroundPictureBox(image);
            }
        }

        private void btnSaveSubtractImage_Click(object sender, EventArgs e)
        {
            if (_subtractProcessor.isOutputNull())
                return;

            var dialog = new SaveFileDialog
            {
                Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg"
            };

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                _subtractProcessor.OnSaveImage(filePath);
            }
        }

        private void btnClearSubtractMode_Click(object sender, EventArgs e)
        {
            _subtractProcessor.OnClear();
            SetForegroundPictureBox(null);
            SetBackgroundPictureBox(null);
            SetSubtractPictureBox(null);
        }

        private void btnSubtractImages_Click(object sender, EventArgs e)
        {
            var image = _subtractProcessor.OnSubtract();
            SetSubtractPictureBox(image);
        }

        private void btnApplyInvert_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLoadBasicImage_Click(object sender, EventArgs e)
        {
 
            var dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                var image = new Bitmap(filePath);
                _basicProcessor.OnLoadImage(filePath);

                pbInput.Image = image;
            
        }
    }

        private void lblSubtracted_Click(object sender, EventArgs e)
        {

        }
    }
}
