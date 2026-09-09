using System;

public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }
    public string _mood { get; set; }

    public Entry(string date, string promptText, string entryText, string mood)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood Rating: {_mood}/5");
        Console.WriteLine($"Response: {_entryText}\n");
    }

    public string ToCsvLine()
    {
        string safePrompt = EscapeCsvField(_promptText);
        string safeEntry = EscapeCsvField(_entryText);
        return $"\"{_date}\",\"{safePrompt}\",\"{safeEntry}\",\"{_mood}\"";
    }

    private string EscapeCsvField(string field)
    {
        if (string.IsNullOrEmpty(field)) return "";
        return field.Replace("\"", "\"\"");
    }
}