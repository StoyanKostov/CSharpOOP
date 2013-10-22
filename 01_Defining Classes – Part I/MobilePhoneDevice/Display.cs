using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class Display
    {
        // Fields
        private string model;
        private double? displaySize;
        private uint? displayColors;

        // Properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double? DisplaySize
        {
            get { return this.displaySize; }
            set 
            {
                if (this.displaySize <= 0)
                {
                    throw new ArgumentException("Ivalid display size input!");
                }
                else
                {
                    this.displaySize = value;
                }
            }
        }

        public uint? DisplayColors
        {
            get { return this.displayColors; }
            set 
            {
                if (this.displayColors <= 0)
                {
                    throw new ArgumentException("Ivalid display colors input!");
                }
                else
                {
                    this.displayColors = value;
                }
            }
        }

        // Methods
        public override string ToString()
        {
            return string.Format("model {0}, size {1}, colors {2}", this.Model, this.DisplaySize, this.DisplayColors);
        }
        // Constructor
        public Display(string model = null, double? displaySize = null, uint? displayColors = null)
        {
            this.Model = model;
            this.DisplaySize = displaySize;
            this.DisplayColors = displayColors;
        }
    }
}
