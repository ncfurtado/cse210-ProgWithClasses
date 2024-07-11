using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        int points = 100;
        Menu myMenu = new Menu();
        myMenu.DisplayMenu(points);
    }
}