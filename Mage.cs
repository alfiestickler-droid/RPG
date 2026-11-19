using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Mage : Player
    {
        public int Mana { get; set; }

        public Mage (string name, double health = 50, double attackMax = 40, double defenseMax = 10, double stamina = 3, double armour = 0, double maxHealth = 50, int mana = 3) : base(name, health, attackMax, defenseMax, stamina, armour, maxHealth)
        {
            Mana = mana;
        }

        #region functions

        public double MagicAttack()
        {
            if (Mana > 0)
            {
                Mana--;
                return rnd.Next(10, ((int)AttackMax + 20)); 
            }
            else
            {
                Console.WriteLine("You are out of mana!");
                return base.Attack();
            }
        }

        public override void ShowStats()
        {
            Console.WriteLine($"{Name}'s \nHealth is {Health} \nmaximum attack is {AttackMax} \nmaximum defence is {DefenseMax} \nstamina is {Stamina} \narmour is {Armour} \nMana is {Mana}");
        }

        #endregion
    }
}
