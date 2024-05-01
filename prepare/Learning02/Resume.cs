using System;
public class Resume
{
    public string _names;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_names}");
        Console.WriteLine("Jobs:");
        
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }


}
