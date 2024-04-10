using System;

public class Inventory : Component
{
    //attributes
    int _money;

    //constructors
    public Inventory(string name, string description): base(name, description)
    {
        _money = 25;
    }

    //methods
    public override string Display()
    {
        //change output
        string display = ("Inventory");
        return display;
    }
}