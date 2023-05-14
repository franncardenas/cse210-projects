
public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public string _fileName;

        public void Display()
        {

        foreach (Entry entry in _entries)
        {
            //using behavior from Entry
            entry.DisplayEntry();
        }
        }
        public void SaveToFile()
        {
        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            // writer.WriteLine("Date, Prompt, journal");

            // Escribir cada objeto Entry como una fila en el archivo CSV
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date};{entry._promptEntry};{entry._userEntry}");
            }
        }
        }
        public List<Entry> ReadFile()
        {

            List<Entry> _entriesfile = new List<Entry>();
            string [] lines = System.IO.File.ReadAllLines(_fileName);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split(";");
                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._promptEntry = parts[1];
                newEntry._userEntry = parts[2];

                _entriesfile.Add(newEntry);

            }
                
            return _entriesfile;
        }
    }