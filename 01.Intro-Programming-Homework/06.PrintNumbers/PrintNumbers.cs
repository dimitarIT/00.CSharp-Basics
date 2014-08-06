//Write a program to print the numbers 1, 101 and 1001, each at a separate line.

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the number: 1");
        ushort firstNumber = ushort.Parse(Console.ReadLine());
        Console.WriteLine("Number: {0}", firstNumber);
        Console.WriteLine()
            ;
        Console.WriteLine("Please enter the number: 101");
        ushort secondNumber = ushort.Parse(Console.ReadLine());
        Console.WriteLine("Number: {0}", secondNumber);
        Console.WriteLine();

        Console.WriteLine("Please enter the number: 1001");
        ushort thirdNumber = ushort.Parse(Console.ReadLine());
        Console.WriteLine("Number: {0}", thirdNumber);
    }
}
