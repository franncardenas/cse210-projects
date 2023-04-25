using System;

class Program
{
    static void Main(string[] args)
    {
        // Get number from the user
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;

        while (magicNumber != guess)
        {
            // Get guess from the user
            Console.Write("What is your guess? ");
            string guessUser = Console.ReadLine();
            guess = int.Parse(guessUser);


            if (guess < magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}