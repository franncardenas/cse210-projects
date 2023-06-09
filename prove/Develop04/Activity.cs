public class Activity 
{
    //Attributes
    protected string _nameActivity;
    protected string _description;
    protected int _duration;

    //Constructors
    public Activity()
    {

    }

    //Behaviors
    public void ShowInitialMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_nameActivity}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session?: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void SpinnerAnimation(int duration)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|"); 

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        int j = 0;
        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(600);
            Console.Write("\b \b");
            i++;
            j++;
            if (i > 4)
            {
                i=0;
            }
        }
        Console.WriteLine("");
    }

    public void CountAnimation(int number)
    {   
        
        for (int i = number ;i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void StartPaused()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinnerAnimation(4);
    }
    public void ShowFinalMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well Done!!");
        SpinnerAnimation(4);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_nameActivity}");
        SpinnerAnimation(4);
        Console.WriteLine("");
    }

    public string RandomPrompt(List<string> prompt)
    {
        Random promptRandom = new Random();

        int index = promptRandom.Next(prompt.Count);
        return  prompt[index]; 
    }
}