using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int addedNumber = -1;
        while (addedNumber != 0)
        {
        Console.Write("Enter a list of numbers, type 0 when finished: ");
            
        string userinput = Console.ReadLine();
        addedNumber = int.Parse(userinput);
            
        
        if (addedNumber != 0)
        {
            numbers.Add(addedNumber);
        }
        }

    
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"the sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"the average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}