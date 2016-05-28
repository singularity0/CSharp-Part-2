using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.WordDict
{
    class DictWords
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR", "managed execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");

            string input = Console.ReadLine();
            Console.WriteLine(dict[input]);
        }
    }
}
