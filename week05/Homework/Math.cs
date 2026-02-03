
public class Math : Assignment
{
    private string _textbookSection;
    private string _problems;

    public Math(string studentName, string topic, string textbookSection, string problem)
    : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problem;
    }
    
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection}, Problems {_problems}";
    }
}