using System;
using System.Collections.Generic;
using Travel;

namespace TourismClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.InputEncoding = System.Text.Encoding.Default;
            bool flag = true;                                           //variable for the menu loop to work
            int choice;                                                 //variable to record what the user enters
            List<Сountry> ListOfTravels = new List<Сountry>();
            Console.WriteLine("Вітаємо в клубі любителів туризму!");
            menu();
            List<string> countries = new List<string>() { "Єгипет", "США", "Мексика", "Велика Британія", "ОАЕ" };
            List<string> subjects = new List<string>() { "Природа", "Розваги", "Музеї", "Екскурсія" };
            List<string> agencies = new List<string>() { "Поїхали з нами!", "Ukraine Travel", "TOURS&TICKETS", "TUI-турагентство" };
            while (flag)
            {
                try
                {
                    if (!Int32.TryParse(Console.ReadLine(), out choice))
                    {
                        throw new ArgumentException("Введено неправильні дані");
                    }
                    if (choice == 0)                                //condition for exiting the cycle
                    {
                        flag = false;
                    }
                    else if (choice == 1)                                //condition for displaying the list of countries
                    {
                        ShowCountries(countries);
                        Console.WriteLine("Виберіть наступну дію: ");
                    }
                    else if (choice == 2)                                //condition for displaying a list of agencies
                    {
                        ShowSubjects(subjects);
                        Console.WriteLine("Виберіть наступну дію: ");
                    }
                    else if (choice == 3)                                //condition for displaying a list of subjects
                    {
                        ShowAgencies(agencies);
                        Console.WriteLine("Виберіть наступну дію: ");
                    }
                    else if (choice == 4)                                //condition for planning a trip
                    {
                        Console.WriteLine("Якщо передумали планувати поїздку натисніть '0'");
                        Console.WriteLine("Оберіть країну для поїздки: ");
                        ShowCountries(countries);
                        int chooseCountry;
                        if (!Int32.TryParse(Console.ReadLine(), out chooseCountry))
                        {
                            throw new ArgumentException("Введено неправильні дані");
                        }
                        if (chooseCountry == 0)
                        {
                            Console.WriteLine("Виберіть наступну дію: ");
                            continue;
                        }
                        if (chooseCountry < 1 || chooseCountry > countries.Count)
                            throw new ArgumentException("Введено неправильні дані");
                        Console.WriteLine("Оберіть тематику поїздки: ");
                        ShowSubjects(subjects);
                        int chooseSubject;
                        if (!Int32.TryParse(Console.ReadLine(), out chooseSubject))
                        {
                            throw new ArgumentException("Введено неправильні дані");
                        }
                        if (chooseSubject == 0)
                        {
                            Console.WriteLine("Виберіть наступну дію: ");
                            continue;
                        }
                        if (chooseSubject < 1 || chooseSubject > subjects.Count)
                            throw new ArgumentException("Введено неправильні дані");
                        Console.WriteLine("Оберіть агентство");
                        ShowAgencies(agencies);
                        int chooseAgency;
                        if (!Int32.TryParse(Console.ReadLine(), out chooseAgency))
                        {
                            throw new ArgumentException("Введено неправильні дані");
                        }
                        if (chooseAgency == 0)
                        {
                            Console.WriteLine("Виберіть наступну дію: ");
                            continue;
                        }
                        if (chooseAgency < 1 || chooseAgency > agencies.Count)
                            throw new ArgumentException("Введено неправильні дані");
                        int day, month, year;
                        Console.WriteLine("Введіть дату поїздки:\nЧисло: ");
                        if (!Int32.TryParse(Console.ReadLine(), out day))
                        {
                            throw new ArgumentException("Введено неправильні дані");
                        }
                        if (day == 0)
                        {
                            Console.WriteLine("Виберіть наступну дію: ");
                            continue;
                        }
                        if (day < -1 || day > 31)
                            throw new ArgumentException("Обрано не правильний день");
                        Console.WriteLine("Місяць: ");
                        if (!Int32.TryParse(Console.ReadLine(), out month))
                        {
                            throw new ArgumentException("Введено неправильні дані");
                        }
                        if (month == 0)
                        {
                            Console.WriteLine("Виберіть наступну дію: ");
                            continue;
                        }
                        if (month < -1 || month > 12)
                            throw new ArgumentException("Обрано не правильний місяць");
                        Console.WriteLine("Рік: ");
                        if (!Int32.TryParse(Console.ReadLine(), out year))
                        {
                            throw new ArgumentException("Введено неправильні дані");
                        }
                        if (year == 0)
                        {
                            Console.WriteLine("Виберіть наступну дію: ");
                            continue;
                        }
                        if (year < 2021 || year > 2050)
                            throw new ArgumentException("Обрано не правильний рік");
                        if(year == 2021 && month <= 5 && day < 18)
                            throw new ArgumentException("Обрана дата застаріла!");
                        Console.WriteLine("Введіть своє Ім’я: ");
                        string name = Console.ReadLine();
                        if (name == "0")
                        {
                            Console.WriteLine("Виберіть наступну дію: ");
                            continue;
                        }
                        if (name == "")
                            throw new ArgumentException("Ви не вказали ім’я");
                        ListOfTravels.Add(new Сountry(countries[chooseCountry - 1], name, subjects[chooseSubject - 1], agencies[chooseAgency - 1], day, month, year));
                        Console.WriteLine("Подорож запланована!");
                        Console.WriteLine("Виберіть наступну дію: ");
                    }
                    else if (choice == 5)                                //condition for displaying the list of planned trips
                    {
                        ShowListOfTravels(ListOfTravels);
                        Console.WriteLine("Виберіть наступну дію: ");
                    }
                    else if (choice == 6)                                //condition for deleting the planned trip
                    {
                        if (ListOfTravels.Count != 0)
                        {
                            Console.WriteLine("Якщо передумали видаляти натисніть '0'");
                            Console.WriteLine("Оберіть поїздку для видалення: \n");
                            ShowListOfNames(ListOfTravels);
                            int deletetravel;
                            if (!Int32.TryParse(Console.ReadLine(), out deletetravel))
                            {
                                throw new ArgumentException("Введено неправильні дані");
                            }
                            if (deletetravel < -1 || deletetravel > ListOfTravels.Count)
                                throw new ArgumentException("Введено неправильні дані");
                            if (deletetravel != 0)
                            {
                                ListOfTravels.RemoveAt(deletetravel - 1);
                                Console.WriteLine("Подорож видалена!");
                            }

                        }
                        else 
                        {
                            Console.WriteLine("Жодної поїздки не заплановано!");
                        }
                        Console.WriteLine("Виберіть наступну дію: ");
                    }
                    else if (choice == 7)                                //condition for giving the country, agency, subject
                    {
                        Console.WriteLine("Якщо не бажаєте додавати щось, натисніть '0'");
                        Console.WriteLine("Введіть нову країну: ");
                        string newCountry = Console.ReadLine();
                        int temp;
                        if (!Int32.TryParse(newCountry, out temp))
                            temp = -1;
                        firstlettertoUpper(ref newCountry);
                        if (!countries.Contains(newCountry) && temp != 0 && newCountry != "")
                            countries.Add(newCountry);
                        Console.WriteLine("Введіть нову тематику: ");
                        string newsubject = Console.ReadLine();
                        if (!Int32.TryParse(newsubject, out temp))
                            temp = -1;
                        firstlettertoUpper(ref newsubject);
                        if (!subjects.Contains(newsubject) && temp != 0 && newCountry != "")
                            subjects.Add(newsubject);
                        Console.WriteLine("Введіть нове агентство: ");
                        string newagency = Console.ReadLine();
                        if (!Int32.TryParse(newagency, out temp))
                            temp = -1;
                        firstlettertoUpper(ref newagency);
                        if (!agencies.Contains(newagency) && temp != 0 && newCountry != "")
                            agencies.Add(newagency);
                        Console.WriteLine("Виберіть наступну дію: ");
                    }
                    else if (choice == 8)                                //condition for showing the menu
                    {
                        Console.Clear();
                        menu();
                        Console.WriteLine("Виберіть наступну дію: ");
                    }
                    else
                    {
                        Console.WriteLine("Введено неправильні дані");
                        Console.WriteLine("Виберіть наступну дію: ");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Виберіть наступну дію: ");
                }
            }
            Console.ReadKey();
        }
        static public void menu() 
        {
            Console.WriteLine("Виберіть дію:");
            Console.WriteLine("0 - вийти з програми");
            Console.WriteLine("1 - переглянути країни для відвідання");
            Console.WriteLine("2 - переглянути тематики поїздок");
            Console.WriteLine("3 - переглянути турагенції");
            Console.WriteLine("4 - запланувати поїздку");
            Console.WriteLine("5 - переглянути заплановані поїздки");
            Console.WriteLine("6 - видалити заплановану поїздку");
            Console.WriteLine("7 - додати країну, тематику, агентство до списку");
            Console.WriteLine("8 - показати це меню");
        }
        static public void ShowCountries(List<string> countries)
        {
            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + countries[i]);
            }
        }
        static public void ShowSubjects(List<string> subjects)
        {
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + subjects[i]);
            }
        }
        static public void ShowAgencies(List<string> agencies)
        {
            for (int i = 0; i < agencies.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + agencies[i]);
            }
        }
        static public void ShowListOfTravels(List<Сountry> ListOfTravels)
        {
            if (ListOfTravels.Count != 0)
            {
                for (int i = 0; i < ListOfTravels.Count; i++)
                {
                    Console.WriteLine(ListOfTravels[i].ShowTravel(i));
                }
            }
            else 
            {
                Console.WriteLine("Жодної поїздки не заплановано!");
            }
        }
        static public void ShowListOfNames(List<Сountry> ListOfTravels)
        {
            for (int i = 0; i < ListOfTravels.Count; i++)
            {
                Console.WriteLine(ListOfTravels[i].ShowName(i));
            }
        }
        static public void firstlettertoUpper(ref string str) {
            char[] arr = str.ToCharArray();
            string temp = arr[0].ToString().ToUpper();
            arr[0] = Convert.ToChar(temp);
            string str1 = new string(arr);
            str = str1;
        }
    }
}
