using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Malachi", "3", "10");
        Scripture scripture = new Scripture(scriptureReference, "Bring ye all the tithes into the storehouse, that there may be meat in mine house, and prove me now herewith, saith the Lord of hosts, if i will not open you the windows of heaven, and pour you out a blessing, that there shall not be room enough to receive it.");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        string userInput = "";

        while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.WriteLine();
            Console.ReadLine();
            scriptureMemorizer.removeWordsFromText();
        }
    }
}