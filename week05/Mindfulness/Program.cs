using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity b1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 30);
        ReflectingActivity r1 = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 40);
        ListingActivity l1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 50, 0);

        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu:");
            string userInput = Console.ReadLine();
            int option = int.Parse(userInput);

            if (option == 1)
            {
                b1.Run();
            }
            else if (option == 2)
            {
                r1.Run();
            }
            else if (option == 3)
            {
                l1.Run();
            }
            else if (option == 4)
            {
                Console.WriteLine("Goodbye");
                running = false;
                break;
            }
            else
            {
                Console.WriteLine("Please select a valid option");
            }
        }
    }
}