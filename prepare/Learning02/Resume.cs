public class Resume
{
    //member variables
    public string _name;

    public List<Job> _jobs = new List<Job>();
    


    //behaviors 
    public void Display()
    {

        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs)
        {
            //using behavior from Job
            job.DisplayJobDetails();
        }
    }

} 