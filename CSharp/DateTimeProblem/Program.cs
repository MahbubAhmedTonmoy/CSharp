using System;

namespace DateTimeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter date");
            var year = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var date = int.Parse(Console.ReadLine());
            DateTime createdate = new DateTime(year, month, date);
            calculateDate(createdate, 0, 0, 13, 2, true, false);
        }

        static void calculateDate(DateTime inputDate, int month, int day, int monthsAfter, int daysAfter, bool endOfMonth, bool shouldBeWeekday)
        {
            DateTime newdate = inputDate;
            if(month > 0)
            {
                newdate = inputDate.AddMonths(month);
            }
            if(day > 0)
            {
                newdate = inputDate.AddDays(day);
            }
            if(monthsAfter > 0 && daysAfter > 0)
            {
                var hour = (double)(monthsAfter * 730) + (daysAfter * 24);
                newdate = inputDate.AddHours(hour);
                if (shouldBeWeekday)
                {
                    if (newdate.DayOfWeek == DayOfWeek.Friday)
                    {
                        newdate = newdate.AddDays(1);
                    }
                }

                if (endOfMonth)
                {
                    var lastDayOfMonth = DateTime.DaysInMonth(newdate.Year, newdate.Month);
                    newdate = newdate.AddDays( (lastDayOfMonth - newdate.Day ));
                }
            }

        }
    }
}
