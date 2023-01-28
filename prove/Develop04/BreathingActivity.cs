using System;

public class BreathingActivity
{
    Activity _activity = new Activity();

    private int _timeduration;

    public BreathingActivity()
    {
        Console.WriteLine("Welcome to Breathing Activity.");
        Console.WriteLine("This breathing activity will guide you to release from stress by doing the breathing in and out exercise.");
        Console.WriteLine("How long you would like your session would be /in seconds/");
        _timeduration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get Start...");
        _activity.Timer();

        Countdown();

        Console.WriteLine("Nicely done!");
        _activity.Timer();

        Console.WriteLine($"You have done another {_timeduration} seconds of breathing activity");
        _activity.Timer();
        Console.Clear();

    }

    private void Countdown()
    {
        int i = 20;
        for (int a = _timeduration / i - 1; a >=0; a--)
        {
            for (i = 5; i >= 0; i--)
            {
                Console.Write("Breath in...{0}", i);
                Thread.Sleep(1000);
            }
            for (i = 5; i >= 0; i--)
            {
                Console.Write("Breath out...{0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}