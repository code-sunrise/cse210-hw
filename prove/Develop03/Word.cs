using System;
using System.ComponentModel;

public class Word
{
    //attributes
    private string _text;
    private bool _isHidden;
    //constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetTextDisplay()
    {
        string display = _text;
        if(_isHidden == true)
        {
            display = new string('_', _text.Length);
        }
        return display;
    }
}