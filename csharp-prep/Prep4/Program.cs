using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int totalValue = 0;
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0){
            numbers.Add(number);
            totalValue += number;
            }
        }

        numbers.Sort();
        Console.WriteLine("Here's your list of numbers");
        foreach (int item in numbers)
            {Console.WriteLine(item);}
        Console.WriteLine($"You list has {numbers.Count} numbers.");
        Console.WriteLine($"The sum is {totalValue}.");
        float averageValue = totalValue / numbers.Count();
        Console.WriteLine($"The average is {averageValue}"); 
        Console.WriteLine($"The smallest number is {numbers[0]}."); 
        numbers.Reverse();
        Console.WriteLine($"The largest number is {numbers[0]}."); 

    }
}