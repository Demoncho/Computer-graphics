using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab6
{
    class Polygon3d
    {
        public List<Point3d> points { get; set; }

        public Polygon3d()
        {
            this.points = new List<Point3d>();
        }
        public Polygon3d( List<Point3d> points)
        {
            this.points = points;
        }
    }
}
