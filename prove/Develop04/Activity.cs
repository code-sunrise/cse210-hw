using System;
public class Activity
{
    //attributes
    protected string _name;
    protected string _description;
    protected int _duration;
    //constructors
    Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
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
        Console.WriteLine($"Durationi: {_duration}");
    }
    public void DisplayEnd()
    {
        Console.WriteLine("!");
    }
    public void ShowSpinner()
    {
        Console.WriteLine("Activity starting in...");
        DateTime currentTime = DateTime.Now;
        DateTime spinnerTime = currentTime.AddSeconds(5);
    }
    public void ShowCount()
    {
        //have countdown
    }
}