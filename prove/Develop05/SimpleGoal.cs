class SimpleGoal : Goal
{
    private const int goalType = 1;

    private bool goalComplete;

    public SimpleGoal()
    {
    }
    public SimpleGoal(string _goalTitle, string _goalDescription, int _fullScore, bool _goalComplete) : base (_goalTitle, _goalDescription, _fullScore)
    {
        goalComplete = _goalComplete;
    }

    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, getGoalTitle(), getGoalDescription(), getFullScore(), goalComplete);
    }
    public override string ToString()
    {
        return string.Format("[{0}] {1} ({2})", ((goalComplete == false) ? " " : "X"), getGoalTitle(), getGoalDescription());
    }
    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congratulations! You earned {0}", getFullScore()));
        goalComplete = true;
    }
    
}
