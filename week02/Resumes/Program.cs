using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        Resume resume1 = new Resume();

        job1._company = "Co-op1";
        job1._jobTitle = "service clerk";
        job1._startYear = "2014";
        job1._endYear = "2018";   

        job2._company = "poop juice";
        job2._jobTitle = "mixy person";
        job2._startYear = "2024";
        job2._endYear = "2025";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}
        