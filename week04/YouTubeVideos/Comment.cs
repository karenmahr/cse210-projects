using System;

public class Comment
{
    public string _name;
    public string _text;
    public List<Comment> _comment = new List<Comment>();

    public Comment(string name, string text)
    { 
        _name = name;
        _text = text;
    }
}