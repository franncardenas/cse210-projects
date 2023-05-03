using System;

class Program
{
    static void Main(string[] args)
    {
        //initialize the first object
        Job job1 = new Job();
        //add values 
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //initialize the second object
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //initialize Resume object 
        Resume myResume = new Resume();
        myResume._name = "Franco Cardenas";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        //using behavior from Resume
        myResume.Display();
    }
}