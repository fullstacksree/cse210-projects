using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        do {
            Console.WriteLine("\n Select one of the below choices:");
            Console.Write("1. Write 2. Display 3. Load 4. Save 5.Quit")
            int choice = int.Parse(Console.ReadLince());
            Journal myJournal = new Journal();
            Prompt myPrompts = new Prompt();
            switch(choice){
                entry 1:
                    myJournal.Write();
                    break;
                entry 2:
                    myJournal.Display();
                    break;
                entry 3:
                    myJournal.Load();
                    break;
                entry 4:
                    myJournal.Save();
                    break;
                entry 5:
                    myJournal.Quit()
            }
        }while(flag);
    }
}