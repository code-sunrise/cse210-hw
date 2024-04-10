using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

//child of component class

public class Potion : Component
{
    //attributes
    private int _strength = 0;
    // i added this to the component class int _amount;
    private int _value;

    //constructors

    public Potion(string name, string description) : base(name, description)
    {
        _strength = 0;
        _value = 8;
    }
    //methods
    public void Brew()
    {
        int brew = _strength * 2 + 6;
        _amount += brew;
    }
    public int Sell()
    {
        int income = _value * _amount;
        _amount = 0;
        return income;
    }
    public void Lesson()
    {
        _value =+ 5;
        _strength =+ 1;
    }

    public override string Display()
    {
        string display = $"Testing!! {_name} {_description} {_amount}, {_strength}, {_value}";
        return display;
    }
}