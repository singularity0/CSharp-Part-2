using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _16.DateDifference
{
    class DateDiff
    {
        static void Main(string[] args)
        {
            string fisrtdate = Console.ReadLine();
            string second_date = Console.ReadLine();

            DateTime beginning = DateTime.ParseExact(fisrtdate, "d.M.yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(second_date, "d.M.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Distance {0}", Math.Abs((end - beginning).TotalDays));

        }
    }
}
