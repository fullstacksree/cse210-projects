using System;

public class Resume
{
    public string _name;

    // Initialize the list to a new list before using it
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Make a note to use of the custom date type as "Job" in this below loop
        foreach (Job job in _jobs)
        {
            // This shows the Display on each of the job
            job.Display();
        }
    }


}