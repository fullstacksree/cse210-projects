using System;

class Program
{
    static void Main(string[] args)
    {
        bool flag = true;

        WholeGoals wholeGoals = new WholeGoals();
        int choice = 0;


        do{
            Menu menu = new Menu();
            menu.DisplayScore(wholeGoals.getFullScore());
            menu.DisplayMainMenu();
            choice = menu.DisplayGetMainMenu();
            switch (choice)
            {
                case 1:
                    int generateNewGoalSelection = menu.DislayGetGenerateNewGoalMenu();
                    Goal goal = null;
                    switch (generateNewGoalSelection)
                    {
                        case 1:
                            goal = new SimpleGoal();
                            goal.DisplayGetGoalTitle();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetFullScore();
                            break;
                    }
                    if (goal != null)
                    {
                        wholeGoals.addGoal(goal);
                    }
                    break;
                case 2:
                    wholeGoals.DisplayGoals();
                    break;
                case 3:
                    wholeGoals.SaveGoals();
                    break;
                case 4:
                    wholeGoals.LoadGoals();
                    break;
                case 5:
                    wholeGoals.RecordEvent();
                    break;
                case 6:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Enter {6} to quit");
                    break;
            }
            }while (flag);
        }
}