//Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them

using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.WriteLine("The format for the dates is day.month.year (e.g. 31.12.2012)");

            Console.Write("Enter the first date: ");
            string input = Console.ReadLine();
            DateTime startDate = ParseDate(input);

            Console.Write("Enter the second date: ");
            input = Console.ReadLine();
            DateTime endDate = ParseDate(input);

            double resultDistance = (endDate - startDate).TotalDays;

            Console.WriteLine("Distance: {0} day/s/", resultDistance);
    }

    static DateTime ParseDate(string dateAsString)
    {
        DateTime date = DateTime.ParseExact(dateAsString, "d.M.yyyy", CultureInfo.InvariantCulture);
        return date;
    }

}