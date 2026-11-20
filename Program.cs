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
        Console.Clear();
        Console.WriteLine("You search the crates quietly and find a Health Potion and a Power Potion tucked inside an old medic's satchel.");
        player.Inv.AddToInventory("health potion");
        player.Inv.AddToInventory("power potion");
        break;
    case 2:
        Console.Clear();
        Console.WriteLine("You burst in on a Goblin smashing furniture he turns to you and you are ready to do battle");
        Battle(player, new Goblin());
        Console.WriteLine("After defeting the Goblin you search the room but find nothing.");
        break;
    case 3:
        Console.Clear();
        Console.WriteLine("2 Goblin Ambushers lunges from the shadows.");
        Battle(player, new Goblin());
        Console.Clear();
        Console.WriteLine("You have defeated the first Goblin, now for the second!\n");
        Battle(player, new Goblin());
        Console.WriteLine("After defeating both Goblins you look around for anything useful");
        string swordOrShield = SwordOrShield();
        Console.WriteLine($"\nAfter looking around you find a chest and open it inside you find a health potion and a {swordOrShield}.\n You equip the {swordOrShield}");
        player.Inv.HealthPotion++;
        switch (swordOrShield)
        {
            case "Steel Sword":
                Console.WriteLine("+5 for each attack");
                break;
            case "Shield":
                Console.WriteLine("+5 for each defence");
                break;
        }
        break;

}
Continue();

Console.WriteLine("Stepping out of the outer guardhouse passages, you find yourself standing before a massive, jagged archway carved directly into the bedrock. The worked stone of the human outpost ends here, giving way to ancient, moss-covered steps spiralling down into the pitch-black chill of the Sunken Ossuary.");
Continue();
Console.WriteLine("There is no time to rest and no safe place to light a fire. Strange, rhythmic scraping echoes up from the dark below, warning you that worse creatures than goblins are already stirring. You tighten your grip on your weapon, steady your breathing, and prepare to descend with whatever strength you have left.");
Continue();
Console.WriteLine("Before you take your first step down the stairs, the trials of the upper ruins leave their mark on you. Surviving the ambushes and navigating the darkened halls has sharpened your instincts.");
Console.WriteLine();
StatUpgrade();
Continue();

#endregion

#region Act 2

Console.WriteLine("Descending the spiral steps, the damp stonework of the outpost gives way to vast, vaulted burial chambers lined with ancient stone sarcophagi. A pale, unnatural mist clings to the flagstones, and the air smells of dust and ozone.");
Console.WriteLine();
Console.WriteLine("Ahead, the main crypt gallery splits into three ominous passages, each leading deeper toward the sealed heart of the fortress. You must choose which path to brave.");
Continue();

Console.WriteLine("Path 1: Faint blue light pulses beneath a cracked iron grate, accompanied by the slow, rhythmic scraping of a heavy blade dragged across stone.");
Console.WriteLine();
Console.WriteLine("Path 2: Rows of sealed stone coffins line a narrow, undisturbed hallway where even the mist seems reluctant to enter.");
Console.WriteLine();
Console.WriteLine("Path 3: The heavy clatter of rusted armour and sharp, chittering goblin barks echo from a wide, pillared hall ahead.");

Console.WriteLine();
Console.WriteLine("Which path will you take?");
Console.WriteLine("Path 1");
Console.WriteLine("Path 2");
Console.WriteLine("Path 3");
userChoice = UserChoice(3);

