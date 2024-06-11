using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Please input your grade: ");
        string stringNumberGrade = Console.ReadLine();
        string pass = ("You passed!");
        string fail = ("You failed");
        int numberGrade = int.Parse(stringNumberGrade);

        if (numberGrade >= 90)
        {
            Console.WriteLine($"Letter grade: A, {numberGrade}");
            Console.WriteLine(pass);
        }
        else if (numberGrade >= 80)
        {
            Console.WriteLine($"Letter grade: B, {numberGrade}");
            Console.WriteLine(pass);

        }
        else if (numberGrade >= 70)
        {
            Console.WriteLine($"Letter grade: C, {numberGrade}");
            Console.WriteLine(pass);

        }
        else if (numberGrade >= 60)
        {
            Console.WriteLine($"Letter grade: D {numberGrade}");
            Console.WriteLine(fail);

        }
        else if (numberGrade < 60)
        {
            Console.WriteLine($"Letter grade: F {numberGrade}");
            Console.WriteLine(fail);

        }
        else
        {
            Console.WriteLine($"Invalid input, please write a valid number.");
        }
    }
}