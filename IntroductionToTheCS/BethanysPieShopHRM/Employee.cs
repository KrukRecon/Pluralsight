using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string email;
        private DateTime birthDay;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private EmployeeType employeeType;

        public string FirstName 
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public Employee() { }
        public Employee(string firstName, string lastName, string email, DateTime birthDay, EmployeeType employeeType, double hourlyRate)
        {
            FirstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDay = birthDay;
            this.employeeType = employeeType;
            this.hourlyRate = hourlyRate;
        }

        public void PerformWork()
        {
            numberOfHoursWorked++;

            Console.WriteLine($"{firstName} {lastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{firstName} {lastName} has stoped working!");
        }

        public double RecieveWage()
        {
            wage = numberOfHoursWorked * hourlyRate;

            Console.WriteLine($"The wage for {numberOfHoursWorked} hours of work is {wage}.");
            numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {firstName},\nLast name: {lastName},\nEmail: {email},\nBirthday: {birthDay.ToShortDateString()},\nEmployee type: {employeeType},\n");
        }
    }
}
