using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexToDec
{
    class HexDec
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            HexToDec(number);
                
        }

        private static void HexToDec(string number)
        {
            string mapper = "0123456789ABCDEF";
            string result = "";
            foreach (var num in number)
            {
                result += Convert.ToString(mapper.IndexOf(num), 2).PadLeft(4, '0');
            }
            result = result.Substring(result.IndexOf('1'));
            Console.WriteLine(result);

        }
    }
}
