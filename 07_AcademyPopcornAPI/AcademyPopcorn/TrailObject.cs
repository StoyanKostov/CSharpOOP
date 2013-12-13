using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class TrailObject : GameObject
    {
        // Fields
        public int Lifetime { get; set; }

        // Constructor
        public TrailObject(MatrixCoords topLeft, int lifetime)
            : base(topLeft, new char[,] { { '.' } })
        {
            this.Lifetime = lifetime;
        }

        // Methods
        public override void Update()
        {
            this.Lifetime--;
            if (this.Lifetime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
