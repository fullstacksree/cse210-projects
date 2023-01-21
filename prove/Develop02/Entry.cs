public class Entry {

    // Prompt is the part of the entry
    //public string _prompt; 

    // User answer based on the prompt
    //public string _answer;

    // When the use make an entry with date

    public string _date;

    
    public string _prompt;
    Prompt myPrompts = new Prompt();
    public string Prompt()
    {
        _prompt=(string.Format("{0} Prompt:{1}", _date, Prompt()));
        Console.WriteLine(_prompt);
        _prompt += " " + Console.ReadLine();
        return _prompt;
    }
    
}