class Menu
{
    public void DisplayMenu(int points)
    {   
        Console.WriteLine($"You have {points} points");
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Events");
        Console.WriteLine(" 6. Quit");
        Console.WriteLine("Select a choice from the menu: ");


    }
    public void DisplaySubMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goals");
        Console.WriteLine("2. Eternal Goals");
        Console.WriteLine("3. Checklist Goals");
        Console.WriteLine("Which type of goal would you like to create?: ");
    }
}