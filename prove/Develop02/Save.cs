using System;
using System.IO;

class Save
{
    public string _fileTxt = "journal.txt";
    
    public void DisplaySaving()
    // This method  ask for the file name and store the new string in the same file.txt.
    {
        Console.WriteLine("which is the name of the file:");
        string name = Console.ReadLine();
        if(name == _fileTxt)
        {
            File.Move( name, _fileTxt);
            Console.WriteLine("Saved !");
            Console.ReadKey();
        }
        else if(name != _fileTxt)
        {
            Console.WriteLine("Please, enter the right name of file.");
            Console.ReadKey();
                


        }
        
    }
    public void DisplayLoad()
    { // This method ask for the name of the file , if the name is incorrect
        // ask the user for the right name and load the file.txt in the screen
                Console.WriteLine("What is the file name, please.");
                string fileSee = Console.ReadLine();
                if(fileSee == _fileTxt)
                {
                Journal fil2 = new Journal();
                fil2.DisplayReading();
                }
                else
                {
                    Console.WriteLine("Please, enter the right name.");
                    Console.ReadKey();
                }
    }
}