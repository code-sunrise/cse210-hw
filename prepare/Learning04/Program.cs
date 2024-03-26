using System;

class Program
{
    static void Main(string[] args)
    {
        //main assignment test
        Assignment science = new Assignment("Xoey", "Science");
        Console.WriteLine(science.GetSummary());
        //math assignment test
        Math math1 = new Math("Kiki", "Algebra II", "14", "3-11");
        Console.WriteLine(math1.GetHomeworkList());
        //writing assignment test
        Writing writing1 = new Writing("Suzie", "English 101", "Explanatory Synthesis");
        Console.WriteLine(writing1.GetWritingInfo());
    }
}