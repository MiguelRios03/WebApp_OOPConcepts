using System;
using System.Collections.Generic;
using System.Text;

namespace WEBAPP_OOPCONCEPTS
{
    public class Date
    {
        #region Fields
        private int _year;
        private int _month;
        private int _day;
        #endregion

        #region Methods

        public Date(int day,int month, int year) //Constructor
        {
            _day = CheckDay(day, month, year);
            _month = CheckMonth(month);
            _year = CheckYear(year);
            
        }

        private int CheckDay(int day, int month, int year)
        {
            int[] DaysxMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //Month's array with position as number of days
            if (month >=1 && month <=12)
            {
                if (month == 2 && day == 29 && IsLeapYear(year))
                {
                    return day;
                }

                if (day >= 1 && day <= DaysxMonth[month])
                {
                    return day;
                }

                throw new DayException("The day isn't valid");
            }
            throw new MonthException("The month isn't valid");
        }

        private bool IsLeapYear(int year)
        {

                return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
           
        }
        private int CheckMonth(int month)
        {

                if(month <=12 && month>=1)
                {
                    return month;
                }
            
                throw new MonthException("The month isn't valid");

            
        }
        private int CheckYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            throw new YearException("The year isn't valid");
        }

        public override string ToString()
        {
            return String.Format("{0:00}/{1:00}/{2:0000}", _day,_month,_year);
        }

        #endregion
    }
}
