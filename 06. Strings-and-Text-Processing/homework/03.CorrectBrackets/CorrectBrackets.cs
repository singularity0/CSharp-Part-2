
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            
           
            string text = Console.ReadLine();
            CounterBrackets(text);

        }

        private static void CounterBrackets(string text)
        {
            int counterOpenBrackets = 0;
            int counterClosingBrackets = 0;
            //bool isCorrect = true;
            if (text.IndexOf("()") != -1 || text.StartsWith(")") || text.EndsWith("("))
            {
                //isCorrect = false;
                Console.WriteLine("Incorrect");
                return; 
            }
            foreach (var item in text)
            {
                if (item == '(')
                {
                    counterOpenBrackets++;
                }
                if (item == ')')
                {
                    counterClosingBrackets++;
                    if (counterClosingBrackets > counterOpenBrackets)
                    {
                        Console.WriteLine("Incorrect");
                        return;
                    }
                }
            }
            if (counterClosingBrackets != counterOpenBrackets)
            {
                Console.WriteLine("Incorrect");
                return;
            }
            Console.WriteLine("Correct");

        }
    }
}
