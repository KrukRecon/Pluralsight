using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingEnumerations();
            UsingStruct();

            Console.ReadLine();
        }

        private static void UsingStruct()
        {
            Employee employee;
            employee.Name = "Bethany";
            employee.Wage = 1250;
            employee.Work();
        }

        private static void UsingEnumerations()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;
            int baseWage = 6000;

            CalculateWage(baseWage, employeeType, storeType);
        }

        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculateWage = 0;

            if (employeeType == EmployeeType.Manager)
            {
                calculateWage = baseWage * 3;
            }
            else
            {
                calculateWage = baseWage * 2;
            }

            if (storeType == StoreType.FullPieRestaurant)
            {
                calculateWage += 500;
            }

            Console.WriteLine($"The calculated wage is: {calculateWage}");
        }
    }

    struct Employee
    {
        public string Name;
        public int Wage;

        public void Work()
        {
            Console.WriteLine($"{Name} is now working");
        }
    }

    enum EmployeeType
    {
        Sales,//0
        Manager,//1
        Research,//2
        StoreManager,//3
    }
    enum StoreType
    {
        PieCorner = 10,
        Seating = 20,
        FullPieRestaurant = 100,
        Undefined = 99,
    }
}
 