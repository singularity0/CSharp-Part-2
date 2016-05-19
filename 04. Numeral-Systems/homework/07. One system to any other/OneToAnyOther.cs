using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//credits https://github.com/pokemon4e
namespace Problem07
{
    class Problem07
    {
        private static readonly char[] BaseChars =
        "0123456789ABCDEF".ToCharArray();

        static void Main(string[] args)
        {
            ulong s = ulong.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            ulong d = ulong.Parse(Console.ReadLine());
            Console.WriteLine(BaseToBase(number, s, d));

        }


        static string BaseToBase(string number, ulong start_base, ulong end_base)
        {
            string result = "";


            result = BaseToDecimal(number, start_base).ToString();


            string result2 = DecimalToBase(ulong.Parse(result), end_base);
            return result2;
        }

        static string DecimalToBase(ulong number, ulong basee)
        {
            string result = "";

            while (number > 0)
            {
                ulong remainder = number % basee;
                result = BaseChars[remainder] + result;
                number /= basee;
            }

            return result;
        }

        static ulong BaseToDecimal(string number, ulong basee)
        {
            ulong result = 0;

            foreach (char c in number.ToCharArray())
            {
                result = (ulong)"0123456789ABCDEF".IndexOf(c) + result * basee;
            }

            return result;
        }
    }
}
