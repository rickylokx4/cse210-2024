using System;
public class Comment
{
    public string _commentAuthor;
    public string _comment;

    public void DisplayComments()
    {
        Console.WriteLine($"{_commentAuthor}: {_comment}");
    }
    
}