using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");        
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        if (number == 1)
        {
            Console.WriteLine ($"_prompts");
        }
        else if (number == 2)
        {
            Console.WriteLine ($"Display");
        }
        else if (number==3)
        {
            Console.WriteLine ("What is the filename? ");
        }
        else if (number==4)
        {

        }
        else
        {
            Environment.Exit(0);
        }

    }
}