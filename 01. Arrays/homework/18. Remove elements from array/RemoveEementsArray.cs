using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.RemoveElementsFromArray
{
    class RemoveEementsArray
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int len = arr.Length;
            int[] result = new int[len];
            int max = 0;
            for (int i = 0; i < len; i++)
            {
                max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        if (result[j] > max)
                        {
                            max = result[j];
                        }
                    }
                }
                result[i] = max + 1;
                max = 0;
            }
            for (int i = 0; i < len; i++)
            {
                if (result[i] > max)
                {
                    max = result[i];

                }
            }

            Console.WriteLine((arr.Length - 1) - (max));
        }
    }
}
