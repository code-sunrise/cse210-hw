using System;

public class Component
{
    //attributes
    string _name;
    string _description;

    //constructor
    public Component(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public virtual string Display()
    {
        return "";
    }
}