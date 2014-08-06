//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is “254”.

using System;

class VariabelnHexadecimalFormat
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number in hexadecimal format is {0}", number.ToString("X"));
    }
}