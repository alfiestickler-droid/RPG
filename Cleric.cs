using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RPG
{
    class Cleric : Player
    {
        public Cleric (string name, double health = 100, double attackMax = 10, double defenseMax = 10, double stamina = 3, double armour = 0) : base(name, health, stamina, armour)
        {

        }
    }
}
