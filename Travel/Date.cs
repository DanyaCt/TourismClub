using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Date
    {
        private int day, month, year;
        public Date(int day, int month, int year) 
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public string ShowDate()
        {
            string date;
            date = Convert.ToString(day) + "." + Convert.ToString(month) + "." + Convert.ToString(year);
            return date;
        }
    }
}
