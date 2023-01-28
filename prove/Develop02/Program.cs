using System;
using System.IO;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // The menu it's shown directly  on the Main.
        while (true)
        {
            Console.WriteLine("Please, choos one option: ");
            Console.WriteLine("1.Write.");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Show");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What do you want to do: ");
            int op = int.Parse(Console.ReadLine());

            if(op < 1 || op > 5 )
            {
                Console.WriteLine("Please input a valid number.");
                Console.ReadKey();
            }

             else if (op == 1)
            {
                Journal fil = new Journal();
                fil.DisplayQues();

            }
            else if (op == 2)
            {
                
                Journal ff = new Journal();
                ff.DisplayReading();
                
            }
            else if (op == 3)
            {
                Save loaded = new Save();
                loaded.DisplayLoad();
               
            
                
                
            }
            else if (op == 4)
            {
                Save fileName = new Save();
                fileName.DisplaySaving();


            }
            else if (op == 5)
            {
                break;
            }


        }


    }
}




