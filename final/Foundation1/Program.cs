using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to multiply the table of 9?", "Frank Dustin", 320);
        video1.AddComment(new Comment("Jhon Valdir", "Thank you very much for teaching the table of 9, now I know how to multiply"));
        video1.AddComment(new Comment("Joa Felix", "Thank you very much, now my son knows the table of 9"));
        video1.AddComment(new Comment("Mateo Arcor", "What a good idea to teach the table of 9 with a song"));

        Video video2 = new Video("Singing with Cecilia", "Cecilia Cuadrado", 180);
        video2.AddComment(new Comment("Deli Rojas", "how beautiful you sing Ceciliaaa!"));
        video2.AddComment(new Comment("Abril Axis", "Your voice transmits me a lot of peace, keep on singing"));
        video2.AddComment(new Comment("Federico Calleger", "It is very beautiful what you convey!"));

        Video video3 = new Video("Incredible fight of two lions", "Victor Cecco", 420);
        video3.AddComment(new Comment("Matias Rolon", "It's amazing the animal world"));
        video3.AddComment(new Comment("Brian Aban", "I can't believe what can cause a lion to lose a fight in a gang"));
        video3.AddComment(new Comment("Nicolas Alvez", "I think the lion with less mane won, but as I am not an expert I don't know what others think"));
        

        List<Video> videosList = new List<Video>();
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            Console.WriteLine("Video:");
            video.ShowInfo();
            int cant = video.CountComments();
            Console.WriteLine($"There are {cant} comments");
            Console.WriteLine("Comentarios:");
            video.ShowComments();
            Console.WriteLine();
        }
    }
}