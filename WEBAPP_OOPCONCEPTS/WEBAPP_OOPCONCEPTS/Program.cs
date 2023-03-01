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

                Employee SalaryEmployee = new SalaryEmployee()
                {
                    ID = 1,
                    FirstName = "Patricia",
                    LastName = "Alcantarez",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Salary = 1160000
                };

                Console.WriteLine(SalaryEmployee);


                Employee ComissionEmployee = new ComissionEmployee()
                {
                    ID = 1,
                    FirstName = "Patricia",
                    LastName = "Alcantarez",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    ComissionPercenteage = 5,
                    Sales = 20000
                };

                Console.WriteLine(ComissionEmployee);

            }
            catch (Exception message)
            {

                Console.WriteLine(message);
            }

        }
    }
}
