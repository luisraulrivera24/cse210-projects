// Control + K + C will comment code
// Control + K + U will uncomment code

using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomNumber = new Random();
        // This won't count the number 100. Instead of 100,
        // I should have done 101.
        int number = randomNumber.Next(1,100);

        int guesses = 0;
        int guess;
        
        do
        {
            Console.Write("\nWhat is your guess? ");
            string numberGuess = Console.ReadLine();
            guess = int.Parse(numberGuess);

            if (guess < number)
            {
                Console.WriteLine("Higher");
                guesses += 1;
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
                guesses += 1;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                guesses += 1;
                Console.WriteLine($"You had a total of {guesses} guess(es).\n");
            }

        } while (number != guess);
    }
}