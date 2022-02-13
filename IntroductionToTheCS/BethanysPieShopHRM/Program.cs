using System;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(2000, 7, 10), EmployeeType.Manager, 26.97);
            Employee george = new Employee("George", "Smith", "george@snowball.be", new DateTime(2000, 7, 10), EmployeeType.Research, 18.97);
            Employee test = bethany;

            //test.firstName = "test";
            //test.lastName = "test";

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.RecieveWage();

            george.DisplayEmployeeDetails();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.RecieveWage();
        }
    }
}
