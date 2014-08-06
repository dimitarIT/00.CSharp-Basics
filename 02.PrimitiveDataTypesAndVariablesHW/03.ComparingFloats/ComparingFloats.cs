//Write a program that safely compares floating-point numbers with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("This program will compare two floating - point numbers with a precision of 0.000001");
        double firstNumber, secondNumber;

        Console.Write("Please enter the first floating - point number: ");
        firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Please enter the second floating - point number: ");
        secondNumber = double.Parse(Console.ReadLine());

        bool compare = (Math.Abs(secondNumber - firstNumber) < 0.000001);
        bool border = (Math.Abs(secondNumber - firstNumber) >= 0.000001);
        decimal result = (decimal)(secondNumber - firstNumber);
        if (border)
        {
            Console.WriteLine("Border case. The difference 0.000001 == eps. We consider the numbers are different.");
        }
        else if (compare)
        {
            Console.WriteLine("The difference {0} < eps", result);
        }

        else if ((secondNumber - firstNumber) >= 0.000001 )
        {
            Console.WriteLine("The difference of {0} is too big (>ep)", result);
        }
    }
}
