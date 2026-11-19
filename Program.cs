using RPG;
#region main

#region Setup
Console.WriteLine("Welcome to the game!");
string playerName = GetPlayerName();
Player player = SelectClass();
Console.Clear();
Console.WriteLine($"You have selected a {player.GetType().Name} who goes by the name {playerName}");
player.ShowStats();
Continue();
#endregion

#region intro
Console.WriteLine("The cold rain lashes against the cracked stone walls of Oakhaven Outpost. You stand before the heavy iron gates leading down into the Whispering Ruins. For weeks, a thick, unnatural fog has poured from the depths, and tonight, the creatures of the dark finally pushed back.");
Continue();
Console.WriteLine("Stepping through the shattered courtyard, you see the aftermath of a brutal ambush. Broken spears and scorched banners litter the mud. Near the entrance to the subterranean stairs, leaning heavily against a crumbled pillar, is Captain Vance, the commander of the outpost's vanguard. His armour is rent, and a dark, cursed ichor seeps from a wound in his side.");
Continue();
Console.WriteLine("As you approach, he looks up, gripping the hilt of a notched blade planted in the dirt beside him.");
Console.WriteLine();
Console.WriteLine("\"You're too late for the garrison, traveller,\" Vance rasps, coughing weakly. \"The seal in the lower vaults... it's broken. Something ancient is waking up down there, and it's driving the beasts into a frenzy.\"");
Console.WriteLine();
Console.WriteLine("He gestures toward the dark stairwell leading down, then looks at your gear.");
Console.WriteLine();
Console.WriteLine("\"I won't survive the climb back to the capital, and my men are gone. If you're mad enough to go down there and finish what we started, you'll need better steel than what you're carrying. Take what you need from my pack—I can only spare one piece before the dark takes me.\"");
Continue();

Console.WriteLine("You look at Vance and see a shield and a steel sword");
Console.WriteLine("Which item do you choose?");
Console.WriteLine();
Console.WriteLine("1. Shield");
Console.WriteLine("2. Sword");
int userChoice = UserChoice(2);

switch (userChoice)
{
    case 1:
        player.Inv.AddToInventory("shield");
        Console.Clear();
        Console.WriteLine("You lift the scarred, iron-rimmed shield. Vance gives a grim smile, knowing it will keep you alive.");
        Console.WriteLine();
        Console.WriteLine("+5 is added to your defence");
        break;
    case 2:
        player.Inv.AddToInventory("steel sword");
        Console.Clear();
        Console.WriteLine("You unbuckle the heavy, well-balanced steel sword from Vance's belt. He nods approvingly as you test its weight.");
        Console.WriteLine();
        Console.WriteLine("+5 is added to your attack");
        break;
}

Continue();
Console.WriteLine("With a final nod, Captain Vance closes his eyes as the rain washes over the courtyard. You turn toward the yawning blackness of the dungeon stairs, gripping your newly claimed gear, and step into the Whispering Ruins.");
Continue();

#endregion

#region Act 1

Console.WriteLine("Descending the stairs from Captain Vance, you enter the crumbling outer halls of the outpost. Torchlight dances across damp stone walls as the corridor splits into three distinct passages.");
Console.WriteLine();
Console.WriteLine("Path 1: A partially collapsed wooden door hangs open, revealing dusty shelves untouched by the chaos.");
Console.WriteLine();
Console.WriteLine("Path 2: Loud banging and snarling echo from behind a set of heavy double doors.");
Console.WriteLine();
Console.WriteLine("Path 3: Muddy footprints lead up a narrow spiral staircase toward a dimly lit landing.");

Console.WriteLine();
Console.WriteLine("Which path will you take?");
Console.WriteLine("Path 1");
Console.WriteLine("Path 2");
Console.WriteLine("Path 3");
userChoice = UserChoice(3);

switch (userChoice)
{
    case 1:
        Console.WriteLine("You search the crates quietly and find a Health Potion and a Power Potion tucked inside an old medic's satchel.");
        player.Inv.AddToInventory("health potion");
        player.Inv.AddToInventory("power potion");
        break;
    case 2:

        break;
}

#endregion

#endregion

#region functions

string GetPlayerName() 
{
    Console.WriteLine("Please enter a name for your character");
    string playerName = Console.ReadLine();

    while (string.IsNullOrEmpty(playerName))
    {
        Console.WriteLine("Your character must have a name, please enter a name");
        playerName = Console.ReadLine();
    }

    return playerName;
}

