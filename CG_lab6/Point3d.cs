using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CG_lab6
{
    class Point3d
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Point3d(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public PointF To2D()
        {
            return new PointF((float)(X + Y/Math.Sqrt(2)), (float)(Z + Y/Math.Sqrt(2)));
        }
    }
}
