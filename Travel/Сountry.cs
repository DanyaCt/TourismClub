using System;

namespace Travel
{
    //class for storing country data
    public class Сountry
    {
        private string countryname;
        private Subject sub;
        private string name;
        //constructor with the name of the country, the name of the agency, the name of the topic, day, month, year and name for the trip
        public Сountry(string countryname, string name, string subject, string agency, int day, int month, int year)
        {
            this.countryname = countryname;
            this.name = name;
            sub = new Subject(subject, agency, day, month, year);
        }
        //method that returns the country, agency, subject, date, month, and year
        public string ShowTravel(int i)
        {
            string str = Convert.ToString(i + 1) + ". Ім’я: " + name + "\n" + "Країна подорожі: " + countryname + "\n" + "Вид подорожі: " +  
               sub.ShowSubject() + "\n" + "Обране агентство: " + sub.ShowAgency() + "\n" + "Обрана дата: " +  
               sub.ShowDate();
            return str;
        }
        //method that returns the name
        public string ShowName(int i)
        {
            string str = Convert.ToString(i + 1) + ". Ім’я: " + name;
            return str;
        }
    }
}
