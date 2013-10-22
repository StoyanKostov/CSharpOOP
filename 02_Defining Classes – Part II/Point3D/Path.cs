using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Path
    {
        // fields
        private List<Point3D> pointHolder = new List<Point3D>();

        // Proparty
        public List<Point3D> PointHolder
        {
            get { return pointHolder; }
            private set { this.pointHolder = value; }
        }

        // Method
        public void AddPoint(Point3D a)
        {
            this.PointHolder.Add(a);
        }
    }
}
