using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {

        string option = "";
        Journal journal = new Journal();
        while (option != "5")
        {   


            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            option = Console.ReadLine();
            if (option == "1")
            {
                PromptGenerator prompt = new PromptGenerator();
                string prompt1 = prompt.DisplayPrompt();
                Console.Write(prompt1);
                Console.WriteLine();

                Entry entry = new Entry();
                entry._promptEntry = prompt1;
                entry._userEntry = Console.ReadLine();
                entry._date = DateTime.Now.ToString("dd/MM/yyyy");
                journal._entries.Add(entry);
                Console.WriteLine("");

            }
            else if (option == "2")
            {
                journal.Display();
                Console.WriteLine("");
            }
            else if (option == "3")
            {

                Console.WriteLine("What is the filename?: ");
                journal._fileName = Console.ReadLine();
                journal.SaveToFile();
                Console.WriteLine("Saved file!");
                Console.WriteLine("");

            }
            else if (option == "4")
            { 

                Console.WriteLine("What is the filename?: ");
                journal._fileName = Console.ReadLine();
                List<Entry> _entriesFile = journal.ReadFile();
                foreach (Entry entry in _entriesFile)
                {
                    journal._entries.Add(entry);
                }
                Console.WriteLine("");

            }
            else if (option == "5")
            {
                Console.WriteLine("I'll be waiting for you tomorrow :)");
                Console.WriteLine("");
            }
            else 
            {
                Console.WriteLine("Incorrect option, try again");
                Console.WriteLine("");
            }

        }

    }
}   