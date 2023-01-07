using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int SquaredrootNumber = SquareNumber(userNumber);

        DisplayResult(userName, SquaredrootNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the C# Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squareroot = number * number;
        return squareroot;
    }

    static void DisplayResult(string name, int squareroot)
    {
        Console.WriteLine($"{name}, the squareroot of your number is {squareroot}");
    }
}