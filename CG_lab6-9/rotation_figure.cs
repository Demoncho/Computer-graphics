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
    public partial class Rotation_figure : Form
    {
        public List<Point3d> Points { get; private set; }
        public char Axis { get; private set; }
        public int Count { get; private set; }
        public Rotation_figure()
        {
            Points = new List<Point3d>();
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox_X.Text);
            float y = float.Parse(textBox_Y.Text);
            float z = float.Parse(textBox_Z.Text);
            Points.Add(new Point3d(x, y, z));
            label_points_list.Text += "( " + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ") \n";
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (Points.Count > 1)
            {
                Axis = textBox_axis.Text[0];
                Count = Int32.Parse(textBox_count.Text);
                DialogResult = DialogResult.OK;
                Close();
            }

            else
            {
                DialogResult = DialogResult.Ignore;
            }
        }

    }
}
