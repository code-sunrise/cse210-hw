using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
    public List<string> entries = new List<string>
    {

    };
    public List<string> options = new List<string>
    {
    "1. Write", "2. Display", "3. Save", "4. Load", "5. Quit"
    };

    public void MainMenu()
    {

        bool run = true;
        do
        {
            Console.WriteLine("menu");
            foreach (string option in options)
            {
                Console.WriteLine($"{option}");
            }

            string input = Console.ReadLine();
            if (input == "1" || input == "Write")
            {
                //date,prompt,entry
                Prompt write = new Prompt();
                Entry userEntry = new Entry();
                userEntry.Date();
                Console.WriteLine(userEntry._date);
                write.PromptGenerator();
                userEntry._currentPrompt = write._myPrompt;
                Console.WriteLine(write._myPrompt);
                string userInput = Console.ReadLine();
                userEntry._currentEntry = userInput;
                string listItem = userEntry.CompileEntry();
                entries.Add(listItem);
            }
            else if (input == "2" || input == "Display")
            {
                foreach (string item in entries)
                {
                    Console.WriteLine(item);
                }
            }
            else if (input == "3" || input == "Save")
            {
                string filename = "journal.txt";
                using (StreamWriter output = new StreamWriter(filename))
                {
                    Console.WriteLine("Saving to file...");
                    foreach (string item in entries)
                    {
                        output.WriteLine(item);
                    };
                }
            }
            else if (input == "4" || input == "Load")
            {
                string filename = "myFile.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("&&");

                    string theDate = parts[0];
                    string thePrompt = parts[1];
                    string theEntry = parts[2];
                    string theWordcount = parts[3];
                    Console.WriteLine(theDate);
                    Console.WriteLine(thePrompt);
                    Console.WriteLine(theEntry);
                    Console.WriteLine(theWordcount);
                }
            }
            else if (input == "5" || input == "Quit")
            {
                Console.WriteLine("Come back soon!");
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
}