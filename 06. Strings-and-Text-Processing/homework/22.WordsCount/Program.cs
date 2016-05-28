using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "some text for sample purposes some not not very long onw";

            string[] arr = text.Split(' ');
            Dictionary<string, int> mapper = new Dictionary<string, int>();
            foreach (var item in arr)
            {
                if (mapper.ContainsKey(item))
                {
                    mapper[item] += 1;
                }
                else
                {
                    mapper[item] = 1;
                }
            }

            //print
            foreach (KeyValuePair<string,int> item in mapper)
            {
                Console.WriteLine("{0} => {1}", item.Key, item.Value);
            }
        }
    }
}
