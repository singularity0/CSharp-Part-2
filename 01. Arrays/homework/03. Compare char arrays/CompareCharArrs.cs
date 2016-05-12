using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareCharArrays
{
    class CompareCharArrs
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().ToLower().ToArray();
            char[] arr2 = Console.ReadLine().ToLower().ToArray();
            int min_length = Math.Min(arr1.Length, arr2.Length);
            bool equal = true;
            for (int i = 0; i < min_length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(">");
                    equal = false;
                    break;
                }
                else if (arr1[i] < arr2[i])
                {
                    Console.WriteLine("<");
                    equal = false;
                    break;
                }
            }

            if (equal && (arr1.Length == arr2.Length) )
            {
                Console.WriteLine("=");
            }
            else if (equal && (arr1.Length != arr2.Length))
            {
                Console.WriteLine(arr1.Length > arr2.Length ? ">" : "<");
            }


        }
    }
}
