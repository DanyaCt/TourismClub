using System;

namespace Travel
{
    //class for storing subject data
    public class Subject
    {
        private string subject;
        private Agency agency;
        //constructor with the name of the agency, the name of the topic, day, month and year for the trip
        public Subject(string subject, string agency, int day, int month, int year)
        {
            this.subject = subject;
            this.agency = new Agency(agency, day, month, year);
        }
        //method that returns the subject
        public string ShowSubject()
        {
            return subject;
        }
        //method that returns the agency
        public string ShowAgency()
        {
            return agency.ShowAgency();
        }
        //method that returns the date
        public string ShowDate()
        {
            return agency.ShowDate();
        }
    }
}