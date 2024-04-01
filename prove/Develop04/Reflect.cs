using System;
using System.ComponentModel;
using System.Collections.Generic;
public class Reflect : Activity
{
    //attributes
    List<string> _prompts = new List<string>
    {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };
    List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    //constructors
    public void ReflectActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    //methods
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int select = rand.Next(_prompts.Count());
        string prompt = _prompts[select];
        return prompt;
    }
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int select = rand.Next(_questions.Count());
        string question = _questions[select];
        return question;
    }
    public void DisplayPrompt()
    {
        string display = GetRandomPrompt();
        Console.WriteLine($"Prompt: {display}");
    }
    public void Run()
    {
        int timed = (int)Math.Ceiling(_duration / 5.0);
        DisplayStart();
        ShowSpinner();
        GetRandomPrompt();
        ShowSpinner();
        GetRandomQuestion();
        DisplayEnd();

    }
}
/*The activity should begin with the standard starting message
and prompt for the duration that is used by all activities.
The description of this activity should be something like:
"This activity will help you reflect on times in your life when
you have shown strength and resilience. This will help you recognize the
power you have and how you can use it in other aspects of your life."
After the starting message, select a random prompt to show the user such as:

Think of a time when you stood up for someone else.
Think of a time when you did something really difficult.
Think of a time when you helped someone in need.
Think of a time when you did something truly selfless.
After displaying the prompt, the program should ask the to reflect on
questions that relate to this experience. These questions should be pulled
from a list such as the following:

Why was this experience meaningful to you?
Have you ever done anything like this before?
How did you get started?
How did you feel when it was complete?
What made this time different than other times when you were not as successful?
What is your favorite thing about this experience?
What could you learn from this experience that applies to other situations?
What did you learn about yourself through this experience?
How can you keep this experience in mind in the future?

After each question the program should pause for several seconds before continuing
to the next one. While the program is paused it should display a kind of spinner.
It should continue showing random questions until it has reached the number of
seconds the user specified for the duration.

The activity should conclude with the standard finishing message for all activities. */