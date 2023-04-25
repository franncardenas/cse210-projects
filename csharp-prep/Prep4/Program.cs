using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();

        int userNumber = -1; 
        while (userNumber != 0)
        {
            
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
                
        }
        float sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
        

        int minNumber = 9999999;
        foreach (int number in numbers)
        {
            if (number > 0 && minNumber > number)
            {
                minNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {minNumber}");

        numbers.Sort();
        
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}