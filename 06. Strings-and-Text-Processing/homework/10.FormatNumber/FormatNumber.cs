using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FormatNumber
{
    class FormatNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15}", num);
            Console.WriteLine("{0, 15:X}", num);
            Console.WriteLine("{0, 15:P3}", num);
            Console.WriteLine("{0, 15:E}", num);
           
        }
    }
}
