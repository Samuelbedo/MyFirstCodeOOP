using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    
    public class Date
    {
        #region Propierties
        public int _day;
        public int _month;
        public int _year;
        #endregion

        #region Constructor
        public Date(int year, int month, int day)
        {
            this._year = ValidateYear(year);
            this._month = ValidateMonth(month);
            this._day = ValidateDay(day, month);
        }

        private int ValidateYear(int year)
        {
            if(year >= 1)
            {
                return year;
            }
            throw new YearException("The year is not valid!");
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{_year:0000}/{_month:00}/{_day:00}";
        }

        private int ValidateDay(int day, int month)
        {
            if (month == 2)
            {
                if(day >= 1 && day <= 28)
                {
                    return day;
                }
                throw new Dayexception("The day is invalid!");
            }

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day >= 1 && day <= 31)
                {
                    return day;
                }
            }
            else
            {
                if (day >= 1 && day<= 30)
                {
                    return day;
                }
            }
            throw new Dayexception("The day is invalid!");
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12) 
            {
                return month;
            }

            throw new MonthExcepction("The month is invalid!");
        }
        #endregion
    }
}
