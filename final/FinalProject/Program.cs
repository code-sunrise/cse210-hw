using System;
using System.Diagnostics.CodeAnalysis;
/*this is a potion game where upon starting the program multiple challenges are intialized
The user then has to spend turns completing different actions to get enough of the potion they
need to defeat the challenge (which will be listed in the challenge... forgot to add that "type" in there)
The user will have an inventory that will tell them how many potions they have of each type.
They can:
1. brew potions and the amount is based on the level of their brewing ability
2. take lessons and increase their brew level but it costs money
3. sell potions, they pick which type and it empties their inventory of that potion
when they use a turn the challenge target and the correct type of potion amount will be compared
if there are not enough potions the game continues to check if there are turns left.
If there are no turns left you lose the game

if you have enough potions you defeat the challenge and are introduced to the next challenge and get more turns
This continues until you complete 3 challenges and then you get a message saying you win!*/
class Program
{
    static void Main(string[] args)
    {
        /* None of the classes should appear in here except the GameManager if I do this right
        Main is for menu and managing user input.*/

        //initialize everything in the game manager

        GameManager manager = new GameManager();
        bool menuMain = true;
        while (menuMain)
        {
            menuMain = MainMenu();
        }
    }
    private static bool MainMenu()
    {
        // i should call the game manager here instead to display the inventory and challenge
        //display inventory
        //display challenge
        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine("1. Brew some potions");
        Console.WriteLine("2. Take brewing lessons");
        Console.WriteLine("3. Sell some potions for cash");
        //the quit is 'silent', perhaps change the number to 9 or 0.
        string result = Console.ReadLine();
        switch (result)//
        {
            case "1":
                BrewMenu();
                return true;
            case "2":
                LessonMenu();
                return true;
            case "3":
                SellMenu();
                return true;
            case "4":
                //quit
                return false;
            default:
                Console.WriteLine("Please enter a valid option.");
                return true;
        }

    }
    private static void SellMenu()
    {
        //minus one turn
        // i should call the game manager here instead to display the inventory and challenge
        Console.WriteLine("\nYou spend the day traveling to the market to sell your wares. What would you like to sell?");
        Console.WriteLine("1. Sell all cures! {amount}"); //game manager fetches amount based on level
        Console.WriteLine("2. Sell all poisons!{amount}");
        Console.WriteLine("3. Sell all fizzy drinks! {amount}");
        Console.WriteLine("4. Nevermind, go back");
        //the quit is 'silent', perhaps change the number to 9 or 0.
        string result = Console.ReadLine();
        switch (result)//
        {
            case "1":
                Console.Write("test sellMenu 1");
                break;
            case "2":
                Console.Write("test sellMenu 2");
                break;
            case "3":
                Console.Write("test sellMenu 3");
                break;
            case "4":
                Console.Write("test sellMenu go back");
                //quit
                break;
            default:
                Console.WriteLine("Please enter a valid option. sell"); //edit
                break;
        }
    }
    private static void BrewMenu()
    {
        // i should call the game manager here instead to display the inventory and challenge
        Console.WriteLine("\nYou spend the day in your shop mixing potions. What would you like to brew?");
        Console.WriteLine("1. Brew some cures! {amount}"); //game manager fetches amount based on level
        Console.WriteLine("2. Brew some poisons!{amount}");
        Console.WriteLine("3. Brew some fizzy drinks! {amount}");
        Console.WriteLine("4. Nevermind, go back");
        //the quit is 'silent', perhaps change the number to 9 or 0.
        string result = Console.ReadLine();
        switch (result)//
        {
            case "1":
                Console.Write("test brewMenu 1");
                //game manager - 1 turn
                //game manager potion 1 brew method
                break;
            case "2":
                Console.Write("test brewMenu 2");
                break;
            case "3":
                Console.Write("test brewMenu 3");
                break;
            case "4":
                Console.Write("test brewMenu go back");
                //quit
                break;
            default:
                Console.WriteLine("Please enter a valid option. brew"); //edit
                break;
        }
    }
    private static void LessonMenu()
    {
        // i should call the game manager here instead to display the inventory and challenge
        Console.WriteLine("\nYou travel to your teacher's house in the forest. What would you like to learn?");
        Console.WriteLine("1. Improve cures! {bonus}"); //game manager fetches amount based on level
        Console.WriteLine("2. Improve poisons!{bonus}");
        Console.WriteLine("3. Improve fizzy drinks! {bonus}");
        Console.WriteLine("4. Nevermind, go back");
        //the quit is 'silent', perhaps change the number to 9 or 0.
        string result = Console.ReadLine();
        switch (result)//
        {
            case "1":
                Console.Write("test lessonMenu 1");
                break;
            case "2":
                Console.Write("test lessonMenu 2");
                break;
            case "3":
                Console.Write("test lessonMenu 3");
                break;
            case "4":
                Console.Write("test lessonMenu go back to main");
                //quit
                break;
            default:
                Console.WriteLine("Please enter a valid option. lesson"); //edit
                break;
        }
    }
}
//validated
//Console.Clear();