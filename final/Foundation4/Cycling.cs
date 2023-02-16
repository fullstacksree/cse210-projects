using System;

public class Cycling : Activity
{
    private double _speed; 

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public double GetSpeed()
    {
        return _speed;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public override double CalculateDistance()
    {
        double distance = Math.Round(GetLength() * CalculateSpeed() / 60, 1);
        return distance;
    }
    public override double CalculateSpeed()
    {
        return Math.Round(_speed, 1);
    }

    public override double CalculatePace()
    {
        double pace = Math.Round(60 / CalculateSpeed(), 1);
        return pace;
    }

    public override void GenerateSummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()} min) - Distance: {CalculateDistance()} miles; Speed: {CalculateSpeed()}, Pace: {CalculatePace()} min per mile");
    }
}