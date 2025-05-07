using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");   

        List<int> numberList = new List<int>();
        int number; 

        do 
        {
            Console.Write("Enter a number: "); 
            string numbers = Console.ReadLine();
            number = int.Parse(numbers);  

            if (number != 0)
            {
                numberList.Add(number);
            }
        } while (number != 0) ;

            int sum =numberList.Sum();
            double average = numberList.Average();
            int max =numberList.Max();
            int min = numberList.Where(n => n > 0).Min();
            numberList.Sort();
            
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
            Console.WriteLine($"The smallest positive number is: {min}");
            Console.WriteLine($"The sorted list is: ");
            foreach (int element in numberList)
            {
                Console.WriteLine(element);
            }
    }
}
