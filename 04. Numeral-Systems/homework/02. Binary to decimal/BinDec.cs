using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.BinaryToDEcimal
{
    class BinDec
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(BinaryToDEcimal(number));
        }

        static long BinaryToDEcimal(string number)
        {
            long reselt = new long();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1' )
                {
                    reselt += (long)Math.Pow(2, number.Length-1-i);
                }
                else
                {
                    continue;
                }
            }

            //second(shorter) way
            //foreach (char item in number)
            //{
            //    reselt = (item - '0') + reselt * 2;
            //}


            return reselt;
        }


    }
}
