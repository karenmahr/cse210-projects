using System;
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator generator = new PromptGenerator();
        Journal journal = new Journal();
        bool running = true;

        while (running)
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
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);

                string answer = Console.ReadLine();
                journal.AddEntry(new Entry(prompt, answer));
            }
            
            else if (number == 2)
            {
                journal.DisplayAll();
            }
            else if (number == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile();
            }
            else if (number == 4)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.SaveToFile();
            }
            else
            {
                Console.WriteLine("Goodbye");
                running = false;
                break;
            }
        }
    }
}
