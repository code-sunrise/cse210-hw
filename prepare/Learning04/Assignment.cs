using System;

public class Assignment
{
    //attributes
    protected string _studentName;
    protected string _topic;


    //constructors
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    //methods
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
}
