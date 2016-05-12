using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int counter = 1;
            int max_counter = 0;
            //poulate array
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i+1] == arr[i])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (max_counter < counter)
                {
                    max_counter = counter;
                }
            }
            Console.WriteLine(max_counter);

        }
    }
}
