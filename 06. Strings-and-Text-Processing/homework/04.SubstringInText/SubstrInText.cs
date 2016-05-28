using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SubstringInText
{
    class SubstrInText
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            //string[] result = text.Split(new string[] {pattern}, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(result.Length-1);

            int counter = 0; ;
            int position = 0;
            while (text.IndexOf(pattern, position) > 0)
            {
                counter++;
                position = text.IndexOf(pattern, position)+1;

            }
            Console.WriteLine(counter);

            

        }
    }
}
