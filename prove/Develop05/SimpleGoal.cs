using System;

public class SimpleGoal : Goal
{
    //attributes
    private bool _isComplete;

    //constructor
    public SimpleGoal(string title, string description, int points) : base(title, description, points)
    {
        _isComplete = false;
    }

    //methods
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string box = "&&o";
        if(_isComplete == true)
        {
            box = "&&x";
        }
        string display = $"{_title}&&{_description}&&Points: {_points}{box}";
        return display;
    }
}