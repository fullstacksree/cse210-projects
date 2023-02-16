using System;

public class Running : Activity
{
    private double _distance;
    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public double GetDistance()
    {
        return _distance;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public override double CalculateDistance()
    {
        return Math.Round(_distance, 1);
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
        Console.WriteLine($"{GetDate()} Running ({GetLength()} min) - Distance: {CalculateDistance()} miles; Speed: {CalculateSpeed()}, Pace: {CalculatePace()} min per mile");
    }
}