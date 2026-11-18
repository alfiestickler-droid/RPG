using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class DungeonOverLord : NPC
    {
        public DungeonOverLord(double health = 200, double attackMax = 70, double defenseMax = 70, double armour = 30) : base(health, attackMax, defenseMax, armour)
        {
        }
    }
}
