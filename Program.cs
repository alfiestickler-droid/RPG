using RPG;

#region main
#region Setup
Console.WriteLine("Welcome to the game!");
string playerName = GetPlayerName();
Player player = SelectClass();
Console.Clear();
Inventory playerInv = new Inventory($"{playerName}'s Inventory");
Console.WriteLine($"You have selected a {player.GetType().Name} who goes by the name {playerName}");
player.ShowStats();
Continue();
#endregion


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
        playerInv.AddToInventory("shield");
        break;
    case 2:
        playerInv.AddToInventory("steel sword");
        break;
}


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



#endregion