using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private ArrayList coordinates = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                coordinates.Add(p);
                Invalidate();
            }
            if (e.Button == MouseButtons.Right)
            {
                coordinates.Clear();
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            const int WIDTH = 20;
            const int HEIGHT = 20;
            Graphics g = e.Graphics;
            foreach (Point p in coordinates)
            {
                g.FillEllipse(Brushes.Black, p.X - WIDTH / 2, p.Y - WIDTH / 2, WIDTH, HEIGHT);
                string placement = "(" + p.X + ", " + p.Y + ")";
                g.DrawString(placement, Font, Brushes.Black, p.X + 20, p.Y - 7);
                    
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            coordinates.Clear();
            Invalidate();
        }


        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coordinates.Clear();
            Invalidate();
        }
    }
}
