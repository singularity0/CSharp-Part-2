using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8};
            int condition = 11;
            int current_sum = 0;
            bool close_outer_loop = false;
            List<int> result_arr = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                
                    
                    if (arr[i] < condition)
                    {
                        current_sum += arr[i];
                        result_arr.Add(arr[i]);
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (current_sum < condition)
                            {
                                result_arr.Add(arr[j]);
                            }
                        else
                        {

                        }
                        }
                    }
                    else if (arr[i] == condition)
                    {
                        close_outer_loop = true;
                        break;
                    }
                
                if (close_outer_loop)
                {
                    break;
                }
            }



            for (int i = 0; i < result_arr.Count; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
