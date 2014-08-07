//You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even.

using System;

class OddAndEvenProduct
{
    static void Main()
    {
            
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        uint evenProducts = 1;
        uint oddProducts = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            uint products = uint.Parse(numbers[i]);

            if (i % 2 == 0)
            {
                evenProducts *= products;
            }

            else
            {
                oddProducts *= products;
            }

        }

        if (evenProducts == oddProducts)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", evenProducts);
        }

        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProducts);
            Console.WriteLine("even_product = {0}", evenProducts);
        }

    }
}