switch (userChoice)
{
    case 1:
        Console.Clear();
        Console.WriteLine("A goblin roams the room as well as 2 towering Skeleton Warriors stands sentinel before a glowing altar, rising to strike the moment your shadow crosses the threshold.");
        Battle(player, new Goblin());
        Console.Clear();
        Console.WriteLine("As you strike down the goblin the first skeleton warrior approches");
        Battle(player, new Skeleton());
        Console.Clear();
        Console.WriteLine("The first skeleton warrior crumbles to dust, teh second approches");
        Battle(player, new Skeleton());
        Console.Clear();
        Console.WriteLine("As you defeat the second skeleton warrior and it crumbles to dust the alter in the room is unlocked");
        Console.WriteLine();
        Console.WriteLine("A voice is heard all around you.\n \"You have proven yourself worthy, you can now choose to get either my Sword of Power or Shield of Power, choose wisley\"");
        Console.WriteLine();
        Console.WriteLine("What will you choose?");
        Console.WriteLine();
        Console.WriteLine("1. Sword of Power");
        Console.WriteLine("2. Shield of Power");
        userChoice = UserChoice(2);

        switch (userChoice)
        {
            case 1:
                Console.WriteLine("You chose the Sword of power\n +15 to each attack");
                player.Inv.SteelSword = 0;
                player.Inv.PowerSword++;
                break;
            case 2:
                Console.WriteLine("You chose the Shield of power\n +15 to each Defence");
                player.Inv.Shield = 0;
                player.Inv.PowerShield++;
                break;
        }
        Continue();
        Console.WriteLine("After searching the rest of teh room you find a power potion");
        player.Inv.PowerPotion++;
        Continue();

        break;
    case 2:
        Console.Clear();
        Console.WriteLine("You pry open an ancient warden's funerary chest tucked behind a toppled statue, a health potion and a power potion.");
        player.Inv.AddToInventory("health potion");
        player.Inv.AddToInventory("power potion");
        Continue();
        break;
    case 3:
        Console.Clear();
        Console.WriteLine("You step into an ambush where a Skeleton Warrior stands guard alongside a Goblin, working together to block the exit.");
        Console.WriteLine();
        Console.WriteLine("You have no choice but to attack.");
        Battle(player, new Goblin());
        Console.WriteLine("You easily defeat the goblin, but the skeleton now approches!");
        Battle(player, new Skeleton());
        Console.WriteLine("After defeating the skeleton warrior he crumbles to dust");
        Continue();
        Console.WriteLine("You search the hall and find nothing useful.");
        Continue();
        break;
}
Console.WriteLine("Emerging from your chosen crypt passage, the dusty stone tombs abruptly drop away into a vast subterranean gorge. Thick, rusted iron chains stretch across the abyss, suspending a series of ancient stone bridges over a glowing, shadowy void.");
Console.WriteLine();
Console.WriteLine("The air here is freezing and crackles with dark static. Distant, inhuman roars echo from the bridges ahead, signalling that you have left the outer burial grounds behind and entered the fortress's inner defences.");
Console.WriteLine();
Console.WriteLine("There is still no safe haven to stop and recover. Surviving the undead guardians of the ossuary has sharpened your battle instincts, giving you a brief moment to focus your strength before crossing into the chasm.");

Continue();
StatUpgrade();
Continue();

#endregion

#region Act 3

Console.WriteLine("Stepping onto the suspended stone walkways, thick webs cling to the massive iron chains anchoring the bridges over the dark void. The air vibrates with dark energy from the sanctum ahead, and skittering shapes move silently through the shadows.");
Console.WriteLine();
Console.WriteLine("At the central nexus of the chasm, four separate paths branch out across the gorge toward the fortress's inner gate. Carrying over whatever Health, Stamina, and supplies you have left, you must choose how to cross.");
Continue();

Console.WriteLine("path 1. A precarious wooden scaffold clings to the cliffside, leading to a tiny, forgotten watch-box untouched by webs or bones.");
Console.WriteLine();
Console.WriteLine("Path 2. A lowered stone platform hangs heavy on rusted chains, where a faint metallic glint shines beside a pile of bleached bones.");
Console.WriteLine();
Console.WriteLine("Path 3. A wide stone bridge is completely cocooned in thick, glistening silk, with shadows darting along the underside.");
Console.WriteLine();
Console.WriteLine("Path 4. An arched stone viaduct spans the deepest part of the chasm, guarded by both ancient bones and fresh webbing.");
Console.WriteLine();
userChoice = UserChoice(4);

switch (userChoice)
{
    case 1:
        Console.Clear();
        Console.WriteLine("You carefully cross the creaking planks and pry open a reinforced supply locker left behind by the original prison guards.");
        Console.WriteLine();
        Console.WriteLine("Inside you find a health potion and a power potion");
        player.Inv.HealthPotion++;
        player.Inv.PowerPotion++;
        Continue();

        break;
    case 2:
        Console.Clear();
        Console.WriteLine("As you step onto the platform, a Skeleton Warrior pulls itself from the wreckage to defend the cache.");
        Battle(player, new Skeleton());
        Console.Clear();
        Console.WriteLine("You strike down the skeleton and just as you think it's over 2 giant spider crawl onto the platform from below");
        Battle(player, new GiantSpider());
        Console.Clear();
        Console.WriteLine("You kill the first spider and it stumbles and falls off the platform, the second spider now approches");
        Battle(player, new GiantSpider());
        Console.Clear();
        Console.WriteLine("You strike a fatal blow to the second spider winning the battle");
        Continue();
        Console.WriteLine("After a few moments to catch your breath you go and investigate the metallic glint");
        Console.WriteLine();
        Console.WriteLine("After investigating you find 2 power potions and a health potion");
        player.Inv.PowerPotion += 2;
        player.Inv.HealthPotion++;
        Continue();

        break;
    case 3:
        Console.Clear();
        Console.WriteLine(" Midway across, two Giant Spiders drop from the chains above, blocking your retreat.");
        Battle(player, new GiantSpider());
        Console.Clear();
        Console.WriteLine("After slaying the first spider you turn and face the second");
        Battle(player, new GiantSpider());
        Console.Clear();
        Console.WriteLine("You defeated both spiders, and after a moment to catch your breath you decide to look around, but find nothing useful so continue");
        Continue();
        break;
    case 4:
        Console.Clear();
        Console.WriteLine("2 Giant Spiders and 2 Skeleton Warriors lurk at the far end of the bridge, guarding a sealed iron reliquary.");
        Console.WriteLine();
        Console.WriteLine("Knowing theres no going back you charge at them");
        Battle(player, new Skeleton());
        Console.Clear();
        Console.WriteLine("The first skeleton crumbles to dusk, the second attacks");
        Battle(player, new Skeleton());
        Console.Clear();
        Console.WriteLine("You skrike a killing blow on the second skeleton but now a spider approches");
        Battle(player, new GiantSpider());
        Console.Clear();
        Console.WriteLine("The first spider shreiks as you land the killing blow, the second spider charges at you");
        Battle(player, new GiantSpider());
        Console.Clear();
        Console.WriteLine("You land a final killing blow on the last enemy, you take a moment to sit down and recover");
        Console.WriteLine();
        Console.WriteLine("As you are recovering you notice something dangling off the edge of the viaduct");
        Console.WriteLine();
        Console.WriteLine("You go over and carefully retrive the item");
        Continue();
        Console.WriteLine("You found an amulet of health!");
        Console.WriteLine();
        Console.WriteLine("Health increased +50");
        player.MaxHealth += 50;
        player.Health += 50;
        Continue();

        break;
}

