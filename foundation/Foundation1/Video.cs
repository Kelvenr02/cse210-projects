using System;

public class Video
{
    public string _title { get; set; }
    public string _channel { get; set; }
    public int _length { get; set; }
    public List<Comment> _comments;

    public Video(string title, string channel, int length)
    {
        _title = title;
        _channel = channel;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Channel: {_channel}");
        Console.WriteLine($"Length (seconds): {_length}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in GetComments())
        {
            Console.WriteLine($"- {comment._user}: {comment._text}");
        }
        Console.WriteLine(); // White line
    }
}