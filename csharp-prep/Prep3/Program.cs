using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Welcome to the Guess My Number game!");
        bool success = false;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int guesses = 0;
        while (success == false)
        {
            // Console.Write("What is the magic number?: ");
            // int magicNumber = int.Parse(Console.ReadLine());

            Console.Write("What is your guess?: ");
            int guessedNumber = int.Parse(Console.ReadLine());
            guesses ++;
            if (guessedNumber > magicNumber)
            {
                Console.WriteLine("Your guess is too high! Try lower");
            }
            else if (guessedNumber < magicNumber)
            {
                Console.WriteLine("Your guess is too low! Try a higher number.");
            }
            else 
            {
                Console.WriteLine($"Correct! The number was {magicNumber}");
                success = true;
            }
        

        }
        Console.Write($"Nice! You guessed {magicNumber} in {guesses} guesses!");
    }
}