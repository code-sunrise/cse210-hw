using System;

class Program
{
    /*memorizer that randomly hides words until they're all gone
    the idea is you memorize it entirely*/
    static void Main(string[] args)
    {
        string input = " ";
        bool boolean = false;
        string text = "Behold, God is my salvation; I will trust, and not be afraid; for the Lord Jehovah is my strength and my song; he also has become my salvation.";
        Reference secondNephi = new Reference("2 Nephi", 22, 2);
        Scripture chapter22 = new Scripture(secondNephi, text);
        /*a case swicth thingy or while loop that repeats
        until the user types quit*/
        while (input != "quit")
        {
            boolean = chapter22.IsCompletelyHidden();
            if (boolean == true)
            {
                break;
            }
            Console.WriteLine(chapter22.GetDisplayText());
            chapter22.HideRandomWords(2);
            input = Console.ReadLine();
        }
        //if chater22.IsCompletelyHidden == True automatically end the program
        Console.WriteLine($"All words in {secondNephi} are hidden! Thanks for playing");
    }
}
/*2 Nephi 22:2 Behold, God is my salvation; I will trust, and not
be afraid; for the Lord Jehovah is my strength and my
song; he also has become my salvation. */