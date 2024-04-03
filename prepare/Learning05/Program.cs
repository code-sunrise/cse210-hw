using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // list
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Green", 3.1);
        Circle shape2 = new Circle("Blue", 1.5);
        Rectangle shape3 = new Rectangle("Red", 4, 5);

        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);


        foreach(Shape item in shapes)
        {
            Console.WriteLine($"{item.GetColor}");
            Console.WriteLine($"{item.GetArea}");
        }

    }
}
//verified working