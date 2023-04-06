using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (JournalEntry entry in _entries)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("");
            Console.WriteLine(entry);
            Console.WriteLine("=====================================================");
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                foreach (JournalEntry entry in _entries)
                {
                    writer.WriteLine($"{entry.GetPrompt()};{entry.GetEntryText()};{entry.GetDate()}");
                }
            }
            Console.WriteLine("Journal saved to file.");
        }
        catch (IOException)
        {
            Console.WriteLine("An error occurred while writing to the file.");
        }
    }

    public List<JournalEntry> LoadFromFile(string fileName)
{
    try
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 3)
                {
                    JournalEntry entry = new JournalEntry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Journal loaded from file!");
    }
    catch (IOException)
    {
        Console.WriteLine("An error occurred while reading the file.");
    }

    return _entries;
}

}
