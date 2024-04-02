using System;

public class Circle : Shape
{
    //attributes
    private double _radius;

    //constructors
    public Circle(string color, double radius): base(color)
    {
        _radius = radius;
    }

    //methods
    public override double GetArea()
    {
        //circle math 
        return _radius * _radius * Math.PI;
    }
}