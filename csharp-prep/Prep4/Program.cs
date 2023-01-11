using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a number, if you want  to finish enter 0.");
        //here I have initializate the variables;
         List<int> numbers = new List<int>();
         int total = 0;
         int sum = 0;
         double average = 0;
         int minus = 0;
        /* here I start the loops while, for obtain the numbers with I going to do 
          the operations      */
         while(true)
         {
          Console.Write("enter a number: ");
          string nu = Console.ReadLine();
          int num = int.Parse(nu);
          if(num == 0)
          {
            break;
          }
          numbers.Add(num);

         }
         /*with this foreach loop I going to obtain the numbers from  list 
         and  response the answer of the requirements */
         foreach(int n in numbers)
          {
            sum += n;
            total += 1;
          }
          /* It's  average variable */ 
          average = (double)sum/total;
          // here   is the loop that obtain the smallet positive number. 
           numbers.Min();
           foreach(var min in numbers)
           {
            if(min > 0)
            {
               minus = min;
            }
           }
           // it's the max number method.
          var largest = numbers.Max();
          Console.WriteLine($"the sum is {sum}");
         Console.WriteLine($" the average is {average}");
          Console.WriteLine($"the smallets positive number is {minus}");
          Console.WriteLine($"the largest number is {largest}");
          // It's the loop for sorted the numbers.
          Console.WriteLine("sorted list");
          numbers.Sort();
          foreach(int x in numbers)
          {
            Console.WriteLine(x);
          }

    }
}