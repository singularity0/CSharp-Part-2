using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateWorkdays
{
    class workdaysCalc
    {
        static void Main(string[] args)
        {
            //TODO investigate why DateTime date is not updating
            Console.WriteLine("Enter day");
            int day = int.Parse( Console.ReadLine());
            int current_day = int.Parse(DateTime.Now.Day.ToString());
            int[] national_holiday_days = { 3, 23, 24, 25, 15, 27 };
            int counter = 0;
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, current_day);
            for (int i = current_day, index = 0; i < day; i++, index++)
            {
                
                if (national_holiday_days.Contains(i))
                {
                    continue;
                }
                if (date.DayOfWeek.ToString() != "Saturday" && date.DayOfWeek.ToString() != "Sunday")
                {
                    Console.WriteLine(date.DayOfWeek.ToString());
                    counter++;
                }
                date = date.AddDays(1);


            }
            Console.WriteLine("The number of working days for the period is:");
            Console.WriteLine(counter);

        }
    }
}
