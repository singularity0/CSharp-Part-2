using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishDigit
{
    class englishDigit
    {
        static void Main(string[] args)
        {
            
            PrintCorrespondingNumber(GetLastDigit());
        }
        static int GetLastDigit()
        {
            string numberInn = Console.ReadLine();
            int value = int.Parse(numberInn[numberInn.Length - 1].ToString());
            return value;
        }
        static void PrintCorrespondingNumber(int val)
        {
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine(digits[val]);
        }


    }
}
