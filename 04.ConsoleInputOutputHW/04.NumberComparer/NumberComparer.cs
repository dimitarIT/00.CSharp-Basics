//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. 

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please enter two number");
        double firstNumber, secondNumber;

        Console.Write("First number: ");
        firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("First number is greater than Second number!");
        }
        if (firstNumber == secondNumber)
        {
            Console.WriteLine("First and Second number are equal!");
        }
        else
        {
            Console.WriteLine("Second number is greater than First number!");
        }
    }
}