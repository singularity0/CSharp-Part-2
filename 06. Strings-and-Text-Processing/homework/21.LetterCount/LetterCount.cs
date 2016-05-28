using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LetterCount
{
    class LetterCount
    {
        static void Main(string[] args)
        {
            string text = "a number of diff words in here";
            Dictionary<char, int> mapper = new Dictionary<char, int>();
            foreach (var item in text)
            {
                if (mapper.ContainsKey(item))
                {
                    mapper[item]++;
                }
                else
                {
                    mapper[item] = 1;
                }
            }
            //printing
            foreach (KeyValuePair<char, int> kvp in mapper)
            {
                Console.WriteLine("{0} - {1} times", kvp.Key, kvp.Value);
                
            }
            
        }
    }
}
