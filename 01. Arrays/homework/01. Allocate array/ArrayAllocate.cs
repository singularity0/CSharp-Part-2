using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayAllocation
{
    class ArrayAllocate
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }

        }
    }
}
