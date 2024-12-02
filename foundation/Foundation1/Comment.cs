using System;

public class Comment
{
    public string _user {get; set; }
    public string _text {get; set; }

    public Comment(string user, string text)
    {
        _user = user;
        _text = text;
    }
}