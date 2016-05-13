using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerCalculations
{
    class IntCalcs
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            int[] user_input = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                user_input[i] = int.Parse(input[i]);
            }
            Console.WriteLine(GetMin(user_input));
            Console.WriteLine(GetMax(user_input));
            Console.WriteLine("{0:F2}",Average(user_input));
            Console.WriteLine(Sum(user_input));
            Console.WriteLine(Product(user_input));

        }

        private static long Product(int[] user_input)
        {
            long product = 1;
            for (int i = 0; i < user_input.Length; i++)
            {
                product *= user_input[i];
            }
            return product;
        }

        private static decimal Sum(int[] user_input)
        {
            decimal sum = new int();
            for (int i = 0; i < user_input.Length; i++)
            {
                sum += user_input[i];
            }
            return sum;
        }

        private static decimal GetMin(int[] user_input)
        {
           Array.Sort(user_input);
           return (decimal)user_input[0];
        }
        private static decimal GetMax(int[] user_input)
        {
            Array.Sort(user_input);
            return (decimal)user_input[user_input.Length-1];
        }
        private static decimal Average(int[] user_input)
        {
            return (decimal) (Sum(user_input) / user_input.Length);
        }
    }
}
