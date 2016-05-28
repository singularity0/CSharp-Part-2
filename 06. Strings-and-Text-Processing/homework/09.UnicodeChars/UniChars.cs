using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.UnicodeChars
{
    class UniChars
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //string result = "";
            var builder = new StringBuilder();
            foreach (var item in str)
            {
                builder.AppendFormat("\\u{0:X4}", (int)item);
            }
            Console.WriteLine(builder.ToString());

            //foreach (var item in str)
            //{
            //    result += string.Format("\\u{0:X4}", (int)item);
            //}
            //Console.WriteLine(result);
        }
    }
}
