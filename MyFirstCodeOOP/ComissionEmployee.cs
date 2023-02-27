using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    internal class ComissionEmployee : Employee
    {
        #region Properties
        public float ComissionPercentage { get; set; }
        public decimal Sales { get; set; }
        #endregion

        #region Methods

 
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)(ConvertPerentage(ComissionPercentage));
        }

        public override string ToString()
        {
            return  $"{base.ToString()}"+ 
                    $"\n\tCommision Percentage... {ConvertPerentage(ComissionPercentage):P2}" +
                    $"\n\t Sales... {Sales:C2}"+
                    $"\n\tValue to pay... {GetValueToPay():C2}";
        }

        public float ConvertPerentage(float ComissionPercentage) { return ComissionPercentage /100; }

        #endregion
    }
}
