using System;

class Program
{
    static void Main(string[] args)
    {
        Reception reception = new Reception("Welcome from Mateo", "We will welcome Mateo, he is coming back from his internship in Spain and we want him to feel at home.", "31/07/2023", "21:00", new Address("38959 Yost Parks Apt. 102"), "hilpert.alessandra@hotmail.com");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Gather to think", "This meeting is to share with each other what kind of thoughts influence us when making decisions.", "08/10/2023", "16:00", new Address("Los 3 Alamos Park"), "Sunny");

        Lecture lecture = new Lecture("The economy that will save us", "We need a giant change in our economy in order to progress, but how do we start? This is what we will talk about in this lecture.", "11/08/2023","18:00", new Address("2412 Evangeline Center Suite 046"), "Javier Milei", 550);

        List<Event> events = new List<Event>();
        events.Add(reception);
        events.Add(outdoorGathering);
        events.Add(lecture);


        foreach (Event e in events)
        {
            Console.WriteLine("Standard details:");
            e.StandarDetails();
            Console.WriteLine("");
            Console.WriteLine("Full details:");
            e.FullDetails();
            Console.WriteLine("");
            Console.WriteLine("Brief description:");
            e.ShortDetails();
            Console.WriteLine("");
        }
    }
}