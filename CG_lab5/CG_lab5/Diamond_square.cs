using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_lab5
{
    public partial class Diamond_square : Form
    {
        Bitmap bmp;
        Graphics g;
        Pen pen = new Pen(Color.Black);
        Pen pen_white = new Pen(Color.White);
        PointF from, to;
        double r;

        public Diamond_square()
        {
            InitializeComponent();
            pictureBox_diamond.Image = new Bitmap(pictureBox_diamond.Width, pictureBox_diamond.Height);
            bmp = (Bitmap)pictureBox_diamond.Image;
            //Clear();
            pictureBox_diamond.Image = bmp;
            g = Graphics.FromImage(pictureBox_diamond.Image);
            g.Clear(Color.White);
        }

        private void Diamond_square_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_diamond_alg_Click(object sender, EventArgs e)
        {
            r = Double.Parse(textBox_roughness.Text);
            if (from.X > to.X)
            {
                PointF temp = from;
                from = to;
                to = temp;
            }
            //label1.Text = to.ToString();
            diamond_alg(from, to);
        }

        private void diamond_alg(PointF start, PointF finish)
        {
            /*Random rnd = new Random();
            double random = 5 + rnd.NextDouble() * (10 - 5);
            label1.Text = random.ToString();*/
            //h = (hL + hR) / 2 + random(- R * l, R * l)
            double new_x = (finish.X + start.X) / 2.0;           
            double length = Math.Sqrt((finish.X - start.X) *(finish.X - start.X) + (finish.Y - start.Y) *(finish.Y - start.Y));
            Random rnd = new Random();
            double random = (-r * length) + rnd.NextDouble() * ((r * length) - (-r * length));
            double new_y = (start.Y + finish.Y) / 2 + random;
            PointF new_point = new PointF((float)new_x, (float)new_y);
            //label1.Text = length.ToString();
            g.DrawLine(pen_white, start, finish);
            g.DrawLine(pen, start, new_point);
            g.DrawLine(pen, new_point, finish);
            Task.Delay(5);
            pictureBox_diamond.Refresh();
            if (finish.X - start.X > 1)
            {
                diamond_alg(start, new_point);
                diamond_alg(new_point, finish);
            }
        }

        private void pictureBox_diamond_MouseDown(object sender, MouseEventArgs e)
        {
            from = e.Location;
            to = e.Location;
        }

        private void pictureBox_diamond_MouseMove(object sender, MouseEventArgs e)
        {
            //to = e.Location;
            //pictureBox_diamond.Invalidate();
        }

        private void pictureBox_diamond_MouseUp(object sender, MouseEventArgs e)
        {
            to = e.Location;
            g.DrawLine(pen, from, to);
            pictureBox_diamond.Refresh();

        }

        private void button_clear_diamond_Click(object sender, EventArgs e)
        {
            pictureBox_diamond.Image = new Bitmap(pictureBox_diamond.Width, pictureBox_diamond.Height);
            g = Graphics.FromImage(pictureBox_diamond.Image);
            g.Clear(Color.White);
            pictureBox_diamond.Refresh();
        }
    }
}
