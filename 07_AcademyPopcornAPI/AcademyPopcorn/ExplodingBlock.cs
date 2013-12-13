using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplodingBlock : Block
    {
        // Constructor
        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
        }

        // Methods
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> explosionParticles = new List<GameObject>();
            if (this.IsDestroyed)
            {
                explosionParticles.Add(new ExplosionParticle(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(-1, 0)));
                explosionParticles.Add(new ExplosionParticle(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(1, 0)));
                explosionParticles.Add(new ExplosionParticle(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(0, 1)));
                explosionParticles.Add(new ExplosionParticle(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(0, -1)));
                explosionParticles.Add(new ExplosionParticle(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(1, -1)));
                explosionParticles.Add(new ExplosionParticle(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(-1, 1)));
                explosionParticles.Add(new ExplosionParticle(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(-1, -1)));
                explosionParticles.Add(new ExplosionParticle(this.topLeft, new char[,] { { '+' } }, new MatrixCoords(1, 1)));
            }
            return explosionParticles;
       }
    }
}
