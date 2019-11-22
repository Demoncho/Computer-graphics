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
    public class Point3d
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

        public Point3d(Point3d p)
        {
            this.X = p.X;
            this.Y = p.Y;
            this.Z = p.Z;
        }

        static public bool operator ==(Point3d p1, Point3d p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        static public bool operator !=(Point3d p1, Point3d p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y || p1.Z != p2.Z;
        }

        public PointF To2D()
        {
            return new PointF((float)(275 + X ), (float)(275 + Z));
            //return new PointF((float)(275 + X + Y/Math.Sqrt(2)), (float)(275 + Z + Y/Math.Sqrt(2)));
            //return new PointF((float)(X + 275 - 50), (float)((550 - Y) - 275 + 50));
        }

        public float X2D()
        {
            return (float)(275 + X);
            //return (float)(275 + X + Y / Math.Sqrt(2));
        }

        public float Y2D()
        {
            return (float)(275 + Z);
            // return (float)(275 + Z + Y / Math.Sqrt(2));
        }
    }
}
