public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public void GetRandomPrompt()
    {
        Random R = new Random(); 
		int someRandomNumber = R.Next(0, _prompts.Count());

		Console.WriteLine(_prompts.ElementAt(someRandomNumber));
    }
}