using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // We will be using a do-while loop here
        int useNumber = -1;
        while (useNumber !=0)
        {
            Console.Write("Entry a number (0 to quit): ");
            string useResponse = Console.ReadLine();
            useNumber = int.Parse(useResponse);

            // Here will add the number to the list if the number is not 0
            if (useNumber !=0)
            {
                numbers.Add(useNumber);
            }
        }

        // Now we Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Now we Compute the average
        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");

        // Now we will find the maximum number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number is: {max}");
        
        // Now we will find the minimum number
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The min number is: {min}");
    }
}