using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>(); 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry newEntry in _entries)
        {
            newEntry.Display();
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            if (parts.Length >= 2)
            {
                string firstName = parts[0];
                string lastName = parts[1];
            }
            else
            {
                {
                    Console.WriteLine($"Skipped invalid line: \"{line}\"");
                }
            }
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}