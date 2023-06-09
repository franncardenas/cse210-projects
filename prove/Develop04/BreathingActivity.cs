public class BreathingActivity : Activity
{
    //Constructor
    public BreathingActivity() : base()
    {   
        _nameActivity = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    //Behaviors
    public void StartBreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration-5);

        Console.WriteLine(" ");
        Console.Write("Brethe in...");
        CountAnimation(2);
        Console.WriteLine(" ");
        Console.Write("Now breathe out...");
        CountAnimation(4);
        Console.WriteLine(" ");
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(" ");
            Console.Write("Brethe in...");
            CountAnimation(4);
            Console.WriteLine(" ");
            Console.Write("Now breathe out...");
            CountAnimation(6);
            Console.WriteLine(" ");
        }
        
    }

}