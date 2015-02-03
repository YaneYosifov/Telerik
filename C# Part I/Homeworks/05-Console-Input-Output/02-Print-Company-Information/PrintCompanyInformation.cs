using System;
class PrintCompanyInformation
{
    static void Main()
    {
        // * A company has name, address, phone number, fax number, web site and manager. 
        //   The manager has first name, last name, age and a phone number.
        // * Write a program that reads the information about a company 
        //   and its manager and prints it back on the console.

        Console.Write("Company name: ");
        string company = Console.ReadLine();
        Console.Write("Company address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        string phone = Console.ReadLine();
        Console.Write("Fax number: ");
        int fax = int.Parse(Console.ReadLine());
        Console.Write("Web site: ");
        string site = Console.ReadLine();
        Console.Write("Manager first name: ");
        string fName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string lName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("\n" + company);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Tel. " + phone);
        Console.WriteLine("Fax: " + fax);
        Console.WriteLine("Web site: " + site);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})\n", fName, lName, age, managerPhone);
    }
}