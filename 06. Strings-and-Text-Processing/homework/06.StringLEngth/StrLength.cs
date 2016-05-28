using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringLEngth
{
    class StrLength
    {
        static void Main(string[] args)
        {
            string entry = Console.ReadLine().Replace("\\", string.Empty); ;
            string result = entry.PadRight(20, '*');
            Console.WriteLine(result);
        }
    }
}
