using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string name = AskUserName();
        int num = FavoriteNumber();
        int numSquared = SquareNumber(num);
        DisplayResults(name, numSquared);
    }
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string AskUserName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            return userName;
        }
        static int FavoriteNumber()
        {
            Console.WriteLine("What is your favorite number?");
            string favoriteString = Console.ReadLine();
            int favoriteNumber = int.Parse(favoriteString);
            return favoriteNumber;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResults(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}!");
        }
}