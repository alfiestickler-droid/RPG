using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Mage : Player
    {
        public int Mana { get; set; }

        public Mage (string name, double health = 50, double attackMax = 40, double defenseMax = 10, double stamina = 3, double armour = 0, int mana = 3) : base(name, stamina, armour)
        {
            Mana = mana;
        }

        #region functions

        public double MagicAttack()
        {
            if (Mana > 0)
            {
                return rnd.Next(10, 60);
            }
            else
            {
                Console.WriteLine("You are out of mana!");
                return 0;
            }
        }

        #endregion
    }
}
