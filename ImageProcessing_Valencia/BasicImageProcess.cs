using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessing_Valencia
{
    internal class BasicImageProcess
    {
        private Bitmap _inputImage, _outputImage;

        public BasicImageProcess()
        {
            _inputImage = null;
            _outputImage = null;
        }

        private void SetInputImage(Bitmap bmp)
        {
            _inputImage = bmp;
        }

        private void SetOutputImage(Bitmap bmp)
        {
            _outputImage = bmp;
        }

        public Bitmap LoadImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return null;

            SetInputImage(new Bitmap(filePath));
            return _inputImage;
        }

        public bool IsOutputNull()
        {
            return _outputImage == null;
        }

        public Bitmap SaveImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || _outputImage == null)
                return null;

            _outputImage.Save(filePath);
            return _outputImage;
        }

        public void ClearImages()
        {
            _inputImage = null;
            _outputImage = null;
        }

        public Bitmap CopyImage()
        {
            if (_inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(_inputImage.Width, _inputImage.Height);

            for (int y = 0; y < _inputImage.Height; y++)
            {
                for (int x = 0; x < _inputImage.Width; x++)
                {
                    Color pixel = _inputImage.GetPixel(x, y);
                    bmp.SetPixel(x, y, pixel);
                }
            }

            SetOutputImage(bmp);
            return _outputImage;
        }

        public Bitmap InvertImage()
        {
            if (_inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(_inputImage.Width, _inputImage.Height);

            for (int y = 0; y < _inputImage.Height; y++)
            {
                for (int x = 0; x < _inputImage.Width; x++)
                {
                    Color pixel = _inputImage.GetPixel(x, y);
                    int r = 255 - pixel.R;
                    int g = 255 - pixel.G;
                    int b = 255 - pixel.B;
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            SetOutputImage(bmp);
            return _outputImage;
        }

        public Bitmap ConvertToGrayscale()
        {
            if (_inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(_inputImage.Width, _inputImage.Height);

            for (int y = 0; y < _inputImage.Height; y++)
            {
                for (int x = 0; x < _inputImage.Width; x++)
                {
                    Color pixel = _inputImage.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            SetOutputImage(bmp);
            return _outputImage;
        }

        public Bitmap ApplySepia()
        {
            if (_inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(_inputImage.Width, _inputImage.Height);

            for (int y = 0; y < _inputImage.Height; y++)
            {
                for (int x = 0; x < _inputImage.Width; x++)
                {
                    Color pixel = _inputImage.GetPixel(x, y);

                    int tr = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int tg = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int tb = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                    int r = Math.Min(255, tr);
                    int g = Math.Min(255, tg);
                    int b = Math.Min(255, tb);

                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            SetOutputImage(bmp);
            return _outputImage;
        }

        public Bitmap GenerateHistogram()
        {
            if (_inputImage == null)
                return null;

            int histWidth = 256;
            int histHeight = 120;
            Bitmap histBmp = new Bitmap(histWidth, histHeight);

            int[] histogram = new int[256];
            for (int y = 0; y < _inputImage.Height; y++)
            {
                for (int x = 0; x < _inputImage.Width; x++)
                {
                    Color pixel = _inputImage.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    histogram[gray]++;
                }
            }

            int max = histogram.Max();
            using (Graphics g = Graphics.FromImage(histBmp))
            {
                g.Clear(Color.White);

                for (int x = 0; x < histWidth; x++)
                {
                    int h = (int)((histogram[x] / (float)max) * 100);
                    g.DrawLine(Pens.Black, x, histHeight - 20, x, histHeight - 20 - h);
                }

                g.DrawLine(Pens.Black, 0, histHeight - 20, histWidth - 1, histHeight - 20);
                g.DrawLine(Pens.Black, 0, histHeight - 20, 0, 0);

                int[] xLabels = { 0, 64, 128, 192, 255 };
                foreach (int label in xLabels)
                {
                    g.DrawLine(Pens.Gray, label, histHeight - 20, label, histHeight - 15);
                    g.DrawString(label.ToString(), new Font("Arial", 7), Brushes.Black, label - 10, histHeight - 15);
                }

                int[] yLabels = { 0, max / 2, max };
                for (int i = 0; i < yLabels.Length; i++)
                {
                    int y = histHeight - 20 - (int)((yLabels[i] / (float)max) * 100);
                    g.DrawLine(Pens.Gray, 0, y, 5, y);
                    g.DrawString(yLabels[i].ToString(), new Font("Arial", 7), Brushes.Black, 7, y - 7);
                }

                g.DrawString("Gray Level", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, histWidth / 2 - 30, histHeight - 10);
                g.DrawString("Frequency", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 0, 0);
            }

            Bitmap scaledBmp = new Bitmap(500, 420);
            using (Graphics g = Graphics.FromImage(scaledBmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.Clear(Color.White);
                g.DrawImage(histBmp, 0, 0, 500, 420);
            }

            SetOutputImage(scaledBmp);
            return _outputImage;
        }
    }
}
