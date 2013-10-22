using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Point3D
    {
        // Fields
        private static Point3D pointO = new Point3D(0, 0, 0);

        // Proparties
        public Point3D pointO { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        // Methods
        public override string ToString()
        {
            return string.Format("Coordinates: x = {0}, y = {1}, z = {2}", this.X, this.Y, this.Z);
        }

        // Constructor
        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
