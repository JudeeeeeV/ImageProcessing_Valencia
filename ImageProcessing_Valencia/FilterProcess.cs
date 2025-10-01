using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing_Valencia
{
    internal static class FilterProcess
    {
        public static bool Conv3x3(Bitmap image, ConvolutionMatrix matrix)
        {
            // Avoid divide by zero errors
            if (matrix.Factor == 0)
                return false;

            // GDI+ uses BGR, not RGB
            Bitmap sourceImage = (Bitmap)image.Clone();

            BitmapData imageData = image.LockBits(
                new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            BitmapData sourceData = sourceImage.LockBits(
                new Rectangle(0, 0, sourceImage.Width, sourceImage.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            int stride = imageData.Stride;
            int stride2 = stride * 2;

            IntPtr scan0 = imageData.Scan0;
            IntPtr srcScan0 = sourceData.Scan0;

            unsafe
            {
                byte* pixelPtr = (byte*)(void*)scan0;
                byte* srcPixelPtr = (byte*)(void*)srcScan0;

                int offset = stride - image.Width * 3;
                int width = image.Width - 2;
                int height = image.Height - 2;

                int pixelValue;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        // Blue channel
                        pixelValue = ((((srcPixelPtr[2] * matrix.TopLeft) +
                            (srcPixelPtr[5] * matrix.TopMid) +
                            (srcPixelPtr[8] * matrix.TopRight) +
                            (srcPixelPtr[2 + stride] * matrix.MidLeft) +
                            (srcPixelPtr[5 + stride] * matrix.Pixel) +
                            (srcPixelPtr[8 + stride] * matrix.MidRight) +
                            (srcPixelPtr[2 + stride2] * matrix.BottomLeft) +
                            (srcPixelPtr[5 + stride2] * matrix.BottomMid) +
                            (srcPixelPtr[8 + stride2] * matrix.BottomRight))
                            / matrix.Factor) + matrix.Offset);

                        if (pixelValue < 0) pixelValue = 0;
                        if (pixelValue > 255) pixelValue = 255;

                        pixelPtr[5 + stride] = (byte)pixelValue;

                        // Green channel
                        pixelValue = ((((srcPixelPtr[1] * matrix.TopLeft) +
                            (srcPixelPtr[4] * matrix.TopMid) +
                            (srcPixelPtr[7] * matrix.TopRight) +
                            (srcPixelPtr[1 + stride] * matrix.MidLeft) +
                            (srcPixelPtr[4 + stride] * matrix.Pixel) +
                            (srcPixelPtr[7 + stride] * matrix.MidRight) +
                            (srcPixelPtr[1 + stride2] * matrix.BottomLeft) +
                            (srcPixelPtr[4 + stride2] * matrix.BottomMid) +
                            (srcPixelPtr[7 + stride2] * matrix.BottomRight))
                            / matrix.Factor) + matrix.Offset);

                        if (pixelValue < 0) pixelValue = 0;
                        if (pixelValue > 255) pixelValue = 255;

                        pixelPtr[4 + stride] = (byte)pixelValue;

                        // Red channel
                        pixelValue = ((((srcPixelPtr[0] * matrix.TopLeft) +
                            (srcPixelPtr[3] * matrix.TopMid) +
                            (srcPixelPtr[6] * matrix.TopRight) +
                            (srcPixelPtr[0 + stride] * matrix.MidLeft) +
                            (srcPixelPtr[3 + stride] * matrix.Pixel) +
                            (srcPixelPtr[6 + stride] * matrix.MidRight) +
                            (srcPixelPtr[0 + stride2] * matrix.BottomLeft) +
                            (srcPixelPtr[3 + stride2] * matrix.BottomMid) +
                            (srcPixelPtr[6 + stride2] * matrix.BottomRight))
                            / matrix.Factor) + matrix.Offset);

                        if (pixelValue < 0) pixelValue = 0;
                        if (pixelValue > 255) pixelValue = 255;

                        pixelPtr[3 + stride] = (byte)pixelValue;

                        pixelPtr += 3;
                        srcPixelPtr += 3;
                    }

                    pixelPtr += offset;
                    srcPixelPtr += offset;
                }
            }

            image.UnlockBits(imageData);
            sourceImage.UnlockBits(sourceData);
            return true;
        }

        public static bool Smooth(Bitmap image, int weight = 1)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.SetAll(1);
            matrix.Pixel = weight;
            matrix.Factor = weight + 8;
            return Conv3x3(image, matrix);
        }

        public static bool GaussianBlur(Bitmap image)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();

            matrix.TopLeft = 1; matrix.TopMid = 2; matrix.TopRight = 1;
            matrix.MidLeft = 2; matrix.Pixel = 4; matrix.MidRight = 2;
            matrix.BottomLeft = 1; matrix.BottomMid = 2; matrix.BottomRight = 1;

            matrix.Factor = 16;
            matrix.Offset = 0;

            return Conv3x3(image, matrix);
        }

        public static bool Sharpen(Bitmap image)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.SetAll(0);
            matrix.Pixel = 11;
            matrix.TopMid = matrix.MidLeft = matrix.MidRight = matrix.BottomMid = -2;
            matrix.Factor = 3;
            return Conv3x3(image, matrix);
        }

        public static bool MeanRemoval(Bitmap image)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();

            matrix.TopLeft = -1; matrix.TopMid = -1; matrix.TopRight = -1;
            matrix.MidLeft = -1; matrix.Pixel = 9; matrix.MidRight = -1;
            matrix.BottomLeft = -1; matrix.BottomMid = -1; matrix.BottomRight = -1;
            matrix.Factor = 1;
            matrix.Offset = 0;
            return Conv3x3(image, matrix);
        }

        public static bool Emboss(Bitmap image)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();

            matrix.TopLeft = -1; matrix.TopMid = 0; matrix.TopRight = -1;
            matrix.MidLeft = 0; matrix.Pixel = 4; matrix.MidRight = 0;
            matrix.BottomLeft = -1; matrix.BottomMid = 0; matrix.BottomRight = -1;
            matrix.Factor = 1;
            matrix.Offset = 127;
            return Conv3x3(image, matrix);
        }

        public static bool EmbossHorizontalVertical(Bitmap image)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.TopLeft = 0; matrix.TopMid = -1; matrix.TopRight = 0;
            matrix.MidLeft = -1; matrix.Pixel = 4; matrix.MidRight = -1;
            matrix.BottomLeft = 0; matrix.BottomMid = -1; matrix.BottomRight = 0;
            matrix.Factor = 1;
            matrix.Offset = 127;
            return Conv3x3(image, matrix);
        }

        public static bool EmbossAllDirections(Bitmap image)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.TopLeft = -1; matrix.TopMid = -1; matrix.TopRight = 1;
            matrix.MidLeft = -1; matrix.Pixel = 8; matrix.MidRight = -1;
            matrix.BottomLeft = 1; matrix.BottomMid = -1; matrix.BottomRight = 1;
            matrix.Factor = 1;
            matrix.Offset = 127;
            return Conv3x3(image, matrix);
        }

        public static bool EmbossLossy(Bitmap image)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.TopLeft = 1; matrix.TopMid = -2; matrix.TopRight = 1;
            matrix.MidLeft = -2; matrix.Pixel = 4; matrix.MidRight = -2;
            matrix.BottomLeft = -1; matrix.BottomMid = 1; matrix.BottomRight = -2;
            matrix.Factor = 1;
            matrix.Offset = 127;
            return Conv3x3(image, matrix);
        }

        public static bool EmbossHorizontalOnly(Bitmap image)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.TopLeft = 0; matrix.TopMid = 0; matrix.TopRight = 0;
            matrix.MidLeft = -1; matrix.Pixel = 2; matrix.MidRight = -1;
            matrix.BottomLeft = 0; matrix.BottomMid = 0; matrix.BottomRight = 0;
            matrix.Factor = 1;
            matrix.Offset = 127;
            return Conv3x3(image, matrix);
        }

        public static bool EmbossVerticalOnly(Bitmap image)
        {
            ConvolutionMatrix matrix = new ConvolutionMatrix();
            matrix.TopLeft = 0; matrix.TopMid = -1; matrix.TopRight = 0;
            matrix.MidLeft = 0; matrix.Pixel = 0; matrix.MidRight = 0;
            matrix.BottomLeft = 0; matrix.BottomMid = 1; matrix.BottomRight = 0;
            matrix.Factor = 1;
            matrix.Offset = 127;
            return Conv3x3(image, matrix);
        }
    }
}
