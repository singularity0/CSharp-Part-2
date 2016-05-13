using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargerThanNeighbours
{
    public class LargerThanNeighb
    {
        static void Main(string[] args)
        {
            
            int size = int.Parse(Console.ReadLine());
            string[] inn = Console.ReadLine().Split(' ');
            int[] arr = new int[inn.Length];
            LargerThanNeighboursLogic(arr, inn);

        }

        private static void LargerThanNeighboursLogic(int[] arr, string[] inn)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(inn[i]);
            }

            int counter = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
