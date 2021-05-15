using System;

namespace Travel
{
    public class Agency
    {
        private string agency;
        private Date date;
        public Agency(string agency, int day, int month, int year)
        {
            this.agency = agency;
            date = new Date(day, month, year);
        }
        public string ShowAgency()
        {
            return agency;
        }
        public string ShowDate()
        {
            return date.ShowDate();
        }
    }
}
