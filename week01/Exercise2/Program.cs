using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int grades = int.Parse(grade);
        string letter= "";
        string sign = "";
        
        if (grades >=90)
        {
            letter= "A";
        }
        else if (grades >= 80)
        {
            letter= "B";
        }
        else if (grades >=70)
        {
            letter= "C";
        }
        else if (grades >=60)
        {
            letter= "D";
        }
        else
        {
            letter= "F";
        }

        int lastDigit = grades % 10;
   
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = " ";
        }

        if (grades >= 94 || grades < 60)
        {
            sign = " ";
        }

        Console.WriteLine($"Your grade is an {letter}{sign}");


        if (grades >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass the course. Keep on trying");
        }
    }
}
