using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1; 
            this.AttackPoints = 0;
        }

        public int AttackPoints { get; private set; }

        public int DefensePoints
        {
            get { return int.MaxValue; } // but should be invulnerable – it should not be able to be destroyed by other objects. 
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int currentHighestHitPoints = availableTargets[0].HitPoints;
            int indexHighestHitPoints = 0;

            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0) // and has the highest HitPoints of all the available targets.
                {
                    if (availableTargets[i].HitPoints > currentHighestHitPoints)
                    {
                        currentHighestHitPoints = availableTargets[i].HitPoints;
                        indexHighestHitPoints = i;
                    }
                    return indexHighestHitPoints;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone) // For each stone resource the Ninja has gathered, its AttackPoints should increase by the resource’s quantity multiplied by 2
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }
            if (resource.Type == ResourceType.Lumber) // AttackPoints should increase by the resource’s quantity
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }
            return false;
        }
    }
}
