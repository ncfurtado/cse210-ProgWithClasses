using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello Prep1 World!");
        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}