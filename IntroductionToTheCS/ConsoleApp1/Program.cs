using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string fullName = firstName + " " + lastName;
            string employeeIdentification = string.Concat(firstName, lastName);

            string empId = firstName.ToLower() + "-" + lastName.ToLower();
            string filePath = @"C:\x\d";

            int x = 5;
            int y = x;
            x += 5;

            Console.WriteLine(filePath);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
 