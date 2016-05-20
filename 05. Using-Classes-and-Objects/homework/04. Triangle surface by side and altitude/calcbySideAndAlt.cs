using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CalcTriangBySideAltitude
{
    class calcbySideAndAlt
    {
        static void Main(string[] args)
        {
            decimal side = decimal.Parse(Console.ReadLine());
            decimal altitude = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", side *altitude/2);

        }
    }
}
