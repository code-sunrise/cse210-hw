using System;

public class List : Activity
{
    //attributes
    List<string> _listPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    //constructor 
    
    public string GetListPrompt()
    {
        Random rand = new Random();
        int select = rand.Next(_listPrompts.Count());
        string prompt = _listPrompts[select];
        return prompt;
    }
    //methods
    public void Run()
    {
        DisplayStart();
        ShowSpinner();
        ShowCount();
        DisplayEnd();
    }
}