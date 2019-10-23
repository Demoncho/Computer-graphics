using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_lab6
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Pen pen = new Pen(Color.Black);
        List<Point3d> polyhedron_points = new List<Point3d>();
        public Form1()
        {
            InitializeComponent();
            comboBox_action.Items.AddRange(new string[] { "", "Смещение", "Поворот", "Масштаб", "Отражение относительно плоскости", "Масштабирование относительно центра", "Вращение вокргу прямой", "Поворот вокруг прямой" });
            pictureBox_3d_picture.Image = new Bitmap(pictureBox_3d_picture.Width, pictureBox_3d_picture.Height);
            bmp = (Bitmap)pictureBox_3d_picture.Image;
            pictureBox_3d_picture.Image = bmp;
            g = Graphics.FromImage(pictureBox_3d_picture.Image);
            g.Clear(Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            pictureBox_3d_picture.Image = new Bitmap(pictureBox_3d_picture.Width, pictureBox_3d_picture.Height);
            g = Graphics.FromImage(pictureBox_3d_picture.Image);
            g.Clear(Color.White);
            pictureBox_3d_picture.Refresh();
        }

        private void button_add_tetrahedron_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox_coordinate_X.Text);
            float y = float.Parse(textBox_coordinate_Y.Text);
            float z = float.Parse(textBox_coordinate_Z.Text);
            float length = float.Parse(textBox_coordinate_length.Text);
            float length_2 = (float)(length / Math.Sqrt(2));
            Point3d start = new Point3d(x, y, z);
            Point3d p2 = new Point3d(x + length_2, y + length_2, z);
            Point3d p3 = new Point3d(x + length_2, y, z + length_2);
            Point3d p4 = new Point3d(x, y + length_2, z + length_2);
            polyhedron_points.Add(start);
            polyhedron_points.Add(p2);
            polyhedron_points.Add(p3);
            polyhedron_points.Add(p4);
            g.DrawLine(pen, start.To2D(), p2.To2D());
            g.DrawLine(pen, start.To2D(), p3.To2D());
            g.DrawLine(pen, start.To2D(), p4.To2D());
            g.DrawLine(pen, p2.To2D(), p3.To2D());
            g.DrawLine(pen, p2.To2D(), p4.To2D());
            g.DrawLine(pen, p3.To2D(), p4.To2D());
            pictureBox_3d_picture.Refresh();
        }

        private void comboBox_action_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_action.Text =="")
            {

            }
            else
            {
                switch (comboBox_action.SelectedItem.ToString())
                {
                    case "Смещение":
                        label_delta_X.Visible = true;
                        label_delta_Y.Visible = true;
                        label_delta_Z.Visible = true;
                        textBox_delta_X.Visible = true;
                        textBox_delta_Y.Visible = true;
                        textBox_delta_Z.Visible = true;
                        break;

                    case "Поворот":

                        break;

                    case "Масштаб":

                        break;

                    case "Отражение относительно плоскости":

                        break;

                    case "Масштабирование относительно центра":

                        break;

                    case "Вращение вокргу прямой":

                        break;

                    case "Поворот вокруг прямой":

                        break;
                }
            }
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            if (comboBox_action.Text == "")
            {

            }
            else
            {
                switch (comboBox_action.SelectedItem.ToString())
                {
                    case "Смещение":
                        int delta_x = Int32.Parse(textBox_delta_X.Text);
                        int delta_y = Int32.Parse(textBox_delta_Y.Text);
                        int delta_z = Int32.Parse(textBox_delta_Z.Text);
                        change_position(delta_x, delta_y, delta_z);
                        break;

                    case "Поворот":

                        break;

                    case "Масштаб":

                        break;

                    case "Отражение относительно плоскости":

                        break;

                    case "Масштабирование относительно центра":

                        break;

                    case "Вращение вокргу прямой":

                        break;

                    case "Поворот вокруг прямой":

                        break;
                }
            }
        }

        private void change_position(int delta_x, int delta_y, int delta_z)
        {
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, 0 }, { polyhedron_points[i].X, polyhedron_points[i].Y, polyhedron_points[i].Z, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
                double[,] new_matr = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { -delta_x, -delta_y,-delta_z, 1 } };
                old_matr = matrix_multiplication(old_matr, new_matr);
                polyhedron_points[i] = get_point_from_matrix(old_matr);
            }
            redraw();
        }


        private double[,] matrix_multiplication(double[,] matr1, double[,] matr2) // Умножение матриц
        {
            double[,] result = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }};
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    for (int k = 0; k < 4; ++k)
                        result[i, j] += matr1[i, k] * matr2[k, j];
            return result;
        }

        private Point3d get_point_from_matrix(double[,] matr) // Получение точки из конечной матрицы
        {
            return new Point3d((float)matr[1, 0], (float)matr[1, 1] , (float)matr[1, 2]);
        }

        private void redraw() // Перерисовывание многогранника 
        {
            pictureBox_3d_picture.Image = new Bitmap(pictureBox_3d_picture.Width, pictureBox_3d_picture.Height);
            g = Graphics.FromImage(pictureBox_3d_picture.Image);
            g.Clear(Color.White);
            pictureBox_3d_picture.Refresh();
            for (int i = 0; i < polyhedron_points.Count; ++i)
                for (int j = i+1; j < polyhedron_points.Count ; ++j)
                    g.DrawLine(pen, polyhedron_points[i].To2D(), polyhedron_points[j].To2D());

            //g.DrawLine(pen, polyhedron_points.Last().To2D(), polyhedron_points.First().To2D());
            pictureBox_3d_picture.Refresh();
        }

    }
}
