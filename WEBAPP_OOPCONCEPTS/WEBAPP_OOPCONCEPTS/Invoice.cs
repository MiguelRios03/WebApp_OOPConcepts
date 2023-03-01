using System;
using System.Collections.Generic;
using System.Text;

namespace WEBAPP_OOPCONCEPTS
{
    public class Invoice :IPay  
    {
        #region Properties
        public int ID { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        #endregion
        #region Methods
        public decimal GetValueToPay()
        {
            return (decimal)Quantity * Price;
        }
        public override string ToString()
        {
            return $"\nID: {ID} - Description: {Description}" +
                $"\nQuantity...........{Quantity}" +
                $"\nPrice..............{Price:C2}" +
                $"\nTotal Invoice......{GetValueToPay():C2}";
        }
        #endregion
    }
}
