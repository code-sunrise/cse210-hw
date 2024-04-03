using System;
public class Activity
{
    //attributes
    protected string _name;
    protected string _description;
    protected int _duration;
    //constructors
    public Activity()
    {
        _name = "Default";
        _description = "You have encountered and error if you are seeing this message.";
        _duration = 10;
    }
    //methods
    public void DisplayStart()
    {
        /*Each activity should start with a common starting message that provides
        the name of the activity, a description, and asks for and sets the duration
        of the activity in seconds. Then, it should tell the user to prepare to begin
        and pause for several seconds*/
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long would you like your session? (seconds)");
        string result = Console.ReadLine();
        _duration = int.Parse(result);
    }
    public void DisplayEnd()
    {
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds!");
    }
    public void ShowSpinner()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(3);
        for (int i = 3; i >= 0; i--)
        {
            if (startTime < futureTime)
            {
                Console.Write($"\b\b{i}");
                //Console.Write($"{i}");
                Thread.Sleep(1000);
            }
        }
    }
    public void ShowCount()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        Console.Write($"Loading... ");
        for (int i = _duration; i >= 0; i--)
        {
            if (startTime < futureTime)
            {
                Console.Write($"\b\b{i}");
                //Console.Write($"{i}");
                Thread.Sleep(1000);
            }
        }
    }
}