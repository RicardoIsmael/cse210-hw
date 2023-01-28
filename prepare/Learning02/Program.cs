using System;

class Program
{
    static void Main(string[] args)
    {
      Job  job1=  new Job();
      job1._title = "Sofware Engineer";
      job1._company = "Microsoft";
      job1._year1 = 2014;
      job1._year2 = 2019;
      

      Job job2 = new Job();      
      job2._title = "Manager";
      job2._company = "Goggle";
      job2._year1 = 2019;
      job2._year2 = 2022;

      Job job3 = new Job();
      job3._title = "accounting";
      job3._company = "arcor";
      job3._year1 = 1234;
      job3._year2 = 2314;

      Resume resume1 = new Resume();
      resume1._name = "Renato Guemez";
      resume1._job.Add(job1);
      resume1._job.Add(job2);
      resume1._job.Add(job3);
      resume1.Display();
      

        
    }
}