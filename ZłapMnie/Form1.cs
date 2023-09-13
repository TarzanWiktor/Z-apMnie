using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZłapMnie
{
    
    public partial class Form1 : Form
    {
        Random r;
        int punkty;
        public Form1()
        {

            InitializeComponent();
            r = new Random();
            timer1.Start();
            punkty = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveButton();
            toolStripStatusLabel1.Text = "Punkty: " + punkty.ToString();
            punkty = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveButton();
            punkty++;
            toolStripStatusLabel1.Text = "Punkty: " + punkty.ToString();
            timer1.Stop();
            timer1.Start();
        }

        private void MoveButton()
        {
            int maxX = this.Size.Width - button1.Size.Width - 50;
            int maxY = this.Size.Height - button1.Size.Height - 50;
            Point p = new Point();
            p.X = r.Next(12, maxX);
            p.Y = r.Next(12, maxY);
            button1.Location = p;
        }
    }
}
