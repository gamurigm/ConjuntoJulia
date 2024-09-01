using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractales
{
    public partial class Visualizer : Form
    {
        private Fractal fractal;
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

            if (zoomBar != null)
            {
                zoomBar.Minimum = 10;
                zoomBar.Maximum = 100;
                zoomBar.Value = 12;
            }

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(OnKeyDown);
            this.Resize += new EventHandler(this.OnResize);
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
            if (picCanvas.Width != this.ClientSize.Width || picCanvas.Height != this.ClientSize.Height)
            {
                picCanvas.Width = this.ClientSize.Width;
                picCanvas.Height = this.ClientSize.Height;
                DrawJuliaSet();
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    moveY -= moveStep;
                    break;
                case Keys.S:
                    moveY += moveStep;
                    break;
                case Keys.A:
                    moveX -= moveStep;
                    break;
                case Keys.D:
                    moveX += moveStep;
                    break;
            }
            DrawJuliaSet();
        }

        private void DrawJuliaSet()
        {
            if (fractal != null && picCanvas != null && picCanvas.Width > 0 && picCanvas.Height > 0)
            {
                fractal.DrawJuliaSet(picCanvas, zoom, moveX, moveY, cRe, cIm);
            }
        }
    }
}
