//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 

using System;

class PrintNumbers1ToN
{
    static void Main()
    {
        uint input = uint.Parse(Console.ReadLine());

        for (uint i = 0; i <= input; i++)
        {
            if (i % 3 == 0)
            {
                continue;
             
            }
            else if (i % 7 == 0)
            {
                continue;
            }

            Console.Write(i + " ");
        }
    }
}