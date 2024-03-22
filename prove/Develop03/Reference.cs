using System;
using System.Collections.Concurrent;
public class Reference
//a class that stores scripture references
{
    //attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string reference;
        if (_endVerse == 0)
        {
            reference = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            reference =  $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return reference;
    }

}