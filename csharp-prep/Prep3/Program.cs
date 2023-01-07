using System;

class Program
{
    static void Main(string[] args)
    {
        // I need to start the variable "guess" at something, but I don't wish to start
        // Here in section 1 and 2, the user specifies the number...
        

        // In section 3, we use a random number to keep continuing as long as the guess doesn't match with magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 99);
        int guess= -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }

            // At this time, you have guessed the magic number correctly
                Console.WriteLine(" number of times I have tried to find the magic number");

        }
    }
}