using System;

public class Resume
{
    public string _name;

    public List<Job> _jobList = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"\nName: {_name}");
        Console.WriteLine("Jobs:");

        foreach(Job j in _jobList)
        {
            j.DisplayJobDetails();
        }
        
        Console.WriteLine();
    }
}