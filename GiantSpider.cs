using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class GiantSpider : NPC
    {
        

        public GiantSpider(string name = "Giant Spider", double health = 50, double attackMax = 20, double defenseMax = 15, double armour = 5) : base(name, health, attackMax, defenseMax, armour)
        {
            
        }
    }
}
