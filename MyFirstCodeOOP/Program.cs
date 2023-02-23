using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyFirstCodeOOP
{
    internal class Program
    {
  
        static void Main(string[] args)
        {

            try
            {
                int year = 0;
                int month = 0;
                int day = 0;

                Console.WriteLine("Enter year: ");
                year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter month: ");
                month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter day: ");
                day = int.Parse(Console.ReadLine());

                var dateObject = new Date(year, month, day);

                Console.WriteLine(dateObject);

                Console.WriteLine("************************");
                Console.WriteLine("TESTING SALARY EMPLOYEE");
                Console.WriteLine("************************");

                Console.WriteLine("Enter your ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your First name: ");
                string firstname = (Console.ReadLine());

                Console.WriteLine("Enter your Last name: ");
                string lastname = (Console.ReadLine());

                Console.WriteLine("Are you Active?: ");
                Boolean isactive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your Salary: ");
                Decimal salary = Convert.ToDecimal(Console.ReadLine());

                Employee SalaryEmployee = new SalaryEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    LastName = lastname,  
                    BirthDay = new Date(2002, 10, 26),
                    HiringDate = new Date(2017, 7, 3),
                    IsActive = isactive,
                    Salary = salary,

                };

                Console.WriteLine(SalaryEmployee);

                Console.WriteLine("testing Comission Employee");
                 
                Console.WriteLine("Enter your ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your First name: ");
                firstname = (Console.ReadLine());

                Console.WriteLine("Enter your Last name: ");
                lastname = (Console.ReadLine());

                Console.WriteLine("Are you Active?: ");
                isactive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your comission percentage: ");
                float comissionPercentage = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your sales: ");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                Employee ComissionEmployee = new ComissionEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    LastName = lastname,
                    BirthDay = new Date(2002, 10, 26),
                    HiringDate = new Date(2017, 7, 3),
                    IsActive = isactive,
                    ComissionPercentage = comissionPercentage,
                    Sales= sales,

                };

                Console.WriteLine(ComissionEmployee);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
