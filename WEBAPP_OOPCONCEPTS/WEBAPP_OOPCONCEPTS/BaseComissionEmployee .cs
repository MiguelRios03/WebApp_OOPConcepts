using System;
using System.Collections.Generic;
using System.Text;

namespace WEBAPP_OOPCONCEPTS
{
    public class BaseComissionEmployee : ComissionEmployee
    {
        #region Properties

        public decimal Base { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {

            return $"{base.ToString()}" +
                $"Base....................{Base:C2}\n" +
                $"Total...................{GetValueToPay():C2} \n";
        }

        #endregion
    }
}
