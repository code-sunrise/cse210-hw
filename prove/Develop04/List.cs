using System;

public class List : Activity
{
    //attributes
    List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    //constructor
    
    //methods
    public void Run()
    {
        DisplayStart();
        ShowSpinner();
        DisplayEnd();
    }
}