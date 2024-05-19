using System;

class Program
{
    static void Main(string[] args)
    {
        bool closeProgram = false;
        while (!closeProgram)
        {       
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Star breathing activity");
            Console.WriteLine("2. reflecting activity");
            Console.WriteLine("3. Star listing activity");
            Console.WriteLine("4. Exit Program");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();        

            switch(choice)
            {
                case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStaringMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                break;

                case "2":
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayStaringMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
                break;

                case "3":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStaringMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
                break;

                case "4":
                closeProgram = true;
                break;
            }

            
        }
    }
}