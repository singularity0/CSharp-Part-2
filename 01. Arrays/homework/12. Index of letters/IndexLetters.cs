using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class IndexLetters
    {
        static void Main(string[] args)
        {
            char[] arr = new char[27];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)(i + 65);
            }
            
            char[] expression = Console.ReadLine().ToUpper().ToCharArray();
            for (int i = 0; i < expression.Length; i++)
            {
                Console.WriteLine(Array.IndexOf(arr, expression[i]));
            }
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    Console.Write("{0} ", (char)arr[i]);
            //}
        }
    }
}
