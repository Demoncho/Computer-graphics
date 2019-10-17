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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_L_sytems_Click(object sender, EventArgs e)
        {
            new L_systems().Show();
        }

        private void button_Diamond_square_Click(object sender, EventArgs e)
        {
            new Diamond_square().Show();
        }
    }
}
