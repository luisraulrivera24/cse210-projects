using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        // Here I create my numbers list
        List<int> numbersList = new List<int>();
        List<int> positiveNumbersList = new List<int>();

        int num = -1;
        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.");

        while (num != 0)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            num = int.Parse(number);
            if (num != 0)
            {
                numbersList.Add(num);

                if (num > 0)
                {
                    positiveNumbersList.Add(num);
                }
            }
        }

        int listSum = numbersList.Sum();
        double listAverage = numbersList.Average();
        int listMax = numbersList.Max();
        int listSmallestPositive = positiveNumbersList.Min();

        Console.WriteLine($"The sum is: {listSum}");
        Console.WriteLine($"The average is: {listAverage}");
        Console.WriteLine($"The largest number is: {listMax}");
        Console.WriteLine($"The smallest positive number is: {listSmallestPositive}\n");
    }
}