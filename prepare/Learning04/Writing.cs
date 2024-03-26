using System;

public class Writing : Assignment
{
    //attributes
    //parent class has _studentName and _topic
    string _title;

    //constructor
    public Writing(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // method
    //parent GetSummary() name and topic
    public string GetWritingInfo()
    {
        string info = $"{_studentName} - {_topic}, Assignment: {_title}";
        return info;
    }
}