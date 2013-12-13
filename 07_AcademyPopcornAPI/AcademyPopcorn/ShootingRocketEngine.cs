using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ShootingRocketEngine : Engine
    {
        // Constructor
        public ShootingRocketEngine(IRenderer renderer, IUserInterface userInterface, uint sleepTimeMiliseconds = 500)
            : base(renderer, userInterface, sleepTimeMiliseconds)
        { 
        }
        // Methods
        public void ShootPlayerRacket()
        {
            //if (this.playerRacket is ShoothingRacket)
            //{
            //    (this.playerRacket as ShoothingRacket).Shoot();
            //}
        }
    }
}
