using System;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool correctNum = false;
        string userInput = null;
        bool continuePlaying = true;

        while (continuePlaying)     // main game loop
        {
            Random randomGenerator = new Random();
            int targetNum = randomGenerator.Next(1,100);    // generate number 1-100
            int numberOfGuesses = 0;

            while (!correctNum)     // While not correct number
            {
                Console.Write("What is your guess?\n  > ");
                userInput = Console.ReadLine();
                int guessNum = int.Parse(userInput);    // Convert to integer

                numberOfGuesses += 1;

                if (guessNum > targetNum)
                {
                    Console.WriteLine("Lower\n");
                }
                else if (guessNum < targetNum)
                {
                    Console.WriteLine("Higher\n");
                }
                else        // correct
                {
                    correctNum = true;
                    Console.WriteLine($"Correct! You guessed it in {numberOfGuesses} guesses!");
                }
            }

            //--Play again?--
            Console.Write("Play Again? (y/n) ");
            userInput = Console.ReadLine();

            if (userInput == "y")           // Restart
            {
                continuePlaying = true;
                correctNum = false;
            }
            else if (userInput == "n")      // Break Loops
            {
                continuePlaying = false;
            }
            //---------------
        }
    }
}