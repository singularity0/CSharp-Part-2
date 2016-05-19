using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.DecimalBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            int system_base = 2;
            Console.WriteLine(DecimalToBinary(number, system_base));
            

        }

        static string DecimalToBinary(BigInteger number, int system_base)
        {
            string result = "";
            while (number > 0)
            {
                result = (number % system_base) + result;
                number /= system_base;
            }



            return result;
        }
    }
}
