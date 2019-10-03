using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_lab4
{
    public partial class Form1 : Form
    {
        bool drawing = false;
        bool is_created = false; //Проверка, был ли создан примитив
        bool is_polygon = false; //Проверяет, был ли создан полигон
        bool is_line = false; //Проверяет, был ли создано ребро
        Bitmap bmp;
        Graphics g;
        Pen pen = new Pen(Color.Black);
        Point from, to; // точки начала и конца ребра или прямой для полигона
        List<Point> polygon_points = new List<Point>(); // Список точек полигона
        bool is_point; //Нужно ли задать точку для действия с ней
        bool is_second_line; // Нужно ли нарисовать вторую линию
        Point random_point = new Point(0,0); //Точка относительно которой преобразования ( может быть центром масс)
        Point from_second, to_second; // Точки для задание второй линии

        public Form1()
        {
            InitializeComponent();
            comboBox_actions.Items.AddRange(new string[] {"","Смещение","Поворот вокруг точки","Поворот вокруг центра","Масштабировнаие относительно точки", "Масштабировнаие относительно центра","Точка в полигоне" });
            comboBox_actions_line.Items.AddRange(new string[] { "", "Поворот ребра на 90", "Точка пересечения", "Положение точки" });
            canvas.Image = new Bitmap(canvas.Width, canvas.Height);
            bmp = (Bitmap)canvas.Image;
            //Clear();
            canvas.Image = bmp;
            g = Graphics.FromImage(canvas.Image);
            g.Clear(Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_canvas(object sender, EventArgs e) // Кнопка очищения поля для рисования и всех других параметров
        {
            label_help.Visible = false;
            textBox_dX.Visible = false;
            textBox_dY.Visible = false;
            label_dX.Visible = false;
            label_dY.Visible = false;
            label_angle.Visible = false;
            textBox_angle.Visible = false;
            label_location_random_point.Visible = false;
            button_make_convert.Visible = false;
            drawing = false;
            is_created = false;
            is_polygon = false;
            is_point = false;
            is_line = false;
            is_second_line = false;
            polygon_points.Clear();
            random_point = new Point(0, 0);
            comboBox_actions.SelectedIndex = 0;
            comboBox_actions_line.SelectedIndex = 0;
            canvas.Image = new Bitmap(canvas.Width, canvas.Height);
            g = Graphics.FromImage(canvas.Image);
            g.Clear(Color.White);
            canvas.Refresh();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e) // Проверка нажатия мышки
        {
            if (!is_created) //Если ещё не создан примитив
            {
                drawing = true;
                from = e.Location;
                to = e.Location;
            }
            if (is_second_line) //Для рисования второй линии в "Точка пересечения 2х линия"
            {
                from_second = e.Location;
                to_second = e.Location;
            }
        }
    
        private void canvas_MouseUp(object sender, MouseEventArgs e) //Проверка отпускания мышки
        {
            if (!is_created) //Если ещё не создан примитив
            {
                if (radioButton_dot.Checked) // Если выбрана "точка"
                    g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(to.X, to.Y, 3, 3));
                else if (radioButton_line.Checked) // Если выбрано "ребро"
                {
                    is_line = true;
                    g.DrawLine(pen, from, to);
                }
                else if (radioButton_square.Checked) //Если выбран "прямоугольник"
                {
                    is_polygon = true;
                    if (from.X > to.X) //Упорядочиваем 
                    {
                        int temp = from.X;
                        from.X = to.X;
                        to.X = temp;
                    }
                    if (from.Y > to.Y)
                    {
                        int temp = from.Y;
                        from.Y = to.Y;
                        to.Y = temp;
                    }
                    g.DrawRectangle(pen, new Rectangle(from.X, from.Y, to.X - from.X, to.Y - from.Y));
                    polygon_points.Add(new Point(from.X, from.Y)); //Добавляем точки в список точек полигона
                    polygon_points.Add(new Point(from.X, to.Y));
                    polygon_points.Add(new Point(to.X, to.Y));
                    polygon_points.Add(new Point(to.X, from.Y));
                }
                else if (radioButton_polygon.Checked) //Если выбран "Полигон"
                {
                    if (e.Button == MouseButtons.Right) //Дорисовывание происходит по нажатию правой кнопки мыши
                    {
                        if (polygon_points.Count < 3)
                        {
                            label_help.Visible = true;
                            label_help.Text = "Недостаточно сторон";
                            canvas.Refresh();
                        }
                        else
                        {
                            label_help.Visible = false;
                            g.DrawLine(pen, polygon_points.First(), polygon_points.Last());
                            drawing = false;
                            is_created = true;
                            is_polygon = true;
                            canvas.Refresh();
                        }
                    }
                    else if (polygon_points.Count == 0) // Рисование полигона и добавление точек в список 
                    {
                        g.DrawLine(pen, from, to);
                        polygon_points.Add(from);
                        polygon_points.Add(to);
                        canvas.Refresh();
                    }
                    else
                    {
                        g.DrawLine(pen, polygon_points.Last(), to);
                        polygon_points.Add(to);
                        canvas.Refresh();
                    }
                }
                if (!radioButton_polygon.Checked) {
                    drawing = false;
                    is_created = true;
                    canvas.Refresh();
                }
            }
            if (is_point) //Рисование точки для некоторых заданий
            {
                g.FillEllipse(new SolidBrush(Color.White), new Rectangle(random_point.X, random_point.Y, 3, 3));
                random_point = new Point(e.X, e.Y);
                g.FillEllipse(new SolidBrush(Color.Black), new Rectangle(e.X, e.Y, 3, 3));
                canvas.Refresh();
                label_location_random_point.Text = random_point.ToString();
            }
            if (is_second_line) //Рисование линии в "Точка пересечения 2х линия" 
            {
                g.DrawLine(pen, from_second, to_second);
                is_second_line = false;
                canvas.Refresh();
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e) // Проверка движении мыши
        {
            if (drawing)
            {
                to = e.Location;
                canvas.Invalidate();
            }
            if (is_second_line) //Обновление данных второй точки в "Точка пересечения 2х линия" 
            {
                to_second = e.Location;
                canvas.Invalidate();          
            }
        }

        private void comboBox_actions_SelectedIndexChanged(object sender, EventArgs e) //Действия при выборе какого-либо пункта в "Действия с полигоном"
        {
            if (!is_polygon && comboBox_actions.Text!="")
            {
                label_help.Text = "Не нарисован полигон.";
                label_help.Visible = true;
            }
            else
            {
                if (is_polygon)
                {
                    button_make_convert.Visible = true;
                    label_help.Visible = true;
                }
                switch(comboBox_actions.SelectedItem.ToString())
                {
                    case "Смещение":
                        label_help.Text = "Введите кординаты";
                        textBox_dX.Visible = true;
                        textBox_dY.Visible = true;
                        label_dX.Text = "Сдвинуть X";
                        label_dY.Text = "Сдвинуть Y";
                        label_dX.Visible = true;
                        label_dY.Visible = true;
                        label_angle.Visible = false;
                        textBox_angle.Visible = false;
                        label_location_random_point.Visible = false;
                        break;

                    case "Поворот вокруг точки":
                        label_help.Text = "Введите угол и выберите точку";
                        textBox_dX.Visible = false;
                        textBox_dY.Visible = false;
                        label_dX.Visible = false;
                        label_dY.Visible = false;
                        label_angle.Visible = true;
                        textBox_angle.Visible = true;
                        label_location_random_point.Visible = true;
                        label_location_random_point.Text = random_point.ToString();
                        is_point = true;
                        break;

                    case "Поворот вокруг центра":
                        label_help.Text = "Введите угол";
                        textBox_dX.Visible = false;
                        textBox_dY.Visible = false;
                        label_dX.Visible = false;
                        label_dY.Visible = false;
                        label_angle.Visible = true;
                        textBox_angle.Visible = true;
                        label_location_random_point.Visible = false;
                        break;

                    case "Масштабировнаие относительно точки":
                        label_help.Text = "Введите коэффициенты и выберите точку";
                        textBox_dX.Visible = true;
                        textBox_dY.Visible = true;
                        label_dX.Text = "Коэф. X";
                        label_dY.Text = "Коэф. Y";
                        label_dX.Visible = true;
                        label_dY.Visible = true;
                        label_angle.Visible = false;
                        textBox_angle.Visible = false;
                        label_location_random_point.Visible = true;
                        label_location_random_point.Text = random_point.ToString();
                        is_point = true;
                        break;

                    case "Масштабировнаие относительно центра":
                        label_help.Text = "Введите коэффициенты";
                        textBox_dX.Visible = true;
                        textBox_dY.Visible = true;
                        label_dX.Text = "Коэф. X";
                        label_dY.Text = "Коэф. Y";
                        label_dX.Visible = true;
                        label_dY.Visible = true;
                        label_angle.Visible = false;
                        textBox_angle.Visible = false;
                        label_location_random_point.Visible = false;
                        break;

                    case "Точка в полигоне":
                        label_help.Text = "Выберите точку";
                        label_angle.Visible = false;
                        label_dX.Visible = false;
                        label_dY.Visible = false;
                        label_location_random_point.Visible = true;
                        label_location_random_point.Text = random_point.ToString();
                        textBox_dX.Visible = false;
                        textBox_dY.Visible = false;
                        textBox_angle.Visible = false;
                        is_point = true;
                        break;
                }
            }
        }

        private void comboBox_ations_line_SelectedIndexChanged(object sender, EventArgs e) //Действия при выборе какого-либо пункта в "Действия с ребром"
        {
            if (!is_line && comboBox_actions_line.Text != "")
            {
                label_help.Text = "Не нарисовано ребро.";
                label_help.Visible = true;
            }
            else
            {
                if (is_line)
                {
                    button_make_convert.Visible = true;
                    label_help.Visible = true;
                }
                switch (comboBox_actions_line.SelectedItem.ToString())
                {
                    case "Поворот ребра на 90":
                        label_help.Text = "Нажмите кнопку";
                        label_angle.Visible = false;
                        label_dX.Visible = false;
                        label_dY.Visible = false;
                        label_location_random_point.Visible = false;
                        textBox_dX.Visible = false;
                        textBox_dY.Visible = false;
                        textBox_angle.Visible = false;
                        break;

                    case "Точка пересечения":
                        label_help.Text = "Нарисуйте прямую";
                        label_angle.Visible = false;
                        label_dX.Visible = false;
                        label_dY.Visible = false;
                        label_location_random_point.Visible = false;
                        textBox_dX.Visible = false;
                        textBox_dY.Visible = false;
                        textBox_angle.Visible = false;
                        is_second_line = true;
                        break;

                    case "Положение точки":
                        label_help.Text = "Выберите точку";
                        label_angle.Visible = false;
                        label_dX.Visible = false;
                        label_dY.Visible = false;
                        label_location_random_point.Visible = true;
                        textBox_dX.Visible = false;
                        textBox_dY.Visible = false;
                        textBox_angle.Visible = false;
                        is_point = true;
                        break;
               }
            }
        }

        private void button_make_convert_Click(object sender, EventArgs e) //Контроль вызова метода по выбраному пункту по нажатию кнопки
        {
            int angle;
            int x_change;
            int y_change;
            double kX;
            double kY;
            if (is_polygon)
            {
                switch (comboBox_actions.SelectedItem.ToString())
                {
                    case "Смещение":
                        x_change = Int32.Parse(textBox_dX.Text);
                        y_change = Int32.Parse(textBox_dY.Text);
                        change_position(x_change, y_change);
                        break;

                    case "Поворот вокруг точки":
                        angle = Int32.Parse(textBox_angle.Text);
                        turn(angle);
                        break;

                    case "Поворот вокруг центра":
                        angle = Int32.Parse(textBox_angle.Text);
                        mass_center();
                        turn(angle);
                        break;

                    case "Масштабировнаие относительно точки":
                        kX = Double.Parse(textBox_dX.Text);
                        kY = Double.Parse(textBox_dY.Text);
                        scaling(1 / kX, 1 / kY);
                        break;

                    case "Масштабировнаие относительно центра":
                        kX = Double.Parse(textBox_dX.Text);
                        kY = Double.Parse(textBox_dY.Text);
                        mass_center();
                        scaling(1 / kX, 1 / kY);
                        break;

                    case "Точка в полигоне":
                        in_polygon();
                        break;
                }
            }
            if (is_line)
            {
                switch (comboBox_actions_line.SelectedItem.ToString())
                {
                    case "Поворот ребра на 90":
                        middle_line();
                        turn_line();
                        break;

                    case "Точка пересечения":
                        point_cross();
                        break;

                    case "Положение точки":
                        point_location();
                        break;
                }
            }
        }

        private void change_position(int x_change, int y_change) //Смещение на x_change и y_change 
        {
            for (int i = 0; i < polygon_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0 }, { polygon_points[i].X, polygon_points[i].Y, 1 }, { 0, 0, 0 } };
                double[,] new_matr = { { 1, 0, 0 }, { 0, 1, 0 }, { -x_change, -y_change, 1 } };
                old_matr = matrix_multiplication(old_matr, new_matr);
                polygon_points[i] = get_point_from_matrix(old_matr);
            }
            redraw();
        }

        private void turn(int angle) //Поворачивание относительно точки на угол angle (точка задается random_point, которая может быть равна центру полигона)
        {
            double cos = Math.Cos(Math.PI / 180 * angle);
            double sin = Math.Sin(Math.PI / 180 * angle);
            for (int i = 0; i < polygon_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0 }, { polygon_points[i].X, polygon_points[i].Y, 1 }, { 0, 0, 0 } };
                double[,] matr_dot = { { 1, 0, 0 }, { 0, 1, 0 }, { -random_point.X, -random_point.Y, 1 } };
                double[,] matr_angle = { { cos, sin, 0 }, { -sin, cos, 0 }, { 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0 }, { 0, 1, 0 }, { random_point.X, random_point.Y, 1 } };
                old_matr = matrix_multiplication(old_matr, matr_dot);
                old_matr = matrix_multiplication(old_matr, matr_angle);
                old_matr = matrix_multiplication(old_matr, new_matr);
                polygon_points[i] = get_point_from_matrix(old_matr);
            }
            redraw();
        }

        private void scaling(double kX, double kY) //Масштабирование относительно точки на коэффициенты kX и kY (точка задается random_point, которая может быть равна центру полигона)
        {
            for (int i = 0; i < polygon_points.Count; ++i)
            {
                double[,] old_matr = { { 0, 0, 0 }, { polygon_points[i].X, polygon_points[i].Y, 1 }, { 0, 0, 0 } };
                double[,] matr_dot = { { 1, 0, 0 }, { 0, 1, 0 }, { -random_point.X, -random_point.Y, 1 } };
                double[,] matr_coef = { { kX, 0, 0 }, { 0, kY, 0 }, { 0, 0, 1 } };
                double[,] new_matr = { { 1, 0, 0 }, { 0, 1, 0 }, { random_point.X, random_point.Y, 1 } };
                old_matr = matrix_multiplication(old_matr, matr_dot);
                old_matr = matrix_multiplication(old_matr, matr_coef);
                old_matr = matrix_multiplication(old_matr, new_matr);
                polygon_points[i] = get_point_from_matrix(old_matr);
            }
            redraw();
        }

        private void in_polygon() // Проверка на вхождение точки в полигон - метод лучей(точка = random_button)
        {
            //Задача Ани
        }

        private void turn_line() //Поворачивание ребра на 90 градусов
        {
            //Задача Серого
        }

        private void point_cross() //Точка пересечения 2х прямых
        {
            //Задача Серого
        }
        private void point_location() // Определяет положение точки относительно ребра
        {
            //Задача Ани
        }


        private double[,] matrix_multiplication(double[,] matr1, double[,] matr2) // Умножение матриц
        {
            double[,] result = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    for (int k = 0; k < 3; ++k)
                        result[i, j] += matr1[i, k] * matr2[k, j];
            return result;
        }

        private Point get_point_from_matrix(double[,] matr) // Получение точки из конечной матрицы
        {
            return new Point((int)matr[1,0],(int)matr[1,1]);
        }

        private void mass_center() // Находит точку центр масс и заносит значение в random_point
        {
            int size = polygon_points.Count;
            int x = 0, y = 0;
            for (int i = 0; i < size; i++)
            {
                x += polygon_points[i].X;
                y += polygon_points[i].Y;
            }
            random_point = new Point(x / size, y / size);
        }

        private void middle_line() // Находит точку середины ребра и заносит значение в random_point 
        {
            random_point = new Point((from.X + to.X)/2, (from.Y + to.Y) / 2);
        }

        private void redraw() // Перерисовывание полигона 
        {
            canvas.Image = new Bitmap(canvas.Width, canvas.Height);
            g = Graphics.FromImage(canvas.Image);
            g.Clear(Color.White);
            canvas.Refresh();
            for (int i = 0; i < polygon_points.Count - 1; ++i)
                g.DrawLine(pen, polygon_points[i], polygon_points[i + 1]);
            g.DrawLine(pen, polygon_points.Last(), polygon_points.First());
            canvas.Refresh();
        }
    }
}
