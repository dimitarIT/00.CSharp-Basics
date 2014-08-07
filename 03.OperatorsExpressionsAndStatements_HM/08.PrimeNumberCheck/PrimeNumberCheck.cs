//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int number;

        Console.Write("Please enter integer: ");
        number = int.Parse(Console.ReadLine());
        if (number == 0 || number == 1)
        {
            Console.WriteLine("The number: " + number + " is not prime number");
        }
        else
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("The number: " + number + " is not prime number");
                    return;
                }
            }
            Console.WriteLine("The number: " + number + " is a prime number");
        }
    }
}