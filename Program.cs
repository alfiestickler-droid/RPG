using RPG;

#region main

Console.WriteLine("Welcome to the game!");
string playerName = GetPlayerName();
Player player = SelectClass();
Console.WriteLine($"You have selected a {player.GetType().Name} who goes by the name {playerName}");

player.ShowStats();

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

        Console.WriteLine("press enter when ready to continue");
        Console.ReadLine();
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

#endregion