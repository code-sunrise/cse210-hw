using System;
class Program
{
    static void Main(string[] args)
    {
        //test
        Potion cure = new Potion("Cure", "Heals the sick");

    }
}


/*bool displayMenu = true;
while (displayMenu)
{
    displayMenu = MainMenu();
}
}
private static bool MainMenu()
{
Console.WriteLine("menu options here");
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
}*/
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