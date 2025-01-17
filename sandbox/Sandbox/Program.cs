using System;
using System.Globalization;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        float num = float.Parse(input);

        float remainder = num % 10;
        Math.Floor(remainder);

        Console.WriteLine($"{num}\n{Math.Floor(remainder)}");
        

    }
}