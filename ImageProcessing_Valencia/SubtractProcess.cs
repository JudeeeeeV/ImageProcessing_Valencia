using System;
using System.Drawing;

namespace ImageProcessing_Valencia
{
    internal class SubtractProcess
    {
        private Bitmap _foreground, _background, _outputImage;

        public SubtractProcess()
        {
            _foreground = null;
            _background = null;
            _outputImage = null;
        }

        private void SetForegroundImage(Bitmap bmp)
        {
            _foreground = bmp;
        }

        private void SetBackgroundImage(Bitmap bmp)
        {
            _background = bmp;
        }

        private void SetOutputImage(Bitmap bmp)
        {
            _outputImage = bmp;
        }

        public Bitmap LoadForeground(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return null;

            SetForegroundImage(new Bitmap(filePath));
            return _foreground;
        }

        public Bitmap LoadBackground(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return null;

            SetBackgroundImage(new Bitmap(filePath));
            return _background;
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
            _foreground = null;
            _background = null;
            _outputImage = null;
        }

        public Bitmap SubtractImages()
        {
            if (_foreground == null || _background == null)
                return null;

            int width = Math.Min(_foreground.Width, _background.Width);
            int height = Math.Min(_foreground.Height, _background.Height);

            // Color to subtract (green screen effect)
            Color colorToSubtract = Color.FromArgb(0, 255, 0);
            int greyCTS = (colorToSubtract.R + colorToSubtract.G + colorToSubtract.B) / 3;
            int threshold = 5;

            Bitmap bmp = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color fgPixel = _foreground.GetPixel(x, y);
                    Color bgPixel = _background.GetPixel(x, y);

                    int greyFG = (fgPixel.R + fgPixel.G + fgPixel.B) / 3;
                    int subtractValue = Math.Abs(greyFG - greyCTS);

                    if (subtractValue > threshold)
                        bmp.SetPixel(x, y, fgPixel);
                    else
                        bmp.SetPixel(x, y, bgPixel);
                }
            }

            SetOutputImage(bmp);
            return _outputImage;
        }
    }
}
