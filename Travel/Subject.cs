using System;

namespace Travel
{
    public class Subject
    {
        private string subject;
        private Agency agency;
        public Subject(string subject, string agency, int day, int month, int year)
        {
            //subject = new List<string>() { "Природа", "Розваги", "Музеї", "Екскурсія"};
            this.subject = subject;
            this.agency = new Agency(agency, day, month, year);
        }
        public string ShowSubject()
        {
            return subject;
        }
        public string ShowAgency()
        {
            return agency.ShowAgency();
        }
        public string ShowDate()
        {
            return agency.ShowDate();
        }
    }
}