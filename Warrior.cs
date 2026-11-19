using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Warrior : Player
    {
        

        public Warrior(string name, double health = 150, double attackMax = 15, double defenseMax = 25, double stamina = 3, double armour = 0, double maxHealth = 150) : base(name, health, attackMax, defenseMax, stamina, armour, maxHealth)
        {
            
        }


        #region functions

        public override double Defend()
        {
            double thrityPerHealth = (MaxHealth / 10) * 3;

            if (Health < thrityPerHealth)
            {
                return rnd.Next(1, (int)DefenseMax) + 5;
            }
            else
            {
                return base.Defend();
            }
        }

        #endregion
    }
}
