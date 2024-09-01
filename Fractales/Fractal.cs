using System;
using System.Drawing;

namespace Fractales
{
    internal class Fractal
    {
        public Bitmap JuliaSetBitmap(double zoom, double moveX, double moveY, double cRe, double cIm, Size size, int maxIterations)
        {
            int width = size.Width;
            int height = size.Height;
            Bitmap bitmap = new Bitmap(width, height);

            // Definir los límites de las coordenadas en función del zoom y el desplazamiento
            double xMin = -1.5 / zoom + moveX;
            double xMax = 1.5 / zoom + moveX;
            double yMin = -1.5 / zoom + moveY;
            double yMax = 1.5 / zoom + moveY;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double zx = xMin + (xMax - xMin) * x / width;
                    double zy = yMin + (yMax - yMin) * y / height;
                    int iteration = 0;

                    while (zx * zx + zy * zy < 4 && iteration < maxIterations)
                    {
                        double tmp = zx * zx - zy * zy + cRe;
                        zy = 2.0 * zx * zy + cIm;
                        zx = tmp;
                        iteration++;
                    }

                    Color color = GetColor(iteration, maxIterations);
                    bitmap.SetPixel(x, y, color);
                }
            }

            return bitmap;
        }


        private Color GetColor(int iteration, int maxIteration)
        {
            double t = (double)iteration / maxIteration;
            int r = (int)(9 * (1 - t) * t * t * t * 255);
            int g = (int)(15 * (1 - t) * (1 - t) * t * t * 255);
            int b = (int)(8.5 * (1 - t) * (1 - t) * (1 - t) * t * 255);
            return Color.FromArgb(r, g, b);
        }
    }
}
