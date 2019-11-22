using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_lab6
{
    class Camera_class
    {
        public Point3d position { get; set; }
        public Point3d view { get; set; }

        public Camera_class()
        {
            position = new Point3d(0, 0, 0);
            position = new Point3d(0, 0, 0);
        }

        public Camera_class(Point3d pos, Point3d view)
        {
            this.position = pos;
            this.view = view;
        }

    }
}
