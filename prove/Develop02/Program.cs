using System;
class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        
        Console.WriteLine("Welcome to Daily Journal");
        string choice = "0";
        
        do{
            Console.WriteLine("\n Select one of the below choices:");
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            Journal myJournal = new Journal();
            Prompt myPrompts = new Prompt();
            string _choice = Console.ReadLine();
            switch(choice){
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Enter 5 to Quit or Choose from the list");
                    break;
        }
        }while (flag);
        
    }
}