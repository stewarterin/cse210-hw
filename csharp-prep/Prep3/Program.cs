using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        int guess = -1;

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 100);

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}