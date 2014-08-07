//Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        // Input
        Console.Write("Please enter hexadecimal integer number: ");
        string hexIntNumber = Console.ReadLine(); 

        // First Solution
        long decValue = Convert.ToInt64(hexIntNumber, 16);
        Console.WriteLine(decValue);

        long decWort = long.Parse(hexIntNumber, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(decWort);

        //Hex -> decimal:
        //Convert.ToInt64(hexValue, 16);
        //Decimal -> Hex
        //string.format("{0:x}", decValue);

        // Second solution with loop
        string[] hexNum = hexIntNumber.Split(new char[] {}, StringSplitOptions.None);

        foreach (string hex in hexNum)
        {
            long value = Convert.ToInt64(hex, 16);
            Console.WriteLine(value);
        }

    }
}
