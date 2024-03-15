using System;

class Program
{
    static void Main(string[] args)
    {

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
                Entry write = new Entry.NewEntry();
            }
            else if (input == "2" || input == "Display")
            {
                string[] display = Journal.Display;
            }
            else if (input == "3" || input == "Save")
            {
                Journal.Save
            }
            else if (input == "4" || input == "Load")
            {
                Journal.Load
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
    }
}