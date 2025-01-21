using System;
using System.Globalization;
using System.Runtime.ExceptionServices;


class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person._givenName = "john";
        person._familyName = "smith";
        person.ShowWesternName();
        person.ShowEasternName();
    }
}