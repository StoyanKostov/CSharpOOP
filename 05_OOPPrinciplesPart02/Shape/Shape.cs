using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape
    {
        // Fields
        private double width, height;

        // Properties
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can't be negative");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can't be negative");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        // Constructor
        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // Methods
        public abstract double CalculateSurface();
    }
}
