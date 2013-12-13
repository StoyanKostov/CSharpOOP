using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class ShapeTests
    {
        static void Main(string[] args)
        {
            // Create collection of shapes
            Shape[] shapes = new Shape[] { 
                new Triangle( 4, 4), 
                new Triangle( 2, 6), 
                new Rectangle(3, 6), 
                new Rectangle(8, 9), 
                new Circle(4), 
                new Circle(8), 
            };

            // Console output
            foreach (Shape item in shapes)
            {
                Console.WriteLine("Shape type is {0} with surface = {1:F2}", item.GetType().Name, item.CalculateSurface());
            }
        }
    }
}
