using System;
class Program
{
    static void Main(string[] args)
    {
        //initialize


        bool displayMenu = true;
        while (displayMenu)
        {
            displayMenu = MainMenu();
        }
    }
    private static bool MainMenu()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1 - Breathing activity");
        Console.WriteLine("2 - Reflection activity");
        Console.WriteLine("3 - Listing activity");
        Console.WriteLine("4 - Quit the program");
        string result = Console.ReadLine();
        switch (result)
        {
            case "1":
            //breathing
            //ask for duration and then use that to initialize the exercise!
            return true;
            case "2":
            //reflection
            return true;
            case "3":
            //listing
            return true;
            case "4":
            //quit
            return false;
            default:
            Console.WriteLine("Please enter a valid option.");
            return true;
        }

    }
}
//verified working