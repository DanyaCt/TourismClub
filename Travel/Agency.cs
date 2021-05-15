using System;

namespace Travel
{
    //class for storing agency data
    public class Agency
    {
        private string agency;
        private Date date;
        //constructor with the name of the agency, day, month and year for the trip
        public Agency(string agency, int day, int month, int year)
        {
            this.agency = agency;
            date = new Date(day, month, year);
        }
        //method that returns the agency
        public string ShowAgency()
        {
            return agency;
        }
        //method that returns the date
        public string ShowDate()
        {
            return date.ShowDate();
        }
    }
}
