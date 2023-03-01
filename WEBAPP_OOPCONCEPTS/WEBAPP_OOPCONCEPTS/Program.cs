using Microsoft.VisualBasic;
using System;

namespace WEBAPP_OOPCONCEPTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("--------- FIRST DATE CLASS ---------\n");

                Console.WriteLine("Please, type your day: ");
                int day = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease, type your month: ");
                int month = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease, type your year: ");
                int year = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\n------------------------------------\n");

                Console.WriteLine("********* DATE *********\n");

                var dateObject = new Date(day, month, year);
                Console.WriteLine("Your date is " + dateObject);

                Console.WriteLine("\n************************\n");

                Console.WriteLine("\n------------- SALARY EMPLOYEEE -------------");

                Employee SalaryEmployee = new SalaryEmployee()
                {
                    ID = 100,
                    FirstName = "Patricia",
                    LastName = "Alcantarez",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Salary = 1160000
                };

                Console.WriteLine(SalaryEmployee);

                Console.WriteLine("\n----------- COMISSION EMPLOYEEE -----------");

                Employee ComissionEmployee = new ComissionEmployee()
                {
                    ID = 200,
                    FirstName = "Juan",
                    LastName = "Salazar",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    ComissionPercenteage = 5,
                    Sales = 20000000
                };

                Console.WriteLine(ComissionEmployee);

                Console.WriteLine("\n---------- INFO HOURLY EMPLOYEEE ----------");

                Console.WriteLine("\nPlease, type the ID: ");
                int id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease, type the first name: ");
                String firstName = Console.ReadLine();

                Console.WriteLine("\nPlease, type the last name: ");
                String lastName = Console.ReadLine();

                Console.WriteLine("\nPlease, type if is an active employee (true/false): ");
                bool isActive = Boolean.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease, type the hours: ");
                float hours = float.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease, type value per hour: ");
                decimal hourValue = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("\n------------ HOURLY EMPLOYEEE ------------");

                Employee HourlyEmployee = new HourlyEmployee()
                {
                ID = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObject,
                HiringDate = dateObject,
                IsActive = isActive,
                Hours = hours,
                HourValue = hourValue
                };

                Console.WriteLine(HourlyEmployee);

            }
            catch (Exception message)
            {

                Console.WriteLine(message);
            }

        }
    }
}
