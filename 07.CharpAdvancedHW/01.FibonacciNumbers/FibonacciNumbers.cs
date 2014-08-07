//Define a method Fib(n) that calculates the nth Fibonacci number.

using System;
using System.Numerics;


class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Fibonacci Numbers: ");
        int n = int.Parse(Console.ReadLine());
        Fib(n);
    }

    static void Fib(int n) 
    {
        
        BigInteger firstNumber, secondNumber, result;
        firstNumber = 0;
        secondNumber = 1;

        if (n == 0)
        {
            Console.WriteLine("Fib(n): 1");
        }

        else if (n == 1 || n == 2)
        {
            Console.WriteLine("Fib(n): 1");
        }

        else
        {
            for (int i = 0; i < n; i++)
            {

                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
                if (n - 1 == i)
                {
                    Console.WriteLine("Fib(n): {0}", result);
                }

            }
            
        }

    }
}