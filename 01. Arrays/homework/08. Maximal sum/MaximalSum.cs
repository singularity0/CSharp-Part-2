using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class MaxKsum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int current_sum = 0;
            int max_sum = int.MinValue;
            //populate array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < arr.Length; i++)
            {
                current_sum += arr[i];
                if (current_sum < arr[i])
                {

                    current_sum = arr[i];
                }
                else
                {

                    if (max_sum < current_sum)
                    {
                        max_sum = current_sum;
                    }
                }
            }

            Console.WriteLine(max_sum);




        }
    }
}