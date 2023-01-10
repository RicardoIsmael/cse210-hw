using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you like to play a guess number");
        Random gran = new Random();
        int n2 = gran.Next(1, 100);
        int count = 1;
        while (true)
        {
            Console.Write("choose a number:  ");
            string num = Console.ReadLine();
            int n1 = int.Parse(num);


            if (n1 < n2)
            {
                Console.WriteLine("the number it's Higuer");
            }
            else if (n1 > n2)
            {
                Console.WriteLine("the number it's Lower");
            }
            else
            {
                Console.WriteLine("you win");
                Console.WriteLine($"you have guessed after {count} intents. ");
                Console.Write("Do you like to play again (enter y/n): ");
                string op = Console.ReadLine();
                if (op == "y")
                {
                    n2 = gran.Next(1, 100);
                    count = 1;
                    continue;
                }
                else
                {
                    break;
                }

            }
            count += 1;
        }




    }
}
