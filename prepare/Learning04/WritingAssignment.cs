public class WritingAssignment : Assignment
{
    private string _title;

    // Here we should notice that the syntax in the WritingAssignment constructor has 3 parameters
    // and it passes to 2 of them directly to the "basic" constructor, which here known as "Assignment" class constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        //Setting a specific variable to WritingAssignment class
        _title = title;
    }

    public string GetWritingInformation()
    {
        // We have to make a note that we are here calling the getter because _studentName is the private in base class
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}