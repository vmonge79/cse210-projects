using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Consultant";
        job1._company = "TALENTOH";
        job1._startYear = 2010;
        job1._endYear = 2022;


        Job job2 = new Job();
        job2._jobTitle = "Psychologyst";
        job2._company = "Entrepeneur";
        job2._startYear = 2007;
        job2._endYear = 2024;


        Resume resume1 = new Resume();
        resume1._name = "Viviana Monge";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}
