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
        bool is_drawn = false;
        float length;
        Bitmap bmp;
        Graphics g;
        Pen pen = new Pen(Color.Black);
        Pen red_pen = new Pen(Color.Red);
        List<Point3d> polyhedron_points = new List<Point3d>();
        List<Point3d> projection_points = new List<Point3d>();
        Line3d line = new Line3d(new Point3d(), new Point3d());
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
            is_drawn = false;
            make_all_invisible();
            polyhedron_points.Clear();
            projection_points.Clear();
            pictureBox_3d_picture.Image = new Bitmap(pictureBox_3d_picture.Width, pictureBox_3d_picture.Height);
            g = Graphics.FromImage(pictureBox_3d_picture.Image);
            g.Clear(Color.White);
            pictureBox_3d_picture.Refresh();
        }

        private void button_add_tetrahedron_Click(object sender, EventArgs e)
        {
            is_drawn = true;
            float x = float.Parse(textBox_coordinate_X.Text);
            float y = float.Parse(textBox_coordinate_Y.Text);
            float z = float.Parse(textBox_coordinate_Z.Text);
            length = float.Parse(textBox_coordinate_length.Text);
            float length_2 = (float)(length / Math.Sqrt(2));
            Point3d start = new Point3d(x, y, z);
            Point3d p2 = new Point3d(x + length_2, y + length_2, z);
            Point3d p3 = new Point3d(x + length_2, y, z + length_2);
            Point3d p4 = new Point3d(x, y + length_2, z + length_2);
            polyhedron_points.Add(start);
            polyhedron_points.Add(p2);
            polyhedron_points.Add(p3);
            polyhedron_points.Add(p4);
            projection_points.Add(start);
            projection_points.Add(p2);
            projection_points.Add(p3);
            projection_points.Add(p4);
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
            if (comboBox_action.Text == "" || !is_drawn)
            {

            }
            else
            {
                switch (comboBox_action.SelectedItem.ToString())
                {
                    case "Смещение":
                        make_all_invisible();
                        label_delta_X.Visible = true;
                        label_delta_Y.Visible = true;
                        label_delta_Z.Visible = true;
                        //label_delta_X.Text = "X";
                        label_delta_Y.Text = "delta Y";
                        //label_delta_Z.Text = "Z";
                        textBox_delta_X.Visible = true;
                        textBox_delta_Y.Visible = true;
                        textBox_delta_Z.Visible = true;
                        break;

                    case "Поворот":
                        make_all_invisible();
                        label_axis.Visible = true;
                        label_angle.Visible = true;
                        textBox_angle.Visible = true;
                        textBox_axis.Visible = true;
                        break;

                    case "Масштаб":
                        make_all_invisible();
                        label_delta_Y.Text = "delta Y";
                        label_delta_X.Visible = true;
                        label_delta_Y.Visible = true;
                        label_delta_Z.Visible = true;
                        textBox_delta_X.Visible = true;
                        textBox_delta_Y.Visible = true;
                        textBox_delta_Z.Visible = true;
                        break;

                    case "Отражение относительно плоскости":
                        make_all_invisible();
                        label_axis.Visible = true;
                        textBox_axis.Visible = true;
                        break;

                    case "Масштабирование относительно центра":
                        make_all_invisible();
                        label_delta_Y.Visible = true;
                        textBox_delta_Y.Visible = true;
                        label_delta_Y.Text = "Коэффициент: ";
                        break;

                    case "Вращение вокргу прямой":
                        make_all_invisible();
                        label_axis.Visible = true;
                        label_angle.Visible = true;
                        textBox_angle.Visible = true;
                        textBox_axis.Visible = true;
                        break;

                    case "Поворот вокруг прямой":
                        make_all_invisible();
                        button_draw_line.Visible = true;
                        label_x1_line.Visible = true;
                        label_x2_line.Visible = true;
                        label_y1_line.Visible = true;
                        label_y2_line.Visible = true;
                        label_z1_line.Visible = true;
                        label_z2_line.Visible = true;
                        label_angle.Visible = true;
                        textBox_x1_line.Visible = true;
                        textBox_x2_line.Visible = true;
                        textBox_y1_line.Visible = true;
                        textBox_y2_line.Visible = true;
                        textBox_z1_line.Visible = true;
                        textBox_z2_line.Visible = true;
                        textBox_angle.Visible = true;
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
                        string axis = textBox_axis.Text;
                        int angle = Int32.Parse(textBox_angle.Text);
                        switch (axis)
                        {
                            case "X":
                                turn_x_far(angle);
                                break;

                            case "Y":
                                turn_y_far(angle);
                                break;

                            case "Z":
                                turn_z_far(angle);
                                break;
                        }
                        break;

                    case "Масштаб":
                        float coef_x = float.Parse(textBox_delta_X.Text);
                        float coef_y = float.Parse(textBox_delta_Y.Text);
                        float coef_z = float.Parse(textBox_delta_Z.Text);
                        scaling(coef_x, coef_y, coef_z);
                        break;

                    case "Отражение относительно плоскости":
                        string axis1 = textBox_axis.Text;
                        switch (axis1)
                        {
                            case "X":
                                mirror_x();
                                break;

                            case "Y":
                                mirror_y();
                                break;

                            case "Z":
                                mirror_z();
                                break;
                        }
                        break;

                    case "Масштабирование относительно центра":
                        float coef = float.Parse(textBox_delta_Y.Text);
                        scaling_center(coef);
                        break;

                    case "Вращение вокргу прямой":
                        string axis2 = textBox_axis.Text;
                        int angle2 = Int32.Parse(textBox_angle.Text);
                        switch (axis2)
                        {
                            case "X":
                                turn_x(angle2);
                                break;

                            case "Y":
                                turn_y(angle2);
                                break;

                            case "Z":
                                turn_z(angle2);
                                break;
                        }
                        break;

                    case "Поворот вокруг прямой":
                        /*int x1 = Int32.Parse(textBox_x1_line.Text);
                        int y1 = Int32.Parse(textBox_y1_line.Text);
                        int z1 = Int32.Parse(textBox_z1_line.Text);
                        int x2 = Int32.Parse(textBox_x2_line.Text);
                        int y2 = Int32.Parse(textBox_y2_line.Text);
                        int z2 = Int32.Parse(textBox_z2_line.Text);*/
                        int angle_turn = Int32.Parse(textBox_angle.Text);
                        //Line3d line = new Line3d(new Point3d(x1, y1, z1), new Point3d(x2, y2, z2));
                        turn_line(angle_turn);
                        break;
                }
            }
        }

        private void change_position(int delta_x, int delta_y, int delta_z)
        {
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0, delta_x }, { 0, 1, 0, delta_y }, { 0, 0, 1, delta_z }, { 0, 0, 0, 1 } };
                //double[,] displayMatrix = { { Math.Sqrt(0.5), 0, -Math.Sqrt(0.5), 0 }, { 1 / Math.Sqrt(6), 2 / Math.Sqrt(6), 1 / Math.Sqrt(6), 0 }, { 1 / Math.Sqrt(3), -1 / Math.Sqrt(3), 1 / Math.Sqrt(3), 0 }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void turn_x_far(int angle)
        {
            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            Point3d center = mass_center();
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                //double[,] matr_dot = { { 1, 0, 0, -center.X }, { 0, 1, 0, -center.Y }, { 0, 0, 1, -center.Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { 1, 0, 0, 0 }, { 0, cos, -sin, 0 }, { 0, sin, cos, 0 }, { 0, 0, 0, 1 } };
                //double[,] new_matr = { { 1, 0, 0, center.X }, { 0, 1, 0, center.Y }, { 0, 0, 1, center.Z }, { 0, 0, 0, 1 } };
                // old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr = matrix_multiplication(matr_angle, old_matr);
                //old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void turn_y_far(int angle)
        {
            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            Point3d center = mass_center();
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                //double[,] matr_dot = { { 1, 0, 0, -center.X }, { 0, 1, 0, -center.Y }, { 0, 0, 1, -center.Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { cos, 0, sin, 0 }, { 0, 1, 0, 0 }, { -sin, 0, cos, 0 }, { 0, 0, 0, 1 } };
                //double[,] new_matr = { { 1, 0, 0, center.X }, { 0, 1, 0, center.Y }, { 0, 0, 1, center.Z }, { 0, 0, 0, 1 } };
                //old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr = matrix_multiplication(matr_angle, old_matr);
                //old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void turn_z_far(int angle)
        {
            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            Point3d center = mass_center();
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                // double[,] matr_dot = { { 1, 0, 0, -center.X }, { 0, 1, 0, -center.Y }, { 0, 0, 1, -center.Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { cos, -sin, 0, 0 }, { sin, cos, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
                //double[,] new_matr = { { 1, 0, 0, center.X }, { 0, 1, 0, center.Y }, { 0, 0, 1, center.Z }, { 0, 0, 0, 1 } };
                // old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr =  matrix_multiplication(matr_angle, old_matr);

                //old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void turn_x(int angle)
        {
            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            Point3d center = mass_center();
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_dot = { { 1, 0, 0, -center.X }, { 0, 1, 0, -center.Y }, { 0, 0, 1, -center.Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { 1, 0, 0, 0 }, { 0, cos, -sin, 0 }, { 0, sin, cos, 0 }, { 0, 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0, center.X }, { 0, 1, 0, center.Y }, { 0, 0, 1, center.Z }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr = matrix_multiplication(matr_angle, old_matr);
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void turn_y(int angle)
        {
            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            Point3d center = mass_center();
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_dot = { { 1, 0, 0, -center.X }, { 0, 1, 0, -center.Y }, { 0, 0, 1, -center.Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { cos, 0, sin, 0 }, { 0, 1, 0, 0 }, { -sin, 0, cos, 0 }, { 0, 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0, center.X }, { 0, 1, 0, center.Y }, { 0, 0, 1, center.Z }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr = matrix_multiplication(matr_angle, old_matr);
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void turn_z(int angle)
        {
            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            Point3d center = mass_center();
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_dot = { { 1, 0, 0, -center.X }, { 0, 1, 0, -center.Y }, { 0, 0, 1, -center.Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { cos, -sin, 0, 0 }, { sin, cos, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0, center.X }, { 0, 1, 0, center.Y }, { 0, 0, 1, center.Z }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr = matrix_multiplication(matr_angle, old_matr);
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void mirror_x()
        {
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_dot = { { 1, 0, 0, -polyhedron_points[0].X }, { 0, 1, 0, -polyhedron_points[0].Y }, { 0, 0, 1, -polyhedron_points[0].Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { -1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0, polyhedron_points[0].X }, { 0, 1, 0, polyhedron_points[0].Y }, { 0, 0, 1, polyhedron_points[0].Z }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr = matrix_multiplication(matr_angle, old_matr);
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void mirror_y()
        {
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_dot = { { 1, 0, 0, -polyhedron_points[0].X }, { 0, 1, 0, -polyhedron_points[0].Y }, { 0, 0, 1, -polyhedron_points[0].Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { 1, 0, 0, 0 }, { 0, -1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0, polyhedron_points[0].X }, { 0, 1, 0, polyhedron_points[0].Y }, { 0, 0, 1, polyhedron_points[0].Z }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr = matrix_multiplication(matr_angle, old_matr);
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void mirror_z()
        {
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_dot = { { 1, 0, 0, -polyhedron_points[0].X }, { 0, 1, 0, -polyhedron_points[0].Y }, { 0, 0, 1, -polyhedron_points[0].Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, -1, 0 }, { 0, 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0, polyhedron_points[0].X }, { 0, 1, 0, polyhedron_points[0].Y }, { 0, 0, 1, polyhedron_points[0].Z }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr = matrix_multiplication(matr_angle, old_matr);
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void scaling(float coef_x, float coef_y, float coef_z)
        {
            /* length *= coef;
             float length_2 = (float)(length / Math.Sqrt(2));
             float x = polyhedron_points[0].X;
             float y = polyhedron_points[0].Y;
             float z = polyhedron_points[0].Z;
             polyhedron_points[1] = new Point3d(x + length_2, y + length_2, z);
             polyhedron_points[2] = new Point3d(x + length_2, y, z + length_2);
             polyhedron_points[3] = new Point3d(x, y + length_2, z + length_2);
             redraw();*/
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_dot = { { 1, 0, 0, -polyhedron_points[0].X }, { 0, 1, 0, -polyhedron_points[0].Y }, { 0, 0, 1, -polyhedron_points[0].Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { coef_x, 0, 0, 0 }, { 0, coef_y, 0, 0 }, { 0, 0, coef_z, 0 }, { 0, 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0, polyhedron_points[0].X }, { 0, 1, 0, polyhedron_points[0].Y }, { 0, 0, 1, polyhedron_points[0].Z }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr = matrix_multiplication(matr_angle, old_matr);
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void scaling_center(float coef)
        {
            Point3d center = mass_center();
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_dot = { { 1, 0, 0, -center.X }, { 0, 1, 0, -center.Y }, { 0, 0, 1, -center.Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { coef, 0, 0, 0 }, { 0, coef, 0, 0 }, { 0, 0, coef, 0 }, { 0, 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0, center.X }, { 0, 1, 0, center.Y }, { 0, 0, 1, center.Z }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_dot, old_matr);
                old_matr = matrix_multiplication(matr_angle, old_matr);
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private void turn_line(int angle)
        {
            Point3d vect = new Point3d(line.to.X - line.from.X, line.to.Y - line.from.Y, line.to.Z - line.from.Z);
            float length_line = (float)Math.Sqrt((line.to.X - line.from.X) * (line.to.X - line.from.X) + (line.to.Y - line.from.Y) * (line.to.Y - line.from.Y) + (line.to.Z - line.from.Z) * (line.to.Z - line.from.Z));
            Point3d unit = new Point3d(vect.X / length_line, vect.Y / length_line, vect.Z / length_line);

            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);

            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] new_matr = { {unit.X*unit.X + cos* (1 - unit.X * unit.X), unit.X*(1 - cos)*unit.Y + unit.Z*sin, unit.X*(1-cos)*unit.Z - unit.Y*sin, 0 },
                    {unit.X*(1-cos)*unit.Y - unit.Z*sin, unit.Y*unit.Y + cos*(1 - unit.Y*unit.Y), unit.Y*(1-cos)*unit.Z + unit.X*sin, 0 },
                    {unit.X*(1-cos)*unit.Z + unit.Y*sin, unit.Y*(1-cos)*unit.Z - unit.X*sin ,unit.Z*unit.Z + cos* (1 - unit.Z * unit.Z), 0 },
                    {0, 0, 0, 1 } };
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            redraw();
        }

        private double[,] matrix_multiplication(double[,] matr1, double[,] matr2) // Умножение матриц
        {
            double[,] result = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    for (int k = 0; k < 4; ++k)
                        result[i, j] += matr1[i, k] * matr2[k, j];
            return result;
        }


        private Point3d get_point_from_matrix_row(double[,] matr) // Получение точки из конечной матрицы
        {
            return new Point3d((float)matr[1, 0], (float)matr[1, 1], (float)matr[1, 2]);
        }

        private Point3d get_point_from_matrix_colon(double[,] matr) // Получение точки из конечной матрицы
        {
            return new Point3d((float)matr[0, 3], (float)matr[1, 3], (float)matr[2, 3]);
        }

        private void redraw() // Перерисовывание многогранника 
        {
            pictureBox_3d_picture.Image = new Bitmap(pictureBox_3d_picture.Width, pictureBox_3d_picture.Height);
            g = Graphics.FromImage(pictureBox_3d_picture.Image);
            g.Clear(Color.White);
            pictureBox_3d_picture.Refresh();
            for (int i = 0; i < polyhedron_points.Count; ++i)
                for (int j = i + 1; j < polyhedron_points.Count; ++j)
                    g.DrawLine(pen, polyhedron_points[i].To2D(), polyhedron_points[j].To2D());
            g.DrawLine(new Pen(Color.Red), line.from.To2D(), line.to.To2D());
            //g.DrawLine(pen, polyhedron_points.Last().To2D(), polyhedron_points.First().To2D());
            pictureBox_3d_picture.Refresh();
        }
        private void redraw_with_projection() // Перерисовывание многогранника 
        {
            pictureBox_3d_picture.Image = new Bitmap(pictureBox_3d_picture.Width, pictureBox_3d_picture.Height);
            g = Graphics.FromImage(pictureBox_3d_picture.Image);
            g.Clear(Color.White);
            pictureBox_3d_picture.Refresh();
            for (int i = 0; i < polyhedron_points.Count; ++i)
                for (int j = i + 1; j < polyhedron_points.Count; ++j)
                    g.DrawLine(pen, polyhedron_points[i].To2D(), polyhedron_points[j].To2D());
            for (int i = 0; i < projection_points.Count; ++i)
                for (int j = i + 1; j < projection_points.Count; ++j)
                    g.DrawLine(red_pen, projection_points[i].To2D(), projection_points[j].To2D());
            g.DrawLine(new Pen(Color.Red), line.from.To2D(), line.to.To2D());
            //g.DrawLine(pen, polyhedron_points.Last().To2D(), polyhedron_points.First().To2D());
            pictureBox_3d_picture.Refresh();
        }

        private void make_all_invisible()
        {
            button_draw_line.Visible = false;
            label_delta_X.Visible = false;
            label_delta_Y.Visible = false;
            label_delta_Z.Visible = false;
            label_angle.Visible = false;
            label_axis.Visible = false;
            label_x1_line.Visible = false;
            label_x2_line.Visible = false;
            label_y1_line.Visible = false;
            label_y2_line.Visible = false;
            label_z1_line.Visible = false;
            label_z2_line.Visible = false;
            textBox_delta_X.Visible = false;
            textBox_delta_Y.Visible = false;
            textBox_delta_Z.Visible = false;
            textBox_angle.Visible = false;
            textBox_axis.Visible = false;
            textBox_x1_line.Visible = false;
            textBox_x2_line.Visible = false;
            textBox_y1_line.Visible = false;
            textBox_y2_line.Visible = false;
            textBox_z1_line.Visible = false;
            textBox_z2_line.Visible = false;
        }

        private Point3d mass_center() // Находит точку центр масс и заносит значение в random_point
        {
            int size = polyhedron_points.Count;
            float x = 0;
            float y = 0;
            float z = 0;
            for (int i = 0; i < size; ++i)
            {

                x += polyhedron_points[i].X;
                y += polyhedron_points[i].Y;
                z += polyhedron_points[i].Z;
                int a = (int)x;
                //button_clear.Text += " " + a.ToString();
            }
            //button_clear.Text += "!!!";
            //button_clear.Text = x.ToString() + " " + y.ToString() + " " + z.ToString();
            return new Point3d(x / size, y / size, z / size);
        }

        private void button_draw_line_Click(object sender, EventArgs e)
        {
            float x1 = float.Parse(textBox_x1_line.Text);
            float y1 = float.Parse(textBox_y1_line.Text);
            float z1 = float.Parse(textBox_z1_line.Text);
            float x2 = float.Parse(textBox_x2_line.Text);
            float y2 = float.Parse(textBox_y2_line.Text);
            float z2 = float.Parse(textBox_z2_line.Text);
            line = new Line3d(new Point3d(x1, y1, z1), new Point3d(x2, y2, z2));
            g.DrawLine(new Pen(Color.Red), line.from.To2D(), line.to.To2D());
            pictureBox_3d_picture.Refresh();
        }

        private double[,] get_projection_koeff()
        {
            if (radioButton_perspect.Checked)
            {
                return new double[4, 4] { { Math.Sqrt(0.5), 0, -Math.Sqrt(0.5), 0 }, { 1 / Math.Sqrt(6), 2 / Math.Sqrt(6), 1 / Math.Sqrt(6), 0 }, { 1 / Math.Sqrt(3), -1 / Math.Sqrt(3), 1 / Math.Sqrt(3), 0 }, { 0, 0, 0, 1 } };
            }
            if (radioButton_ortogr.Checked)
            {
                if (textBox_proect_axis.Text == "X")
                {
                    return new double[4, 4] { { 0, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
                }
                if (textBox_proect_axis.Text == "Y")
                {
                    return new double[4, 4] { { 1, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
                }
                if (textBox_proect_axis.Text == "Z")
                {
                    return new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 1 } };

                }
            }

            return new double[4, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        }

        private void button_project_Click(object sender, EventArgs e)
        {
            Point3d center = mass_center();
            for (int i = 0; i < projection_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] koeff = get_projection_koeff();
                double[,] new_matr = matrix_multiplication(koeff,  old_matr);
                projection_points[i] = get_point_from_matrix_colon(new_matr);
            }
            redraw_with_projection();
        }

        private void button_apply_and_projection_Click(object sender, EventArgs e)
        {
            button_action_Click(sender, e);
            button_project_Click(sender, e);
        }
    }
}