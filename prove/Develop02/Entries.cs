using System;
using System.IO;

class Journal:Save // the class Journal inherits Save attribute.
{

    public void DisplayQues() //This method return the question for user.
    {
        List<string> question = new List<string>()
        {
            "How are you, on this beautiful day?",
            "who needs your help today?",
            "which is your favorite place to rest ?",
            "Which  scripture did you read today?",
            "How did you see the hand of the Lord in your life today?",
            "what things do you need to learn through this experience?",
            "Hello, tell about Jesus christ.",
            "Why are you angry or sad?"

        };
        Random Que = new Random();
        int n1 = Que.Next(1, 8);
        Console.WriteLine($"{question[n1]}");
        string s1= Console.ReadLine();
        

        //here is writing the question and answer .
       using (StreamWriter sw = new StreamWriter(_fileTxt,true))
        {
            DateTime tiempo = DateTime.Now;
            string today = tiempo.ToShortDateString();
            
            sw.WriteLine($"{today}--prompt: {question[n1]}");
            sw.WriteLine($"{s1}");
            sw.Close();
        }
    }
    public void DisplayReading() // This method reading all the entries 
    {
        using (StreamReader leer = new StreamReader(_fileTxt))
        {
            while (!leer.EndOfStream)
            {
                string a = leer.ReadLine();
                Console.WriteLine(a);
            }
        }
        object value = Console.ReadKey();

    }

}

