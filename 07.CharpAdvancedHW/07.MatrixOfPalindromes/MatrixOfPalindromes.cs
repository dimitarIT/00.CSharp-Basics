//Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:

using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("Enter height = ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Enter width = ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine();

        string[,] matrix = new string[height, width];

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
            }
        }

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();

        }
    }
}