//Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class DateAfter10Years
{
    static void Main()
    {
        Byte age;
        Console.Write("Please enter your age: ");
        age = byte.Parse(Console.ReadLine());
        if (age < 120)
        {
            Console.WriteLine("After 10 years you'll be {0} years old!", age + 10);
        }

        else
        {
            Console.WriteLine("You are very old man!");
        }
        
    }
}
