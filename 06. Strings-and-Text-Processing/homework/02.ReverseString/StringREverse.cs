using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class StringREverse
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = ReverseText(text);
            Console.WriteLine(result);

        }

        static string ReverseText(string s)
        {
            var builder = new StringBuilder();
            
            for (int i = s.Length-1; i >= 0; i--)
            {
                builder.Append(s[i]);
            }
            return builder.ToString();
        }
    }
}
