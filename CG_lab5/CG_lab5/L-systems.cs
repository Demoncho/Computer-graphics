using System;
using System.IO;
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
    public partial class L_systems : Form
    {
        Grammar grammar = new Grammar();
        Pen pen = new Pen(Color.Black);
        public L_systems()
        {
            InitializeComponent();
        }

        private void L_systems_Load(object sender, EventArgs e)
        {

        }

        private void parse(string fileName)
        {
             string[] lines = File.ReadAllLines(fileName);
             string[] firstLineItems = lines[0].Split(' ');
             Grammar temp_gram = new Grammar();
             temp_gram.start_symbol = firstLineItems[0];
             temp_gram.angle = double.Parse(firstLineItems[1].Replace('.', ','));

             foreach (var line in lines.Skip(1))
             {
                 string[] lineItems = line.Split(' ');
                 temp_gram.rules.Add(lineItems[0][0], lineItems[2]);
             }

            grammar = temp_gram;
        }

        private void draw()
        {
            int depth =(int)numericUpDown_generation.Value;
            string current_state = grammar.start_symbol;
            for (int i = 0; i < depth; i++)
            {
                string temp = current_state;
                current_state = "";
                for (int j = 0; j < temp.Length; j++)
                {
                    if (grammar.rules.ContainsKey(temp[j]))
                        current_state += grammar.rules[temp[j]];
                    else
                        current_state += temp[j];
                }
            }

            
            List<PointF> points = new List<PointF>();
            List<PointF> points_without_lines = new List<PointF>();
            PointF last_point = new PointF(0, 0);
            points.Add(last_point);
            double current_angle = 0;
            double line_size = 200.0 / Math.Pow(Math.Log(200, 9), depth - 1);

            Stack<Tuple<PointF, double>> branching_stack = new Stack<Tuple<PointF, double>>(); 

            for (int i = 0; i < current_state.Length; i++)
            {
                char c = current_state[i];
                switch (c)
                {
                    case '-':
                        current_angle += grammar.angle;
                        break;
                    case '+':
                        current_angle -= grammar.angle;
                        break;
                    case '[':
                        branching_stack.Push(new Tuple<PointF, double>(last_point, current_angle));
                        break;
                    case ']':
                        var settings = branching_stack.Pop();
                        last_point = settings.Item1;
                        points.Add(last_point);
                        points_without_lines.Add(last_point);
                        current_angle = settings.Item2;
                        break;
                    case 'F':
                        {
                            PointF new_point = get_point(last_point, current_angle, line_size);
                            points.Add(new_point);
                            last_point = new_point;                              
                            break;
                        }
                }
            }

            double x_min = points.Select(point => point.X).Min();
            double y_min = points.Select(point => point.Y).Min();
            double x_max = points.Select(point => point.X).Max();
            double y_max = points.Select(point => point.Y).Max();

            double zoom = Math.Min((pictureBox_fractal.Width - 15) / (x_max - x_min), (pictureBox_fractal.Height - 15) / (y_max - y_min));

            for (int i = 0; i < points.Count; i++)
                points[i] = new PointF((float)((points[i].X - x_min) * zoom + 5), (float)((points[i].Y - y_min) * zoom + 5));

            Image fractal_image;
            fractal_image = new Bitmap((int)((x_max - x_min) * zoom + 10), (int)((y_max - y_min) * zoom + 10));

            Graphics g = Graphics.FromImage(fractal_image);

            for (int i = 1; i < points.Count; i++)
                g.DrawLine(pen, points[i - 1], points[i]);
            pictureBox_fractal.Image = fractal_image;
            g.Dispose();
        }

        private PointF get_point(PointF prev_point, double angle, double line_size)
        {
            angle *= Math.PI / 180.0;
            float delta_X = (float)(line_size * Math.Cos(angle));
            float delta_Y = (float)(line_size * Math.Sin(angle));
            return new PointF(prev_point.X + delta_X, prev_point.Y - delta_Y);
        }

        private void button_choose_template_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Templates";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = dialog.FileName;
                label_filename.Visible = true;
                label_filename.Text = Path.GetFileName(selectedFile);
                numericUpDown_generation.Value = 1;
                parse(selectedFile);
                draw();
            }
        }

        private void numericUpDown_generation_ValueChanged(object sender, EventArgs e)
        {
            draw();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    class Grammar
    {
        public string start_symbol;
        public double angle;
        public Dictionary<char, string> rules = new Dictionary<char, string>();
    }
}
