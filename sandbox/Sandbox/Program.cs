using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("This language is compiled! It will take much longer to test code compared to Python.");
        int x = 10;
        Console.WriteLine("C# is a strongly typed language, you must give a type to each variable and it NEVER changes.");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(x+ i);
        }
    }
}