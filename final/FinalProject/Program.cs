using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
{

    Potion cure = new Potion("Cure", "Heal a sick individual.");
    Console.WriteLine(cure.Display());
    Challenge ch1 = new Challenge();
    //do this two more times and Add to a Challenge list.
    /*initialize inventory, while GoalManager.Compare == False keep running the program,
    when == true,
    change to #2 on the list, after completing #3 end the program*/

    /*Maybe the case switch should be for which challenge I'm on and entered automatically
    Like... readline, convert to int/parse, enter that into the goal manager.
    There could be a menu number and an option number and the number will change
    the menus need their own class maybe? HOW DO I DO THIS PART*/

    /*
        bool displayMenu = true;
        while (displayMenu)
        {
            displayMenu = MainMenu();
        }
    }
    private static bool MainMenu()
    {
        List<Challenge> challenges;
        Challenge cOne = new Challenge();
        Challenge cTwo = new Challenge();
        Challenge cThree = new Challenge();
        do i need to initialize the goal manager?

        //display challenge
        //display inventory
        Console.WriteLine("You have {challenge turns} left, would you like to...");
        Console.Writeline("1. Brew Potions")
        Console.Writeline("2. Take Lessons")
        Console.Writeline("3. Sell Stock")
        //the quit is 'silent', perhaps change the number to 9 or 0.
        string result = Console.ReadLine();
        switch (result)//
        {
            case "1":
            return true;
            case "2":
            return true;
            case "3":
            return true;
            case "4":
            //quit
            return false;
            default:
            Console.WriteLine("Please enter a valid option.");
            return true;
        }
*/
    }
}
//validated
//Console.Clear();