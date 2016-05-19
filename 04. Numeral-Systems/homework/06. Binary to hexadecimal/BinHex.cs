using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHex
{
    class BinHex
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(BinToHex(number));
        }
        static string BinToHex(string number)
        {
            while (number.Length % 4 != 0)
            {
                number = "0" + number;
            }
            string result = "";
            for (int i = 0; i < number.Length; i+=4)
            {
                string current_result = (number[i].ToString() + number[i + 1].ToString() + number[i + 2].ToString() + number[i + 3].ToString());
                result += DecimalToHex(BinaryToDEcimal(current_result), 16);
            }
            return result;
        }
        static long BinaryToDEcimal(string number)
        {
            long reselt = new long();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1')
                {
                    reselt += (long)Math.Pow(2, number.Length - 1 - i);
                }
                else
                {
                    continue;
                }
            }
            return reselt;
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
