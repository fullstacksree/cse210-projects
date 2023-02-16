using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;

    public List<Comment> _commentsList = new List<Comment>();

    public void DisplayDetails()
    {
        Console.WriteLine($"\n> VIDEO DETAILS\n- Title: {_title}\n - Author: {_author}\n - Length: {_lengthInSeconds}");
    }

    public void DisplayComments()
    {
        Console.Write("\n>> COMMENTS");

        foreach (Comment comment in _commentsList)
        {
            comment.DisplayComment();
        }
    }

    public int ComputeNumberOfComments()
    {
        return _commentsList.Count();
    }
}