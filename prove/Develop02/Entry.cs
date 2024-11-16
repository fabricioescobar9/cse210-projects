public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();

        Console.WriteLine($"Date: {_date} — Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}