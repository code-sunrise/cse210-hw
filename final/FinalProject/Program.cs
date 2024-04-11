using System;
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
        GameManager manager = new GameManager();
        /* None of the classes should appear in here except the GameManager if I do this right*/
        //update: I did!
        Console.WriteLine("Welcome to the game, you're a small alchemist who's just settled down in a small village.\nIt's not long before someone comes knocking at your door for help.\nComplete three challenges to win the game");
        Thread.Sleep(1500);

        bool menuMain = true;
        while (menuMain)
        {
            Console.WriteLine("\nLoading\n");
            Thread.Sleep(2500);
            manager.IsComplete();
            bool done = manager.isAllComplete();
            if (done == true)
            {
                menuMain = false;
                Console.WriteLine("That's the potion game!\nThanks for playing");
            }
            MainMenu(manager);

        }
    }
    private static bool MainMenu(GameManager manager)
    {
        //display inventory & challenges

        manager.Inventory();

        Console.WriteLine("\nEach option spends one turn. What would you like to do?");
        Console.WriteLine("1. Brew some potions");
        Console.WriteLine("2. Take brewing lessons");
        Console.WriteLine("3. Sell some potions for cash");
        //the quit is 'silent', perhaps change the number to 9 or 0.
        string result = Console.ReadLine();
        switch (result)//
        {
            case "1":
                BrewMenu(manager);
                return true;
            case "2":
                LessonMenu(manager);
                return true;
            case "3":
                SellMenu(manager);
                return true;
            case "0":
                //quit
                return false;
            default:
                Console.WriteLine("Please enter a valid option.");
                return true;
        }

    }
    private static void BrewMenu(GameManager manager)
    {
        Console.WriteLine("\nYou spend the day in your shop mixing potions. What would you like to brew?");
        Console.WriteLine("1. Brew some cures!");
        Console.WriteLine("2. Brew some poisons!");
        Console.WriteLine("3. Brew some fizzy drinks!");
        Console.WriteLine("4. Nevermind, go back");
        string result = Console.ReadLine();
        switch (result)
        {
            case "1":
                manager.BrewBridge(0);
                break;
            case "2":
                manager.BrewBridge(1);
                break;
            case "3":
                manager.BrewBridge(2);
                break;
            case "4":
                Console.Write("Going back to the Main Menu.");
                //quit
                break;
            default:
                Console.WriteLine("Please enter a valid option.");
                break;
        }
    }
    private static void SellMenu(GameManager manager)
    {
        //minus one turn
        // i should call the game manager here instead to display the inventory and challenge
        Console.WriteLine("\nYou spend the day traveling to the market to sell your wares.\nWhat would you like to sell?\n(Value in Inventory)");
        Console.WriteLine("1. Sell all cures!");
        Console.WriteLine("2. Sell all poisons!");
        Console.WriteLine("3. Sell all fizzy drinks!");
        Console.WriteLine("4. Nevermind, go back");

        string result = Console.ReadLine();

        switch (result)//
        {
            case "1":
                manager.SellBridge(0);
                break;
            case "2":
                manager.SellBridge(1);
                break;
            case "3":
                manager.SellBridge(2);
                break;
            case "4":
                Console.Write("Going back to the Main Menu.");
                //quit
                break;
            default:
                Console.WriteLine("Please enter a valid option. sell");
                break;
        }
    }
    private static void LessonMenu(GameManager manager)
    {
        Console.WriteLine("\nYou travel to your old teacher's house in the forest.\nShe'll teach you at a discount of 25 gold, but she keeps the potions.\nWhat would you like to learn?");
        Console.WriteLine("1. Improve cures!");
        Console.WriteLine("2. Improve poisons!");
        Console.WriteLine("3. Improve fizzy drinks!");
        Console.WriteLine("4. Nevermind, go back");
        string result = Console.ReadLine();
        switch (result)
        {
            case "1":
                manager.LessonBridge(0);
                break;
            case "2":
                manager.LessonBridge(1);
                break;
            case "3":
                manager.LessonBridge(2);
                break;
            case "4":
                Console.Write("Going back to the Main Menu.");
                //quit
                break;
            default:
                Console.WriteLine("Please enter a valid option.");
                break;
        }
    }
}