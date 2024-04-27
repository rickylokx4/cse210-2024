using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber = 0;

        
        
        
        while (magicNumber != guessNumber)
        {
            Console.WriteLine("What is the magic number? ");
            guessNumber = int.Parse(Console.ReadLine());
            
            if (guessNumber < magicNumber)
        {
            Console.WriteLine("higher ");
        }
            else if (guessNumber > magicNumber)
        {
            Console.WriteLine("lower ");
        }
            else 
        {
            Console.WriteLine("You guess it! ");
        }
        }

    }
}