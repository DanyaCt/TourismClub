using System;

namespace Travel
{
    public class Сountry
    {
        private string countryname;
        protected Subject sub;
        private string name;
        public Сountry(string countryname, string name, string subject, string agency, int day, int month, int year)
        {
            this.countryname = countryname;
            this.name = name;
            sub = new Subject(subject, agency, day, month, year);
        }
        public string ShowTravel(int i)
        {
            string str = Convert.ToString(i + 1) + ". Ім’я: " + name + "\n" + "Країна подорожі: " + countryname + "\n" + "Вид подорожі: " +  
               sub.ShowSubject() + "\n" + "Обране агенство: " + sub.ShowAgency() + "\n" + "Обрана дата: " +  
               sub.ShowDate();
            return str;
        }
        public string ShowName(int i)
        {
            string str = Convert.ToString(i + 1) + ". Ім’я: " + name;
            return str;
        }
    }
}
