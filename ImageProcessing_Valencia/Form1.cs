using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ImageProcessing_Valencia
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private enum WebcamProcessMode { None, Grayscale, Invert, Sepia, Subtract }
        private WebcamProcessMode _webcamMode = WebcamProcessMode.None;

        private BasicImageProcess basicImageProcessor;
        private SubtractProcess subtractImageProcessor;
        int threshold = 5;

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
                SetOutputPictureBox(null);
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
        private void SetConvolutionInputPictureBox(Bitmap bmp)
        {
            imgConvolutionInput.SizeMode = PictureBoxSizeMode.Zoom;
            imgConvolutionInput.Image = bmp;
        }

        private void SetConvolutionOutputPictureBox(Bitmap bmp)
        {
            imgConvolutionOutput.SizeMode = PictureBoxSizeMode.Zoom;
            imgConvolutionOutput.Image = bmp;
        }

        private void btnConvolutionLoadImg_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog { Filter = "Image Files|*.png;*.jpg;*.jpeg" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                var image = basicImageProcessor.LoadImage(filePath);
                SetConvolutionInputPictureBox(image);
                SetConvolutionOutputPictureBox(null);
            }
        }

        private void btnConvolutionSaveImg_Click(object sender, EventArgs e)
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

        private void btnConvolutionClearImg_Click(object sender, EventArgs e)
        {
            basicImageProcessor.ClearImages();
            SetConvolutionInputPictureBox(null);
            SetConvolutionOutputPictureBox(null);
        }

        private void btnConvolutionSmooth_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.SmoothFilter();
            SetConvolutionOutputPictureBox(image);
        }
        private void btnConvolutionSharpen_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.SharpenFilter();
            SetConvolutionOutputPictureBox(image);
        }

        private void btnConvolutionGaussianBlur_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.GaussianBlurFilter();
            SetConvolutionOutputPictureBox(image);
        }

        private void btnConvolutionMeanRemoval_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.MeanRemovalFilter();
            SetConvolutionOutputPictureBox(image);
        }

        private void btnConvolutionLaplascian_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.LaplascianEmboss();
            SetConvolutionOutputPictureBox(image);
        }

        private void btnConvolutionHorizontalVertical_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.HorizontalVerticalEmboss();
            SetConvolutionOutputPictureBox(image);
        }

        private void btnConvolutionAllDirections_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.AllDirectionsEmboss();
            SetConvolutionOutputPictureBox(image);
        }

        private void btnConvolutionLossy_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.LossyEmboss();
            SetConvolutionOutputPictureBox(image);
        }

        private void btnConvolutionHorizontalOnly_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.HorizontalOnlyEmboss();
            SetConvolutionOutputPictureBox(image);
        }

        private void btnConvolutionVerticalOnly_Click(object sender, EventArgs e)
        {
            var image = basicImageProcessor.VerticalOnlyEmboss();
            SetConvolutionOutputPictureBox(image);
        }

        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            // Create processed frame FIRST
            Bitmap processedFrame = ApplyEffectOptimized(frame);

            // Use Invoke to update UI thread safely
            if (pbWebcam.InvokeRequired)
            {
                pbWebcam.Invoke(new Action(() =>
                {
                    UpdateImageView(pbWebcam, (Bitmap)frame.Clone());
                    UpdateImageView(pbWebcamOutput, processedFrame);
                }));
            }
            else
            {
                UpdateImageView(pbWebcam, (Bitmap)frame.Clone());
                UpdateImageView(pbWebcamOutput, processedFrame);
            }

            frame.Dispose();
        }

        private Bitmap ApplyEffectOptimized(Bitmap src)
        {
            Bitmap result = new Bitmap(src.Width, src.Height);

            BitmapData srcData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData resultData = result.LockBits(new Rectangle(0, 0, result.Width, result.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            try
            {
                int bytesPerPixel = 3;
                int width = srcData.Width;
                int height = srcData.Height;

                unsafe
                {
                    byte* srcPtr = (byte*)srcData.Scan0;
                    byte* resultPtr = (byte*)resultData.Scan0;

                    int srcStride = srcData.Stride;
                    int resultStride = resultData.Stride;

                    Parallel.For(0, height, y =>
                    {
                        byte* srcRow = srcPtr + (y * srcStride);
                        byte* resultRow = resultPtr + (y * resultStride);

                        for (int x = 0; x < width; x++)
                        {
                            int pixelIndex = x * bytesPerPixel;
                            byte b = srcRow[pixelIndex];
                            byte g = srcRow[pixelIndex + 1];
                            byte r = srcRow[pixelIndex + 2];

                            ProcessPixelOptimized(resultRow, pixelIndex, r, g, b);
                        }
                    });
                }
            }
            finally
            {
                src.UnlockBits(srcData);
                result.UnlockBits(resultData);
            }

            return result;
        }

        private unsafe void ProcessPixelOptimized(byte* resultRow, int index, byte r, byte g, byte b)
        {
            switch (_webcamMode)
            {
                case WebcamProcessMode.Grayscale:
                    byte gray = (byte)((r * 0.299 + g * 0.587 + b * 0.114));
                    resultRow[index] = gray;     // B
                    resultRow[index + 1] = gray; // G
                    resultRow[index + 2] = gray; // R
                    break;

                case WebcamProcessMode.Invert:
                    resultRow[index] = (byte)(255 - b);     // B
                    resultRow[index + 1] = (byte)(255 - g); // G
                    resultRow[index + 2] = (byte)(255 - r); // R
                    break;

                case WebcamProcessMode.Sepia:
                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    resultRow[index] = (byte)Math.Min(255, tb);     // B
                    resultRow[index + 1] = (byte)Math.Min(255, tg); // G
                    resultRow[index + 2] = (byte)Math.Min(255, tr); // R
                    break;

                case WebcamProcessMode.Subtract:
                    int grayValue = (r + g + b) / 3;
                    int greygreen = 85; // (0 + 255 + 0) / 3 = 85

                    int subtractValue = Math.Abs(grayValue - greygreen);
                    if (subtractValue > threshold)
                    {
                        resultRow[index] = b;     // B
                        resultRow[index + 1] = g; // G
                        resultRow[index + 2] = r; // R
                    }
                    else
                    {
                        resultRow[index] = 0;     // B
                        resultRow[index + 1] = 0; // G
                        resultRow[index + 2] = 0; // R
                    }
                    break;

                default:
                    resultRow[index] = b;     // B
                    resultRow[index + 1] = g; // G
                    resultRow[index + 2] = r; // R
                    break;
            }
        }

        private void UpdateImageView(PictureBox pictureBox, Bitmap newImage)
        {
            var oldImage = pictureBox.Image;
            pictureBox.Image = newImage;
            oldImage?.Dispose();
        }

        private void checkBoxWebcam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWebcam.Checked)
            {
                if (videoDevices == null || videoDevices.Count == 0) return;

                int selectedIndex = comboBoxWebcam.SelectedIndex;
                if (selectedIndex < 0) return;

                videoSource = new VideoCaptureDevice(videoDevices[selectedIndex].MonikerString);
                videoSource.VideoResolution = videoSource.VideoCapabilities[0];
                videoSource.NewFrame += Video_NewFrame;
                videoSource.Start();
            }
            else
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource.NewFrame -= Video_NewFrame;
                    videoSource = null;
                }

                pbWebcam.Image?.Dispose();
                pbWebcam.Image = null;
                pbWebcamOutput.Image?.Dispose();
                pbWebcamOutput.Image = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            comboBoxWebcam.Items.Clear();
            if (videoDevices.Count == 0)
            {
                comboBoxWebcam.Items.Add("No camera found");
                comboBoxWebcam.SelectedIndex = 0;
                return;
            }

            // Add each camera's name to the ComboBox
            foreach (FilterInfo device in videoDevices)
            {
                comboBoxWebcam.Items.Add(device.Name);
            }

            // Select the first camera by default
            comboBoxWebcam.SelectedIndex = 0;
        }

        private void btnWebcamSubtract_Click(object sender, EventArgs e)
        {
            _webcamMode = WebcamProcessMode.Subtract;
        }

        private void btnWebcamInvert_Click(object sender, EventArgs e)
        {
            _webcamMode = WebcamProcessMode.Invert;
        }

        private void btnWebcamClear_Click(object sender, EventArgs e)
        {
            _webcamMode = default;
        }

        private void btnWebcamSepia_Click(object sender, EventArgs e)
        {
            _webcamMode = WebcamProcessMode.Sepia;
        }

        private void btnWebcamGrayscale_Click(object sender, EventArgs e)
        {
            _webcamMode = WebcamProcessMode.Grayscale;
        }
    }
}
