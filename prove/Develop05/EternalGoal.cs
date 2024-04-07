using System;
using System.ComponentModel;

public class EternalGoal : Goal
{
    //attributes - inherited

    //constructor
    EternalGoal(string title, string description, int points) : base(title, description, points)
    {
        //default message 
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