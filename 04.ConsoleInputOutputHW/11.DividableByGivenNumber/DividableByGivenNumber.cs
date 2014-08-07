//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. 

using System;

class DividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("This program reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0!");
        Console.WriteLine();
        Console.Write("Please enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        int count = 0;
        Console.Write("Between first number and second number, exist: ");
        for (int p = firstNum; p <= secondNum; p++)
        {
            
            if (p % 5 == 0)
            {
                Console.Write("{0} ", p);
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("There is {0} numbers dividable by 5!", count);
    }
}