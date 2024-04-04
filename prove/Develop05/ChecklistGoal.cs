using System;

public class CheckListGoal : Goal
{
    //attributes
    int _amountCompleted;
    int _target;

    int _bonus;

    //constructor
    public CheckListGoal(string title, string description, int points, int bonus) : base(title, description, points)
    {
        _bonus = bonus;
    }

    //method
    public override void RecordEvent()
    {}

    public override bool IsComplete()
    {
        return true;
    }
     public override string GetStringRepresentation()
    {
        return " ";
    }
}