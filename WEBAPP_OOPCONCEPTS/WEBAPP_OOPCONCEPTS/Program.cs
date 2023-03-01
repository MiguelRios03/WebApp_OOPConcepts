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

                Console.WriteLine("\n------------- SALARY EMPLOYEEE -------------");

                Employee SalaryEmployee = new SalaryEmployee()
                {
                    ID = 100,
                    FirstName = "Patricia",
                    LastName = "Alcantarez",
                    BirthDate = new Date(day, month, year),
                    HiringDate = new Date(day, month, year),
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
                    BirthDate = new Date(day, month, year),
                    HiringDate = new Date(day, month, year),
                    IsActive = true,
                    ComissionPercenteage = 5,
                    Sales = 20000000
                };

                Console.WriteLine(ComissionEmployee);

                Console.WriteLine("\n---------- INFO HOURLY EMPLOYEEE ----------");

                Console.Write("\nPlease, type the ID: ");
                int id = Int32.Parse(Console.ReadLine());

                Console.Write("\nPlease, type the first name: ");
                String firstName = Console.ReadLine();

                Console.Write("\nPlease, type the last name: ");
                String lastName = Console.ReadLine();

                Console.Write("\nPlease, type the day of born: ");
                int dayBorn = Int32.Parse(Console.ReadLine());

                Console.Write("\nPlease, type the month of born: ");
                int monthBorn = Int32.Parse(Console.ReadLine());

                Console.Write("\nPlease, type the year of born: ");
                int yearBorn = Int32.Parse(Console.ReadLine());

                Console.Write("\nPlease, type the day of hiring: ");
                int dayHiring = Int32.Parse(Console.ReadLine());

                Console.Write("\nPlease, type the month of hiring: ");
                int monthHiring = Int32.Parse(Console.ReadLine());

                Console.Write("\nPlease, type the year of hiring: ");
                int yearHiring = Int32.Parse(Console.ReadLine());

                Console.Write("\nPlease, type if is an active employee (true/false): ");
                bool isActive = Boolean.Parse(Console.ReadLine());

                Console.Write("\nPlease, type the hours: ");
                float hours = float.Parse(Console.ReadLine());

                Console.Write("\nPlease, type value per hour: ");
                decimal hourValue = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("\n------------ HOURLY EMPLOYEEE ------------");

                Employee HourlyEmployee = new HourlyEmployee()
                {
                ID = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = new Date(dayBorn, monthBorn, yearBorn),
                HiringDate = new Date(dayHiring, monthHiring, yearHiring),
                IsActive = isActive,
                Hours = hours,
                HourValue = hourValue
                };

                Console.WriteLine(HourlyEmployee);

                Console.WriteLine("\n----------- BASE COMISSION EMPLOYEEE -----------");

                Employee BaseComissionEmployee = new BaseComissionEmployee()
                {
                    ID = 400,
                    FirstName = "Paco",
                    LastName = "Aristizabal",
                    BirthDate = new Date(day, month, year),
                    HiringDate = new Date(day, month, year),
                    IsActive = true,
                    ComissionPercenteage = 10,
                    Sales = 50000000,
                    Base = 5000000
                };

                Console.WriteLine(BaseComissionEmployee);

            }
            catch (Exception message)
            {

                Console.WriteLine(message);
            }

        }
    }
}
