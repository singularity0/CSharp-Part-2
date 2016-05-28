using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLEtters
{
    class LetterSeries
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var builder = new StringBuilder();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == text[i+1])
                {
                    continue;
                }
                else
                {
                    builder.Append(text[i]);
                }
            }
            builder.Append(text[text.Length - 1]); // appending the last letter
            Console.WriteLine(builder.ToString());

        }
    }
}
