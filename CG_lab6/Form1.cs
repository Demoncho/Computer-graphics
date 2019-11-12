using System;
using System.Collections.Generic;
using System.IO;
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
        bool is_segment = false;
        bool is_drawn = false;
        bool not_rotation = true;
        bool first_rotation_figure = false;
        float length;
        char axis_rotation_figure;
        int count_rotation_figure;
        Bitmap bmp;
        Graphics g;
        Pen pen = new Pen(Color.Black);
        Pen red_pen = new Pen(Color.Red);
        Pen green_pen = new Pen(Color.Green);
        Pen blue_pen = new Pen(Color.Blue);
        List<Point3d> polyhedron_points = new List<Point3d>();
        List<Point3d> projection_points = new List<Point3d>();
        List<Point3d> start_rotation_figure_points = new List<Point3d>();
        List<Point3d> finish_rotation_figure_points = new List<Point3d>();
        List<Point3d> rotation_figure_draw_points = new List<Point3d>();
        Polyhedron main_polyhedron = new Polyhedron();
        Line3d line = new Line3d();
        Point3d view_vector = new Point3d();
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

        private void button_clear_Click(object sender, EventArgs e) // Кнопка очистки pictureBox 
        {
            is_segment = false;
            is_drawn = false;
            not_rotation = true;
            first_rotation_figure = false;
            make_all_invisible();
            polyhedron_points.Clear();
            projection_points.Clear();
            main_polyhedron = new Polyhedron();
            pictureBox_3d_picture.Image = new Bitmap(pictureBox_3d_picture.Width, pictureBox_3d_picture.Height);
            g = Graphics.FromImage(pictureBox_3d_picture.Image);
            g.Clear(Color.White);
            pictureBox_3d_picture.Refresh();
        }

        private void button_add_tetrahedron_Click(object sender, EventArgs e) // Кнопка добавления тетраэдра
        {
            if (is_drawn == false)
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
                Polygon3d polygon_1st = new Polygon3d();
                Polygon3d polygon_2nd = new Polygon3d();
                Polygon3d polygon_3rd = new Polygon3d();
                Polygon3d polygon_4th = new Polygon3d();
                polygon_1st.points.Add(start); polygon_1st.points.Add(p2); polygon_1st.points.Add(p3);
                polygon_2nd.points.Add(start); polygon_2nd.points.Add(p2); polygon_2nd.points.Add(p4);
                polygon_3rd.points.Add(start); polygon_3rd.points.Add(p3); polygon_3rd.points.Add(p4);
                polygon_4th.points.Add(p2); polygon_4th.points.Add(p3); polygon_4th.points.Add(p4);
                main_polyhedron.polygons.Add(polygon_1st);
                main_polyhedron.polygons.Add(polygon_2nd);
                main_polyhedron.polygons.Add(polygon_3rd);
                main_polyhedron.polygons.Add(polygon_4th);
                pictureBox_3d_picture.Refresh();
            }
        }

        private void comboBox_action_SelectedIndexChanged(object sender, EventArgs e) // Появления необходимых окон при выборе действия
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
                        label_delta_Y.Text = "delta Y";
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

        private void button_action_Click(object sender, EventArgs e) // Кнопка "применить"
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
                        int angle_turn = Int32.Parse(textBox_angle.Text);
                        turn_line(angle_turn);
                        break;
                }
            }
        }

        private void change_position(int delta_x, int delta_y, int delta_z) // Сдвиг
        {
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0, delta_x }, { 0, 1, 0, delta_y }, { 0, 0, 1, delta_z }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else redraw_rotation_figure();
        }

        private void turn_x_far(int angle) //Поворот вокруг оси X
        {
            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            Point3d center = mass_center();
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { 1, 0, 0, 0 }, { 0, cos, -sin, 0 }, { 0, sin, cos, 0 }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_angle, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else if (!first_rotation_figure) redraw_rotation_figure();
        }

        private void turn_y_far(int angle) //Поворот вокруг оси Y
        {
            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            Point3d center = mass_center();
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { cos, 0, sin, 0 }, { 0, 1, 0, 0 }, { -sin, 0, cos, 0 }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_angle, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else if (!first_rotation_figure) redraw_rotation_figure();
        }

        private void turn_z_far(int angle) //Поворот вокруг оси Z
        {
            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            Point3d center = mass_center();
            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] matr_angle = { { cos, -sin, 0, 0 }, { sin, cos, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
                old_matr = matrix_multiplication(matr_angle, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else if (!first_rotation_figure) redraw_rotation_figure();
        }

        private void turn_x(int angle) // Поворот по прямой через  ось X 
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
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else redraw_rotation_figure();
        }

        private void turn_y(int angle) // Поворот по прямой через  ось Y
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
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else redraw_rotation_figure();
        }

        private void turn_z(int angle) // Поворот по прямой через  ось Z
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
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else redraw_rotation_figure();
        }

        private void mirror_x() //Отражение по оси X
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
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else redraw_rotation_figure();
        }

        private void mirror_y() //Отражение по оси Y
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
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else redraw_rotation_figure();
        }

        private void mirror_z() //Отражение по оси Z
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
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else redraw_rotation_figure();
        }

        private void scaling(float coef_x, float coef_y, float coef_z) //Масштабирование отсносительно начальной точки
        {
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
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else redraw_rotation_figure();
        }

        private void scaling_center(float coef) //Масштабирование отсносительно центра
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
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else redraw_rotation_figure();
        }

        private void turn_line(int angle) //Поворот вокруг линии
        {
            Point3d vect = new Point3d(line.to.X - line.from.X, line.to.Y - line.from.Y, line.to.Z - line.from.Z);
            float length_line = (float)Math.Sqrt((line.to.X - line.from.X) * (line.to.X - line.from.X) + (line.to.Y - line.from.Y) * (line.to.Y - line.from.Y) + (line.to.Z - line.from.Z) * (line.to.Z - line.from.Z));
            Point3d unit = new Point3d(vect.X / length_line, vect.Y / length_line, vect.Z / length_line);

            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            double l = unit.X;
            double m = unit.Y;
            double n = unit.Z;
            double d = Math.Sqrt(unit.Y * unit.Y + unit.Z * unit.Z);

            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0, polyhedron_points[i].X }, { 0, 0, 0, polyhedron_points[i].Y }, { 0, 0, 0, polyhedron_points[i].Z }, { 0, 0, 0, 1 } };
                double[,] t = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { -(line.to.X + line.from.X) / 2, -(line.to.Y + line.from.Y) / 2, -(line.to.Z + line.from.Z) / 2, 1 } };
                double[,] new_matr = { {unit.X*unit.X + cos* (1 - unit.X * unit.X), unit.X*(1 - cos)*unit.Y + unit.Z*sin, unit.X*(1-cos)*unit.Z - unit.Y*sin, 0 },
                    {unit.X*(1-cos)*unit.Y - unit.Z*sin, unit.Y*unit.Y + cos*(1 - unit.Y*unit.Y), unit.Y*(1-cos)*unit.Z + unit.X*sin, 0 },
                    {unit.X*(1-cos)*unit.Z + unit.Y*sin, unit.Y*(1-cos)*unit.Z - unit.X*sin ,unit.Z*unit.Z + cos* (1 - unit.Z * unit.Z), 0 },
                    {0, 0, 0, 1 } };
                double[,] t_minus = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { (line.to.X + line.from.X) / 2, (line.to.Y + line.from.Y) / 2, (line.to.Z + line.from.Z) / 2, 1 } };
                old_matr = matrix_multiplication(new_matr, old_matr);
                polyhedron_points[i] = get_point_from_matrix_colon(old_matr);
            }
            if (is_segment) segment_redraw();
            else if (not_rotation) redraw();
            else redraw_rotation_figure();
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
            pictureBox_3d_picture.Refresh();
        }

        private void make_all_invisible() // Скрыть все поля в приложении
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
            }
            return new Point3d(x / size, y / size, z / size);
        }

        private void button_draw_line_Click(object sender, EventArgs e) //Нарисовать прямую для поворота вокруг нее
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

            if (radioButton_izom.Checked)
            {
                return new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, -1 / 100 }, { 0, 0, 0, 1 } };
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
                if (!radioButton_izom.Checked)
                {

                    double[,] new_matr = matrix_multiplication(koeff, old_matr);
                    projection_points[i] = get_point_from_matrix_colon(new_matr);
                }
                else
                {
                    double[,] vec = { { polyhedron_points[i].X, polyhedron_points[i].Y, polyhedron_points[i].Z, 1 } };
                    double[,] res = { { 0, 0, 0, 0 } };
                    for (int i1 = 0; i1 < 1; i1++)
                        for (int j = 0; j < 4; j++)
                            for (int k = 0; k < 4; k++)
                                res[i1, k] += vec[i1, j] * koeff[j, k];
                    res[0, 0] /= (1 - polyhedron_points[i].Z / 100);
                    res[0, 1] /= (1 - polyhedron_points[i].Z / 100);
                    res[0, 3] = 1;
                    projection_points[i] = new Point3d((float)res[0, 0], (float)res[0, 1], 0);
                }
            }
            redraw_with_projection();
        }

        private void button_apply_and_projection_Click(object sender, EventArgs e)
        {
            button_action_Click(sender, e);
            button_project_Click(sender, e);
        }


        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Лабораторная работа №7. Построение трёхмерных моделей !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        private void button_load_Click(object sender, EventArgs e) //Кнопка загрузки 3d модели (test.txt)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.CurrentDirectory.Replace("bin\\Debug", "");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = dialog.FileName;
                parse(selectedFile);
            }
        }

        private void parse(string file_name) // Чтение из файла
        {
            string[] lines = File.ReadAllLines(file_name);
            foreach (string line in lines)
            {
                List<Point3d> points_polygon = new List<Point3d>();
                string[] coordinates = line.Split(' ')[1].Split(';');
                foreach (string coordinate in coordinates)
                {
                    string coordinate_without_brackets = coordinate.Trim(new char[] { '(', ')' });
                    string[] numbers = coordinate_without_brackets.Split(',');
                    Point3d temp_point = new Point3d(float.Parse(numbers[0]), float.Parse(numbers[1]), float.Parse(numbers[2]));
                    points_polygon.Add(temp_point);
                }
                Polygon3d temp_polygon = new Polygon3d(points_polygon);
                main_polyhedron.polygons.Add(temp_polygon);
            }
            draw_main_polyhedron();
        }

        private void draw_main_polyhedron() //Нарисовать многогранник по граням
        {
            is_drawn = true;
            foreach (Polygon3d polygon in main_polyhedron.polygons)
            {
                for (int i = 0; i < polygon.points.Count - 1; ++i)
                {
                    if (!polyhedron_points.Contains(polygon.points[i]))
                    {
                        polyhedron_points.Add(polygon.points[i]);
                    }
                    g.DrawLine(pen, polygon.points[i].To2D(), polygon.points[i + 1].To2D());
                }
                if (!polyhedron_points.Contains(polygon.points[polygon.points.Count - 1]))
                {
                    polyhedron_points.Add(polygon.points[polygon.points.Count - 1]);
                }
                g.DrawLine(pen, polygon.points[polygon.points.Count - 1].To2D(), polygon.points[0].To2D());

            }
            pictureBox_3d_picture.Refresh();
        }

        private void button_rotation_figure_Click(object sender, EventArgs e) //Кнопка создания фигуры вращения
        {
            List<Point3d> rotation_points = new List<Point3d>();
            using (Rotation_figure form = new Rotation_figure())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    count_rotation_figure = form.Count;
                    axis_rotation_figure = form.Axis;
                    rotation_points = form.Points;
                    draw_rotation_figure(rotation_points, axis_rotation_figure, count_rotation_figure);
                }
            }
        }

        private void draw_rotation_figure(List<Point3d> rotation_points, char axis, int count)
        {
            first_rotation_figure = true;
            not_rotation = false;
            is_drawn = true;

            int angle = 360 / count;

            polyhedron_points = new List<Point3d>(rotation_points);
            start_rotation_figure_points = new List<Point3d>(rotation_points);
            rotation_figure_draw_points = new List<Point3d>(rotation_points);
            List<Point3d> old_points= new List<Point3d>(rotation_points);

            for (int i = 0; i < count; ++i)
            {
                for (int j = 0; j < polyhedron_points.Count - 1; ++j)
                {
                    g.DrawLine(pen, polyhedron_points[j].To2D(), polyhedron_points[j + 1].To2D());
                }

                if (axis == 'X')
                {
                    turn_x_far(angle);
                }
                if (axis == 'Y')
                {
                    turn_y_far(angle);
                }
                if (axis == 'Z')
                {
                    turn_z_far(angle);
                }

                for (int j = 0; j < polyhedron_points.Count; ++j)
                {
                    g.DrawLine(pen, polyhedron_points[j].To2D(), old_points[j].To2D());
                }

                Polygon3d temp_polygon = new Polygon3d();

                for (int j = 0; j < polyhedron_points.Count - 1; ++j)
                {                   
                    temp_polygon.points.Add(old_points[j]);
                    temp_polygon.points.Add(old_points[j + 1]);
                    temp_polygon.points.Add(polyhedron_points[j]);                                  
                    temp_polygon.points.Add(polyhedron_points[j + 1]);
                }

                main_polyhedron.polygons.Add(temp_polygon);

                for (int j = 0; j < polyhedron_points.Count; ++j)
                {
                    old_points[j] = polyhedron_points[j];
                }

                foreach (Point3d point in polyhedron_points)
                {
                    rotation_figure_draw_points.Add(point);
                }
            }

            finish_rotation_figure_points = new List<Point3d>(polyhedron_points);
            polyhedron_points = new List<Point3d>(rotation_figure_draw_points);
            first_rotation_figure = false;

            Polygon3d high_polygon = new Polygon3d();
            Polygon3d low_polygon = new Polygon3d();

            for (int i = 0; i < polyhedron_points.Count; ++i)
            {
                if (i % finish_rotation_figure_points.Count == 0)
                    high_polygon.points.Add(polyhedron_points[i]);
                else if ((i + 1) % finish_rotation_figure_points.Count == 0)
                    low_polygon.points.Add(polyhedron_points[i]);
            }

            main_polyhedron.polygons.Add(high_polygon);
            main_polyhedron.polygons.Add(low_polygon);

            pictureBox_3d_picture.Refresh();
        }

        private void redraw_rotation_figure()
        {
            pictureBox_3d_picture.Image = new Bitmap(pictureBox_3d_picture.Width, pictureBox_3d_picture.Height);
            g = Graphics.FromImage(pictureBox_3d_picture.Image);
            g.Clear(Color.White);
            int count = start_rotation_figure_points.Count;
            for (int i = 1; i < polyhedron_points.Count; ++i)
            {
                if (i % count != 0)
                    g.DrawLine(pen, polyhedron_points[i].To2D(), polyhedron_points[i - 1].To2D());
            }

            
            for (int i = 0; i < polyhedron_points.Count - count; ++i)
            {
                g.DrawLine(pen, polyhedron_points[i].To2D(), polyhedron_points[i + count].To2D());
            }
            pictureBox_3d_picture.Refresh();
        }

 
        private float segment_func(float x, float y)
        {
            return (float)Math.Sin(x) * (float)Math.Cos(y);
        }

        private void draw_segment_Click(object sender, EventArgs e)
        {
            is_segment = true;
            is_drawn = true;
            float x0, y0, x1, y1;
            int range;

            float.TryParse(segment_x0.Text, out x0);
            float.TryParse(segment_x1.Text, out x1);
            Int32.TryParse(segment_range.Text, out range);
            y0 = x0;
            y1 = x1;
            float step = (x1 - x0) / range;


            for (float i = x0; i < x1; i += step)
                for (float j = y0; j < y1; j += step)
                {
                    g.DrawLine(pen, new Point3d(i, j, segment_func(i, j)).To2D(), new Point3d(i, j + step, segment_func(i, j + step)).To2D());
                    g.DrawLine(pen, new Point3d(i, j, segment_func(i, j)).To2D(), new Point3d(i - step, j, segment_func(i - step, j)).To2D());
                    g.DrawLine(pen, new Point3d(i - step, j, segment_func(i - step, j)).To2D(), new Point3d(i - step, j + step, segment_func(i - step, j + step)).To2D());
                    g.DrawLine(pen, new Point3d(i, j + step, segment_func(i, j + step)).To2D(), new Point3d(i - step, j + step, segment_func(i - step, j + step)).To2D());

                    polyhedron_points.Add(new Point3d(i, j, segment_func(i, j)));
                    polyhedron_points.Add(new Point3d(i, j + step, segment_func(i, j + step)));
                    polyhedron_points.Add(new Point3d(i, j, segment_func(i, j)));
                    polyhedron_points.Add(new Point3d(i - step, j, segment_func(i - step, j)));
                    polyhedron_points.Add(new Point3d(i - step, j, segment_func(i - step, j)));
                    polyhedron_points.Add(new Point3d(i - step, j + step, segment_func(i - step, j + step)));
                    polyhedron_points.Add(new Point3d(i, j + step, segment_func(i, j + step)));
                    polyhedron_points.Add(new Point3d(i - step, j + step, segment_func(i - step, j + step)));

                }
            segment_redraw();
        }

        private void segment_redraw() // Перерисовывание многогранника 
        {
            pictureBox_3d_picture.Image = new Bitmap(pictureBox_3d_picture.Width, pictureBox_3d_picture.Height);
            g = Graphics.FromImage(pictureBox_3d_picture.Image);
            g.Clear(Color.White);
            pictureBox_3d_picture.Refresh();
            g.DrawLine(green_pen, new Point3d(0, 0, 0).To2D(), new Point3d(50, 0, 0).To2D());
            g.DrawLine(red_pen, new Point3d(0, 0, 0).To2D(), new Point3d(0, 50, 0).To2D());
            g.DrawLine(blue_pen, new Point3d(0, 0, 0).To2D(), new Point3d(0, 0, 50).To2D());
            for (int i = 0; i < polyhedron_points.Count; i+=2)
                g.DrawLine(pen, polyhedron_points[i].To2D(), polyhedron_points[i+1].To2D());
            g.DrawLine(new Pen(Color.Red), line.from.To2D(), line.to.To2D());
            pictureBox_3d_picture.Refresh();
        }


        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Лабораторная работа №8. Отсечение нелицевых граней !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        private void button_add_cube_Click(object sender, EventArgs e)
        {
            if (is_drawn == false)
            {
                is_drawn = true;
                float x = float.Parse(textBox_coordinate_X.Text);
                float y = float.Parse(textBox_coordinate_Y.Text);
                float z = float.Parse(textBox_coordinate_Z.Text);
                length = float.Parse(textBox_coordinate_length.Text);
                float length_2 = (float)(length / Math.Sqrt(2));
                Point3d start = new Point3d(x, y, z);
                Point3d p2 = new Point3d(x + length, y , z);
                Point3d p3 = new Point3d(x , y, z + length);
                Point3d p4 = new Point3d(x + length, y , z + length);
                Point3d p5 = new Point3d(x , y + length, z);
                Point3d p6 = new Point3d(x + length, y + length, z);
                Point3d p7 = new Point3d(x, y + length, z + length);
                Point3d p8 = new Point3d(x + length, y + length, z + length);

                polyhedron_points.Add(start);
                polyhedron_points.Add(p2);
                polyhedron_points.Add(p3);
                polyhedron_points.Add(p4);
                polyhedron_points.Add(p5);
                polyhedron_points.Add(p6);
                polyhedron_points.Add(p7);
                polyhedron_points.Add(p8);

                projection_points.Add(start);
                projection_points.Add(p2);
                projection_points.Add(p3);
                projection_points.Add(p4);
                projection_points.Add(p5);
                projection_points.Add(p6);
                projection_points.Add(p7);
                polyhedron_points.Add(p8);

                g.DrawLine(pen, start.To2D(), p2.To2D());
                g.DrawLine(pen, start.To2D(), p3.To2D());
                g.DrawLine(pen, start.To2D(), p5.To2D());
                g.DrawLine(pen, p2.To2D(), p6.To2D());
                g.DrawLine(pen, p2.To2D(), p4.To2D());
                g.DrawLine(pen, p3.To2D(), p4.To2D());
                g.DrawLine(pen, p3.To2D(), p7.To2D());
                g.DrawLine(pen, p4.To2D(), p8.To2D());
                g.DrawLine(pen, p5.To2D(), p7.To2D());
                g.DrawLine(pen, p5.To2D(), p6.To2D());
                g.DrawLine(pen, p6.To2D(), p8.To2D());
                g.DrawLine(pen, p7.To2D(), p8.To2D());

                Polygon3d polygon_1st = new Polygon3d();
                Polygon3d polygon_2nd = new Polygon3d();
                Polygon3d polygon_3rd = new Polygon3d();
                Polygon3d polygon_4th = new Polygon3d();
                Polygon3d polygon_5th = new Polygon3d();
                Polygon3d polygon_6th = new Polygon3d();

                polygon_1st.points.Add(start); polygon_1st.points.Add(p2); polygon_1st.points.Add(p4); polygon_1st.points.Add(p3);
                polygon_2nd.points.Add(start); polygon_2nd.points.Add(p5); polygon_2nd.points.Add(p7); polygon_2nd.points.Add(p3);
                polygon_3rd.points.Add(p5); polygon_3rd.points.Add(p6); polygon_3rd.points.Add(p8); polygon_3rd.points.Add(p7);
                polygon_4th.points.Add(p2); polygon_4th.points.Add(p6); polygon_4th.points.Add(p8); polygon_4th.points.Add(p4);
                polygon_5th.points.Add(start); polygon_5th.points.Add(p5); polygon_5th.points.Add(p6); polygon_5th.points.Add(p2);
                polygon_6th.points.Add(p3); polygon_6th.points.Add(p7); polygon_6th.points.Add(p8); polygon_6th.points.Add(p4);
                main_polyhedron.polygons.Add(polygon_1st);
                main_polyhedron.polygons.Add(polygon_2nd);
                main_polyhedron.polygons.Add(polygon_3rd);
                main_polyhedron.polygons.Add(polygon_4th);
                main_polyhedron.polygons.Add(polygon_5th);
                main_polyhedron.polygons.Add(polygon_6th);
                pictureBox_3d_picture.Refresh();
            }
        }

        private void button_draw_view_Click(object sender, EventArgs e)
        {
            float x1 = float.Parse(textBox_x1_from.Text);
            float y1 = float.Parse(textBox_y1_from.Text);
            float z1 = float.Parse(textBox_z1_from.Text);

            float x2 = float.Parse(textBox_x2_to.Text);
            float y2 = float.Parse(textBox_y2_to.Text);
            float z2 = float.Parse(textBox_z2_to.Text);

            Point3d from = new Point3d(x1, y1, z1);
            Point3d to = new Point3d(x2, y2, z2);

            g.DrawLine(red_pen, from.To2D(), to.To2D());

            g.FillEllipse(new SolidBrush(Color.Red), new Rectangle((int)to.X2D(), (int)to.Y2D(), 5, 5));

            view_vector = new Point3d(x2 - x1, y2 - y1, z2 - z1);

            pictureBox_3d_picture.Refresh();
        }

        private void button_delete_polygons_Click(object sender, EventArgs e)
        {
            pictureBox_3d_picture.Image = new Bitmap(pictureBox_3d_picture.Width, pictureBox_3d_picture.Height);
            g = Graphics.FromImage(pictureBox_3d_picture.Image);
            g.Clear(Color.White);
            Point3d mass = mass_center();
            foreach (Polygon3d polygon in main_polyhedron.polygons)
            {
                Point3d point1 = new Point3d(polygon.points[1].X - polygon.points[0].X, polygon.points[1].Y - polygon.points[0].Y, polygon.points[1].Z - polygon.points[0].Z);
                Point3d point2 = new Point3d(polygon.points[2].X - polygon.points[0].X, polygon.points[2].Y - polygon.points[0].Y, polygon.points[2].Z - polygon.points[0].Z);
                Point3d normal_vect = new Point3d(point1.Y * point2.Z - point1.Z * point2.Y, point1.Z * point2.X - point1.X * point2.Z, point1.X * point2.Y - point1.Y * point2.X);
                Point3d direct = new Point3d(mass.X - polygon.points[0].X, mass.Y - polygon.points[0].Y, mass.Z - polygon.points[0].Z);
                //Point3d norval_vect = new Point3d(temp.X + polygon.points[0].X, temp.Y + polygon.points[0].Y, temp.Z + polygon.points[0].Z);
                double angle = angle_between(normal_vect, direct);
                if (angle < Math.PI / 2)
                {
                    normal_vect = new Point3d(-normal_vect.X, -normal_vect.Y, -normal_vect.Z);
                }
                angle = angle_between(normal_vect, view_vector);
                if (angle > Math.PI / 2 && polygon.points.Count < 5)
                {
                    g.DrawLine(pen, polygon.points[0].To2D(), polygon.points[1].To2D());
                    g.DrawLine(pen, polygon.points[0].To2D(), polygon.points[2].To2D());
                    g.DrawLine(pen, polygon.points[1].To2D(), polygon.points[3].To2D());
                    g.DrawLine(pen, polygon.points[2].To2D(), polygon.points[3].To2D());
                }
                else if (polygon.points.Count < 5)
                {
                    g.DrawLine(red_pen, polygon.points[0].To2D(), polygon.points[1].To2D());
                    g.DrawLine(red_pen, polygon.points[0].To2D(), polygon.points[2].To2D());
                    g.DrawLine(red_pen, polygon.points[1].To2D(), polygon.points[3].To2D());
                    g.DrawLine(red_pen, polygon.points[2].To2D(), polygon.points[3].To2D());
                }
                else
                {
                    if (angle > Math.PI / 2)
                    {
                        for (int i = 0; i < polygon.points.Count - 1; ++i)
                            g.DrawLine(pen, polygon.points[i].To2D(), polygon.points[i + 1].To2D());
                        g.DrawLine(pen, polygon.points[0].To2D(), polygon.points[polygon.points.Count - 1].To2D());
                    }
                    else
                    {
                        {
                            for (int i = 0; i < polygon.points.Count - 1; ++i)
                                g.DrawLine(red_pen, polygon.points[i].To2D(), polygon.points[i + 1].To2D());
                            g.DrawLine(red_pen, polygon.points[0].To2D(), polygon.points[polygon.points.Count - 1].To2D());
                        }
                    }
                }

            }
            pictureBox_3d_picture.Refresh();
        }

        private double angle_between(Point3d first_vector, Point3d second_vector)
        {
            return Math.Acos((first_vector.X * second_vector.X + first_vector.Y * second_vector.Y + first_vector.Z * second_vector.Z)
                            / (Math.Sqrt(first_vector.X * first_vector.X + first_vector.Y * first_vector.Y + first_vector.Z * first_vector.Z)
                            * Math.Sqrt(second_vector.X * second_vector.X + second_vector.Y * second_vector.Y + second_vector.Z * second_vector.Z)));

        }

    }
}