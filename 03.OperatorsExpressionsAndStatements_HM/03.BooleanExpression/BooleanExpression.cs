//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:

//n	    Divided by 7 and 5?
//3	    false
//0	    false
//5	    false
//7	    false
//35	true
//140	true

using System;

class BooleanExpression
{
    static void Main()
    {
        Console.Write("Please enter enteger: ");
        int number = int.Parse(Console.ReadLine());
        bool checkup = number % (7 * 5) == 0;

        if (checkup)
        {
            Console.WriteLine("The number {0} can be divided by 7 and 5 at the same time!", number);
        }
        else
        {
            Console.WriteLine("The number {0} cannot be divided by 7 and 5 at the same time!", number);
        }
    }
}