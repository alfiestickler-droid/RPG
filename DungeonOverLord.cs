using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class DungeonOverLord : NPC
    {
        

        public DungeonOverLord(string name = "Dungeon Overlord", double health = 200, double attackMax = 70, double defenseMax = 30, double armour = 10) : base(name, health, attackMax, defenseMax, armour)
        {
            
        }
    }
}
