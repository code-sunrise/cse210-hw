using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6,7);
        Console.WriteLine(f3.GetBottom());
        f3.SetBottom(9);
        Console.WriteLine(f3.GetBottom());

        string theF3 = f3.GetFractionString();
        Console.WriteLine(theF3);
        double decF3 = f3.GetDecimalValue();
        Console.WriteLine(decF3);

    }
}
