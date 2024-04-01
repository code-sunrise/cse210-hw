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
        and pause for several seconds.*/
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
        DateTime futureTime = startTime.AddSeconds(5);
        for (int i = 1; i <= 100; i += 4)
        {
            Console.Write($"Loading... {i}%");
            Thread.Sleep(100);
            /* Thread.Sleep(3000);

             DateTime currentTime = DateTime.Now;
             if (currentTime < futureTime)
             {
                 Console.WriteLine("Loading....");
             }*/
        }}
        /*public void ShowCount()
        {
            //have countdown
        }*/
    }