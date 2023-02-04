using System;

public class Goal
{
    private string _goalTitle;

    private string _goalDescription;

    private string _fullScore;

    public Goal(string goalTitle, string goalDescription, string fullScore)
    {
        _goalTitle = goalTitle;
        _goalDescription = goalDescription;
        _fullScore = fullScore;
    }

    public string getGoalTitle()
    {
        return _goalTitle;
    }
    public void choice()
    {
        Console.Write("What is the title of the goal? ");
        _goalTitle = Console.ReadLine();
    }
    public string getGoalDescription()
    {
        return _goalDescription;
    }
    public void DisplayGetGoalDescription()
    {
        Console.Write("What is the short description of the goal? ");
        _goalDescription = Console.ReadLine();
    }
    public string getFullScore()
    {
        return _fullScore;
    }
    public string DisplayGetFullScore(string fullScore)
    {
        _fullScore = fullScore;
        return _fullScore;
    }
    public void DisplayScore()
    {
        Console.WriteLine(string.Format("You have now {0} points", _fullScore.ToString()));
    }
    public virtual string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}", getGoalTitle(), getGoalDescription(), getFullScore());
    }
    public virtual void RecordEvent()
    {
        Console.WriteLine(string.Format("Congratulations! You earned {0}", getFullScore()));
    }

    internal void DisplayGetGoalTitle()
    {
        throw new NotImplementedException();
    }

    internal void DisplayGetFullScore()
    {
        throw new NotImplementedException();
    }
}