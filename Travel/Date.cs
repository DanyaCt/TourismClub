using System;

namespace Travel
{
    //class that contains information about the date of the trip
    class Date
    {
        private int day, month, year;
        //constructor with day, month and year for the trip
        public Date(int day, int month, int year) 
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        //method that returns the date
        public string ShowDate()
        {
            string date;
            date = Convert.ToString(day) + "." + Convert.ToString(month) + "." + Convert.ToString(year);
            return date;
        }
    }
}
