using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("John", 3, 16);

        Scripture s1 = new Scripture(r1, "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life.");

        while (s1.IsCompletelyHidden() == false)
        {
            Console.WriteLine("Welcome to the Scripture Memorizer Program!");
            Console.WriteLine("");
            Console.WriteLine(s1.GetText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                s1.HideWords();
            }

        }

            Console.Clear();

            // Console.WriteLine(s1.GetText());
            Environment.Exit(0);

    }
}