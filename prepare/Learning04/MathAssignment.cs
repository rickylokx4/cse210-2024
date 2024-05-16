using System;

class MathAssignment : Assignment
{
    private string _texbookSection;
    private string _problems;
    public MathAssignment(string studentName, string topic, string texbookSelection, string problems) : base(studentName, topic)
    {
        _texbookSection = texbookSelection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"{_studentName} - {_topic}\n{_texbookSection} {_problems}";
    }
}