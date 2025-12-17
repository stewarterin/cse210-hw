using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video v1 = new Video("How to Change a Tire", "James Stewart", 1800);
        Comment c1 = new Comment("Vance Santos", "Very helpful!");
        v1.AddComment(c1);
        Comment c2 = new Comment("Santi Little", "Thanks for the video.");
        v1.AddComment(c1);
        Comment c3 = new Comment("Bob Wright", "Great work, man.");
        v1.AddComment(c3);
        _videos.Add(v1);

        Video v2 = new Video("Funniest Cat Videos", "Heather Mayer", 1200);
        Comment c4 = new Comment("Roger Loftis", "Hilarious!");
        v2.AddComment(c4);
        Comment c5 = new Comment("Tucker McAllister", "This is so great.");
        v2.AddComment(c5);
        Comment c6 = new Comment("Juan Martinez", "So funny!");
        v2.AddComment(c6);
        _videos.Add(v2);
        
        Video v3 = new Video("Hidden Gems in the Treasure Valley", "Maria Orozco", 1200);
        Comment c7 = new Comment("Bella Brown", "Love it!");
        v3.AddComment(c7);
        Comment c8 = new Comment("Rusty Owens", "So many good suggestions.");
        v3.AddComment(c8);
        Comment c9 = new Comment("Callie Meyet", "Best video!");
        v3.AddComment(c9);
        Comment c10 = new Comment("Rachel Ranjel", "Woah, great list.");
        v3.AddComment(c10);
        _videos.Add(v3);

        foreach (Video video in _videos)
        {
            video.DisplayVideoDetails();
        }
    }
}