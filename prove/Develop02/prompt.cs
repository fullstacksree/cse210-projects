public class Prompt
{
    List<string> _prompts;// = new List<string>();

    public Prompt()
    {
        _prompts = new List<string>() 
        {
        "What will be my first thing to do on this day?",
        "What scripture keeps you lifted while reading?",
        "How can I seek the guidance of my Heavenly Father?"
        };
    }


    public void displayPrompt()
    {
        Random dom = new Random();
        int index = dom.Next(0, _prompts.Count());
        Console.WriteLine(String.Format("{0}", _prompts[index]));
    }
   
}