using System;
using System.ComponentModel;
using System.Collections.Generic;

//child of component class

public class Challenge : Component
{
    //attributes
    int _potionIndex;
    int _target;

    //constructors
    public Challenge(string name, string description, int potionIndex) : base(name, description)
    {
        Random randTarget = new Random();
        _amount = randTarget.Next(9);
        _amount += 20;
        _potionIndex = potionIndex;
        Random randTurns = new Random();
        _target = randTurns.Next(6);
        _target += 4;
    }

    //methods
    public int GetTurns()
    {
        return _target;
    }
    public override string Display()
    {
        //change output
        return $"{base._description} You need {base._amount} of potions to complete the {base._name} this challenge.";
    }
}