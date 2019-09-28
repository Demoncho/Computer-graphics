using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Task1b : Form
    {
        Image image_for_fill;
        string path_of_pic = @"C:\Users\demon\Downloads\шедевр.jpg"; //поменять путь в зависимости от картинки
        Graphics g;
        Point from, to, start_fill_point;
        bool drawing = true;
        Bitmap drawn_image, filling_image;
        List<Point> border;

        public Task1b()
        {
            InitializeComponent();
            image_to_draw.Image = new Bitmap(image_to_draw.Width, image_to_draw.Height);
            g = Graphics.FromImage(image_to_draw.Image);
            g.Clear(Color.White);
            image_for_filling.Visible = true;
            choice_box.Visible = true;
            show_image_for_filling();
            border = new List<Point>();
        }

        void show_image_for_filling() // показывает изображением, которым залиивается
        {
            if (path_of_pic != null)
            {
                image_for_fill = Image.FromFile(path_of_pic);
                image_for_filling.Image = image_for_fill;
            }
            else
            {
                image_for_filling.Image = null;
            }
        }


        private Bitmap make_not_white(Image img) //убирает полностью белый цвет с изображения
        {
            Bitmap temp= new Bitmap(img);
            for (int i = 0; i < img.Width; ++i)
                for (int j = 0; j < img.Height; ++j)
                    if (temp.GetPixel(i, j) == Color.FromArgb(255, 255, 255, 255))
                        temp.SetPixel(i, j, Color.FromArgb(254, 254, 254, 254));
            return temp;
        }

        private void draw_radioButton_check(object sender, EventArgs e) // проверяет кнопку Draw/Clear
        {
            if (draw_radioButton.Checked)
            {
                drawing = true;
                image_to_draw.Image = new Bitmap(image_to_draw.Width, image_to_draw.Height);
                g = Graphics.FromImage(image_to_draw.Image);
                g.Clear(Color.White);
                border = new List<Point>();
                image_to_draw.Refresh();
            }
        }

        void fill_with_image(int x, int y) // ф-ия заполнения области картинкой, начиная с точки (x,y)
        {
            int step_XRight = 0, step_XLeft = -1;
            bool stop_right = false, stop_left = false;
            while ((!stop_right || !stop_left) && x > 0 && x < drawn_image.Width && y > 0 && y < drawn_image.Height)
            {
                if ((x + step_XRight) < drawn_image.Width && !border.Contains(new Point(x + step_XRight, y))
                    && !border.Contains(new Point(x + step_XRight, y - 1)) && !border.Contains(new Point(x + step_XRight, y + 1))
                    && drawn_image.GetPixel(x + step_XRight, y) == Color.FromArgb(255, 255, 255, 255)) // линия по x вправо
                {
                    drawn_image.SetPixel(x + step_XRight, y, filling_image.GetPixel((((x + step_XRight - start_fill_point.X) % filling_image.Width) + filling_image.Width) % filling_image.Width,
                        ((((y - start_fill_point.Y) % filling_image.Height)) + filling_image.Height) % filling_image.Height));
                    step_XRight++;
                }
                else
                    stop_right = true;
                if ((x + step_XLeft) > 0 && !border.Contains(new Point(x + step_XLeft, y))
                    && !border.Contains(new Point(x + step_XLeft, y - 1)) && !border.Contains(new Point(x + step_XLeft, y + 1))
                    && drawn_image.GetPixel(x + step_XLeft, y) == Color.FromArgb(255, 255, 255, 255)) // линия по х влево
                {
                    drawn_image.SetPixel(x + step_XLeft, y, filling_image.GetPixel((((x + step_XLeft - start_fill_point.X) % filling_image.Width) + filling_image.Width) % filling_image.Width, 
                        ((((y - start_fill_point.Y) % filling_image.Height)) + filling_image.Height) % filling_image.Height));
                    step_XLeft--;
                }
                else
                    stop_left = true;
            }
            image_to_draw.Image = drawn_image;
            for (int i = step_XLeft + 3; i < step_XRight; i++)
            {
                fill_with_image(x + i, y - 1);
                fill_with_image(x + i, y + 1);
            }
        }


        private void image_to_draw_MouseMove(object sender, MouseEventArgs e) //действие при движении мышки - рисование 
        {
            if (e.Button == MouseButtons.Left && drawing)
            {
                Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
                g.DrawLine(pen, from, e.Location);
                image_to_draw.Refresh();
                from = e.Location;
            }
        }

        private void image_to_draw_MouseDown(object sender, MouseEventArgs e) //действие при нажимании мышки - задача точки начала рисования
        {
            if (drawing || draw_radioButton.Checked)
            {
                from = e.Location;
                border.Add(from);
                to = e.Location;
                drawing = true;
            }
        }

        private void image_to_draw_Click(object sender, EventArgs e)
        {

        }

        private void image_to_draw_MouseUp(object sender, MouseEventArgs e) //действие при отпускании мышки - конец рисования
        {
            if (drawing)
            {
                drawing = false;
                Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));

                image_to_draw.Refresh();
                drawn_image = new Bitmap(image_to_draw.Image);
                make_border(from);
            }
        }

        private void image_to_draw_MouseClick(object sender, MouseEventArgs e) // проверка на готовность заполнения картинкой
        {
            if (fill_radioButton.Checked)
            {
                drawn_image = new Bitmap(image_to_draw.Image);
                filling_image = new Bitmap(make_not_white(image_for_fill));
                start_fill_point = e.Location;
                fill_with_image(e.X, e.Y);
            }
        }

        void make_border(Point possibleBorder) // создает границу нарисованного изображения
        {
            Point temp = new Point(possibleBorder.X, possibleBorder.Y);
            if (temp.Y - 1 > 0
                && drawn_image.GetPixel(temp.X, temp.Y - 1) == Color.FromArgb(255, 0, 0, 0))
            {
                temp.Y--;
                if (!border.Contains(temp))
                {
                    border.Add(temp);
                    make_border(temp);
                }
            }
            if (temp.Y - 1 > 0 && temp.X + 1 < drawn_image.Width
                && drawn_image.GetPixel(temp.X + 1, temp.Y - 1) == Color.FromArgb(255, 0, 0, 0))
            {
                temp.Y--;
                temp.X++;
                if (!border.Contains(temp))
                {
                    border.Add(temp);
                    make_border(temp);
                }
            }
            if (temp.X + 1 < drawn_image.Width
                && drawn_image.GetPixel(temp.X + 1, temp.Y) == Color.FromArgb(255, 0, 0, 0))
            {
                temp.X++;
                if (!border.Contains(temp))
                {
                    border.Add(temp);
                    make_border(temp);
                }
            }
            if (temp.X + 1 < drawn_image.Width && temp.Y + 1 < drawn_image.Height
                && drawn_image.GetPixel(temp.X + 1, temp.Y + 1) == Color.FromArgb(255, 0, 0, 0))
            {
                temp.Y++;
                temp.X++;
                if (!border.Contains(temp))
                {
                    border.Add(temp);
                    make_border(temp);
                }
            }
            if (temp.Y + 1 < drawn_image.Height
                && drawn_image.GetPixel(temp.X, temp.Y + 1) == Color.FromArgb(255, 0, 0, 0))
            {
                temp.Y++;
                if (!border.Contains(temp))
                {
                    border.Add(temp);
                    make_border(temp);
                }
            }
            if (temp.X - 1 > 0 && temp.Y + 1 < drawn_image.Height
                && drawn_image.GetPixel(temp.X - 1, temp.Y + 1) == Color.FromArgb(255, 0, 0, 0))
            {
                temp.Y++;
                temp.X--;
                if (!border.Contains(temp))
                {
                    border.Add(temp);
                    make_border(temp);
                }
            }
            if (temp.X - 1 > 0
                && drawn_image.GetPixel(temp.X - 1, temp.Y) == Color.FromArgb(255, 0, 0, 0))
            {
                temp.X--;
                if (!border.Contains(temp))
                {
                    border.Add(temp);
                    make_border(temp);
                }
            }
            if (temp.X - 1 > 0 && temp.Y - 1 > 0
                && drawn_image.GetPixel(temp.X - 1, temp.Y - 1) == Color.FromArgb(255, 0, 0, 0))
            {
                temp.Y--;
                temp.X--;
                if (!border.Contains(temp))
                {
                    border.Add(temp);
                    make_border(temp);
                }
            }
        }
    }
}