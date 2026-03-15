public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        PromptGenerator question = new PromptGenerator();
        _promptText = question.GetRandomPrompt();
        Console.WriteLine(_promptText);

        Console.Write("> ");
        _entryText = Console.ReadLine();
    }
}