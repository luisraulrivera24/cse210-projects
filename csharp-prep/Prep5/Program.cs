using System;

class Program
{
    static void Main(string[] args)
    {
        static void MainFunction()
        {
            static void DisplayWelcome()
            {
                Console.WriteLine("\nWelcome to the program!");
            }

            DisplayWelcome();

            static string PromptUserName()
            {
                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();

                return name;
            }

            string userName = PromptUserName();

            static int PromptUserNumber()
            {
                Console.Write("Please enter your favorite number: ");
                string FavoriteNumber = Console.ReadLine();
                int FavNum = int.Parse(FavoriteNumber);

                return FavNum;
            }

            int favoriteNumber = PromptUserNumber();

            static int SquareNumber(int Number)
            {
                int NewNumber = (Number * Number);

                return NewNumber;
            }

            int newNumber = SquareNumber(favoriteNumber);

            static void DisplayResult(string name, int squaredNumber)
            {
                Console.WriteLine($"{name}, the square of your number is {squaredNumber}\n");

            }

            DisplayResult(userName, newNumber);
        }

        MainFunction();

    }
}