using System;
using System.Collections.Generic;
using System.Text;

namespace WEBAPP_OOPCONCEPTS
{
    public abstract class Employee
    {
        #region Properties

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        #endregion

        #region Methods

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"ID.......................{ID}\n" +
                $"FirstName................{FirstName}\n" +
                $"LastName.................{LastName}\n" +
                $"BirthDate................{BirthDate}\n" +
                $"HiringDate...............{HiringDate}\n" +
                $"Is Active?...............{IsActive}\n";
        }


        #endregion
    }
}
