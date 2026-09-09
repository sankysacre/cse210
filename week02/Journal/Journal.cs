using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries { get; set; } = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nYour journal is currently empty.\n");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToCsvLine());
            }
        }
        Console.WriteLine($"\nJournal successfully saved to '{file}'.\n");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"\nError: The file '{file}' does not exist.\n");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            List<string> parts = ParseCsvLine(line);
            if (parts.Count >= 4)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                string mood = parts[3];

                _entries.Add(new Entry(date, prompt, response, mood));
            }
        }

        Console.WriteLine($"\nJournal successfully loaded from '{file}'.\n");
    }

    private List<string> ParseCsvLine(string line)
    {
        List<string> result = new List<string>();
        bool inQuotes = false;
        string currentField = "";

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];

            if (c == '"')
            {
                if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                {
                    currentField += '"';
                    i++;
                }
                else
                {
                    inQuotes = !inQuotes;
                }
            }
            else if (c == ',' && !inQuotes)
            {
                result.Add(currentField);
                currentField = "";
            }
            else
            {
                currentField += c;
            }
        }
        result.Add(currentField);
        return result;
    }
}