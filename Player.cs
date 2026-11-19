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
        public double MaxHealth { get; set; }
        public Inventory Inv { get; set; }

        public Player (string name, double health = 100, double attackMax = 15, double defenseMax = 15, double stamina = 3, double armour = 0, double maxHealth = 100)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            DefenseMax = defenseMax;
            Stamina = stamina;
            Armour = armour;
            MaxHealth = maxHealth;
            Inv = new Inventory($"{name}'s Inventory");
        }

        #region functions

        public virtual double Attack()
        {
            if (Inv.SteelSword == 1)
            {
                return rnd.Next(1, (int)AttackMax) + 5;
            }
            else
            {
                return rnd.Next(1, (int)AttackMax);
            }
        }

        public virtual double HeavyAttack()
        {
            if (Inv.SteelSword == 1)
            {
                if (Stamina > 0)
                {
                    Stamina--;
                    return rnd.Next(10, ((int)AttackMax + 15));
                }
                else
                {
                    Console.WriteLine("You have no stamina left, you attack normally instead.");
                    return Attack();
                }
            }
            else
            {
                if (Stamina > 0)
                {
                    Stamina--;
                    return rnd.Next(10, ((int)AttackMax + 10));
                }
                else
                {
                    Console.WriteLine("You have no stamina left, you attack normally instead.");
                    return Attack();
                }
            }
        }

        public virtual double Defend()
        {
            if (Inv.Shield == 1)
            {
                return rnd.Next(1, (int)DefenseMax) + 5;
            }
            else
            {
                return rnd.Next(1, (int)DefenseMax);
            }
        }

        public virtual void ShowStats()
        {
            Console.WriteLine($"{Name}'s \nHealth is {Health} \nmaximum attack is {AttackMax} \nmaximum defence is {DefenseMax} \nstamina is {Stamina} \narmour is {Armour}");
        }

        #endregion
    }
}
