using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "HR Executive";
        job1._company = "Patra";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new job();
        job2._jobTitle = "Senior HR";
        job2._company ="HSBC";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Steve Martin";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        
    }
}