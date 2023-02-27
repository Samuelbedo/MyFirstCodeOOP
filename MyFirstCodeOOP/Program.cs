using MyFirstCodeOOP.Helper;
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

                #region Date
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
                #endregion

                #region Salary Employee
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

               //Console.WriteLine(SalaryEmployee);
                #endregion

                #region Comission Employee
                Console.WriteLine("**************************");
                Console.WriteLine("TESTING COMISSION EMPLOYEE");
                Console.WriteLine("**************************");

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

                //Console.WriteLine(ComissionEmployee);
                #endregion

                #region Contractor Employee
                Console.WriteLine("************************");
                Console.WriteLine("TESTING CONTRACTOR EMPLOYEE");
                Console.WriteLine("************************");

                Console.WriteLine("Enter your ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your First name: ");
                firstname = (Console.ReadLine());

                Console.WriteLine("Enter your Last name: ");
                lastname = (Console.ReadLine());

                Console.WriteLine("Are you Active?: ");
                isactive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your total hours: ");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your hour value: ");
                decimal hoursValue = Convert.ToDecimal(Console.ReadLine());

                Employee ContractorEmployee = new ContractorEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    LastName = lastname,
                    BirthDay = new Date(2002, 10, 26),
                    HiringDate = new Date(2017, 7, 3),
                    IsActive = isactive,
                    Hours = hours,
                    HourValue = hoursValue,

                };

                //Console.WriteLine(ContractorEmployee);
                #endregion

                #region Base Comission Employee
                Console.WriteLine("**************************");
                Console.WriteLine("TESTING BASE & COMISSION EMPLOYEE");
                Console.WriteLine("**************************");

                Console.WriteLine("Enter your ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your First name: ");
                firstname = (Console.ReadLine());

                Console.WriteLine("Enter your Last name: ");
                lastname = (Console.ReadLine());

                Console.WriteLine("Are you Active?: ");
                isactive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your comission percentage: ");
                comissionPercentage = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your sales: ");
                sales = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter your salary base: ");
                decimal salaryBase= Convert.ToDecimal(Console.ReadLine());

                Employee BaseComissionEmployee = new BaseComissionEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    LastName = lastname,
                    BirthDay = new Date(2002, 10, 26),
                    HiringDate = new Date(2017, 7, 3),
                    IsActive = isactive,
                    ComissionPercentage = comissionPercentage,
                    Sales = sales,  
                    Base = salaryBase

                };

                //Console.WriteLine(ComissionEmployee);
                #endregion

                EmployeeHelper employeeHelper = new EmployeeHelper(SalaryEmployee, ComissionEmployee, ContractorEmployee, BaseComissionEmployee);

                Console.WriteLine($"Total payroll.........{employeeHelper.GetPayrollFromActiveEmployees():C2}");
                
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
