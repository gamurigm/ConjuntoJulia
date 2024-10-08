﻿namespace Fractales
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
            this.button1 = new System.Windows.Forms.Button();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.iterationsBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCRe = new System.Windows.Forms.TextBox();
            this.txtCIm = new System.Windows.Forms.TextBox();
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
            this.grbCanvas.Location = new System.Drawing.Point(140, 15);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(634, 429);
            this.grbCanvas.TabIndex = 1;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Canvas";
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.Location = new System.Drawing.Point(6, 21);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(622, 402);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // BtnGraficar
            // 
            this.BtnGraficar.Location = new System.Drawing.Point(16, 162);
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
            this.grbControles.Controls.Add(this.txtCIm);
            this.grbControles.Controls.Add(this.txtCRe);
            this.grbControles.Controls.Add(this.label4);
            this.grbControles.Controls.Add(this.label3);
            this.grbControles.Controls.Add(this.button1);
            this.grbControles.Controls.Add(this.BtnGraficar);
            this.grbControles.Location = new System.Drawing.Point(23, 101);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(111, 271);
            this.grbControles.TabIndex = 0;
            this.grbControles.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // zoomBar
            // 
            this.zoomBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.zoomBar.Location = new System.Drawing.Point(140, 463);
            this.zoomBar.Maximum = 100;
            this.zoomBar.Minimum = 1;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(628, 64);
            this.zoomBar.TabIndex = 2;
            this.zoomBar.Value = 1;
            // 
            // iterationsBar
            // 
            this.iterationsBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iterationsBar.Location = new System.Drawing.Point(146, 533);
            this.iterationsBar.Maximum = 5000;
            this.iterationsBar.Minimum = 100;
            this.iterationsBar.Name = "iterationsBar";
            this.iterationsBar.Size = new System.Drawing.Size(628, 64);
            this.iterationsBar.TabIndex = 3;
            this.iterationsBar.Value = 100;
            this.iterationsBar.Scroll += new System.EventHandler(this.iterationsBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zoom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Iteraciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "cRe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "cIm:";
            // 
            // txtCRe
            // 
            this.txtCRe.Location = new System.Drawing.Point(25, 42);
            this.txtCRe.Name = "txtCRe";
            this.txtCRe.Size = new System.Drawing.Size(70, 22);
            this.txtCRe.TabIndex = 4;
            // 
            // txtCIm
            // 
            this.txtCIm.Location = new System.Drawing.Point(25, 98);
            this.txtCIm.Name = "txtCIm";
            this.txtCIm.Size = new System.Drawing.Size(70, 22);
            this.txtCIm.TabIndex = 5;
            // 
            // Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterationsBar);
            this.Controls.Add(this.zoomBar);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbControles);
            this.Name = "Visualizer";
            this.Text = "JuliaSet Visualizer";
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbControles.ResumeLayout(false);
            this.grbControles.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCIm;
        private System.Windows.Forms.TextBox txtCRe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

