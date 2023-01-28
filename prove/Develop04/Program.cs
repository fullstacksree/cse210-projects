using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        do
        {
            Console.WriteLine("Menu Choices: ");
            Console.WriteLine("1. Start Breathing Activity \n2. Start Reflecting Activity \n3. Start Listing Activity \n4. Quit");
            Console.Write("Choose your choice from the menu: ");
            choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        BreathingActivity activity1 = new BreathingActivity();
                        break;
                    case "2":
                        Console.Clear();
                        ReflectingActivity activity2 = new ReflectingActivity();
                        break;
                    case "3":
                        Console.Clear();
                        ListingActivity activity3 = new ListingActivity();
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
        }

        while (choice != "4");
    }
}