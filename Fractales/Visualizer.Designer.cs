namespace Fractales
{
    partial class Visualizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.BtnGraficar = new System.Windows.Forms.Button();
            this.grbControles = new System.Windows.Forms.GroupBox();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.iterationsBar = new System.Windows.Forms.TrackBar();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsBar)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCanvas
            // 
            this.grbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(146, 15);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(628, 429);
            this.grbCanvas.TabIndex = 1;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Canvas";
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.Location = new System.Drawing.Point(6, 36);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(616, 387);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // BtnGraficar
            // 
            this.BtnGraficar.Location = new System.Drawing.Point(7, 64);
            this.BtnGraficar.Name = "BtnGraficar";
            this.BtnGraficar.Size = new System.Drawing.Size(75, 23);
            this.BtnGraficar.TabIndex = 0;
            this.BtnGraficar.Text = "Graficar";
            this.BtnGraficar.UseVisualStyleBackColor = true;
            this.BtnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // grbControles
            // 
            this.grbControles.AccessibleDescription = "grbControles";
            this.grbControles.Controls.Add(this.BtnGraficar);
            this.grbControles.Location = new System.Drawing.Point(33, 14);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(94, 345);
            this.grbControles.TabIndex = 0;
            this.grbControles.TabStop = false;
            this.grbControles.Text = "Controles";
            // 
            // zoomBar
            // 
            this.zoomBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.zoomBar.Location = new System.Drawing.Point(140, 463);
            this.zoomBar.Maximum = 100;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(628, 64);
            this.zoomBar.TabIndex = 2;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // iterationsBar
            // 
            this.iterationsBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iterationsBar.Location = new System.Drawing.Point(146, 533);
            this.iterationsBar.Maximum = 100;
            this.iterationsBar.Name = "iterationsBar";
            this.iterationsBar.Size = new System.Drawing.Size(628, 64);
            this.iterationsBar.TabIndex = 3;
            this.iterationsBar.Scroll += new System.EventHandler(this.iterationsBar_Scroll);
            // 
            // Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.iterationsBar);
            this.Controls.Add(this.zoomBar);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbControles);
            this.Name = "Visualizer";
            this.Text = "JuliaSet Visualizer";
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button BtnGraficar;
        private System.Windows.Forms.GroupBox grbControles;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.TrackBar iterationsBar;
    }
}

