using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab6
{
    class Line3d
    {
        public Point3d from { get; set; }
        public Point3d to { get; set; }

        public Line3d()
        {
            this.from = new Point3d();
            this.to = new Point3d();
        }
        public Line3d( Point3d from,  Point3d to)
        {
            this.from = from;
            this.to = to;
        }
    }
}
