using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
//child of component class

public class Potion : Component
{
    //attributes
    string _strength;
    List<string> _strengths;
    int _amount;

    //constructors

    //methods
    public string GetStrength()
    {
        return " ";
    }
    public void SetStrength(int lessonLevel)
    {
        _strength = _strengths[lessonLevel];
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
}