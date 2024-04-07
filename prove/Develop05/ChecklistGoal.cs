using System;

public class CheckListGoal : Goal
{
    //attributes
    int _amountCompleted;
    int _target = 0;


    int _bonus;

    //constructor
    public CheckListGoal(string title, string description, int points, int target, int bonus) : base(title, description, points)
    {
        _bonus = bonus;
        _target = target;
    }

    //method 
    public override void RecordEvent()
    { }

    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        string box = "&&o";
        if (_amountCompleted == _target)
        {
            box = "&&x";
        }
        string display = $"{_title}&&{_description}&&Points: {_points}{box}";
        return display;
    }
}