Player SelectClass()
{
    Console.Clear();
    Console.WriteLine("Please select a class using a number\n");

    Console.WriteLine("1. Warrior");
    Console.WriteLine("2. Mage");
    Console.WriteLine("3. Rouge");
    Console.WriteLine("4. Cleric");
    Console.WriteLine("5. Information on each class");

    string classChoice = Console.ReadLine();
    while (classChoice != "1" && classChoice != "2" && classChoice != "3" && classChoice != "4" && classChoice != "5")
    {
        Console.WriteLine("Sorry invalid selection, please pick a number to choose a class");
        classChoice = Console.ReadLine();
    }

    if (classChoice == "5")
    {
        Console.Clear();
        Console.WriteLine("The Warrior has higher health and defence, when the warriors health is below 30% they get bonus defence.\n");
        Console.WriteLine("The Mage has low health and defence but the highest damage of any class, also has a small amount of mana for some extra strong attacks.\n");
        Console.WriteLine("The Rogue has high attack and low defence, also has a chance for a critical hit dealing double damage and has a small chance to dodge.\n");
        Console.WriteLine("The Cleric has a low attack but can spend a turn restoring a small portion of health and deal light damage.\n");

        Continue();
        return SelectClass();
    }
    else
    {

        return classChoice switch
        {
            "1" => new Warrior(playerName),
            "2" => new Mage(playerName),
            "3" => new Rogue(playerName),
            "4" => new Cleric(playerName)
        };
    }
    
}

void Continue()
{
    Console.WriteLine();
    Console.WriteLine("press enter when ready to continue");
    Console.ReadLine();
    Console.Clear();
}

int UserChoice(int numOfChoice)
{
    Console.WriteLine();
    Console.WriteLine("Pick an option");
    int choice;
    while (true)
    {
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out choice) && choice >= 1 && choice <= numOfChoice)
        {
            return choice;
        }

        Console.WriteLine($"Please enter a valid choice between 1 and {numOfChoice}");
    }
}

void Battle(Player player, NPC enemy)
{
    
    bool enemyDead = false;
    bool powerPotion = false;

    Console.WriteLine($"You have entered a battle with a {enemy.Name}");

    while (!enemyDead)
    {
        Console.WriteLine();
        Console.WriteLine("Your turn, what will you do?");
        Console.WriteLine();
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Heavy Attack");
        Console.WriteLine("3. Drink Potion");
        userChoice = UserChoice(3);

        switch (userChoice)
        {
            case 1:
                double playerDamage = player.Attack();
                if (powerPotion)
                {
                    playerDamage = playerDamage * 2;
                    powerPotion = false;
                }
                playerDamage = playerDamage - enemy.Armour - enemy.Defend();
                if (playerDamage <= 0)
                {
                    Console.WriteLine("You missed and did 0 damage");
                }
                else
                {
                    Console.WriteLine($"You hit the {enemy.Name} for {playerDamage}");
                    enemy.Health -= playerDamage;
                }

                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"You have defeated the {enemy.Name}");
                    enemyDead = true;
                }
                break;

            case 2:
                double playerHeavyDamage = player.HeavyAttack();
                if (powerPotion)
                {
                    playerHeavyDamage = playerHeavyDamage * 2;
                    powerPotion = false;
                }
                playerHeavyDamage = playerHeavyDamage - enemy.Armour - enemy.Defend();
                if (playerHeavyDamage <= 0)
                {
                    Console.WriteLine("You missed and did 0 damage");
                }
                else
                {
                    Console.WriteLine($"You hit the {enemy.Name} for {playerHeavyDamage}");
                    enemy.Health -= playerHeavyDamage;
                }

                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"You have defeated the {enemy.Name}");
                    enemyDead = true;
                }
                break;

            case 3:

                Console.WriteLine("Which potion would you like to drink");
                Console.WriteLine("1. Health");
                Console.WriteLine("2. Power");
                int potionChoice = UserChoice(2);

                switch (potionChoice)
                {
                    case 1:
                        if (player.Inv.HealthPotion > 0)
                        {
                            Console.WriteLine($"You drink a Health Potion, you are back at your full health of {player.MaxHealth}");
                            player.Health = player.MaxHealth;
                            player.Inv.HealthPotion--;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you have no health potions left");
                            break;
                        }

                    case 2:
                        if (player.Inv.PowerPotion > 0)
                        {
                            Console.WriteLine($"You drink a Power Potion, your next attack will do double damage.");
                            powerPotion = true;
                            player.Inv.PowerPotion--;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you have no power potions left");
                            break;
                        }
                        break;
                }
                break;
        }

        Console.WriteLine($"It's now {enemy.Name}'s turn");
        Console.WriteLine();

        double enemyDamage = enemy.Attack();
        enemyDamage = enemyDamage - player.Armour - player.Defend();

        if (enemyDamage <= 0)
        {
            Console.WriteLine($"{enemy.Name} missed and did 0 damage");
        }
        else
        {
            Console.WriteLine($"{enemy.Name} hit you for {enemyDamage}");
            enemy.Health -= enemyDamage;
        }

        if (player.Health <= 0)
        {
            Console.WriteLine($"You have been killed by a {enemy.Name},");
            GameOver();
            
        }

    }
}

void GameOver()
{
    Console.WriteLine("\nGAME OVER");
    Console.WriteLine();

    Environment.Exit(0);
}

#endregion