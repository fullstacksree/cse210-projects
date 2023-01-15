public class Entry {

    // Prompt is the part of the entry
    public string _prompt; 

    // User answer based on the prompt
    public string _answer;

    // When the use make an entry with date

    public string _date;

    public void Display(){
        Console.WriteLine($"Date: {_date} - Prompt: { _prompt} { _answer}");
    }    
}