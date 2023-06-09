public class ReflectingActivity : Activity
{
    public ReflectingActivity(): base()
    {
        _nameActivity = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
    }


    public void ReflectingPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"   --- {FirstPrompt()}---   ");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string enter = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountAnimation(5);
    }

    public string FirstPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        return RandomPrompt(prompts);
    }

    public void QuestionsPrompt()
    {
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {SecondPrompt()} ");
            SpinnerAnimation(10);
        }
        
    }
    public string SecondPrompt()
    {
        List<string> prompt2 = new List<string>();
        prompt2.Add("Why was this experience meaningful to you?");
        prompt2.Add("Have you ever done anything like this before?");
        prompt2.Add("How did you get started?");
        prompt2.Add("How did you feel when it was complete?");
        prompt2.Add("What made this time different than other times when you were not as successful?");
        prompt2.Add("What is your favorite thing about this experience?");
        prompt2.Add("What could you learn from this experience that applies to other situations?");
        prompt2.Add("What did you learn about yourself through this experience?");
        prompt2.Add("How can you keep this experience in mind in the future?");

        return RandomPrompt(prompt2);
    }

}