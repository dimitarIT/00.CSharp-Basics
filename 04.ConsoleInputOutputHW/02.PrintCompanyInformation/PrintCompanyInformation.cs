//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string name = Console.ReadLine();
        Console.Write("Company address: ");
        string address = Console.ReadLine();
        Console.Write("Company phone number: ");
        string number = Console.ReadLine();
        Console.Write("Company fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Company web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string age = Console.ReadLine();
        Console.Write("Manager phone number: ");
        string phone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("COMPANY INFORMATION");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Company name: {0}", name);
        Console.WriteLine("Company address: {0}", address);
        Console.WriteLine("Company phone number: {0}", number);
        Console.WriteLine("Company fax number: {0}", faxNumber);
        Console.WriteLine("Company web site: {0}", webSite);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("MANAGER INFORMATION");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Manager first name: {0}", firstName);
        Console.WriteLine("Manager last name: {0}", lastName);
        Console.WriteLine("Manager age: {0}", age);
        Console.WriteLine("Manager phone number: {0}", phone);
    }
}