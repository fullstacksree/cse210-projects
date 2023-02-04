using System;
class WholeGoals
{
    private List<Goal> wholeGoals = new List<Goal>();

    private int fullScore;

    public int getFullScore()
    {
        return fullScore;
    }
    public void addGoal(Goal _goal)
    {
        wholeGoals.Add(_goal);
    }

    public void DisplayGoals()
    {
        if (wholeGoals.Count() == 0)
        {
            Console.WriteLine("No goals generated or created");
        }
        foreach (Goal goal in wholeGoals)
        {
            Console.WriteLine(goal.ToString());
        }
    }
    public void SaveGoals()
    {
        if (wholeGoals.Count() == 0)
        {
            Console.WriteLine("Here there are no goals to save");
            return;
        }
        string fileToSave = DisplayGetGoalFile();
       
        List<string> saveGoals = new List<string>();
        // Save the scores first
        saveGoals.Add(fullScore.ToString());

        // Loop through all goals and convert them to a CSV record to be save.
        foreach (Goal goal in wholeGoals)
        {
            saveGoals.Add(goal.ToCSVRecord());
        }
        
        SaveLoadCSV.SaveToCSV(saveGoals, fileToSave);

        Console.WriteLine("Goals saved");
    }
    public void LoadGoals()
    {
        List<string> fileGoals;
        
        fileGoals = SaveLoadCSV.LoadFromCSV(DisplayGetGoalFile());
        
        Goal goal = null;
        foreach (string goalInFile in fileGoals)
        {
            string[] goalParts = goalInFile.Split("|");
            int goalType = int.Parse(goalParts[0]);
            switch (goalType)
            {
                case 1:
                    goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
                    break;
            }
            if (goal != null && wholeGoals.Contains(goal) == false)
            {
                wholeGoals.Add(goal);
            }
        }
        Console.WriteLine("\nGoals loaded\n");
    }
    public string DisplayGetGoalFile()
    {
        Console.Write("Whate is the filename of the goal file? ");
        return Directory.GetCurrentDirectory() + "\\Files\\" + Console.ReadLine();
    }
    public void DisplayGoalRecordEvent()
    {
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in wholeGoals)
        {
            Console.WriteLine(string.Format("{0} {1}", wholeGoals.IndexOf(goal) +1, goal.getGoalTitle()));
        }
        Console.Write("Which goal you have attained? ");
        int recordEvent = int.Parse(Console.ReadLine()) - 1;
        wholeGoals[recordEvent].RecordEvent();
        fullScore += wholeGoals[recordEvent].getFullScore();

        Console.WriteLine(string.Format("You have now {0} points", fullScore.ToString()));
    }
}