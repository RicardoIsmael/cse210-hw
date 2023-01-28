public class Resume
{
    public string _name;

    public List<Job> _job = new List<Job>();
    
    public void Display()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine(" I was working in: ");
        foreach (Job job in _job)
        {
            
            job.Display();
        }
    }
    
}