//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 

namespace SumOfFiveNumbers
{
    using System;

    class SumOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("Please enter a five numbers separated by a space: ");
            string input = Console.ReadLine();
            input = input.Replace(',', '.');
            decimal number = 0.00m;
            string[] numbersAsStrings = input.Split(' ');
            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                number += decimal.Parse(numbersAsStrings[i]);
            }
            Console.WriteLine(number);

            Console.WriteLine("Please enter a five numbers separated by a space:");
            string secondinput = Console.ReadLine();
            string[] splitNums = secondinput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < splitNums.Length; i++)
            {
                sum = sum + double.Parse(splitNums[i]);
            }
            Console.WriteLine(sum);

            


        }
    }
}