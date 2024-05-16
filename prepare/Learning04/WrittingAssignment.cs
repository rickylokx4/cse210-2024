using System;

class WrittingAssignment : Assignment
{
    private string _title;

    public WrittingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;

    }

    public string GetWrittingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title}";
    }
}