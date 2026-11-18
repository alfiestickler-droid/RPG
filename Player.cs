using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Player
    {
        public Random rnd = new Random();

        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackMax { get; set; }
        public double DefenseMax { get; set; }
        public double Stamina { get; set; }
        public double Armour { get; set; }

        public Player (string name, double health = 100, double attackMax = 15, double defenseMax = 15, double stamina = 3, double armour = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            DefenseMax = defenseMax;
            Stamina = stamina;
            Armour = armour;
        }

        #region functions

        public virtual double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }

        public virtual double HeavyAttack()
        {
            if (Stamina > 0)
            {
                Stamina--;
                return rnd.Next(10, ((int)AttackMax + 10));
            }
            else
            {
                Console.WriteLine("You have no stamina left");
                return Attack();
            }
        }

        public virtual double Defend()
        {
            return rnd.Next(1, (int)DefenseMax);
        }

        public virtual void ShowStats()
        {
            Console.WriteLine($"{Name}'s \nHealth is {Health} \nmaximum attack is {AttackMax} \nmaximum defence is {DefenseMax} \nstamina is {Stamina} \narmour is {Armour}");
        }

        #endregion
    }
}
