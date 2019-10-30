using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab6
{

    class Polyhedron
    {
        public List<Polygon3d> polygons { get; set; }

        public Polyhedron()
        {
            this.polygons = new List<Polygon3d>();
        }
        public Polyhedron( List<Polygon3d> polygons)
        {
            this.polygons = polygons;
        }
    }
}
