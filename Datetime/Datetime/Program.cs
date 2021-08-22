using System;

namespace Datetime
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime datetime = new DateTime(1995, 5, 5);
            /*
            var Today = DateTime.Today;
            var TodayName = DateTime.Today.DayOfWeek;
            var Time = DateTime.Now;

            DateTime Tomorrow = GetTomorrow();

            int days = DateTime.DaysInMonth(2000, 2);
            int days1 = DateTime.DaysInMonth(2003, 1);
            */
            DateTime Now = DateTime.Now;


            Console.WriteLine("Write a date in this format yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out datetime))
            {
                Console.WriteLine(datetime);
                TimeSpan daysPassed = Now.Subtract(datetime);
                Console.WriteLine($"You are {daysPassed.Days} days old");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
