using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _17.DateInBG
{
    class DateBG
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime value = DateTime.ParseExact(input, "d.M.yyyy HH:MM:ss", CultureInfo.InvariantCulture);

            value = value.AddHours(6.5);

            Console.WriteLine("day: {0}, date/time:{1}", value.ToString("dddd", new CultureInfo("bg-BG" )) ,value);
        }
    }
}
