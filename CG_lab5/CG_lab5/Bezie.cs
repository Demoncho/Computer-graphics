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
    public partial class Bezie : Form
    {
        Bitmap bmp;
        Graphics g;
        Pen pen = new Pen(Color.Black);
        Point to, from;
        List<Point> points = new List<Point>();
        public Bezie()
        {
            InitializeComponent();
            pictureBox_bezie.Image = new Bitmap(pictureBox_bezie.Width, pictureBox_bezie.Height);
            bmp = (Bitmap)pictureBox_bezie.Image;
            //Clear();
            pictureBox_bezie.Image = bmp;
            g = Graphics.FromImage(pictureBox_bezie.Image);
            g.Clear(Color.White);
        }

        private void Bezie_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_bezie_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_bezie_Click(object sender, EventArgs e)
        {
            points.Clear();
            pictureBox_bezie.Image = new Bitmap(pictureBox_bezie.Width, pictureBox_bezie.Height);
            g = Graphics.FromImage(pictureBox_bezie.Image);
            g.Clear(Color.White);
            pictureBox_bezie.Refresh();
        }

        private void pictureBox_bezie_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton_add.Checked)
            {
                to = e.Location;               
            }
            else if (radioButton_delete.Checked)
            {
                to = e.Location;
            }
            else
            {
                from = e.Location;
            }
        }

        private void pictureBox_bezie_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_bezie_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton_add.Checked)
            {
                to = e.Location;
                points.Add(new Point(to.X, to.Y));
                g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(to.X, to.Y, 3, 3));
                pictureBox_bezie.Refresh();
                if (points.Count > 3)
                    bezie_alg();
            }
            else if (radioButton_delete.Checked)
            {
                if (points.Count > 0)
                {
                    to = e.Location;
                    List<double> dist = points.Select(x => distance_between(to, x)).ToList();
                    int min_id = dist.FindIndex(x => x == dist.Min());
                    g.FillEllipse(new SolidBrush(Color.White), new Rectangle(points[min_id].X, points[min_id].Y, 3, 3));
                    points.RemoveAt(min_id);
                    pictureBox_bezie.Refresh();
                    if (points.Count > 3)
                        bezie_alg();
                }
            }
            else
            {
                to = e.Location;
                List<double> dist = points.Select(x => distance_between(from, x)).ToList();
                int min_id = dist.FindIndex(x => x == dist.Min());
                g.FillEllipse(new SolidBrush(Color.White), new Rectangle(points[min_id].X, points[min_id].Y, 3, 3));
                points[min_id] = to;
                g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(to.X, to.Y, 3, 3));
                pictureBox_bezie.Refresh();
                if (points.Count > 3)
                    bezie_alg();
            }
        }

        private void bezie_alg()
        {
            pictureBox_bezie.Image = new Bitmap(pictureBox_bezie.Width, pictureBox_bezie.Height);
            g = Graphics.FromImage(pictureBox_bezie.Image);
            g.Clear(Color.White);
            pictureBox_bezie.Refresh();
            for (int i = 0; i<points.Count;++i)
                g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(points[i].X, points[i].Y, 3, 3));

            for (int i = 1; i < points.Count - 1; i += 2)
            {
                PointF p0, p1, p2, p3;

                int prev = i - 1; 
                int next2 = i + 2;

                if (prev == 0)
                    p0 = points[prev];
                else
                    p0 = new PointF((points[i].X + points[prev].X) / 2, (points[i].Y + points[prev].Y) / 2);

                if (i == points.Count - 2)
                {
                    p1 = points[i];
                    p3 = points[i + 1];
                    p2 = new PointF((p3.X + p1.X) / 2, (p3.Y + p1.Y) / 2);
                }
                else
                {
                    p1 = points[i];
                    p2 = points[i + 1];
                    if (next2 == points.Count - 1)
                        p3 = points[next2];
                    else
                        p3 = new PointF((points[next2].X + p2.X) / 2, (points[next2].Y + p2.Y) / 2);
                }

                g.DrawLines(pen, calcaluteCubeСurve(p0, p1, p2, p3));
                pictureBox_bezie.Refresh();
            }
        }

        private PointF[] calcaluteCubeСurve(PointF p0, PointF p1, PointF p2, PointF p3)
        {
            float step = 0.01f;
            int step_draw = 101;
            PointF[] result = new PointF[step_draw];
            PointF q0 = new PointF();
            PointF q1 = new PointF();
            PointF q2 = new PointF();
            PointF r0 = new PointF();
            PointF r1 = new PointF();
            float t = 0;
            float x, y;
            for (int i = 0; i < step_draw; i++)
            {
                q0.X = p0.X * (1 - t) + p1.X * t; q0.Y = p0.Y * (1 - t) + p1.Y * t;
                q1.X = p1.X * (1 - t) + p2.X * t; q1.Y = p1.Y * (1 - t) + p2.Y * t;
                q2.X = p2.X * (1 - t) + p3.X * t; q2.Y = p2.Y * (1 - t) + p3.Y * t;
                r0.X = q0.X * (1 - t) + q1.X * t; r0.Y = q0.Y * (1 - t) + q1.Y * t;
                r1.X = q1.X * (1 - t) + q2.X * t; r1.Y = q1.Y * (1 - t) + q2.Y * t;
                x = r0.X * (1 - t) + r1.X * t;
                y = r0.Y * (1 - t) + r1.Y * t;
                t += step;
                result[i] = new PointF(x, y);
            }
            return result;
        }

        private double distance_between(Point a, Point b)
        {
            return Math.Sqrt((a.X - b.X)*(a.X - b.X) + (a.Y - b.Y)*(a.Y - b.Y));
        }

    }
}
