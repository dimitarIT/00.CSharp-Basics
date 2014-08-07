//Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality.

using System;

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            
            // input
            Console.Write("Please enter binary integer number: ");
            string inputBin = Console.ReadLine();

            // First solution
            long decimalForm = Convert.ToInt64(inputBin, 2);
            Console.WriteLine(decimalForm);

            // Second solution with loop
            string[] numbers = inputBin.Split(new char[] {}, StringSplitOptions.None);
            long dec = 0L;

            for (int i = 0; i < inputBin.Length; i++)
            {
                if (inputBin[inputBin.Length - i - 1] == '0')
                {
                    continue;
                }

                else
                {
                    dec += (int)Math.Pow(2, i);
                }
            }

            // output
            Console.WriteLine(dec);
        }
    }
}
