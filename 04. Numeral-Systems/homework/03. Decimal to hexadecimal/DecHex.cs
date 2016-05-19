using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.DecimalBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int system_base = 16;
            Console.WriteLine(DecimalToHex(number, system_base));


        }

        static string DecimalToHex(long number, int system_base)
        {
            string result = "";
            while (number > 0)
            {
                long remainder = number % system_base;
                switch (remainder)
                {
                    case 10: result = "A" + result; break;
                    case 11: result = "B" + result; break;
                    case 12: result = "C" + result; break;
                    case 13: result = "D" + result; break;
                    case 14: result = "E" + result; break;
                    case 15: result = "F" + result; break;
                    default: result = remainder + result; break;

                }
                number /= system_base;

            }



            return result;
        }
    }
}
