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
    public partial class Light : Form
    {
        public Point3d position { get; private set; }
        public Color color_object { get; private set; }
        public Light()
        {
            InitializeComponent();
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            textBox_color.BackColor = colorDialog1.Color;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox_x.Text.ToString());
            int y = Int32.Parse(textBox_x.Text.ToString());
            int z = Int32.Parse(textBox_x.Text.ToString());
            position = new Point3d(x, y, z);
            color_object = textBox_color.BackColor;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
