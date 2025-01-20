using System;
using System.Globalization;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);

        DisplayResult(name, number, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userInput = Console.ReadLine();
        
        return userInput;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();

        int userNumber = int.Parse(userInput);
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        userNumber *= userNumber;
        
        return userNumber;
    }

    static void DisplayResult(string name, int number, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}