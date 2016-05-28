using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string text = "there is some abba text tat, lamal";
            var builder = new StringBuilder();
            string[] arr = text.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EndsWith(","))
                {
                    arr[i] = arr[i].Substring(0, arr[i].Length - 1);
                }
            }
            foreach (var item in arr)
            {
                for (int i = 0; i < item.Length/2; i++)
                {
                    if (item[i] == item[item.Length-1-i])
                    {
                        if (i == item.Length / 2 -1)
                        {
                            builder.Append(item + " ");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
