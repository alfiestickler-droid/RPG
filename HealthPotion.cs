using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    internal class HealthPotion
    {
        public string  Name { get; private set; }

        public HealthPotion(string name = "Health Potion")
        {
            Name = name;
        }
    }
}
