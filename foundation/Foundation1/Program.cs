using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        //create 3-4 videos each with 3-4 comments
        Comment comment1 = new Comment("name1", "comment1 text");
        Comment comment2 = new Comment("name2", "comment2 text");
        Comment comment3 = new Comment("name3", "comment3 text");

        List<Comment> comments1 = new List<Comment>();
        comments1.Add(comment1);
        comments1.Add(comment2);
        comments1.Add(comment3);

        Video video1 = new Video("How to change a tire", "tireman89", 300, comments1);

        videos.Add(video1);

        Comment comment4 = new Comment("name4", "comment4 text");
        Comment comment5 = new Comment("name5", "comment5 text");
        Comment comment6 = new Comment("name6", "comment6 text");

        List<Comment> comments2 = new List<Comment>();
        comments2.Add(comment4);
        comments2.Add(comment5);
        comments2.Add(comment6);

        Video video2 = new Video("TV fixing tutorial", "FixItFelix", 500, comments2);

        videos.Add(video2);

        Comment comment7 = new Comment("name7", "comment7 text");
        Comment comment8 = new Comment("name8", "comment8 text");
        Comment comment9 = new Comment("name9", "comment9 text");

        List<Comment> comments3 = new List<Comment>();
        comments3.Add(comment7);
        comments3.Add(comment8);
        comments3.Add(comment9);

        Video video3 = new Video("Let's  play minecraft", "GameGal54", 1000, comments3);

        videos.Add(video3);
        
        //display all the videos with all the comments 
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            int numberOfComments = video.NumOfComments();
            Console.WriteLine("");
            Console.WriteLine($"Number of Comments: {numberOfComments}");
            Console.WriteLine("");
        }
    }
}