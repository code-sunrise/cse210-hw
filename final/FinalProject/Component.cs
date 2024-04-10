using System;

public class Component
{
    //attributes
    protected string _name;
    protected string _description;
    protected int _amount;

    //constructor
    public Component()
    {
        _name = "component name test";
        _description = "Component description test";
        _amount = 0;
    }
    public Component(string name, string description)
    {
        _name = name;
        _description = description;
        _amount = 0;
    }
    public int GetAmount()
    {
        return _amount;
    }
    public void SetAmount(int input)
    {
        _amount = input;
    }
    public virtual string Display()
    {
        return "display test";
    }
}