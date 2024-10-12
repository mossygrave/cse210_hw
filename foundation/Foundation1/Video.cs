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

    public int NumOfComments()
    {
        private int num;
    }

}