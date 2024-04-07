using System;
class Program
{
    static void Main(string[] args)
    {
        SimpleGoal goal = new SimpleGoal("eat", "have food", 100);
        Console.WriteLine(goal.GetStringRepresentation());
        /*bool displayMenu = true;
        Console.WriteLine("Welcome to the Eternal Quest goal tracker!");
        while (displayMenu)
        {
            displayMenu = MainMenu();
        }*/
    }
    /*private static bool MainMenu()
    {
        Console.WriteLine("Choose one option");
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        string result = Console.ReadLine();
        switch (result)//
        {
            case "1":
                //simple goal if this then this points
                Console.WriteLine("Select what king of goal you'd like:");
                Console.WriteLine("Simple Goal");
                Console.WriteLine("Eternal Goal");
                Console.WriteLine("Checklist Goal");
                return true;
            case "2":
                //eternal goal, each time marked, this many points
                return true;
            case "3":
                //checklist goal, # of instances, # of points, bonus for total completion
                return true;
            case "4":
                //save
                return true;
            case "5":
                // load
                return true;
            case "6":
                return false;
            default:
                Console.WriteLine("Please enter a valid option.");
                return true;
        }
    }*/
}
// menu create new goal, list goals, save goals, load goals, record event, quit
// new goal, menu simple, eternal, or checklist goal
// enter goal name
//enter descriptions
//enter points
// list goals shows unchecked item and the goal name,(description) and how many points there are
//eternal goal ex: study scriptures, short description, point allocation
//checklist goal ex: name attend temple, description, points, and # of times = bonus after achiecing it
//end of list checklist goal says 1/3, 0/4, etc based on completed times task has been done
//save file into text file and read text file that parses out the items.
//load file brings that information back
//record event, list items as menu, and then the number input checks of or adds to the goal completion
//tracks number of points earned the whole time
//i need tutoring for the displaying