using System;

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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            /*try { 
            var dateObject = new Date(0, 0, 0);
            Console.WriteLine(dateObject);
            /*}catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
    }
}
