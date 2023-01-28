using System;

public class ListingActivity
{
    List<string> prompt, queries;
    private List<string> listingQueries = new List<string>
    {
        "What is the feeling you had? ",
        "How did you feel at that moment? ",
        "How did you apply that guidance in different aspects of life",
    };

    public void displayPrompt()
    {
        Console.Clear();
        Console.WriteLine("Consider the following: ");
        Console.WriteLine();

        int randomIndex = new Random().Next(0, prompt.Count());
        Console.WriteLine(prompt[randomIndex]);
        Console.WriteLine();

        Console.WriteLine("Do you thinking somewhat in mind, then press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Ponder now on the following queries as they related to your experience");
    }

    public void displayCountDown(int numSecondsToRun)
    {
        for (int i = 1; i <= numSecondsToRun; i++)
        {
            Console.Write(string.Format("You can start now: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }

        Console.Write(" ");
    }

}