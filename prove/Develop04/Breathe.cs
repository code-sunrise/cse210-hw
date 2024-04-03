using System;

public class Breathe : Activity
{
    //attributes NA
    //constructors
    public Breathe()
    {
        _name = "Breathe";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }
    //methods
    public void Run()
    {
        //access the :base elements to run the program
        DisplayStart(); /* 1. The activity should begin with the standard starting message
        and prompt for the duration that is used by all activities.*/
        ShowSpinner();
        int breaths = (int)Math.Ceiling(_duration / 12.0);
        //round the total i guess
        for (int i = breaths; i > 0; --i) //this is wrong
        {
            //five second timer
            Console.WriteLine("Deep breath in...");
            for (int j = 5; j > 0; j--)
            {
                Console.Write($"\b\b{j}");
                Thread.Sleep(1000);
            }

            //seven second timer
            Console.WriteLine(" ");
            Console.WriteLine("Deep breath out...");
            for (int k = 7; k > 0; k--)
            {
                Console.Write($"\b\b{k}");
                Thread.Sleep(1000);
            }
            Console.WriteLine(" ");
        }
        DisplayEnd();
    }
}
/*1. X
2. X The description of this activity should be something like: X
3. X After the starting message, the user is shown a series of messages
alternating between "Breathe in..." and "Breathe out..." X
4. After each message, the program should pause for several seconds and show a countdown.
It should continue until it has reached the number of seconds the user specified for the duration.
5. The activity should conclude with the standard finishing message for all activities.*/