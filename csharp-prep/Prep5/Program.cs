using System;

class Program
{
    
    static void DisplayWelcome()
    {
        ///<summary> Displays a welcome message.</summary>
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {  
        /// Asks for and returns the user's name (as a string)  
        Console.Write("What's your name? ");
        string name = Console.ReadLine();
        return name;
    }
    
    static int PromptUserNumber()
    {
        ///Asks for and returns the user's favorite number (as an integer)
        Console.Write("What's your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static double SquareNumber(int number)
    {
        /// Accepts an integer as a parameter and returns that number squared (as an integer)
        double numberSquared = number * number;
        return numberSquared;
    }
    static void DisplayResult(string name, double squaredNumber)
    {
        /// Accepts the user's name and the squared number and displays them.
        Console.WriteLine($"Oh, so your name is {name}! What an awesome name!");
        Console.WriteLine($"Your favorite number squared is {squaredNumber}!");
    }

    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        double squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
        
    }
}