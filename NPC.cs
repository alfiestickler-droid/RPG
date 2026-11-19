using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class NPC
    {
        public Random rnd = new Random();

        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackMax { get; set; }
        public double DefenseMax { get; set; }
        public double Armour { get; set; }

        public NPC(string name ="", double health = 0, double attackMax = 0, double defenseMax = 0, double armour = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            DefenseMax = defenseMax;
            Armour = armour;
        }

        public virtual double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }
        public virtual double Defend()
        {
            return rnd.Next(1, (int)DefenseMax);
        }
    }
}
