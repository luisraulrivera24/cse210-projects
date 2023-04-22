using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string grade = Console.ReadLine();
        int gradeOfIndividual = int.Parse(grade);

        string letterGrade = "unknown";

        if (gradeOfIndividual >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeOfIndividual >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeOfIndividual >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeOfIndividual >= 60)
        {
            letterGrade = "D";
        }
        else if (gradeOfIndividual < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}.");

        if (gradeOfIndividual >= 70)
        {
            Console.Write("You passed the class!");
        }
        else
        {
            Console.Write("You did not pass, but can get it next time!");
        }

    }
}