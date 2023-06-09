public class ListingActivity : Activity
{
    private List<string> _responses = new List<string>();
    public ListingActivity(): base()
    {
        _nameActivity = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void StartListingAct()
    {   
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"   --- {QuestionPrompt()}---   ");
        Console.Write("You may begin in: ");
        CountAnimation(5);
        Console.WriteLine("");
        ResponsesList();
    }

    public string QuestionPrompt()
    {
        List<string> questions = new List<string>();
        questions.Add("Who are people that you appreciate?");
        questions.Add("What are personal strengths of yours?");
        questions.Add("Who are people that you have helped this week?");
        questions.Add("When have you felt the Holy Ghost this month?");
        questions.Add("Who are some of your personal heroes?");

        return  RandomPrompt(questions);
    }

    public void ResponsesList()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            
            Console.Write("> ");
            string response = Console.ReadLine();
            _responses.Add(response);
        }
        Console.WriteLine($"You listed {_responses.Count} items");
    }
}