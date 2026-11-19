using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Goblin : NPC
    {
        public Goblin(double health = 20, double attackMax = 5, double defenseMax = 5, double armour = 0) : base(health, attackMax, defenseMax, armour)
        {
        }
    }
}
