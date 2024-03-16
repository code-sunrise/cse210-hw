using System;
using System.IO;
using System.Collections.Generic;
using System.Net.NetworkInformation;
/*
public class Journal
{

    //attributes
    public string _filename;
    public List<string> _entry = new List<string>;
    //make a list attribute for the journal entries
    public string NewEntry()
    {
        DateTime _today = DateTime.Now;
        int _month = _today.Month;
        int _day = _today.Day;
        int _year = _today.Year;
        string _currentDate = $"{_month}/{_day}/{_year}";
        Prompt _newPrompt = new Prompt();
        Console.WriteLine(_newPrompt);
        string _hold = Console.ReadLine();
        //word count
        string[] _words = _hold.Split(" ");
        int _wordCount = _words.Length;
        string _return = $"Date: {_currentDate}&&Prompt: {_newPrompt}&&{_hold}&&{_wordCount}";
        return _return;
    }
    //load, save, and display entries from a txt file
    //function load
    static void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("&&");

            string _date = parts[0];
            string _prompt = parts[1];
            string _entry = parts[2];
            string _wordCount = parts[3];
        }
    }
    //save
    static void Save(string input)
    {

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(input);
        }
    }
    //display
    static void DisplayAll()
    {

    }
}*/