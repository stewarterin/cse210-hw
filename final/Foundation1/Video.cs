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

    public int GetCommentCount()
    {
        return _count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine("");
    }
}