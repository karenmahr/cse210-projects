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
            Console.WriteLine(_entries);
        }
    }
    public void SaveToFile()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
 //Writing Text Files in C# - load   
    public void LoadFromFile()
    {
        string fileName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
    }

}