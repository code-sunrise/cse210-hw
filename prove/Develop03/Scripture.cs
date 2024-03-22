using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Scripture
{
    //attributes
    private Reference _reference;
    private List<Word> _words;
//constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<string> appender = new List<string>(text.Split(" "));
        _words = new List<Word>();
        foreach(string word in appender)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
       for(int i = 0; i < numberToHide; i++)
        {
            int select = rand.Next(_words.Count());
            if(_words[select].IsHidden() == true)
            {
                select -=1;
            }
            _words[select].Hide();
        }
    }

    public string GetDisplayText()
    {
        string totalDisplay = $"{_reference.GetDisplayText()} ";
        foreach(Word word in _words)
        {
            string display = word.GetTextDisplay();
            totalDisplay += display + " ";
        }
        return totalDisplay.Trim();
    }
    public bool IsCompletelyHidden()
    {
        bool allHidden = true;
        bool ewbugs;
        foreach(Word word in _words)
        {
            ewbugs = word.IsHidden();
            if(ewbugs == false)
            {
                allHidden = false;
            }
        }
        return allHidden;
    }
}