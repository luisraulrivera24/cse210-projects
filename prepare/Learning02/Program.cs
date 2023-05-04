using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "IBM";
        job1._jobTitle = "Data Engineer";
        job1._startYear = 2021;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Prudential";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2002;
        job2._endYear = 2022;

        Resume resume = new Resume();
        resume._name = "Luis Rivera";
        resume._jobsList.Add(job1);
        resume._jobsList.Add(job2);
        
        resume.JobNames();
        
    }
}