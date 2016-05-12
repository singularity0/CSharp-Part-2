using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class Binary
    {
        static void Main(string[] args)
        {
            int arr_size = int.Parse(Console.ReadLine());
            int[] arr = new int[arr_size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int number_to_search_for = int.Parse(Console.ReadLine());
            int left_bound = 0;
            int right_bound = arr.Length-1;
            int middle = 0;
            int index = -1;
            Array.Sort(arr);
            while (left_bound <= right_bound)
            {
                middle = (left_bound + right_bound) / 2;
                if (arr[middle] == number_to_search_for)
                {
                    index = middle;
                    break;
                }
                else if (arr[middle] > number_to_search_for)
                {
                    right_bound = middle - 1;
                }
                else if(arr[middle] < number_to_search_for)
                {
                    left_bound = middle + 1;

                }
            }
            Console.WriteLine(index);
        }
    }
}
