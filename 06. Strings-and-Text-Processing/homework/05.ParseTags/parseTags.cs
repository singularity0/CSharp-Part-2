using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParseTags
{
    class parseTags
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] result = str.Split(new string[] { "<upcase>", "</upcase>" } , StringSplitOptions.RemoveEmptyEntries);
            var builder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (i%2 == 0)
                {
                    builder.Append(result[i]);
                    continue;
                }
                string substr = result[i].ToUpper();
                builder.Append(substr);
            }
            Console.WriteLine(builder.ToString());

        }
    }
}
