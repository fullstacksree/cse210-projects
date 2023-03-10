using System;

public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, double length, int numberOfLaps): base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }
    public double GetNumberOfLaps()
    {
        return _numberOfLaps;
    }
    public void SetNumberOfLaps(int numberOfLaps)
    {
        _numberOfLaps = numberOfLaps;
    }
    public override double CalculateDistance()
    {
        double distance = Math.Round(_numberOfLaps * 50 / 1000 * 0.62, 1);
        return distance;
    }

    public override double CalculateSpeed()
    {
        double speed = Math.Round((CalculateDistance() / GetLength()) * 60, 1);
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = Math.Round(GetLength() / CalculateDistance(), 1);
        return pace;
    }

    public override void GenerateSummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()} min) - Distance: {CalculateDistance()} miles; Speed: {CalculateSpeed()}, Pace: {CalculatePace()} min per mile");
    }
}