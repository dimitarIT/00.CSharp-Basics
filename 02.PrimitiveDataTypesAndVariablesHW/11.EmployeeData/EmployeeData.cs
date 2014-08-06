//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Dimitar";
        string lastName = "Keremedchiev";
        byte age = 25;
        char gendar = 'm';
        uint ID = 0123456789;
        uint uniqueNumber = 27561234;

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender (m or f): {0}", gendar);
        Console.WriteLine("•Personal ID number: {0}", ID);
        Console.WriteLine("Unique employee number: {0}", uniqueNumber);
    }
}
