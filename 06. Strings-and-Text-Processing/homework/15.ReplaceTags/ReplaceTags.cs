using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            
            string pattern = "<a href=\"";
            int patternLength = pattern.Length;
            int indexOpeningTag = text.IndexOf(pattern);
            int indexClosingTag = text.IndexOf(">", indexOpeningTag + 1);
            string url = string.Empty;
            while (indexOpeningTag != -1)
            {
                //get the url address
                url = text.Substring(indexOpeningTag + patternLength, indexClosingTag - indexOpeningTag - patternLength - 1);


                text = text.Replace(pattern + url + "\">", "[");
                text = text.Replace("</a>", string.Format("]({0})", url));
                indexOpeningTag = text.IndexOf(pattern);
                indexClosingTag = text.IndexOf(">", indexOpeningTag + 1);

            }
            Console.WriteLine(text);
        }
    }
}
