using System;
using System.ComponentModel;

public class Goal
{
    //attributes
    string _title;
    string _description;
    string _points;

    //constructors
    public Goal(string name, string description, string points)
    {

    }

    //methods
    public void RecordEvent()
    {}

    public bool IsComplete()
    {
        return true;
    }
    public string GetDetailsString()
    {
        return " ";
    }
    public string GetStringRepresentation()
    {
        return " ";
    }
}