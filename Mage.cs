using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Mage : Player
    {
        public Mage (string name, double health = 50, double attackMax = 40, double defenseMax = 10, double stamina = 3, double armour = 0) : base(name, stamina, armour)
        {
        }
    }
}
