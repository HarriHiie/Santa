namespace FlappySanta
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maja = new System.Windows.Forms.PictureBox();
            this.kuu = new System.Windows.Forms.PictureBox();
            this.Jõuluvana = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Kuusk = new System.Windows.Forms.PictureBox();
            this.Lumehelves = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jõuluvana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kuusk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lumehelves)).BeginInit();
            this.SuspendLayout();
            // 
            // maja
            // 
            this.maja.Image = ((System.Drawing.Image)(resources.GetObject("maja.Image")));
            this.maja.Location = new System.Drawing.Point(52, 510);
            this.maja.Name = "maja";
            this.maja.Size = new System.Drawing.Size(194, 212);
            this.maja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maja.TabIndex = 0;
            this.maja.TabStop = false;
            this.maja.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kuu
            // 
            this.kuu.Image = ((System.Drawing.Image)(resources.GetObject("kuu.Image")));
            this.kuu.Location = new System.Drawing.Point(-1, 12);
            this.kuu.Name = "kuu";
            this.kuu.Size = new System.Drawing.Size(151, 120);
            this.kuu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kuu.TabIndex = 1;
            this.kuu.TabStop = false;
            // 
            // Jõuluvana
            // 
            this.Jõuluvana.Image = ((System.Drawing.Image)(resources.GetObject("Jõuluvana.Image")));
            this.Jõuluvana.Location = new System.Drawing.Point(196, 323);
            this.Jõuluvana.Name = "Jõuluvana";
            this.Jõuluvana.Size = new System.Drawing.Size(289, 123);
            this.Jõuluvana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jõuluvana.TabIndex = 2;
            this.Jõuluvana.TabStop = false;
            this.Jõuluvana.Click += new System.EventHandler(this.Jõuluvana_Click);
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(-1, 718);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1438, 87);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            this.Ground.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Kuusk
            // 
            this.Kuusk.Image = ((System.Drawing.Image)(resources.GetObject("Kuusk.Image")));
            this.Kuusk.Location = new System.Drawing.Point(863, 530);
            this.Kuusk.Name = "Kuusk";
            this.Kuusk.Size = new System.Drawing.Size(127, 192);
            this.Kuusk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kuusk.TabIndex = 4;
            this.Kuusk.TabStop = false;
            // 
            // Lumehelves
            // 
            this.Lumehelves.Image = ((System.Drawing.Image)(resources.GetObject("Lumehelves.Image")));
            this.Lumehelves.Location = new System.Drawing.Point(951, 135);
            this.Lumehelves.Name = "Lumehelves";
            this.Lumehelves.Size = new System.Drawing.Size(85, 87);
            this.Lumehelves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lumehelves.TabIndex = 5;
            this.Lumehelves.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ScoreLabel.Location = new System.Drawing.Point(12, 135);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(115, 31);
            this.ScoreLabel.TabIndex = 6;
            this.ScoreLabel.Text = "Score: 0";
            this.ScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1195, 805);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Lumehelves);
            this.Controls.Add(this.Kuusk);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Jõuluvana);
            this.Controls.Add(this.kuu);
            this.Controls.Add(this.maja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.maja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jõuluvana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kuusk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lumehelves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox maja;
        private System.Windows.Forms.PictureBox kuu;
        private System.Windows.Forms.PictureBox Jõuluvana;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Kuusk;
        private System.Windows.Forms.PictureBox Lumehelves;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

