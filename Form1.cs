using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappySanta
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int KuuskSpeed = 6;
        int LumehelvesSpeed = 6;
        int score = 0;

        

        
            
            public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Jõuluvana.Top += gravity;
            Kuusk.Left -= KuuskSpeed;
            Lumehelves.Left -= LumehelvesSpeed;

            if (Kuusk.Left < -100)
                Kuusk.Left = 1300;
            score++;

            if (Lumehelves.Left < -100)
                Lumehelves.Left = 1300;
            score++;

            if (Jõuluvana.Bounds.IntersectsWith(Kuusk.Bounds) || Jõuluvana.Bounds.IntersectsWith(Lumehelves.Bounds) ||
                    Jõuluvana.Bounds.IntersectsWith(Ground.Bounds)) { }

                ScoreLabel.Text = $"score: {score}";



           

        }

           
           

           

       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -5;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 5;
        }

        private void Jõuluvana_Click(object sender, EventArgs e)
        {

        }

        private void gameOver()
        {
            timer1.Stop();
        }
    }
}
