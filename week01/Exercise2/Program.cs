using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? \n  > ");
        string userInput = Console.ReadLine();          // Get user input
        float grade = float.Parse(userInput);             // Convert string to float

        string gradeLetter = "";
        string gradeSymbol = "";
        bool studentPassed = false;
        string addN = "";

        //--Calculate grade letter--
        if (grade >= 90)        //A
        {
            gradeLetter = "A";
            addN = "n";
        }
        else if (grade >= 80)   //B
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)   //C
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)   //D
        {
            gradeLetter = "D";
        }
        else if (grade < 60)    //F
        {
            gradeLetter = "F";
        }

        //--------------------------

        //--Calculate grade symbol--
        if (grade < 60)      // Grade F? No symbol.
        {
            gradeSymbol = "";
        }
        else
        {
            float modulo = grade % 10;      // Gets last number of grade
            Math.Floor(modulo);             // Round down

            if (modulo >= 7 && !(grade >= 90))  // add + symbol (ex. B+), unless A.
            {
                gradeSymbol = "+";
            }
            else if (modulo < 3)    //add - symbol (ex. B-)
            {
                gradeSymbol = "-";
            }
            else                    // no symbol (ex. B)
            {
                gradeSymbol = "";
            }
        }
        //--------------------------

        //--Did student pass?--
        if (grade >= 70)
        {
            studentPassed = true;
        }
        else
        {
            studentPassed = false;
        }
        //---------------------

        if (studentPassed)  // congratulate
        {
            Console.WriteLine($"Congratulations! You got a{addN} {gradeLetter}{gradeSymbol}!");
        }
        else                // Try again
        {
            Console.WriteLine($"You got a {gradeLetter}{gradeSymbol} \nTry again.");
        }
    }
}