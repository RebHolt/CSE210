using System;
using System.Diagnostics;
using System.Net.Quic;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //-----Local Variable Parking Space-----
        bool writeMenu = true;
        //--------------------------------------

        Console.WriteLine("\n" +
            "Welcme to the Journal Program!\n" +
            "Please select one of the following choices:\n"
        );

        //-----Menu-----        
        while (writeMenu)
        {
            


            Console.WriteLine(
                "1. Write \n" +
                "2. Display \n" +
                "3. Load \n" +
                "4. Save \n" +
                "5. Quit"
            );

            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();

            if (userInput == "1")           // Write
            {}
            else if (userInput == "2")      // Display
            {}
            else if (userInput == "3")      // Load
            {}
            else if (userInput == "4")      // Save
            {}
            else if (userInput == "5")      // Quit
            {
                System.Environment.Exit(0);
            }
            else                            // Invalid, write menu again
            {
                Console.WriteLine("\n---Error: Invalid input---\n");
            }
        }
        //--------------
    }
}