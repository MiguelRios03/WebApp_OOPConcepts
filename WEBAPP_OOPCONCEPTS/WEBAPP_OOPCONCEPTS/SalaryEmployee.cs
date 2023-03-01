using System;
using System.Collections.Generic;
using System.Text;

namespace WEBAPP_OOPCONCEPTS
{
    public class SalaryEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }

        #endregion 
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salary....{GetValueToPay():C2} \n";
        }   


    }
}
