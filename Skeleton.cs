using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Skeleton : NPC
    {
        public Skeleton(double health = 40, double attackMax = 15, double defenseMax = 10, double armour = 3) : base(health, attackMax, defenseMax, armour)
        {
        }
    }
}
