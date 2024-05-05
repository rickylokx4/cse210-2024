using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        List<string> _prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What is your most important goal?",
                "What you need to do today to be a better person?",
                "Who is the most important person in your life?"
            };
        bool closeProgram = false;
        while (!closeProgram)
        {
            Console.WriteLine("\nWelcome to your Journal App:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");

            Console.Write("What would you like to do?: ");
            string choice = Console.ReadLine();

            
            if(choice == "1")
            {
                string prompt = PromptGenerator.GetRandomPrompt(_prompts);
                Console.WriteLine(prompt);
                string answer = Console.ReadLine();
                journal.AddEntry(prompt, answer);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();     
            }
                
            else if (choice == "3")
            {
                Console.Write("Enter a name for the file: ");
                string fileName = Console.ReadLine();
                journal.SaveFile(fileName);
                Console.WriteLine("File saved successfully.");
            }

            else if (choice == "4")
            {
                Console.Write("Enter the file name to load: ");
                string loadFileName = Console.ReadLine();
                journal.LoadFile(loadFileName);
                Console.WriteLine("File loaded successfully.");
            }

            else if (choice == "5")
            {
                closeProgram = true;
            }

            else
            {
                Console.WriteLine("Please choose an option from 1 to 5");
            }
        }
    }
}



