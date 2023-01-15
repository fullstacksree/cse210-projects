class Entry {

    // Prompt is the part of the entry
    string _prompt; 

    // User answer based on the prompt
    string _answer;

    // When the use make an entry with date

    string _date;

    void Display(){
        Console.WriteLine($"Date: {_date} - Prompt: { _prompt} { _answer}");
    }    
}