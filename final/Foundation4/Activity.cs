using System;

public abstract class Activity
{
    private string _currentDate;

    private double _length;

    public Activity(string currentDate, double length)
    {
        _currentDate = currentDate;
        _length = length;
    }

    public string GetCurrentDate()
    {
        return _currentDate;
    }

    public void SetCurrentDate(string currentDate)
    {
        _currentDate = currentDate;
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public string GetDate()
    {
        DateTime currentDate = DateTime.Now;
        string _currentDate = currentDate.ToString("dd-MMM-yyyy");
        return _currentDate;
    }

    
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract void GenerateSummary();
}