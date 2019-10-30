using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab6
{
    class Polygon3d
    {
        public List<Line3d> lines { get; set; } = new List<Line3d>();

        public Polygon3d(ref List<Line3d> lines)
        {
            this.lines = lines;
        }
    }
}
