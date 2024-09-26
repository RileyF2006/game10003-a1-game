// See https://aka.ms/new-console-template for more information


//Ask the user for a name to use throughout the program.
Console.WriteLine("Hello, welcome to Path Adventure please enter your name:");

//Get input for the users name
string Name = Console.ReadLine();

//Ask the user if they want to go on a path to the left or right.
Console.WriteLine($"{Name} would you like to go towards the left or right path?\n1.Left\n2. Right");

//Get input for which side of the path they want to go towards.
string option1 = Console.ReadLine();

if (option1 == "Left")
{
    //Tell the user that they went down the left path towards a cave.
    Console.WriteLine($"{Name} you went left towards the cave!\nWould you like to enter the cave?\n1. Yes\n2. No");

    //Get input if the user wants to enter the cave.
    string caveDoor = Console.ReadLine();

    if (caveDoor == "Yes")
    {
        //Tell the user that they entered but the path is blocked and they must solve a math question.
        Console.WriteLine("You enter the cave but a living statue is blocking the way!\nThe living statue says,'You must answer this very simple math question if you would like to pass. What is 11 + 17?'");
        
        //Get input from the user for the math questions answer
        int mathAnswer = int.Parse(Console.ReadLine());

        if (mathAnswer == 28)
        {
            //Tell the user that they have solved the question correctly and that they get to go further into the cave.
            Console.WriteLine("The living statue says,'Congrats on getting that math question correct you may pass.'\nYou continue on deeper into the cave and end up seeing something bright and shiny straight ahead but there is also a dark path that looks like it goes deeper into the cave. What will you do?\n1. Go straight\n2. Go deeper");
            
            //Get input for which direction of the cave they want to go further into.
            string cavePath = Console.ReadLine();

            if (cavePath == "Go straight")
            {
                //Tell the player that they have finished the game after they enter the room with treasure.
                Console.WriteLine("You go straight towards the bright shiny light and find a room full of golden treasures!\n You have completed your adventure.");
            }
            else if (cavePath == "Go deeper")
            {
                //Tell the player that they died for choosing the wrong path and have to restart.
                Console.WriteLine("You go deeper into the cave but end up slipping and falling into a hole in the ground and get stuck forever.\nYou lose.");
            }
        }
        else
        {
            //Tell the user they died for getting the question wrong.
            Console.WriteLine("The living statue says,'That is incorrect! You must die!'\n The statue crushes you to death.");
        }
    }
    else if (caveDoor == "No")
    {
        //Tell the player that they die for not entering the cave and leaving instead.
        Console.WriteLine("You head back in the direction you came from but end up getting lost and attacked by a group of bandits.\nYou died.");
    }
}
else if (option1 == "Right")
{
    //Tell the player that they went down the right path towards a village and then ask if they would like to talk to a villager or continue past the village.
    Console.WriteLine($"{Name} you went right towards a village!\nWould you like to talk to a villager or continue foward\n1. Talk\n2. Continue");
    
    //Get input from the player if they want to talk or continue.
    string villageChoice = Console.ReadLine();

    if (villageChoice == "Talk")
    {
        //Tell the player that they asked a villager for directions and then ask the player if they want to go to the mountain or leave.
        Console.WriteLine("You walk up to a villager and ask him for directions to any nearby locations.\nThe villager says,'The closest place around here is that mountain over there.'\nDo you go towards the mountain or leave the village and go somewhere else?\n1. Mountain\n2. Leave");
        
        //Get input from the player if they want to go to the mountain or leave.
        string villager = Console.ReadLine();

        if (villager == "Mountain")
        {
            //Tell the player that they went up the mountain but died from a landslide.
            Console.WriteLine("You start to head up the mountain but a landslide happens and you get crushed by the rubble.\nYou died.");
        }
        else if (villager == "Leave")
        {
            //Tell the player that they managed to make it home safely after leaving the village.
            Console.WriteLine("You leave and make it home safely.\n You have completed your adventure.");
        }
    }
    else if (villageChoice == "Continue")
    {
        //Tell the player that they end up dying after continuing past the village.
        Console.WriteLine($"You leave the village and end up falling into a disguised trap on your path.\nYou died.");
    }
}
else
{
    //If player inputs something that isnt right or left it ends the program.
    Console.WriteLine("That is not a valid option");
}