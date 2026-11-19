using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    internal class Inventory
    {
        public string Name { get; set; }
        public int HealthPotion { get; set; }
        public int PowerPotion { get; set; }
        public int PowerSword { get; set; }
        public int SteelSword { get; set; }
        public int Shield { get; set; }
        public int PowerShield { get; set; }
        public int AmuletOfHealth { get; set; }

        public Inventory(string name, int healthPotion = 0, int powerPotion = 0, int powerSword = 0, int steelSword = 0, int shield = 0, int powerShield = 0, int amuletOfHealth = 0)
        {
            Name = name;
            HealthPotion = healthPotion;
            PowerPotion = powerPotion;
            PowerSword = powerSword;
            SteelSword = steelSword;
            Shield = shield;
            PowerShield = powerShield;
            AmuletOfHealth = amuletOfHealth;
        }

        #region functions

        public void AddToInventory(string item)
        {
            switch (item.ToLowerInvariant().Trim())
            {
                case "health potion":
                    HealthPotion++;
                    break;
                case "power potion":
                    PowerPotion++;
                    break;
                case "power sword":
                    PowerSword++;
                    break;
                case "steel sword":
                    SteelSword++;
                    break;
                case "shield":
                    Shield++;
                    break;
                case "power shield":
                    PowerShield++;
                    break;
                case "amulet of health":
                    AmuletOfHealth++;
                    break;
            }
        }

        public void RemoveFromInventory(string item)
        {
            switch (item.ToLowerInvariant().Trim())
            {
                case "health potion":
                    HealthPotion--;
                    break;
                case "power potion":
                    PowerPotion--;
                    break;
                case "power sword":
                    PowerSword--;
                    break;
                case "steel sword":
                    SteelSword--;
                    break;
                case "shield":
                    Shield--;
                    break;
                case "power shield":
                    PowerShield--;
                    break;
                case "amulet of health":
                    AmuletOfHealth--;
                    break;
            }
        }

        public void ShowInventory()
        {
            if (HealthPotion > 0)
            {
                Console.WriteLine($"Health Potion : {HealthPotion}");
            }
            if (PowerPotion > 0)
            {
                Console.WriteLine($"Power Potion : {PowerPotion}");
            }
            if (PowerSword > 0)
            {
                Console.WriteLine($"Power Sword : {PowerSword}");
            }
            if (SteelSword > 0)
            {
                Console.WriteLine($"Steel Sword : {SteelSword}");
            }
            if (Shield > 0)
            {
                Console.WriteLine($"Shield : {Shield}");
            }
            if (PowerShield > 0)
            {
                Console.WriteLine($"Power Shield : {PowerShield}");
            }
            if (AmuletOfHealth > 0)
            {
                Console.WriteLine($"Amulet of Health : {AmuletOfHealth}");
            }
        }

        #endregion
    }
}
