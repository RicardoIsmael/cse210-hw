using System;


class Program
{
    static void Main(string[] args)
    {
      Message();
      string userName = Name();
      int userAge =  Age();
      int sqrt = Sqrt(userAge);
    
       DisplayMessage(userName,sqrt);
    
    
    
    }
      static void Message()
      {
        Console.WriteLine("Welcome to the Programming Course");

      }
      static string Name()
      {
        Console.Write($"Please, enter your name: ");
        string nam = Console.ReadLine();

        return nam; 
      }
      static int Age()
      {
        Console.Write($"Please, enter your age:   ");
        int age = int.Parse(Console.ReadLine());

        return age;
        
      } 
      static int Sqrt ( int age)
      {
        int result = age *age;
        return result;
      }
      static void DisplayMessage(string nam, int result)
      {  
        Console.WriteLine($"your name is {nam} and the square of your age is {result} ");

      }

    
}