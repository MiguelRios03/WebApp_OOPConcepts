using System;
using System.Collections.Generic;
using System.Text;

namespace WEBAPP_OOPCONCEPTS
{
    public class ComissionEmployee : Employee
    {
        #region Properties

        public double ComissionPercenteage { get; set; }

        public decimal Sales { get; set; }

        #endregion 



        public override decimal GetValueToPay()
        {
            return Sales * ((decimal)ComissionPercenteage/100);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Comission Percentage.......{ComissionPercenteage/100:P2}" +
                $"Sales.....{Sales:C2}" +
                $"Get Value to Pay.....{GetValueToPay():C2}";
        }   


    }
}
