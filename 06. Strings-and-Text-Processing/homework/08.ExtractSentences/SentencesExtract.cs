using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentences
{
    class SentencesExtract
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            

            if (!char.IsLetter(word[0]))
            {
                word = word.Replace(word[0], ' ');
            }
            if (!char.IsLetter(word[word.Length-1]))
            {
                word = word.Replace(word[word.Length - 1], ' ');
            }
            //Console.WriteLine(word);
            string text = Console.ReadLine();

            string[] split = text.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>();
            foreach (var item in split)
            {
                if (item.Contains(word))
                {
                    result.Add(item + ".");
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Trim());
            }

        }
    }
}
