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

        public Line3d(ref Point3d from, ref Point3d to)
        {
            this.from = from;
            this.to = to;
        }
    }
}
