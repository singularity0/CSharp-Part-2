﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaximalKsum
{
    class MaxKsum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            //populate array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            for (int i = 0; i < k; i++)
            {
                sum += arr[arr.Length - 1 - i];
            }
            Console.WriteLine(sum);
        }
    }
}
