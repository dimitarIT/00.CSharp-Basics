//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops

using System;

class MatrixOfNumbers
    {
        static void Main()
        {
            byte n;
            if (byte.TryParse(Console.ReadLine(), out n) && n >= 1 && n <= 20)
            {
            for (int row = 0; row < n; row++)
            {
                for (int col = row + 1; col <= n + row; col++)
                {
                    Console.Write("{0,3}", col);
                }

                Console.WriteLine();
            }

            }
        }
    }
