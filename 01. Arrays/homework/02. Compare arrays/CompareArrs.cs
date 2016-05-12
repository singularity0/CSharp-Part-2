using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareArrays
{
    class CompareArrs
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            bool equal = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
                if (arr1[i] != arr2[i])
                {
                    equal = false;
                }
            }

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

        }
    }
}
