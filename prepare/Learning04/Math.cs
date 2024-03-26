using System;

public class Math : Assignment
{
    //attributes
    //parent class has _studentName and _topic
    private string _textbookSection;
    private string _problems;

    //constructor
    public Math(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    // method
    //parent GetSummary() name and topic
    public string GetHomeworkList()
    {
        string homeworkList = $"{_studentName} - {_topic}, Section: {_textbookSection}, problems {_problems}";
        return homeworkList;
    }
}