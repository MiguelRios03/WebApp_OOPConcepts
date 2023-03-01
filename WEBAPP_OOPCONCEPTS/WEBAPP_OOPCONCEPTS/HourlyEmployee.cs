using System;
using System.Collections.Generic;
using System.Text;

namespace WEBAPP_OOPCONCEPTS
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return HourValue*(decimal)Hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Hours....................{Hours}\n" +
                $"HoursValue...............{HourValue:C2}\n" +
                $"Value To Pay.............{GetValueToPay():C2}\n";
        }

        #endregion

    }
}
