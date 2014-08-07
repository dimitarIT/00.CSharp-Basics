//Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        // input
        Console.Write("Please enter integer number: ");
        long inputNum = long.Parse(Console.ReadLine());

        // solution
        string hexvalue = inputNum.ToString("X");
        
        // output
        Console.WriteLine(hexvalue);
    }
}