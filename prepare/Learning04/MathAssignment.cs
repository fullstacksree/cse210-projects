public class MathAssignment : Assignment
{
    private string _textmanualSection;
    private string _issues;

    // Here we should notice that the syntax in the MathAssignment constructor has 4 parameters
    // and it passes to 2 of them directly to the "basic" constructor, which here known as "Assignment" class constructor
    public MathAssignment (string studentName, string topic, string textmanualSection, string _issues)
        : base(studentName, topic)
    {
        _textmanualSection = textmanualSection;
        _issues = issues;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textmanualSection} Issues {_issues}";
    }
}