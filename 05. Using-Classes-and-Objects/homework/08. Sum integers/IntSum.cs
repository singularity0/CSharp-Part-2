using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumIntegers
{
    class IntSum
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long sum = 0;
            foreach (var item in input)
            {
                sum += int.Parse(item);
            }
            Console.WriteLine(sum);
        }
    }
}
