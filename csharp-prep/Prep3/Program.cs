using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine($"The Magic Number is {magicNumber}");
        bool win = false;
        while (win == false)
        {
            Console.WriteLine("Enter your guess!");
            string guess = Console.ReadLine();
            int compare = int.Parse(guess);
            if (compare == magicNumber)
            {
                Console.WriteLine($"That's correct, the magic number is {magicNumber}!");
                win = true;
            }
            else if (compare > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else if (compare < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Error!");
                break;
            }
        }
        Console.WriteLine("Thanks for playing!");
    }
}