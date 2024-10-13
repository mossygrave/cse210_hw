public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;

        foreach (Comment comment in comments)
        {
            _comments.Add(comment);
        }
    }
    
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title} Author: {_author} Length: {_length}s");
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine("");
            comment.DisplayComment();
        }
    }
    //create a method to count the number of comments
    
    public int NumOfComments()
    {
        int commentsPerVideo = 0;
        foreach (Comment comment in _comments)
        {
            commentsPerVideo += 1;
        }

        return commentsPerVideo;
    }

}