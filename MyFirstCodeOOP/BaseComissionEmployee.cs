using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    internal class BaseComissionEmployee : ComissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return ((Sales * (decimal)ConvertPerentage(ComissionPercentage)) + Base);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                    $"\n\tSalary Base:... {Base:C2}" +
                    //$"\n\t Sales... {Sales:C2}" +
                    $"\n\tValue to pay... {GetValueToPay():C2}";
        }
        #endregion
    }
}
