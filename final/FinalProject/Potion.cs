using System;
using System.Collections.Generic;

//child of component class

public class Potion : Component
{
    //attributes
    //these attributes dont belong here anymore unless id elete component, which i might
    protected string _name;
    protected string _description;
    int _strength = 0;
    List<string> _strengths = new List<string>
    {
        "1",
        "2",
        "3",
        "4 MAX"
    };
    int _amount;

    //constructors

    public Potion(string name, string description) : base(name, description)
    {
        _strength = 0;
        _amount = 0;
    }

    //methods
    public string GetStrength()
    {
        return $"{_strength}";
    }
    public void SetStrength(int lessonLevel)
    {
        _strength = lessonLevel;
    }
    public int GetAmount()
    {
        return 0;
    }
    public void SetAmount(string modify, int amount)
    {
        _amount = amount;
        //if modify = -, subtract amount, if modify = +, add amount to _amount;
    }
    public override string Display()
    {
        string display = $"Testing!! {_name} {_description} {_amount}, {_strength}";
        return display;
    }
}