using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Daily Journal");
        string choice = "0";
        do{
            Console.WriteLine("\n Select one of the below choices:");
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Journal myJournal = new Journal();
            Prompt myPrompts = new Prompt();
            switch(choice){
                case "1":
                    myJournal.Write();
                    break;
                case "2":
                    myJournal.Display();
                    break;
                case "3":
                    myJournal.Load();
                    break;
                case "4":
                    myJournal.Save();
                    break;
                case "5":
                    break;
        }
        }while (choice != "5");
        {
            Console.WriteLine("Goodbye!!");
        } 
    }
}