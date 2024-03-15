using System;

//store and hold current entry for use to save or edit
public class Entry
{
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
}