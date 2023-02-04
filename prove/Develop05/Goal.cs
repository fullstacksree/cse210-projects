using System;

public abstract class Goal
{
    private string _goalTitle;

    private string _goalDescription;

    private int _fullScore;

    public Goal()
    {
    }

    public Goal(string goalTitle, string goalDescription, int fullScore)
    {
        _goalTitle = goalTitle;
        _goalDescription = goalDescription;
        _fullScore = fullScore;
    }

    public string getGoalTitle()
    {
        return _goalTitle;
    }
    public void DisplayGetGoalTitle()
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
    public int getFullScore()
    {
        return _fullScore;
    }
    public void DisplayGetFullScore()
    {
        Console.Write("How many plans associated with this goal");
        _fullScore = int.Parse(Console.ReadLine());
    }
    public void DisplayScore()
    {
        Console.WriteLine(string.Format("You have now {0} points", _fullScore.ToString()));
    }
    public abstract string ToCSVRecord();
    public abstract void RecordEvent();

    
}