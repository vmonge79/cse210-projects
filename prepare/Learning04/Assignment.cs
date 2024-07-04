using System;

class Assignment
{
    private string _studentName;
    private string _topic;

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

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSumary()
    {
        return $"Student Name: {_studentName}, Topic: {_topic}." ;
    }
}