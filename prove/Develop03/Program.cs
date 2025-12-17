//To show creativity and exceed the core requirements, I added an option that allows
//the user to restart the program after the scripture is entirely hidden. The user
//can select "1" to restart or "2" to quit. 

using System;

class Program
{
    static void Main(string[] args)
    {
        int restart = 1;

            while (restart == 1)
            {
                Reference r1 = new Reference("John", 3, 16);

                Scripture s1 = new Scripture(r1, "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life.");

                while (s1.IsCompletelyHidden() == false)
                {
                    Console.WriteLine("Welcome to the Scripture Memorizer Program!");
                    Console.WriteLine("───────────────────────────────");
                    Console.WriteLine(s1.GetText());
                    Console.WriteLine("───────────────────────────────");
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");

                    string userInput = Console.ReadLine();
                    if (userInput == "quit")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        s1.HideWords();
                        Console.Clear();
                    }
                }

                Console.WriteLine("The entire scripture is now hidden.");
                Console.WriteLine("Would you like to start again?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                
                restart = int.Parse(Console.ReadLine());
                Console.Clear();
            }
        
    }
}