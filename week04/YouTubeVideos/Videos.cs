
public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _storeComments = new List<Comment>();

    public void AddComment(string name, string text)
    {
        _storeComments.Add(new Comment(name, text));
    }

    public int NumberOfComments()
    {
        return _storeComments.Count;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
}