using System;

class Program
{
    static void Main(string[] args)
    {
        // Design a basic "Assignment" object
        Assignment a1 = new Assignment("Sree Ranganath", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now we can design the derived class assignments
        MathAssignment a2 = new MathAssignment("Steven Hobbs", "Fractions", "5.1", "7-18");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Water Man", "American History", "The Causes of American War");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}