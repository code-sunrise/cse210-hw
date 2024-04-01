using System;
class Program
//https://stackoverflow.com/questions/6191576/seconds-countdown-timer
{
    static void Main(string[] args)
    {
        //testing zone
        /*Activity test = new Activity();
        test.DisplayStart();
        test.ShowSpinner();
        test.DisplayEnd();*/


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
            Breathe breathing = new Breathe();
            breathing.Run();
            return true;
            case "2":
            //reflection
            Reflect reflection = new Reflect();
            reflection.Run();
            return true;
            case "3":
            //listing
            List listing = new List();
            listing.Run();
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