using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Triangle : Shape
    {
        // Constructor
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        // Methods
        public override double CalculateSurface()
        {
            return (this.Width * this.Height / 2);
        }
    }
}
