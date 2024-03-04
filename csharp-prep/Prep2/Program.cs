using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade %? (Integers only)");
        string input = Console.ReadLine();
        int percent = int.Parse(input);
        string grade = " ";
        if (percent >= 90)
        {
            grade = ("A");
        }
        else if (percent >= 80)
        {
            grade =("B");
        }
        else if (percent >= 70)
        {
            grade = ("C");
        }
        else if (percent >= 60)
        {
            grade = ("D");
        }
        else
        {
            grade = "F";
        }
        if (grade == "A" || grade == "B" || grade == "C")
        {
            Console.WriteLine($"You passed with a {grade}.");
        }
        else
        {
            Console.WriteLine($"You don't pass with a {grade}.");
        }
    }
}