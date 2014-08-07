//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. 

using System;

class PrintNumbers
{
    static void Main()
    {
        uint  inputNumber = uint.Parse(Console.ReadLine());

        for (uint i = 1; i <= inputNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}