
public class Comment
{
    private string _name;
    private string _text;

    public void StoreComment(string name, string text)
    {
        _name = name;
        _text = text;

    }

    public string GetDisplay()
    {
        return $"{_name}: {_text}";
    }
}