using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

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
        private const double moveStep = 0.01;
        private BackgroundWorker renderWorker;

        public Visualizer()
        {
            InitializeComponent();
            fractal = new Fractal();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(OnPressKey);
            this.Resize += new EventHandler(OnResize);
            this.MouseWheel += new MouseEventHandler(OnMouseWheel); // Evento para la rueda del mouse
            picCanvas.Paint += new PaintEventHandler(OnPaint);

            renderWorker = new BackgroundWorker();
            renderWorker.DoWork += new DoWorkEventHandler(RenderFractal);
            renderWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnRenderCompleted);

            iterationsBar.Minimum = 100;
            iterationsBar.Maximum = 5000;
            iterationsBar.Value = 250;
            iterationsBar.Scroll += new EventHandler(iterationsBar_Scroll);
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            // Capturar los valores de cRe y cIm desde los TextBox
            if (double.TryParse(txtCRe.Text, out double parsedCRe))
            {
                cRe = parsedCRe;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido para cRe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(txtCIm.Text, out double parsedCIm))
            {
                cIm = parsedCIm;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido para cIm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StartRendering();
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            zoom = 1.0;
            zoomBar.Value = 10;
            iterationsBar.Value = 300;
            moveX = 0.0;
            moveY = 0.0;
            cRe = -0.7;
            cIm = 0.27015;
            StartRendering();
        }

        private void iterationsBar_Scroll(object sender, EventArgs e)
        {
            StartRendering();
        }

        private void OnResize(object sender, EventArgs e)
        {
            picCanvas.Width = this.ClientSize.Width;
            picCanvas.Height = this.ClientSize.Height;
            StartRendering();
        }

        private void OnPressKey(object sender, KeyEventArgs e)
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
            StartRendering();
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                zoom *= 1.1; // Aumenta el zoom
            }
            else if (e.Delta < 0)
            {
                zoom /= 1.1; // Disminuye el zoom
            }
            StartRendering();
        }

        private void StartRendering()
        {
            if (!renderWorker.IsBusy)
            {
                renderWorker.RunWorkerAsync(new { Zoom = zoom, MoveX = moveX, MoveY = moveY, Width = picCanvas.ClientSize.Width, Height = picCanvas.ClientSize.Height, MaxIteration = iterationsBar.Value });
            }
        }

        private void RenderFractal(object sender, DoWorkEventArgs e)
        {
            var args = (dynamic)e.Argument;
            double zoom = args.Zoom;
            double moveX = args.MoveX;
            double moveY = args.MoveY;
            int width = args.Width;
            int height = args.Height;
            int maxIteration = args.MaxIteration;

            fractalBitmap = fractal.JuliaSetBitmap(zoom, moveX, moveY, cRe, cIm, new Size(width, height), maxIteration);
        }

        private void OnRenderCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picCanvas.Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (fractalBitmap != null)
            {
                using (BufferedGraphics bufferedGraphics = BufferedGraphicsManager.Current.Allocate(e.Graphics, picCanvas.ClientRectangle))
                {
                    bufferedGraphics.Graphics.DrawImage(fractalBitmap, 0, 0, picCanvas.ClientSize.Width, picCanvas.ClientSize.Height);
                    bufferedGraphics.Render();
                }
            }
        }
    }
}
