using System;

public class Breathe : Activity
{
    //attributes
    //constructors
    //breathing actitivty
    public void BreathingActivity()
    {
        int breaths = (int)Math.Ceiling(_duration / 12.0);
        //round the total i guess
        for(int i = breaths, i > 0, --i) //this is wrong
        {
            Console.WriteLine("Deep breath in)");
            //five second timer
            Console.WriteLine("Deep breath out");
            //eight second timer
        }
    }
    //methods
    public void Run()
    {
        //access the :base elements to run the program
        DisplayStart();
        ShowSpinner();
        BreathingActivity();
        DisplayEnd();
    }
}
/*The activity should begin with the standard starting message
and prompt for the duration that is used by all activities.
The description of this activity should be something like:
"This activity will help you relax by walking your through
breathing in and out slowly. Clear your mind and focus on your breathing."
After the starting message, the user is shown a series of messages
alternating between "Breathe in..." and "Breathe out..."
After each message, the program should pause for several seconds and show a countdown.
It should continue until it has reached the number of seconds the user specified for the duration.
The activity should conclude with the standard finishing message for all activities.*/