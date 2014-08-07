using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Fibonacci Numbers: ");
        int loops = int.Parse(Console.ReadLine());

        BigInteger firstNumber, secondNumber, result;
        firstNumber = 0;
        secondNumber = 1;

        Console.Write("Fibonacci Numbers: 0 1 ");

        for (int i = 1; i < loops; i++)
        {
            
            result = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = result;
            Console.Write(result + " ");
        }

        Console.WriteLine( );

    }
}