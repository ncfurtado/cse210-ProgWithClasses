using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bonjour, tout le monde!!");

        Circle myCircle = new Circle(10);
        Console.WriteLine($"{myCircle.GetArea()}");

        Circle unitCircle = new Circle(1);
        Console.WriteLine($"{unitCircle.GetCircumference()}");
        Console.WriteLine($"{unitCircle.GetDiameter()}");
        
    }
}