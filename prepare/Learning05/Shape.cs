using System;

public class Shape
{
    //attributes 
    protected string _color;

    //constructors
    public Shape(string color)
    {
        _color = color;
    }

    //methods
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}