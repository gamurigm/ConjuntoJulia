using System;
using System.Drawing;

namespace Fractales
{
    internal class Fractal
    {
        public Bitmap GenerateJuliaSetBitmap(double zoom, double moveX, double moveY, double cRe, double cIm, Size size)
        {
            int width = size.Width * 2;  // Aumentar el tamaño para permitir el desplazamiento
            int height = size.Height * 2;

            Bitmap bitmap = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double zx = 1.5 * (x - width / 2) / (0.5 * zoom * width) + moveX;
                    double zy = (y - height / 2) / (0.5 * zoom * height) + moveY;
                    int iteration = 0;
                    int maxIteration = 300;

                    while (zx * zx + zy * zy < 4 && iteration < maxIteration)
                    {
                        double tmp = zx * zx - zy * zy + cRe;
                        zy = 2.0 * zx * zy + cIm;
                        zx = tmp;
                        iteration++;
                    }

                    Color color = GetColor(iteration);
                    bitmap.SetPixel(x, y, color);
                }
            }

            return bitmap;
        }

        private Color GetColor(int iteration)
        {
            double t = (double)iteration / 300;
            int r = (int)(9 * (1 - t) * t * t * t * 255);
            int g = (int)(15 * (1 - t) * (1 - t) * t * t * 255);
            int b = (int)(8.5 * (1 - t) * (1 - t) * (1 - t) * t * 255);
            return Color.FromArgb(r, g, b);
        }
    }
}
