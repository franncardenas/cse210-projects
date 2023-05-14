public class Entry
    {
        public string _promptEntry;
        public string _userEntry;
        public string _date;
        
        public void DisplayEntry()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_promptEntry}");
            Console.WriteLine($"{_userEntry}");
        }

    }