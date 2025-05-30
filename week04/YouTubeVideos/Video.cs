using System;

public class Video
{
    public Video() { }
    public List<Comment> _comment = new List<Comment>();
    public string _title;
    public string _author;
    public int _length;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    } 
    public int NumberOfComments()
    {
        int comments = _comment.Count;
        return comments;
    }
}

