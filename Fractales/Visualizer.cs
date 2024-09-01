using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractales
{
    public partial class Visualizer : Form
    {
        private Fractal fractal;
        private Bitmap fractalBitmap;
        private double zoom = 1.0;
        private double moveX = 0.0;
        private double moveY = 0.0;
        private double cRe = -0.7;
        private double cIm = 0.27015;
        private const double moveStep = 0.04;

        public Visualizer()
        {
            InitializeComponent();
            fractal = new Fractal();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(OnKeyDown);
            this.Resize += new EventHandler(this.OnResize);
            picCanvas.Paint += new PaintEventHandler(OnPaint);
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            DrawJuliaSet();
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            zoom = Math.Pow(2, zoomBar.Value / 10.0);
            DrawJuliaSet();
        }

        private void OnResize(object sender, EventArgs e)
        {
            picCanvas.Width = this.ClientSize.Width;
            picCanvas.Height = this.ClientSize.Height;
            DrawJuliaSet();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    moveY -= moveStep / zoom;
                    break;
                case Keys.S:
                    moveY += moveStep / zoom;
                    break;
                case Keys.A:
                    moveX -= moveStep / zoom;
                    break;
                case Keys.D:
                    moveX += moveStep / zoom;
                    break;
            }
            picCanvas.Invalidate(); // Forzar redibujado del PictureBox
        }

        private void DrawJuliaSet()
        {
            if (fractal != null)
            {
                // Generar el fractal en un bitmap más grande
                fractalBitmap = fractal.GenerateJuliaSetBitmap(zoom, moveX, moveY, cRe, cIm, picCanvas.ClientSize);
                picCanvas.Invalidate(); // Forzar redibujado del PictureBox
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (fractalBitmap != null)
            {
                // Dibujar una porción del bitmap en el PictureBox
                e.Graphics.DrawImage(fractalBitmap, 0, 0, picCanvas.ClientSize.Width, picCanvas.ClientSize.Height);
            }
        }
    }
}
