using System;

class WritingAssigment : Assignment
{

    private string _title;

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

 
    public WritingAssigment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }   

    public string GetWritingInfo()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }

}