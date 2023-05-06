using System;

// This class does not need to be public because it is not being used in
// another file.

// reminder: C# syntax is lowercase for the first word then upper case for
// the rest (convention is different for attributes and methods of a class).
class Program
{
    static void Main(string[] args)
    {
        // member variables (attributes) start with underscore then
        // lowercase word, and then the rest is upper case
        Job job1 = new Job();
        job1._company = "Prudential";
        job1._jobTitle = "Data Engineer";
        job1._startYear = 2015;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "IBM";
        job2._jobTitle = "Project Manager";
        job2._startYear = 1998;
        job2._endYear = 2018;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._name = "John Adams";
        resume._jobList.Add(job1);
        resume._jobList.Add(job2);
        // Console.WriteLine(resume._jobList[0]._jobTitle);
        
        // methods (behaviors) are always camel case
        resume.DisplayResume();
    }
}