Console.WriteLine("Crossing the far side of the chasm, you pass through a heavy portcullis into a quiet, domed antechamber carved from smooth black stone. Ancient ward-stones set into the walls still hum with a faint, protective warmth, keeping the surrounding darkness at bay.");
Console.WriteLine();
Console.WriteLine("Just ahead stand the towering, rune-carved doors of the Obsidian Sanctum. Knowing the source of the corruption waits on the other side, you take a rare moment to catch your breath, tend to your wounds, and prepare for the final battle.");
Continue();
Console.WriteLine("You rest by a warm fire you make, completely restoring your Health and giving you 2 Stamina.");
player.Health = player.MaxHealth;
player.Stamina += 2;
Continue();
Console.WriteLine("Drawing on everything you have survived across the ruins, the ossuary, and the chasm, you permanently increase one core stat of your choice:");
StatUpgrade();
Continue();

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
                    Console.WriteLine($"The {enemy.Name}'s health is now {enemy.Health}");
                }

                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"You have defeated the {enemy.Name}");
                    Continue();
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
                    Console.WriteLine($"Your stamina is now at {player.Stamina}");
                }
                else
                {
                    Console.WriteLine($"You hit the {enemy.Name} for {playerHeavyDamage}");
                    Console.WriteLine($"Your stamina is now at {player.Stamina}");
                    enemy.Health -= playerHeavyDamage;
                }

                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"You have defeated the {enemy.Name}");
                    Continue();
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

        if (!enemyDead)
        {

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
                player.Health -= enemyDamage;
                Console.WriteLine($"Your health is now {player.Health}");
            }

            if (player.Health <= 0)
            {
                Console.WriteLine($"You have been killed by a {enemy.Name},");
                GameOver();

            }
        }

    }
}

void GameOver()
{
    Console.WriteLine("\nGAME OVER");
    Console.WriteLine();

    Environment.Exit(0);
}

string SwordOrShield()
{
    if (player.Inv.SteelSword == 1)
    {
        player.Inv.Shield++;
        return "Shield";
    }
    else
    {
        player.Inv.SteelSword++;
        return "Steel Sword";
    }
}

void StatUpgrade()
{
    Console.WriteLine("You can upgrade 1 stat");
    Console.WriteLine();
    Console.WriteLine("1. Health +10");
    Console.WriteLine("2. Maximum Attack +10");
    Console.WriteLine("3. Maximum Defence +10");
    Console.WriteLine("4. Stamina +1");
    Console.WriteLine("5. Armor +3");

    userChoice = UserChoice(5);

    switch (userChoice)
    {
        case 1:
            player.MaxHealth += 10;
            player.Health += 10;
            Console.WriteLine($"You have upgraded your health, max health now at {player.MaxHealth}");
            break;
        case 2:
            player.AttackMax += 10;
            Console.WriteLine($"You have upgraded your attack, max attack now at {player.AttackMax}");
            break;
        case 3:
            player.DefenseMax += 10;
            Console.WriteLine($"You have upgraded your defence, max defence now at {player.DefenseMax}");
            break;
        case 4:
            player.Stamina ++;
            Console.WriteLine($"You have upgraded your stamina, max stamina now at {player.Stamina}");
            break;
        case 5:
            player.Armour += 3;
            Console.WriteLine($"You have upgraded your armour, armour now at {player.Armour}");
            break;
    }
}

#endregion