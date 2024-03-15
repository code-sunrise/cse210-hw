using System;
using System.ComponentModel;
using System.Collections.Generic;
//https://www.w3schools.com/cs/cs_classes.php

public class Prompt
{
    List<string> _prompt = new List<string>
    {
        "Who did I see today?",
        "What did I accomplish today?",
        "Did I create anything today?",
        "What would I change about today?",
        "Was this week better than last week?",
        "Was there anything surprising that happened recently?",
        "Name one thing I admired today? Why?"
    };
    public void PromptGenerator()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(0, _prompt.Count);
        string prompt = _prompt[index];
    }
}