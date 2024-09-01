using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractales
{
    internal class Fractal
    {
        
        public Fractal() {}

        public void DrawJuliaSet(PictureBox picCanvas, double zoom, double moveX, double moveY, double cRe, double cIm)
        {
            int width = picCanvas.Width;
            int height = picCanvas.Height;
            Bitmap bmp = new Bitmap(width, height);

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

                    // Calcular el color basado en el número de iteraciones
                    Color color = GetColor(iteration); // Método que defines para calcular el color
                    bmp.SetPixel(x, y, color);
                }
            }

            picCanvas.Image?.Dispose(); // Liberar la imagen anterior para evitar fugas de memoria
            picCanvas.Image = bmp;
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
