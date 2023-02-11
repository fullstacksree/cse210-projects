using System;

public class Comment
{
    public string _author;

    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"\n- {_text}\n- By {_author}");
    }
}