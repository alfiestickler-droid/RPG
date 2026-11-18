using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Rogue : Player
    {
        public Rogue(string name, double health = 100, double attackMax = 20, double defenseMax = 10, double stamina = 3, double armour = 0) : base(name, health, stamina, armour)
        {

        }
    }
}
