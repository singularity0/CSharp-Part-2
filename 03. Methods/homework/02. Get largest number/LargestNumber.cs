using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetLArgestNumber
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            GetMax(getNumbers());
        }
        static int[] getNumbers()
        {
            string[] inputStr = Console.ReadLine().Split(' ');
            int size = 3; // number of elements
            int[] userInput = new int[size];
            for (int i = 0; i < inputStr.Length; i++)
            {
                userInput[i] = int.Parse(inputStr[i]);
            }
            
            return userInput;
        }

        static void GetMax(int[] nums)
        {
            
            Array.Sort(nums);
            Console.WriteLine(nums[nums.Length-1]);
        }
    }
}
