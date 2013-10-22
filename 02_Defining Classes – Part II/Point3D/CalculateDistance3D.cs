using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class CalculateDistance3D
    {
        // Constructor
        public static double CalculateDistance3D(Point3D a, Point3D b)
        {
            double distance = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
            return distance;
        }
    }
}
