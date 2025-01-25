using System;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


class Program
{
    static void Main(string[] args)
    {
        List<string> original = ["1","2","3","4"];

        List<string> copy = original;

        foreach (string word in copy)
        {
            Console.WriteLine(word);
        }
        Console.WriteLine("\t----------");

        string toRemove = "3";
        copy.Remove(toRemove);
        copy.Remove("1");
        copy.Remove("2");
        copy.Remove("3");
        copy.Remove("4");

        Console.WriteLine(copy.Count);
    }
}

