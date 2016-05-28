using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReverseSentence
{
    class ReveSentence
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++, not PHP and not Delphi!";

            //check and get the ending signs
            int lastEmptySpace = text.LastIndexOf(' ');
            string lastWordAndSign = text.Substring(lastEmptySpace+1);
            string ending = string.Empty;
            int counter = 1;
            while (!char.IsLetter(lastWordAndSign[lastWordAndSign.Length - counter]))
            {
                ending += lastWordAndSign[lastWordAndSign.Length - counter];
                counter++;
            }

            //check/get commas and put them in a list
            string[] split = text.Split(' ');
            List<int> commapositions = new List<int>();
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].EndsWith(","))
                {
                    commapositions.Add(i);
                }
            }

            //get words and reverse
            text = text.Replace(',', ' ');
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            words[words.Length-1] = words[words.Length-1].Substring(0, words[words.Length-1].Length - ending.Length);
            Array.Reverse(words);

            //add commas
            for (int i = 0; i < commapositions.Count; i++)
            {
                words[commapositions[i]] += ",";
            }

            //add last signs
            words[words.Length - 1] += ending;

            //print
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }


        }
    }
}
