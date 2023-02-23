using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    internal abstract class Employee
    {
        #region Variables
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public Date BirthDay { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Methods
        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"------EMPLOYEE------\n\t" +
                   $"ID: {Id} \n\t" +
                   $"First name: {FirstName} \n\t" +
                   $"Last name: {LastName} \n\t" + 
                   $"Hiring Date: {HiringDate} \n\t" + 
                   $"Is active: {IsActive}";
        }
        #endregion
    }
}
