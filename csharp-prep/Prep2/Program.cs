using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter your number calification:  ");
        string numberText = Console.ReadLine();
        int number = int.Parse(numberText);
        string letter = "g";
        string sign = "+";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number <= 59)
        {
            letter = "F";
        }

        if(number%10 >=7 && !(letter =="A" || letter=="F") )
        {
            sign = "+";
        }
        else if (number%10 < 3 && !( letter =="F"))
        {
            sign = "-";
        }
        else
        {
            sign = " ";
        }

    
    
    
        if(number >= 70)
        {
            Console.WriteLine($"you have obteined {letter}{sign}. congratulations You have passed the course.");
        }
        else
        {
            Console.WriteLine($"Your note is {letter}{sign}. Oh sorry You don't  pass the course");
        }

    }
}