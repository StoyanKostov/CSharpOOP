using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class MeteoriteBall : Ball
    {
        // Fields
        List<GameObject> trail;
        private int trailLife = 3;

        // Constructor
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
            
        }

        // Methods

        public override IEnumerable<GameObject> ProduceObjects()
        {
            this.trail = new List<GameObject>();
            this.trail.Add(new TrailObject(this.topLeft, this.trailLife));
            return this.trail;
        }
    }
}
