using System;

public class Job
{
    public string _jobDesignation;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobDesignation} {_company} {_startYear} {_endYear}");
    }
}