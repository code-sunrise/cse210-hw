using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        bool entry = true;
        string response;
        List<int> num = new List<int>();
        while (entry == true)
        {
            Console.WriteLine("Enter an integer: ");
            response = Console.ReadLine();
            int compare = int.Parse(response);
            if (compare == 0)
            {
                entry = false;
            }
            else
            {
                num.Add(compare);
            }
        }
    }
}