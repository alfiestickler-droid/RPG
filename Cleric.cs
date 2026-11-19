using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RPG
{
    class Cleric : Player
    {
        

        public Cleric (string name, double health = 100, double attackMax = 10, double defenseMax = 10, double stamina = 3, double armour = 0, int maxHealth = 100) : base(name, health, attackMax, defenseMax, stamina, armour, maxHealth)
        {
            
        }

        #region functions

        public double RestoreHealthSmlAttk()
        {
            Health += 10;

            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }

            return rnd.Next(1, 7);
        }

        #endregion
    }
}
