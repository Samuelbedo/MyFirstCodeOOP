using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    internal class ContractorEmployee : Employee
    {
        #region Properties
        public int Hours { get; set; }
        public decimal HourValue { get; set; }
        #endregion

        public override decimal GetValueToPay()
        {
            return ((decimal)Hours * HourValue);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Total hours............... {Hours}\n\t" +
                   $"Hours Value............... {HourValue:C2}\n\t" +
                   $"Value to pay.............. {GetValueToPay():C2}";
        }
    }
}
