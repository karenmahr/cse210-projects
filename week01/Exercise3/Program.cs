using System;

class Program
{
    static void Main(string[] args)
    {

        
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);
            int guess = -1;
            int guessCount = 0;

            while (guess!=magicNumber)
            {
                Console.Write("What is your guess? ");   
                guess = int.Parse(Console.ReadLine());
                guessCount ++;
                
                if (guess<magicNumber)
                {
                    Console.WriteLine("higher");
                }
                else if (guess>magicNumber)
                {
                    Console.WriteLine("lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                }
            }
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
    }
}
