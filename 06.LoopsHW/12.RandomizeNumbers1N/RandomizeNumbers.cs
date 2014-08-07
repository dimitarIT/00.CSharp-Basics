//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int inputNums = int.Parse(Console.ReadLine());

        Random ranNums = new Random();

        bool[] printed = new bool[inputNums + 1];
        int numForPrint;

        for (int i = 0; i < inputNums; i++)
        {
            numForPrint = ranNums.Next(1, inputNums + 1);

            if (!printed[numForPrint])
            {
                Console.Write(numForPrint + " ");
                printed[numForPrint] = true;
            }

            else
            {
                i--;
            }

        }
        Console.WriteLine();
    }
}
