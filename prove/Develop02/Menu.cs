using System;
//https://www.w3schools.com/cs/cs_foreach_loop.php

public class Menu
{
    //I messed something up overhere
    public List<string> _options = new List<string>
    {
    "1. Write", "2. Display", "3. Save", "4. Load", "5. Quit"
    };
    public void MainMenu()
    {
        bool run = true;
        do
        {
            Console.WriteLine("menu");
            foreach (string option in _options)
            {
            Console.WriteLine($"{option}");
            }
            string input = Console.ReadLine();
            if (input == "1" || input == "Write")
            {
                //Entry.NewEntry
            }
            else if (input == "2" || input == "Display")
            {
                //Entry.DisplayEntry
            }
            else if (input == "3" || input == "Save")
            {
                //Entry.SaveEntry
            }
            else if (input == "4" || input == "Load")
            {
                //Entry.Loadentry
            }
            else if (input == "5" || input == "Quit")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Invalid answer.");
            }
        }
        while (run == true);
    //while true run the menu
}
}
