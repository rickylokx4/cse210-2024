using System;
class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        public void AddEntry(string _prompt, string _answer)
        {
            Entry entry = new Entry(_prompt, _answer);
            _entries.Add(entry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
            Console.WriteLine(entry);
            }
        }
        public void SaveFile(string _fileName)
        {
            using (StreamWriter writer = new StreamWriter(_fileName))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"Date: {entry._date}");
                    writer.WriteLine($"Prompt: {entry._prompt}");
                    writer.WriteLine($"Response: {entry._answer}\n");
                }
            }
        }

    public void LoadFile(string _fileName)
    {
        _entries.Clear();

        try
        {
            using (StreamReader reader = new StreamReader(_fileName))
        {
            string line;
            string currentPrompt = null;
            string currentResponse = null;
            DateTime currentDate = DateTime.MinValue;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Date: "))
                {
                    currentDate = DateTime.Parse(line.Substring("Date: ".Length));
                }
                else if (line.StartsWith("Prompt: "))
                {
                    currentPrompt = line.Substring("Prompt: ".Length);
                }
                else if (line.StartsWith("Response: "))
                {
                    currentResponse = line.Substring("Response: ".Length);
                    _entries.Add(new Entry(currentPrompt, currentResponse)
                    {
                        _date = currentDate,
                        _prompt = currentPrompt,
                        _answer = currentResponse
                    });
                }
            }
        }
        }
        catch (Exception ex)
        {
        Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
        }
    }
    }