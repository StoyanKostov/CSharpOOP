using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Circle : Shape
    {
        // Constructor
        public Circle(double radius)
            : base(radius, radius)
        {
        }

        // Methods
        public override double CalculateSurface()
        {
            return Math.PI * this.Width * 2;
        }
    }
}
