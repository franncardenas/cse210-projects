using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string userInput;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select an choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                BreathingActivity breathingact = new BreathingActivity();
                breathingact.ShowInitialMessage();
                breathingact.StartPaused();
                breathingact.StartBreathingActivity();
                breathingact.ShowFinalMessage();
            }
            else if (userInput == "2")
            {
                ReflectingActivity reflectingact = new ReflectingActivity();
                reflectingact.ShowInitialMessage();
                reflectingact.StartPaused();
                reflectingact.ReflectingPrompt();
                reflectingact.QuestionsPrompt();
                reflectingact.ShowFinalMessage();
            }
            else if (userInput == "3")
            {
                ListingActivity listingact = new ListingActivity();
                listingact.ShowInitialMessage();
                listingact.StartPaused();
                listingact.StartListingAct();
                listingact.ShowFinalMessage();
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Good Bye");
            }
            else
            {
                Console.WriteLine("Invalid entry, try again.");
            }
        }
        while (userInput != "4");
    }
}