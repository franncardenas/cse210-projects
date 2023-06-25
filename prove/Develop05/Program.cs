using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string userInput;
        int allScore = 0;

        List<Goal> goals = new List<Goal>();

        do
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {allScore} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options: " +
                "\n  1. Create a New Goal"+
                "\n  2. List Goals"+
                "\n  3. Save Goals"+
                "\n  4. Load Goals"+
                "\n  5. Record Event"+
                "\n  6. Quit");
            Console.Write("Select an choice from the menu: ");
            userInput = Console.ReadLine();
            
            if (userInput == "1")
            {
                Console.WriteLine("The types of Goals are: " +
                    "\n  1. Simple Goal"+
                    "\n  2. Eternal Goal"+
                    "\n  3. Checklist Goal");
                Console.Write("Which type of goal would you like create? ");
                string typeGoal = Console.ReadLine();

                if (typeGoal == "1")
                {
                    Console.Write("What is the name of your Goal? ");
                    string nameS = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string descriptionS = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    SimplyGoal simpleGoal = new SimplyGoal(nameS, descriptionS, points);
                    goals.Add(simpleGoal);

                }
                else if (typeGoal == "2")
                {
                    Console.Write("What is the name of your Goal? ");
                    string nameE = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string descriptionE = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int pointsE = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    
                    EternalGoal eternalGoal = new EternalGoal(nameE, descriptionE, pointsE);
                    goals.Add(eternalGoal);
                }
                else if (typeGoal == "3")
                {
                    Console.Write("What is the name of your Goal? ");
                    string nameC = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string descriptionC = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int pointsC = int.Parse(Console.ReadLine());
                    Console.Write("Hom many times does this goal need to be accomplished for bonus? ");
                    int times = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    
                    ChecklistGoal checklistGoal = new ChecklistGoal(nameC, descriptionC, pointsC, times, bonus);
                    goals.Add(checklistGoal);
                }
            }
            else if (userInput == "2")
            {
                int i=1;
                foreach (Goal goal in goals)
                {  
                    string show = goal.ShowGoal();
                    Console.WriteLine($"{i}. {show}");
                    i++;
                }
            }
            else if (userInput == "3")
            {
                Console.Write("What is the filename?: ");
                string filename = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(filename))
                {
                //add score
                writer.WriteLine(allScore);
                foreach (Goal goal in goals)
                {
                    writer.WriteLine(goal.SaveToFile());
                }
                }
            }
            else if (userInput == "4")
            {
                Console.Write("What is the filename?: ");
                string filename = Console.ReadLine();
                string [] lines = System.IO.File.ReadAllLines(filename);

                allScore = int.Parse(lines.First());

                foreach (string line in lines.Skip(1))
                {
                    string[] parts = line.Split(":");
                    string type_goal = parts[0];
                    string parameters = parts[1];
                    
                    if (type_goal == "SimpleGoal")
                    {
                        SimplyGoal simpleGoal = new SimplyGoal();
                        simpleGoal = simpleGoal.CreateGoal(parameters);
                        goals.Add(simpleGoal);
                    }
                    else if (type_goal == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal = eternalGoal.CreateGoal(parameters);
                        goals.Add(eternalGoal);
                    }
                    else if (type_goal == "ChecklistGoal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        checklistGoal = checklistGoal.CreateGoal(parameters);
                        goals.Add(checklistGoal);
                    }
                }
            }
            else if (userInput == "5")
            {
                int i=1;
                foreach (Goal goal in goals)
                {  
                    string nameGoal = goal.GetName();
                    Console.WriteLine($"{i}. {nameGoal}");
                    i++;
                }
                Console.Write("Which goal did you accomplish? ");
                int choice = int.Parse(Console.ReadLine())-1;
                int score = goals[choice].RecordEvent();
                allScore = allScore + score;

            }
            else if (userInput == "6")
            {
                Console.WriteLine("Good Bye");
            }
            else
            {
                Console.WriteLine("Invalid entry, try again.");
            }
        }
        while (userInput != "6");
    }
}