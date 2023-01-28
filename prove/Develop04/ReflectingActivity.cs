using System;

public class ReflectingActivity
{
    List<string> prompt, queries;
    public ReflectingActivity() : base()
    {
        setActivityName("Reflecting Activity");

        setDescription("This activity will guide and help you to reflect on times in your life when you have shown your strength and resilience. This will guide you to recognize the power you have and how you can utilize it in your different aspects of life");

        prompt = new List<string>
        {
            "Think of a time when you learned a bicycle.",
            "Think of a time when you clothed someone in need.",
            "Think of a time when you feel the spirit."
        };

        queries = new List<string>
        {
            "What is the feeling you had? ",
            "How did you feel at that moment? ",
            "How did you apply that guidance in different aspects of life",
        };
    }
    public void runActivity()
    {
        runActivityParentStart();
        displayPrompt();
        displayCountDown(5);
        Console.Clear();
        displayQueries();
        runActivityParentEnd();
    }
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
    }

    public void displayQueries()
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i< 4; i++)
        {

            }
        }
}
