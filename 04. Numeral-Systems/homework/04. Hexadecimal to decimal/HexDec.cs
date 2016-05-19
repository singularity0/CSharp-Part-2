using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.HexToDEc
{
    class HexDec
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            HexToDEc(number);
        }

        private static void HexToDEc(string number)
        {
            BigInteger result = 0;
            Dictionary<string, int> mapper = new Dictionary<string, int>
            { { "A", 10 }, { "B", 11}, {"C", 12}, { "D", 13}, {"E", 14}, {"F", 15} };
            for (int i = 0; i < number.Length; i++)
            {
                //int parsed_num = int.Parse(number[i].ToString())
                if (!Char.IsDigit(number[i]))
                {
                    result += mapper[number[i].ToString()] * BigInteger.Pow(16, number.Length - 1 - i);
                }
                else
                {
                    result += (number[i]-'0') * BigInteger.Pow(16, number.Length-1-i);
                }
            }
            Console.WriteLine(result);
        }

    }
}
