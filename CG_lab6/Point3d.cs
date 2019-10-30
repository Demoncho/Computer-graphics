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
    class Point3d
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Point3d()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        public Point3d(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public PointF To2D()
        {
            return new PointF((float)(275 + X + Y/Math.Sqrt(2)), (float)(275 + Z + Y/Math.Sqrt(2)));
            //return new PointF((float)(X + 275 - 50), (float)((550 - Y) - 275 + 50));
        }
    }
}
