//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. 

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please enter a: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Please enter b: ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.WriteLine();
        if (firstNumber < secondNumber)
        {
            Console.WriteLine(secondNumber + " " + firstNumber);
        }
        else 
        {
            Console.WriteLine(firstNumber + " " + secondNumber);
        }
    }
}