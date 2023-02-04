using System;

class Menu
{
    private List<string> mainMenu, generateGoalMenu;

    public Menu()
    {
        mainMenu = new List<string>
        {
            "Menu Choices:",
            "   1. Generate New Goal",
            "   2. List Goals",
            "   3. Save Goals",
            "   4. Load Goals",
            "   5. Record Event",
            "   6. Quit"
        };
        generateGoalMenu = new List<string>
        {
            "The Goal types are:",
            "   1. Simple Goal",
            "   2. Eternal Goal",
            "   3. Checklist Goal"
        };
    }
    public void DisplayMainMenu()
    {
        foreach (string menuItem in mainMenu)
        {
            Console.WriteLine(menuItem);
        }
    }
    public void DisplayScore(int _fullScore)
    {
        Console.WriteLine(string.Format("You have {0} points \n", _fullScore));
    }
    public int Choice()
    {
        Console.Write("Select an option from the menu: ");
        return int.Parse(Console.ReadLine());
    }
    
    public int DislayGetGenerateNewGoalMenu()
    {
        foreach (string menuItem in generateGoalMenu)
        {
            Console.WriteLine(menuItem);
        }
        Console.Write("Select an option from the menu: ");
        return int.Parse(Console.ReadLine());
    }
}