public class Journal{

    // List of entries we have made
    //private static List<Entry> _entries = new List<Entry>();

    // File we are going to save the journal entries

    //private string _file;

    // Write a new entry into the journal.

    //public void Write()
    //{
        //Entry entry = new Entry();

        DateTime _date = DateTime.Now;
        
        // Give file name
        public string _name = "Sree";
        
        public List<Entry> _prompt = new List<Entry>();

        //entry._prompt = prompt.Random();
        //Console.Write($"{entry._prompt}");
        //_entries.Add(entry);
    //}
    public void DisplayPrompt()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_date);
        foreach(Entry entry in _prompt)
        {
            Console.WriteLine(entry._prompt);
            Console.WriteLine();
        }
    }
    //public void Save(){
        //Console.WriteLine("Save the filename as: ");
        //_file = Console.ReadLine();
        //using (StreamWriter outputfile = new StreamWriter(_file)){
           // foreach(Entry entry in _entries)
             //   outputfile.WriteLine($"{entry._date},{entry._prompt},{entry._answer}");
        //}
        //Console.WriteLine("Journal Successfully saved");
    //}
    //public void Load(){
      //  Console.WriteLine("Give the filename: ");
        //_file = Console.ReadLine();
        //_entries.Clear();
        //string[] lines = System.IO.File.ReadAllLines(_file);
        //foreach (string line in lines){
          //  Entry aux = new Entry();
            //string[] parts = line.Split(",");
            //aux._date = parts[0];
            //aux._prompt = parts[1];
            //aux._answer = parts[2];
            //_entries.Add(aux);
        //}
        //Console.WriteLine("Journal successfully loaded");
    //}
}