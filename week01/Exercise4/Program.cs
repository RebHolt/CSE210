using System;
using System.Transactions;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //--new variable parking--
        bool continueLoop = true;
        float newNum = 0;
        float total = 0;
        float currentLargest = 0;
        float average = 0;

        List<float> numbers = new List<float>();
        //------------------------

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (continueLoop)    // main loop
        {
            Console.Write("  > ");
            string userInput = Console.ReadLine();      // get input
            newNum = float.Parse(userInput);            // convert to float
            
            if (newNum != 0)
            {
                numbers.Add(newNum);
            }
            else    // exit mian loop
            {
                continueLoop = false;
            }
        }
        Console.WriteLine();    //spacing

        foreach (float num in numbers)  // compute total (sum) and find largest number
        {
            total += num;               //add num to sum (compute total)
            
            if (num > currentLargest)  // keep track of largest number
            {
                currentLargest = num;
            }
        }

        average = total / numbers.Count;

        Console.WriteLine(
            $"The sum is: {total}\n" +
            $"The average is: {average}\n" +
            $"The largest number is {currentLargest}\n"
        );
    }
}