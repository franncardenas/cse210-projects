using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade
        Console.Write("What is your percentage grade? ");
        string gradeFromUser = Console.ReadLine();

        int grade = int.Parse(gradeFromUser);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >=70)
        {
            letter = "C";
        }
        else if (grade >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";

        if (grade % 10 >= 7)
        {
            sign = "+";
        } 
        else if (grade % 10 <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Print letter grade
        if (letter == "A" && sign == "+")
        {
            Console.WriteLine($"Your letter grade is: {letter}");
        }
        else if (letter == "F" && sign == "+" || sign == "-")
        {
            Console.WriteLine($"Your letter grade is: {letter}");
        }
        else 
        {
            Console.WriteLine($"Your letter grade is: {letter}{sign}");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed the course!");
        }
        else 
        {
            Console.WriteLine("I'm sorry you couldn't pass the course, but try again!");
        }

    }
}