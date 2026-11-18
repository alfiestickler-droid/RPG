using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Warrior : Player
    {
        public Warrior(string name, double health = 150, double attackMax = 15, double defenseMax = 25, double stamina = 3, double armour = 0) : base(name, attackMax, stamina, armour)
        {
        }
    }
}
