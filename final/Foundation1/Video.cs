public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public int _count;
    public List<Comment> _comments = new List<Comment>();
    public List<string> _videos = new List<string>
    {
        
    };

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length; 
    }

    public int GetCommentCount()
    {
        return _count;
    }

    public void AddVideo()
    {
        
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video: {_title} by {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {_count}");
        Console.WriteLine($"Comments:");
        
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}