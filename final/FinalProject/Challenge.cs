using System;
using System.ComponentModel;
using System.Collections.Generic;

//child of component class

public class Challenge : Component
{
    //attributes
    int _potionIndex;
    int _target;
    bool _complete;

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
        _complete = false;
    }

    //methods
    public int GetTurns()
    {
        return _target;
    }
    public void SetComplete()
    {
        _complete = true;
    }
    public bool GetComplete()
    {
        return _complete;
    }
    public override string Display()
    {
        return $"Challenge: {base._name}\n{base._description}\nYou need {base._amount} of potions to succeed.\nYou have {_target} turns";
    }
}