using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running("0", 30, 30);
        activitiesList.Add(running);

        Cycling cycling = new Cycling("0", 60, 20);
        activitiesList.Add(cycling);

        Swimming swimming = new Swimming("0", 60, 40);
        activitiesList.Add(swimming);

        foreach (Activity activity in activitiesList)
        {
            activity.GenerateSummary();
        }
    }
}