using System;

public class SimpleGoal : Goal
{
    //attributes
    private bool _isComplete;

    //constructor
    public SimpleGoal(string title, string description, int points) : base(title, description, points)
    {
        
    }

    //methods
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