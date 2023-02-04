using System;
using System.Diagnostics;

class Activity
{
    private string startMessage, endMessage, description, activityName;

    static int spinnerCounter, UserSessionLengthInput = 0;

    public Activity()
    {
        spinnerCounter = UserSessionLengthInput = 0;
    }

    public void setActivityName(string _activityName)
    {
        activityName = _activityName;
    }
    public void setDescription(string _description)
    {
        description = _description;
    }

    public int getUserSessionLengthInput()
    {
        return UserSessionLengthInput;
    }
    public void displayStartMessage()
    {
        startMessage = string.Format("Welcome {0}.", activityName);
        Console.WriteLine(startMessage);
        Console.WriteLine();
    }
    public void displayDescription()
    {
        Console.WriteLine(description);
        Console.WriteLine();
    }
    
    public void displayEndMessage()
    {
        endMessage = string.Format("You have finished another {0} seconds of the {1}", UserSessionLengthInput, activityName);

        Console.WriteLine();
        Console.WriteLine("Well done!");
        displaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(endMessage);
        Console.WriteLine();
        displaySpinner(3);
    }

    public void Timer()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

        Console.Write(" ");
    }
    public void displayGetSessionLength()
    {
        Console.WriteLine("How long you would like your session would be /in seconds/");
        UserSessionLengthInput = int.Parse(Console.ReadLine());
    }

    public void displayGetReady()
    {
        Console.WriteLine("Get ready...");
        displaySpinner(5);
    }

    public void runActivityParentStart()
    {
        displayStartMessage();
        displayDescription();
        displayGetSessionLength();
        displayGetReady();
    }

    public void runActivityParentEnd()
    {
        displayEndMessage();
    }
}