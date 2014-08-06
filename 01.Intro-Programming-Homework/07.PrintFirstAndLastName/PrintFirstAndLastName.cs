//Create console application that prints your first and last name, each at a separate line.

using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        string firstName, secondName;

        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();
        Console.WriteLine("Your first name is: {0}", firstName);
        Console.WriteLine();

        Console.Write("Please enter your last name: ");
        secondName = Console.ReadLine();
        Console.WriteLine("Your last name is: {0}", secondName);
    }
}
