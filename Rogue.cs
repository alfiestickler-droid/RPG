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

        #region functions

        public override double Attack()
        {
            int critChance = 10;

            int rndCritAttk = rnd.Next(1, 101);

            if (critChance > rndCritAttk)
            {
                Console.WriteLine("Your attack is doubled!");
                return (rnd.Next(1, (int)AttackMax)) * 2;
            }
            else
            {
                return base.Attack();
            }
        }

        public override double Defend()
        {
            int dodgeChance = 10;
            int rndDodge = rnd.Next(1, 101);

            if (dodgeChance > rndDodge)
            {
                Console.WriteLine("You dodged the enemies attack!");
                return 1000;
            }
            else
            {
                return base.Defend();
            }
        }

        #endregion
    }
}
