using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2023,7,21), 30, 4.8);

        Cycling cycling = new Cycling(new DateTime(2023,6,23),50,80);

        Swimming swimming = new Swimming(new DateTime(2023, 7,10), 45, 32);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            activity.GetDistance();
            Console.WriteLine(summary);
        }




    }
}