public class Prompt
{
    List<string> _prompt;// = new List<string>();

    public Prompt()
    {
        _prompt = new List<string> 
        {
        "What will be my first thing to do on this day?",
        "What scripture keeps you lifted while reading?",
        "How can I seek the guidance of my Heavenly Father?"
        };
    }


    public void displayPrompt()
    {
        Random index = new Random();
        int index = AppDomain.Next(0, _prompts.count())
        Console.WriteLine(String.Format("{0}", _prompts[index]"))
    }
   
}