using System;
//fraction class
public class Fraction
{
// attributes
private int _top;
private int _bottom;
public Fraction()
{
    _top = 1;
    _bottom = 1;
}
public Fraction(int wholeNumber)
{
    _top = wholeNumber;
    _bottom = 1;
}
public Fraction(int top, int bottom)
{
    _top = top;
    _bottom = bottom;
}
public int GetTop()
{
    return _top;
}
public void SetTop(int top)
{
    _top = top;
}

public int GetBottom()
{
    return _bottom;
}
public void SetBottom(int bottom)
{
    _bottom = bottom;
}
public string GetFractionString()
{
    string aFraction = $"{_top}/{_bottom}";
    return aFraction;
}
public double GetDecimalValue()
{
    double dec = (Double)_top / _bottom;
    return dec;
}
}