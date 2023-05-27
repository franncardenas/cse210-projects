using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("3 Nephi", "9", "22");
        string referenceOutput =reference.GetReference();

        string scriptureOutput = "Therefore, whoso repenteth and cometh unto me as a little child, him will I receive, for of such is the kingdom of God. Behold, for such I have laid down my life, and have taken it up again; therefore repent, and come unto me ye ends of the earth, and be saved.";
        Scripture scripture = new Scripture(referenceOutput, scriptureOutput);
        scripture.GetRenderedText();
        Console.WriteLine();

        bool allWordsHidden = false;

        do
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish: ");

            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                Console.WriteLine("Program terminated by user request.");
                break;
            }
            else if (userInput == "")
            {
                scripture.HideWords();
                allWordsHidden = scripture.IsCompletelyHidden();
            }
            else
            {
                Console.WriteLine("Invalid entry, try again.");
            }
        }
        while (!allWordsHidden);

        if (allWordsHidden)
        {
            Console.WriteLine("\nAll words are hidden. End of program.");
        }
    }
}