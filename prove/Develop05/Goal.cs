using System;
using System.ComponentModel;

public class Goal
{
    //attributes 
    protected string _title;
    protected string _description;
    protected int _points;

    //constructors
    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    //methods
    public virtual void RecordEvent()
    {
    }

    public virtual bool IsComplete()
    {
        return false;
    }
    public string GetDetailsString()
    {
        return " ";
    }
    public virtual string GetStringRepresentation()
    {
        return "test";
    }
}