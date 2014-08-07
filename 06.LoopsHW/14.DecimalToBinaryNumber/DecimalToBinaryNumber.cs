//Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        // Input
        Console.Write("Please enter integer number: ");
        long inputNum = long.Parse(Console.ReadLine());

        // First Solution
        string binary = Convert.ToString(inputNum, 2);
        Console.WriteLine(binary);

        // Second solution with loop
        string binResult = string.Empty;

        while (inputNum >= 1)
        {
            binResult = (inputNum % 2) + binResult;
            inputNum = inputNum / 2;
        }

        // Output
        Console.WriteLine(binResult);
    }
}
