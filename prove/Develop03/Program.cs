using System;

    class Program
    {
        
        static void Main()
        {
            Scripture scripture = new Scripture("2 Nephi ", 28, 30, "For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more; and from them that shall say, We have enough, from them shall be taken away even that which they have. ");
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "quit")
                    break;

                if (scripture.HideRandomWord() == false)
                {
                    break;
                }

                Console.Clear();
                scripture.GetDisplayText();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
