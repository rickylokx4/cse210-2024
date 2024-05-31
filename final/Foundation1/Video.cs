using System;
public class Video
{
    public string _title;
    public string _authorName;
    public int _videoLength;
    int _counter;

    public List<Comment> _commentList = new List<Comment>();

    public void CommentCounter()
    {
        _counter = _commentList.Count();
    }

    public void DisplayVideoInformation()
    {
        CommentCounter();
        Console.WriteLine($"Video: {_title}\nAuthor: {_authorName}\nLength of the video: {_videoLength} seconds\nthe amount of comments is {_counter}\nComments:");
        foreach(Comment comment in _commentList)
        {
            comment.DisplayComments();
        }
        Console.WriteLine("");

    }


}