using System;

public class Job
{
    public string _company ;
    public string _title ;
    public int _year1; 
    public int _year2;

    public void Display() /* METHOD FOR SHOW THE VARIABLES*/
    {
        Console.WriteLine($"{_title}-({_company})-{_year1}--{_year2}");
    }
}
