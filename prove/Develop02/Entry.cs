using System;

//store and hold current entry for use to save or edit
public class Entry
{
  //fix this
  public string _date;
  public string _currentPrompt;
  public string _currentEntry;

  public void Date()
  {
    DateTime _today = DateTime.Now;
    int _month = _today.Month;
    int _day = _today.Day;
    int _year = _today.Year;
    _date = $"{_month}/{_day}/{_year}";
  }
  public string CompileEntry()
  {
    string[] words = _currentEntry.Split(" ");
    int _wordCount = words.Length;
    string _compiledData = $"Date: {_date}&&Prompt: {_currentPrompt}&&{_currentEntry}&&{_wordCount}";
    return _compiledData;
  }
}
/*
    string _hold = Console.ReadLine();
    //word count
    string[] _words = _hold.Split(" ");
    int _wordCount = _words.Length;
    _return = $"Date: {_currentDate}&&Prompt: {_newPrompt}&&{_hold}&&{_wordCount}";
  }*/
