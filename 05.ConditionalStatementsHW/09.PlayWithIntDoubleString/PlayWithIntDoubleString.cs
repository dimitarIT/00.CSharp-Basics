//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 

using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\r\n1 --> int\r\n2 --> double\r\n3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter integer: ");
                float inputNumber = float.Parse(Console.ReadLine());
                Console.WriteLine(inputNumber + 1f);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputDouble + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine(inputString + "*");
                break;
            default:
                Console.WriteLine("Not correct choice");
                break;
        }
    }
}