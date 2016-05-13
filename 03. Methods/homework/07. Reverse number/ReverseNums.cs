using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumbers
{
    class ReverseNums
    {
        static void Main(string[] args)
        {
            string num = (Console.ReadLine());
            ReverseDigits(num);
        }

        private static void ReverseDigits(string num)
        {
            string result = "";
            for (int i = 0; i < num.Length; i++)
            {
                result = num.ToString()[i] + result;
            }

            Console.WriteLine(result);
        }
    }
}
