using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            int[] alist = new int[n];
   
            //populate array
            for (int i = 0; i < alist.Length; i++)
            {
                alist[i] = int.Parse(Console.ReadLine());
            }


            //int[] alist = { 54, 26, 93 };

            for (int i = 0; i < alist.Length-1; i++)
            {
                for (int j = i+1; j < alist.Length; j++)
                {
                    if (alist[j] < alist[i])
                    {
                        int temp = alist[i];
                        alist[i] = alist[j];
                        alist[j] = temp;
                    }
                }
            }

            for (int i = 0; i < alist.Length; i++)
            {
                Console.WriteLine(alist[i]);
            }

        }
    }
}
