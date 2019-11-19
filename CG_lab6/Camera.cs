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
    public partial class Camera : Form
    {
        public int X1 { get; private set; }
        public int Y1 { get; private set; }
        public int Z1 { get; private set; }
        public int X2 { get; private set; }
        public int Y2 { get; private set; }
        public int Z2 { get; private set; }

        public Camera()
        {
            InitializeComponent();
        }

        private void button_create_camera_Click(object sender, EventArgs e)
        {
            X1 = Int32.Parse(x1.Text.ToString());
            Y1 = Int32.Parse(y1.Text.ToString());
            Z1 = Int32.Parse(z1.Text.ToString());

            X2 = Int32.Parse(x2.Text.ToString());
            Y2 = Int32.Parse(y2.Text.ToString());
            Z2 = Int32.Parse(z2.Text.ToString());

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
