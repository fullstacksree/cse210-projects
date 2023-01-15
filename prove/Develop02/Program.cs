using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Daily Journal");

        bool = true;
        do {
            Console.WriteLine("\n Select one of the below choices:");
            Console.Write("1. Write 2. Display 3. Load 4. Save 5.Quit");
            int choice = int.Parse(Console.ReadLine());
            Journal myJournal = new Journal();
            Prompt myPrompts = new Prompt();
            switch(choice){
                case 1:
                    myJournal.Write();
                    break;
                case 2:
                    myJournal.Display();
                    break;
                case 3:
                    myJournal.Load();
                    break;
                case 4:
                    myJournal.Save();
                    break;
                case 5:
                    myJournal.Quit()
            }
        }
    }
}